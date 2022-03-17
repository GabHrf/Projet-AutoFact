using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Autofact
{
    public partial class ConnexionPage : Form
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

        public static string utilisateur;

        public ConnexionPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void btn_inscription_Click(object sender, EventArgs e)
        {
            Hide();
            InscriptionPage x = new InscriptionPage();
            x.Show();

        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            //On récupère l'email de connexion pour garder l'identification
            utilisateur = box_mail.Text;

            //Connexion a la BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //On verifie si les cases ne sont pas vides
            if (box_mail.Text != string.Empty && box_mdp.Text != string.Empty)
            {
                conn.Open();
                string selectsalt = "SELECT SALT FROM utilisateur WHERE MAIL = '" + box_mail.Text + "'";
                MySqlCommand cmdSalt = new MySqlCommand(selectsalt, conn);
                string salt = cmdSalt.ExecuteScalar().ToString();

                //On verifie si le SALT du MDP stocker correspond bien avec l'utilisateur
                string select = "SELECT `MAIL`, `MDP` FROM `utilisateur` WHERE `MAIL`= '" + box_mail.Text + "' AND `MDP`= '" + BCrypt.Net.BCrypt.HashPassword(box_mdp.Text, salt) + "'";
                MySqlCommand read = new MySqlCommand(select, conn);
                MySqlDataReader rd = read.ExecuteReader();
                if (rd.Read())
                {
                    rd.Close();
                    MessageBox.Show("Vous venez de vous connectez");
                    Hide();
                    FormMain x = new FormMain();
                    x.Show();
                }
                else
                {
                    MessageBox.Show("Informations incorrectes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les cases et/ou renseignez un email valide !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void box_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_connexion_Click(sender, e);
            }
        }

        private void box_mdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_connexion_Click(sender, e);
            }
        }

        private void ConnexionPage_Load(object sender, EventArgs e)
        {

        }

        /*
        //DEBUT -- Bouton barre de naviguation
        */
        private void btn_leave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

