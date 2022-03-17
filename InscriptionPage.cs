using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BCrypt.Net;
using System.Runtime.InteropServices;

namespace Autofact
{
    public partial class InscriptionPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public InscriptionPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }
        public static bool Validate(string emailAddress)
        {
            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            bool isValid = Regex.IsMatch(emailAddress, regex, RegexOptions.IgnoreCase);
            return isValid;
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


            //Vérification case non vide
            if (box_mail.Text != string.Empty && Validate(box_mail.Text) && box_nom.Text != string.Empty && box_prenom.Text != string.Empty && box_mdp.Text != string.Empty && box_confmdp.Text != string.Empty)
            {

                //Check si la case MDP et ConfMDP correspondent
                if (verifconfmdp == verifmdp)
                    {
                        //Vérifie si l'utilisateur n'existe pas deja en BDD sinon on le creer
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
                            string insert = "INSERT INTO `utilisateur`(`NOM`, `PRENOM`, `MAIL`, `MDP`, `SALT`) VALUES ('" + box_nom.Text + "','" + box_prenom.Text + "','" + box_mail.Text + "','" + myHash + "', '"+mySalt+"')";
                            MySqlCommand cmd = new MySqlCommand(insert, conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Vous venez de vous inscrire");
                            Hide();
                            ConnexionPage x = new ConnexionPage();
                            x.Show();
                            
                            box_nom.Clear();
                            box_prenom.Clear();
                            box_mail.Clear();
                            box_mdp.Clear();
                            box_confmdp.Clear();


                    }
                 }
                    else
                    {
                        MessageBox.Show("Les deux mots de passes doivent se correspondre !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les cases et/ou &renseignez un email valide !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void btn_connexion_Click(object sender, EventArgs e)
        {
            Hide();
            ConnexionPage x = new ConnexionPage();
            x.Show();
        }

        private void box_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_inscription_Click(sender, e);
            }
        }

        private void box_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_inscription_Click(sender, e);
            }
        }

        private void box_prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_inscription_Click(sender, e);
            }
        }

        private void box_mdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_inscription_Click(sender, e);
            }
        }

        private void box_confmdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_inscription_Click(sender, e);
            }
        }


        /*
        //DEBUT -- Bouton barre de naviguation
        */
        private void btn_minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool flag = false;
        private void paneldrag_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void paneldrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)

            {

                this.Location = Cursor.Position;

            }
        }

        private void paneldrag_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        /*
//FIN -- Bouton barre de naviguation
*/
    }
}
