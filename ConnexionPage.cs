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
using BCrypt.Net;

namespace Autofact
{
    public partial class ConnexionPage : Form
    {
        public ConnexionPage()
        {
            InitializeComponent();
        }

        private void btn_inscription_Click(object sender, EventArgs e)
        {
            Hide();
            InscriptionPage x = new InscriptionPage();
            x.Show();
            
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            if (box_mail.Text != string.Empty && box_mdp.Text != string.Empty)
            {
                conn.Open();
                string selectsalt = "SELECT SALT FROM utilisateur WHERE MAIL = '" + box_mail.Text + "'";
                MySqlCommand cmdSalt = new MySqlCommand(selectsalt, conn);
                string salt = cmdSalt.ExecuteScalar().ToString();

                string select = "SELECT `MAIL`, `MDP` FROM `utilisateur` WHERE `MAIL`= '"+box_mail.Text+"' AND `MDP`= '"+BCrypt.Net.BCrypt.HashPassword(box_mdp.Text, salt)+"'";
                MySqlCommand read = new MySqlCommand(select, conn);
                MySqlDataReader rd = read.ExecuteReader();
                if (rd.Read())
                {
                    rd.Close();
                    MessageBox.Show("Vous venez de vous connectez");
                    Hide();
                    Accueil x = new Accueil();
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
    }
    }

