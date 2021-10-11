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
    public partial class AjoutClients : Form
    {
        public AjoutClients()
        {
            InitializeComponent();
        }

        private void btn_ajoutclie_Click(object sender, EventArgs e)
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);



            if (box_nom.Text != string.Empty && box_prenom.Text != string.Empty && box_adresse.Text != string.Empty)
            {  
                conn.Open();
                string select = "SELECT `NOM`, `PRENOM` FROM `clients` WHERE `NOM` = '"+box_nom.Text+"' AND `PRENOM` = '"+box_prenom.Text+"'";
                MySqlCommand read = new MySqlCommand(select, conn);
                MySqlDataReader rd = read.ExecuteReader();
                if (rd.Read())
                {
                    rd.Close();
                    MessageBox.Show("Ce client existe déjà !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    rd.Close();
                    string insert = "INSERT INTO `clients`(`NOM`, `PRENOM`, `ADRESSE`) VALUES ('"+box_nom.Text+"', '"+box_prenom.Text+"', '"+box_adresse.Text+"')";
                    MySqlCommand cmd = new MySqlCommand(insert, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout de " + box_nom.Text + " " + box_prenom.Text + " réussi");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les cases et/ou renseignez un email valide !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
