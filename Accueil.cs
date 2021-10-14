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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
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
    }
}
