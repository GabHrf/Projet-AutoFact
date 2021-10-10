using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BCrypt.Net;

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
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            

            //Hash mdp + Salt
            string password = box_mdp.Text;
            string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
            string myHash = BCrypt.Net.BCrypt.HashPassword(password, mySalt);

            bool verifmdp = BCrypt.Net.BCrypt.Verify(password, myHash);


            //Hash conf mdp + Salt
            string Confpassword = box_confmdp.Text;
            string ConfMySalt = BCrypt.Net.BCrypt.GenerateSalt();
            string ConfmyHash = BCrypt.Net.BCrypt.HashPassword(Confpassword, ConfMySalt);

            bool verifconfmdp = BCrypt.Net.BCrypt.Verify(Confpassword, ConfmyHash);

            if (box_mail.Text != string.Empty || box_nom.Text != string.Empty || box_prenom.Text != string.Empty || box_mdp.Text != string.Empty || box_confmdp.Text != string.Empty)
            {
                if(verifmdp == verifconfmdp)
                {
                    conn.Open();
                    string select = "SELECT * FROM `utilisateur` WHERE `MAIL`= '" + box_mail.Text + "'";
                    MySqlCommand read = new MySqlCommand(select, conn);
                    MySqlDataReader rd = read.ExecuteReader();
                    if (rd.Read())
                    {
                        rd.Close();
                        MessageBox.Show("Ce mail a déjà été utilisé !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        rd.Close();
                        string insert = "INSERT INTO `utilisateur`(`NOM`, `PRENOM`, `MAIL`, `MDP`) VALUES ('" + box_nom.Text + "','" + box_prenom.Text + "','" + box_mail.Text + "','" + myHash + "')";
                        MySqlCommand cmd = new MySqlCommand(insert, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vous venez de vous inscrire");
                        Hide();
                        ConnexionPage x = new ConnexionPage();
                        x.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Les deux mots de passes doivent se correspondre !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les cases et/ou renseignez un email valide !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
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
