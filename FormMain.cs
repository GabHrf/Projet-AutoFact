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
using System.Runtime.InteropServices;

namespace Autofact
{
    public partial class FormMain : Form
    {
        public static List<Form> ListFormMenu = new List<Form>();
        public static string utilisateur;
        public FormMain()
        {
            InitializeComponent();
        }


        /*
        //DEBUT -- Bouton barre de naviguation
        */
        private void btn_client_Click(object sender, EventArgs e)
        {
            ListFormMenu[1].BringToFront();
            ResetBtn();
            btn_client.ForeColor = Color.Red;
        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            //Connexion BDD
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Close();

            MessageBox.Show("Vous venez de vous déconnectez");
            Hide();
            ConnexionPage x = new ConnexionPage();
            x.Show();
        }

        private void btnPrestation_Click(object sender, EventArgs e)
        {
            ListFormMenu[2].BringToFront();
            ResetBtn();
            btnPrestation.ForeColor = Color.Red;
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            ListFormMenu[3].BringToFront();
            ResetBtn();
            btnDocument.ForeColor = Color.Red;
        }
        private void ResetBtn()
        {
            btnAccueil.ForeColor = Color.White;
            btn_client.ForeColor = Color.White;
            btnPrestation.ForeColor = Color.White;
            btnDocument.ForeColor = Color.White;
        }
        private void btn_leave_Click(object sender, EventArgs e)
        {
            //Bouton fermeture
            Application.Exit();
        }

        private void btn_minimized_Click(object sender, EventArgs e)
        {
            //Bouton minimiser
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            ListFormMenu[0].BringToFront();
            ResetBtn();
            btnAccueil.ForeColor = Color.Red;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            // Get Nom, Prénom utilisateur pour afficher sur l'accueil 
            string mailutilisateur = ConnexionPage.utilisateur;
            string selectnommail = "SELECT `NOM` FROM `utilisateur` WHERE `MAIL`= '" + mailutilisateur + "'";
            MySqlCommand mail = new MySqlCommand(selectnommail, conn);
            string Nom = mail.ExecuteScalar().ToString();
            // fin du Get Nom, Prénom utilisateur
            labelnom.Text = Nom;

            

            ListFormMenu.Add(new Accueil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true});
            PanelMain.Controls.Add(ListFormMenu[0]);
            ListFormMenu.Add(new Client() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            PanelMain.Controls.Add(ListFormMenu[1]);
            ListFormMenu.Add(new Prestation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            PanelMain.Controls.Add(ListFormMenu[2]);
            ListFormMenu.Add(new Document() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            PanelMain.Controls.Add(ListFormMenu[3]);
            ListFormMenu[3].Show();
            ListFormMenu[2].Show();
            ListFormMenu[1].Show();
            ListFormMenu[0].Show();
            ListFormMenu[0].BringToFront();

        }
        bool flag = false;
        private void paneldrag2_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void paneldrag2_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)

            {

                this.Location = Cursor.Position;

            }
        }

        private void paneldrag2_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void paneldrag2_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
//FIN -- Bouton barre de naviguation
*/
    }
}
