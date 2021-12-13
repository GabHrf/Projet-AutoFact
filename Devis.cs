using MySql.Data.MySqlClient;
using Syncfusion.DocIO.DLS;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Autofact
{
    public partial class Devis : Form
    {
        public Devis()
        {
            InitializeComponent();
        }
        int IDCli = 0;
        int Qtt = 0;

        private void btn_clients_Click(object sender, EventArgs e)
        {
            Hide();
            Client x = new Client();
            x.Show();
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            Hide();
            ProfilUser x = new ProfilUser();
            x.Show();
        }

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Close();

            MessageBox.Show("Vous venez de vous déconnectez");
            Hide();
            ConnexionPage x = new ConnexionPage();
            x.Show();
        }
        private void ClearData()
        {
            box_prenom.Clear();
            box_nom.Clear();
            box_adresse.Clear();
            IDCli = 0;
        }



        private void dgvclient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvclient.Rows[index];
            IDCli = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            box_nom.Text = selectedRow.Cells[1].Value.ToString();
            box_prenom.Text = selectedRow.Cells[2].Value.ToString();
            box_adresse.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void btn_actucli_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDCLIENT`, `NOM`, `PRENOM`, `ADRESSE` FROM `clients`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvclient.DataSource = dtbl;
            ClearData();
        }

        private void btn_actupresta_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDPRESTATION`, `LIBELLE`, `PRIX`, `TVA` FROM `prestation`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvpresta.DataSource = dtbl;
        }

        private void btn_calcul_Click(object sender, EventArgs e)
        {
            double somme = 0;
            foreach (DataGridViewRow row in dgvpresta.Rows)
            {
                somme += Convert.ToDouble(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[0].Value.ToString());
            }
            box_montanttotal.Text = somme.ToString();
        }

        private void btn_converttoword_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            if (IDCli != 0 && Qtt != 0 && comboBoxType.SelectedIndex > -1)
            {
                foreach (DataGridViewRow row in dgvpresta.Rows)
                {
                    WordDocument document = new WordDocument();
                    Stream docStream = File.OpenRead(Path.GetFullPath(@"C:/Users/gabri/Desktop/Projet/AutoFact/facture/devis-temp.doc"));
                    document.Open(docStream, Syncfusion.DocIO.FormatType.Doc);
                    docStream.Dispose();

                    document.Replace("#idcli#", IDCli.ToString(), true, true);
                    document.Replace("#nom#", box_nom.Text, true, true);
                    document.Replace("#prenom#", box_prenom.Text, true, true);
                    document.Replace("#adresse#", box_adresse.Text, true, true);
                    document.Replace("#typedoc#", comboBoxType.Text, true, true);

                    document.Replace("#qtt#", Qtt.ToString(), true, true);
                    document.Replace("#prestalib#", row.Cells[2].Value.ToString(), true, true);
                    document.Replace("#prix#", row.Cells[3].Value.ToString(), true, true);

                    docStream = File.Create(Path.GetFullPath(@"C:\Users\gabri\Desktop\test\Result+" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm") + ".doc"));
                    document.Save(docStream, Syncfusion.DocIO.FormatType.Doc);
                    docStream.Dispose();

                    /*string insertConserve = "INSERT INTO `conserve`(`IDDOCUMENT`, `IDPRESTATION`, `QUANTITÉ`) VALUES (8, '" + row.Cells[1].Value.ToString() + "', '" + Qtt.ToString() + "');";
                    MySqlCommand cmd1 = new MySqlCommand(insertConserve, conn);
                    cmd1.ExecuteNonQuery();*/
                }
                string format = "yyyy-MM-dd HH:mm:ss";
                string typee = "SELECT `IDTYPE` FROM `type` WHERE `LIBELLE` = '"+comboBoxType.SelectedItem+"'";
                int type = Convert.ToInt32(typee);
                string insertDocument = "INSERT INTO `document`(`IDUTILISATEUR`, `IDCLIENT`, `NUMERO`) VALUES (01,'" + IDCli + "',0001);";
                string insertDevenir = "INSERT INTO `devenir`(`IDDOCUMENT`, `IDTYPE`, `DATEDOC`) VALUES (1, '"+type+"','" + DateTime.Now.ToString(format) + "');";
                MySqlCommand cmd = new MySqlCommand(insertDocument, conn);
                cmd.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand(insertDevenir, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Fichier word généré !", "Success", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Selectionnez un client ainsi que ses prestations !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvpresta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvclient.Rows[index];
            Qtt = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
        }
    }
}
