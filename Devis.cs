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
using Spire.Doc;

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
            ID = 0;
        }

        

        private void dgvclient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvclient.Rows[index];
            ID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            box_nom.Text = selectedRow.Cells[1].Value.ToString();
            box_prenom.Text = selectedRow.Cells[2].Value.ToString();
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

        private void button2_Click(object sender, EventArgs e)
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



            //initialize word object  
            Document doc = new Document();
            doc.LoadFromFile("C:/Users/gabri/Desktop/Projet/AutoFact/facture/devis-temp.doc");
            //get strings to replace  
            Dictionary<string, string> dictReplace = GetReplaceDictionary();
            //Replace text  
            foreach (KeyValuePair<string, string> kvp in dictReplace)
            {
                doc.Replace(kvp.Key, kvp.Value, true, true);
            }
            //Save doc file.  
            Document.SaveToFile("Bureau", FileFormat.Docx);
            //Convert to PDF  
            /*document.SaveToFile(pdfPath, FileFormat.PDF);
            MessageBox.Show("All tasks are finished.", "doc processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();*/
        }

        Dictionary<string, string> GetReplaceDictionary()
        {
            Dictionary<string, string> replaceDict = new Dictionary<string, string>();
            replaceDict.Add("#nom#", box_nom.Text.Trim());
            replaceDict.Add("#prenom#", box_prenom.Text);
            return replaceDict;
        }
    }
}
