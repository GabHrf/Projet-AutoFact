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
        detailsclient detailsclient;
        int ID = 0;

        public Client()
        {
            InitializeComponent();
            displayData();
        }

        private void displayData()      //Permet d'actualiser automatiquement le DGV afin de voir les nouveaux clients 
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDCLIENT`, `NOM`, `PRENOM`, `ADRESSE` FROM `clients`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvclient.DataSource = dtbl;
        }

        private void ClearData()        //Vide les cases Box pour permettre une meilleur possibilite d'insertion d'un autre client
        {
            box_nom.Clear();
            box_prenom.Clear();
            box_adresse.Clear();
            ID = 0;
        }

        private void dgvclient_CellClick(object sender, DataGridViewCellEventArgs e)        //Au clic sur le DGV permet de selectionner la ligne du client
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvclient.Rows[index];
            ID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            box_nom.Text = selectedRow.Cells[1].Value.ToString();
            box_prenom.Text = selectedRow.Cells[2].Value.ToString();
            box_adresse.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void BtnActualiser_Click(object sender, EventArgs e)        //Bouton qui actualise le DGV en lien avec la BDD
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            //Selectionne toutes les donnees de la BDD de la table CLIENT
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDCLIENT`, `NOM`, `PRENOM`, `ADRESSE` FROM `clients`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvclient.DataSource = dtbl;
            ClearData();
        }

        private void btnModifier_Click(object sender, EventArgs e)      //Bouton qui modifie le client selectionne sur le DGV en lien avec la BDD
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //On verifie qu'un client/ligne soit bien selectionne avec son ID
            if (ID != 0)
            {
                //On modifie les donnees voulus directement en BDD
                MySqlCommand cmd = new MySqlCommand("UPDATE `clients` SET `NOM`= '" + box_nom.Text + "',`PRENOM`= '" + box_prenom.Text + "',`ADRESSE`='" + box_adresse.Text + "' WHERE `IDCLIENT` = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Client modifier!");
                displayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selectionnez un client à modifier !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //On verifie qu'aucun client/ligne soit selectionne avec son ID
            if (ID == 0)
            {
                //Verifie que les cases ne soient pas vides
                if (box_nom.Text != string.Empty && box_prenom.Text != string.Empty && box_adresse.Text != string.Empty)
                {
                    //On regarde en BDD si le client n'existe pas deja
                    conn.Open();
                    string select = "SELECT `NOM`, `PRENOM` FROM `clients` WHERE `NOM` = '" + box_nom.Text + "' AND `PRENOM` = '" + box_prenom.Text + "'";
                    MySqlCommand read = new MySqlCommand(select, conn);
                    MySqlDataReader rd = read.ExecuteReader();
                    if (rd.Read())
                    {
                        rd.Close();
                        MessageBox.Show("Ce client existe déjà !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //On insert le client en BDD
                        rd.Close();
                        string insert = "INSERT INTO `clients`(`NOM`, `PRENOM`, `ADRESSE`) VALUES ('" + box_nom.Text + "', '" + box_prenom.Text + "', '" + box_adresse.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(insert, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ajout de " + box_nom.Text + " " + box_prenom.Text + " réussi");

                        ClearData();
                        displayData();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir toutes les cases !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Déselectionner un client !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)     //Bouton qui supprime un client en BDD
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //On verifie qu'un client/ligne soit bien selectionne avec son ID
            if (ID != 0)
            {
                //On supprime le client avec son ID
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `clients` WHERE `IDCLIENT` = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Client supprimer!");
                displayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selectionnez un client à supprimer !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_detailscli_Click(object sender, EventArgs e)       //Bouton qui nous permet de voir les details d'un client
        {
            //On verifie qu'un client/ligne soit bien selectionne avec son ID
            if (ID != 0)
            {
                //On transfert directement les donnees du client dans une autre page
                detailsclient = new detailsclient();
                detailsclient.nom = box_nom.Text;
                detailsclient.prenom = box_prenom.Text;
                detailsclient.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selectionnez un client !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }     

        private void btnDeselectionner_Click(object sender, EventArgs e)
        {
            ID = 0;
            ClearData();
        }
    }
}
