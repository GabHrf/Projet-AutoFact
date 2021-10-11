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
        public Client()
        {
            InitializeComponent();
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

        private void btn_actualiserclient_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDCLIENT`, `NOM`, `PRENOM`, `ADRESSE` FROM `clients`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvclient.DataSource = dtbl;

        }

        private void btn_ajoutclie_Click(object sender, EventArgs e)
        {
            AjoutClients x = new AjoutClients();
            x.Show();
        }
    }
}
