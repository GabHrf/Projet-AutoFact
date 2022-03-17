using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Autofact
{
    public partial class Prestation : Form
    {
        public Prestation()
        {
            InitializeComponent();
            displayData();
        }
        int ID = 0;

        private void displayData()      //Permet d'actualiser automatiquement le DGV afin de voir les nouvelles prestations
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDPRESTATION`, `LIBELLE`, `PRIX`, `TVA` FROM `prestation`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvpresta.DataSource = dtbl;
        }
        private void dgvpresta_CellClick(object sender, DataGridViewCellEventArgs e)        //Au clic sur le DGV permet de selectionner la ligne de la prestation
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvpresta.Rows[index];
            ID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            box_prestation.Text = selectedRow.Cells[1].Value.ToString();
            box_prix.Text = selectedRow.Cells[2].Value.ToString();
            box_tva.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void btn_actupresta_Click(object sender, EventArgs e)       //Bouton qui actualise le DGV en lien avec la BDD
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);


            //Selectionne toutes les donnees de la BDD de la table PRESTATION
            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDPRESTATION`, `LIBELLE`, `PRIX`, `TVA` FROM `prestation`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvpresta.DataSource = dtbl;
            ClearData();
        }

        private void ClearData()        //Vide les cases Box pour permettre une meilleur possibilite d'insertion d'une autre prestation
        {
            box_prestation.Clear();
            box_prix.Clear();
            box_tva.Clear();
            ID = 0;
        }

        private void btn_createpresta_Click(object sender, EventArgs e)     //Bouton qui ajoute une prestation en BDD
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //On verifie qu'aucune prestation/ligne soit selectionne avec son ID
            if (ID == 0)
            {
                //Verifie que les cases ne soient pas vides
                if (box_prestation.Text != string.Empty && box_prix.Text != string.Empty && box_tva.Text != string.Empty)
                {
                    //On regarde en BDD si la prestation n'existe pas deja
                    conn.Open();
                    string select = "SELECT `IDPRESTATION`, `LIBELLE`, `PRIX`, `TVA` FROM `prestation` WHERE `LIBELLE` = '" + box_prestation.Text + "' AND `PRIX` = '" + box_prix.Text + "' AND `TVA` = '" + box_tva.Text + "'";
                    MySqlCommand read = new MySqlCommand(select, conn);
                    MySqlDataReader rd = read.ExecuteReader();
                    if (rd.Read())
                    {
                        rd.Close();
                        MessageBox.Show("Cette prestation existe déjà !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //On insert la prestation en BDD
                        rd.Close();
                        string insert = "INSERT INTO `prestation`(`LIBELLE`, `PRIX`, `TVA`) VALUES ('" + box_prestation.Text + "', '" + box_prix.Text + "', '" + box_tva.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(insert, conn);
                        cmd.ExecuteNonQuery();

                        ClearData();
                        displayData();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir toutes les cases et/ou renseignez une prestation valide !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_supppresta_Click(object sender, EventArgs e)       //Bouton qui supprime une prestation en BDD
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //On verifie qu'un client/ligne soit bien selectionne avec son ID
            if (ID != 0)
            {
                //On supprime la prestation avec son ID
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `prestation` WHERE `IDPRESTATION` = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Prestation supprimer!");
                displayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selectionnez une prestation à supprimer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modifpresta_Click(object sender, EventArgs e)      //Bouton qui modifie une prestation selectionne sur le DGV en lien avec la BDD
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //On verifie qu'un client/ligne soit bien selectionne avec son ID
            if (ID != 0)
            {
                //On modifie les donnees voulus directement en BDD
                MySqlCommand cmd = new MySqlCommand("UPDATE `prestation` SET `LIBELLE`= '" + box_prestation.Text + "',`PRIX`= '" + box_prix.Text.Replace(",",".") + "',`TVA`='" + box_tva.Text.Replace(",", ".") + "' WHERE `IDPRESTATION` = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Prestation modifier!");
                displayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selectionnez une prestation à modifier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_deselect_Click(object sender, EventArgs e)
        {
            ID = 0;
            ClearData();
        }
    }
}
