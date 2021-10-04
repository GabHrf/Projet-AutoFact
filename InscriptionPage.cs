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
            

            string insert = "INSERT INTO `utilisateur`(`NOM`, `PRENOM`, `MAIL`, `MDP`) VALUES (@nom,@prenom,@email,@mdp)";
            MySqlCommand cmd = new MySqlCommand(insert, conn);

            cmd.Parameters.AddWithValue("@nom", box_nom.Text);
            cmd.Parameters.AddWithValue("@prenom", box_prenom.Text);
            cmd.Parameters.AddWithValue("@email", box_mail.Text);
            cmd.Parameters.AddWithValue("@mdp", box_mdp.Text);
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
    }
}
