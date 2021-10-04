using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Autofact
{
    public partial class InscriptionPage : Form
    {

        public InscriptionPage()
        {
            InitializeComponent();
        }

        private void btn_inscription_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            

            string insert = "INSERT INTO `utilisateur`(`NOM`, `PRENOM`, `MAIL`, `MDP`) VALUES ('"+box_nom.Text+"','"+box_prenom.Text+"','"+box_mail.Text+"','"+box_mdp.Text+"')";
            MySqlCommand cmd = new MySqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void box_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_mdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_confmdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_confmdp_Click(object sender, EventArgs e)
        {

        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            Hide();
            ConnexionPage x = new ConnexionPage();
            x.Show();
        }
    }
}
