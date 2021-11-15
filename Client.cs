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
        detailsclient detailsclient;
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

        private void ClearData()
        {
            box_nom.Clear();
            box_prenom.Clear();
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

        private void pictureActualiser_Click(object sender, EventArgs e)
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

        private void pictureModifier_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            if (ID != 0)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE `clients` SET `NOM`= '" + box_nom.Text + "',`PRENOM`= '" + box_prenom.Text + "',`ADRESSE`='" + box_adresse.Text + "' WHERE `IDCLIENT` = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Client modifier!");
                displayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selectionnez un client à modifier");
            }
        }

        private void pictureAjouter_Click(object sender, EventArgs e)
        {
            AjoutClients x = new AjoutClients();
            x.Show();
        }

        private void pictureSupprimer_Click(object sender, EventArgs e)
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

        private void btn_clients_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous êtes déjà sur la page Client !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            Hide();
            ProfilUser x = new ProfilUser();
            x.Show();
        }

        private void btn_detailscli_Click(object sender, EventArgs e)
        {
            if(ID != 0)
            {
                detailsclient = new detailsclient();
                detailsclient.nom = box_nom.Text;
                detailsclient.prenom = box_prenom.Text;
                detailsclient.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selectionnez un client !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_presta_Click(object sender, EventArgs e)
        {
            Hide();
            Prestation x = new Prestation();
            x.Show();
        }
    }
}
