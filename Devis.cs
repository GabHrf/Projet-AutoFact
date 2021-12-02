using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Syncfusion.DocIO.DLS;

namespace Autofact
{
    public partial class Devis : Form
    {
        public Devis()
        {
            InitializeComponent();
        }
        int ID = 0;

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
            ID = 0;
        }

        

        private void dgvclient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvclient.Rows[index];
            ID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
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

            if (ID != 0)
            {
                foreach (DataGridViewRow row in dgvpresta.Rows)
                {
                    if (int.Parse(row.Cells[0].Value.ToString()) > 0)
                    {
                        WordDocument document = new WordDocument();
                        Stream docStream = File.OpenRead(Path.GetFullPath(@"C:/Users/gabri/Desktop/Projet/AutoFact/facture/devis-temp.doc"));
                        document.Open(docStream, Syncfusion.DocIO.FormatType.Doc);
                        docStream.Dispose();

                        document.Replace("#idcli#", ID.ToString(), true, true);
                        document.Replace("#nom#", box_nom.Text, true, true);
                        document.Replace("#prenom#", box_prenom.Text, true, true);
                        document.Replace("#adresse#", box_adresse.Text, true, true);

                        WTable presta = new WTable(document);
                        presta.ResetCells(1, 4);
                        presta[0, 0].Width = 80f;
                        presta[0, 0].AddParagraph().AppendText("Quantité");
                        presta[0, 1].Width = 130f;
                        presta[0, 1].AddParagraph().AppendText("Prestation");
                        presta[0, 2].Width = 80f;
                        presta[0, 2].AddParagraph().AppendText("Prix unitaire HT");
                        presta[0, 3].Width = 90f;
                        presta[0, 3].AddParagraph().AppendText("Prix total HT");

                       
                        
                        TextBodyPart bodyPart = new TextBodyPart(document);
                        bodyPart.BodyItems.Add(presta);
                        document.Replace("#tablepresta#", bodyPart, true, true, true);

                        document.Replace("#qtt#", row.Cells[0].Value.ToString(), true, true);
                        document.Replace("#prestalib#", row.Cells[2].Value.ToString(), true, true);
                        document.Replace("#prix#", row.Cells[3].Value.ToString(), true, true);

                        docStream = File.Create(Path.GetFullPath(@"C:\Users\gabri\Desktop\test\Result.doc"));
                        document.Save(docStream, Syncfusion.DocIO.FormatType.Doc);
                        docStream.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Selectionnez une quantité dans les prestations !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Selectionnez un client ainsi que ses prestations !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
