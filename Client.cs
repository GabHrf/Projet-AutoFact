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

namespace Autofact
{
    public partial class Client : Form
    {
        int ID = 0;
        public Client()
        {
            InitializeComponent();
            displayData();
        }

        private void Client_Load(object sender, EventArgs e)
        {

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

        private void displayData()
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDCLIENT`, `NOM`, `PRENOM`, `ADRESSE` FROM `clients`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvclient.DataSource = dtbl;
        }
        private void btn_actualiserclient_Click(object sender, EventArgs e)
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

        private void ClearData()
        {
            box_nom.Clear();
            box_prenom.Clear();
            box_adresse.Clear();
            ID = 0;
        }
        private void btn_ajoutclie_Click(object sender, EventArgs e)
        {
            AjoutClients x = new AjoutClients();
            x.Show();
        }
        private void btn_suppclie_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            if (ID != 0)
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `clients` WHERE `IDCLIENT` = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Client supprimer!");
                displayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selectionnez un client à supprimer");
            }
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
    }
}
