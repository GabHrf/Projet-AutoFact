﻿using MySql.Data.MySqlClient;
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
            
            if(box_mail.Text != string.Empty || box_nom.Text != string.Empty || box_prenom.Text != string.Empty || box_mdp.Text != string.Empty || box_confmdp.Text != string.Empty)
            {
                if(box_mdp.Text == box_confmdp.Text)
                {
                    conn.Open();
                    string select = "SELECT * FROM `utilisateur` WHERE `MAIL`= '" + box_mail.Text + "'";
                    MySqlCommand read = new MySqlCommand(select, conn);
                    MySqlDataReader rd = read.ExecuteReader();
                    if (rd.Read())
                    {
                        rd.Close();
                        MessageBox.Show("Ce mail a déjà été utilisé !");
                    }
                    else
                    {
                        rd.Close();
                        string insert = "INSERT INTO `utilisateur`(`NOM`, `PRENOM`, `MAIL`, `MDP`) VALUES ('" + box_nom.Text + "','" + box_prenom.Text + "','" + box_mail.Text + "','" + box_mdp.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(insert, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vous venez de vous inscrire");
                        Hide();
                        ConnexionPage x = new ConnexionPage();
                        x.Show();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Les deux mots de passes doivent se correspondre !");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les cases !");
            }

            
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
