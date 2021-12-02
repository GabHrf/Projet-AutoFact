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
        }
        int ID = 0;

        private void btn_clients_Click(object sender, EventArgs e)
        {
            Hide();
            Client x = new Client();
            x.Show();
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            Hide();
            ProfilUser x = new ProfilUser();
            x.Show();
        }

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Close();

            MessageBox.Show("Vous venez de vous déconnectez");
            Hide();
            ConnexionPage x = new ConnexionPage();
            x.Show();
        }

        private void dgvpresta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvpresta.Rows[index];
            ID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            box_prestation.Text = selectedRow.Cells[1].Value.ToString();
            box_prix.Text = selectedRow.Cells[2].Value.ToString();
            box_tva.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void btn_actupresta_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDPRESTATION`, `LIBELLE`, `PRIX`, `TVA` FROM `prestation`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvpresta.DataSource = dtbl;
            ClearData();
        }

        private void ClearData()
        {
            box_prestation.Clear();
            box_prix.Clear();
            box_tva.Clear();
            ID = 0;
        }

        private void btn_createpresta_Click(object sender, EventArgs e)
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);



            if (box_prestation.Text != string.Empty && box_prix.Text != string.Empty && box_tva.Text != string.Empty)
            {
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
        private void displayData()
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDPRESTATION`, `LIBELLE`, `PRIX`, `TVA` FROM `prestation`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvpresta.DataSource = dtbl;
        }

        private void btn_supppresta_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            if (ID != 0)
            {
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

        private void btn_modifpresta_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            if (ID != 0)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE `prestation` SET `LIBELLE`= '" + box_prestation.Text + "',`PRIX`= '" + box_prix.Text + "',`TVA`='" + box_tva.Text + "' WHERE `IDPRESTATION` = @id", conn);
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
    }
}
