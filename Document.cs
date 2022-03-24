using MySql.Data.MySqlClient;
using Syncfusion.DocIO.DLS;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Syncfusion.DocIO;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using Syncfusion.OfficeChartToImageConverter;

namespace Autofact
{
    public partial class Document : Form
    {
        public Document()
        {
            InitializeComponent();
            displayDataClient();
            displayDataPresta();
        }
        int IDCli = 0;
        int Qtt = 0;
        private void displayDataPresta()      //Permet d'actualiser automatiquement le DGV afin de voir les nouvelles prestations
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDPRESTATION`, `LIBELLE`, `PRIX`, `TVA` FROM `prestation`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvpresta.DataSource = dtbl;

        }
        private void displayDataClient()      //Permet d'actualiser automatiquement le DGV afin de voir les nouveaux clients 
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT `IDCLIENT`, `NOM`, `PRENOM`, `ADRESSE` FROM `clients`", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvclient.DataSource = dtbl;
        }

        private void ClearData()
        {
            box_prenom.Clear();
            box_nom.Clear();
            box_adresse.Clear();
            IDCli = 0;
            Qtt = 0;
            displayDataClient();
            displayDataPresta();
        }

        private void dgvpresta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvclient.Rows[index];
            Qtt = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
        }

        private void dgvclient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvclient.Rows[index];
            IDCli = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            box_nom.Text = selectedRow.Cells[1].Value.ToString();
            box_prenom.Text = selectedRow.Cells[2].Value.ToString();
            box_adresse.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void btn_calcul_Click(object sender, EventArgs e)
        {
            double somme = 0;
            foreach (DataGridViewRow row in dgvpresta.Rows)
            {
                if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) != 0)
                {
                    somme += Convert.ToDouble(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[0].Value.ToString());
                }
            }

            box_montanttotal.Text = somme.ToString();
        }

        private void btn_converttopdf_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost; DATABASE=solucedevautofact; UID=root; PASSWORD=''; SSL MODE='none'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();



            // Get ID utilisateur pour insert en bdd 
            string mailutilisateur = ConnexionPage.utilisateur;
            string selectidutmail = "SELECT `IDUTILISATEUR` FROM `utilisateur` WHERE `MAIL`= '" + mailutilisateur + "'";
            MySqlCommand mail = new MySqlCommand(selectidutmail, conn);
            int idu = int.Parse(mail.ExecuteScalar().ToString());
            // fin du Get ID utilisateur

            // Get Nom, Prénom utilisateur pour afficher sur l'accueil 
            string selectnommail = "SELECT `NOM` FROM `utilisateur` WHERE `MAIL`= '" + mailutilisateur + "'";
            MySqlCommand nommail = new MySqlCommand(selectnommail, conn);
            string nomuser = nommail.ExecuteScalar().ToString();
            // fin du Get Nom, Prénom utilisateur

            //On récupère le type du document dans le combobox
            string TypeText = comboBoxType.GetItemText(comboBoxType.SelectedItem);
            //fin


            if (IDCli != 0 && Qtt != 0 && comboBoxType.SelectedItem != null && TypeText == "Facture")
            {
                WordDocument document = new WordDocument();

                Stream docStream = File.OpenRead(Path.GetFullPath(@"template/facture_template.doc"));
                document.Open(docStream, Syncfusion.DocIO.FormatType.Doc);
                docStream.Dispose();



                document.Replace("#nom#", box_nom.Text, true, true);
                document.Replace("#prenom#", box_prenom.Text, true, true);
                document.Replace("#adresse#", box_adresse.Text, true, true);
                document.Replace("#typedoc#", TypeText, true, true);


                string format = "yyyy-MM-dd HH:mm:ss";
                document.Replace("#date#", DateTime.Now.ToString(format), true, true);

                string typee = "SELECT `IDTYPE` FROM `type` WHERE `LIBELLE` = '" + TypeText + "'";
                MySqlCommand type = new MySqlCommand(typee, conn);
                int idtype = int.Parse(type.ExecuteScalar().ToString());


                string insertDocument = "INSERT INTO `document`(`IDUTILISATEUR`, `IDCLIENT`, `NUMERO`) VALUES ('" + idu + "','" + IDCli + "',0001); SELECT LAST_INSERT_ID();";
                string insertDevenir = "INSERT INTO `devenir`(`IDDOCUMENT`, `IDTYPE`, `DATEDOC`) VALUES (LAST_INSERT_ID(), '" + idtype + "','" + DateTime.Now.ToString(format) + "'); ";
                MySqlCommand cmd = new MySqlCommand(insertDocument, conn);
                cmd.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand(insertDevenir, conn);
                cmd2.ExecuteNonQuery();

                int IdDocument = int.Parse(cmd.ExecuteScalar().ToString());

                BookmarksNavigator bookmarkNavigator = new BookmarksNavigator(document);
                bookmarkNavigator.MoveToBookmark("tableau");

                IWSection section = document.AddSection();

                //Entete
                //Ajouter d'un tableau
                IWTable table = section.AddTable();
                //Ajouter d'une ligne
                WTableRow row1 = table.AddRow(true, false);
                WTableCell cell1 = row1.AddCell();
                //Nom de la 1ere cellule
                cell1.AddParagraph().AppendText("Quantité");
                cell1 = row1.AddCell();
                //Nom de la 2eme cellule
                cell1.AddParagraph().AppendText("Description");
                cell1 = row1.AddCell();
                //Nom de la 3eme cellule
                cell1.AddParagraph().AppendText("Prix (€)");
                cell1 = row1.AddCell();
                //Nom de la 4eme cellule
                cell1.AddParagraph().AppendText("TVA (%)");
                cell1 = row1.AddCell();
                //Nom de la 5eme cellule
                cell1.AddParagraph().AppendText("Prix Total (€)");

                double sommetotalht = 0;
                double tvatotal = 0;
                
                foreach (DataGridViewRow row in dgvpresta.Rows)
                {

                    if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) != 0) { 
                        WTableRow az = table.AddRow(true, false);
                        WTableCell cell = az.AddCell();

                        cell.AddParagraph().AppendText(row.Cells[0].Value.ToString());
                        cell = az.AddCell();

                        cell.AddParagraph().AppendText(row.Cells[2].Value.ToString());
                        cell = az.AddCell();

                        cell.AddParagraph().AppendText(row.Cells[3].Value.ToString());
                        cell = az.AddCell();

                        cell.AddParagraph().AppendText(row.Cells[4].Value.ToString());
                        cell = az.AddCell();

                        double sommeparpresta = Convert.ToDouble(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[0].Value.ToString());

                        cell.AddParagraph().AppendText(sommeparpresta.ToString());

                        bookmarkNavigator.InsertTable(table);
                        document.Replace("#tableau#", "", true, true);



                        sommetotalht += Convert.ToDouble(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[0].Value.ToString());

                        tvatotal += Convert.ToDouble(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[0].Value.ToString()) * (Convert.ToDouble(row.Cells[4].Value.ToString()) / 100);




                        string insertConserve = "INSERT INTO `conserve`(`IDDOCUMENT`, `IDPRESTATION`, `QUANTITÉ`) VALUES (LAST_INSERT_ID(), '" + row.Cells[1].Value.ToString() + "', '" + row.Cells[0].Value.ToString() + "');";
                        MySqlCommand cmd1 = new MySqlCommand(insertConserve, conn);
                        cmd1.ExecuteNonQuery();

                    }
                }
                document.Replace("#totalht#", sommetotalht.ToString(), true, true);

                
                document.Replace("#tvatotal#", tvatotal.ToString(), true, true);

                double totalttc = sommetotalht + tvatotal;
                document.Replace("#totalttc#", totalttc.ToString(), true, true);

                //Convert TO PDF
                string pathFacture = @"Devis-Facture/AutoEntrepreneur - " + nomuser + @"/" + box_nom.Text + "_" + box_prenom.Text + @"/Factures\Facture N°" + IdDocument + " " + DateTime.Now.ToString("dd-MM-yyyy-HH-mm") + ".pdf";
                // Si le dossier n'est pas crée, le faire
                document.ChartToImageConverter = new ChartToImageConverter();
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfdocument = converter.ConvertToPDF(document);
                pdfdocument.Save(pathFacture);
                docStream.Dispose();
                //Fin Convert TO PDF

                //Ouverture PDF
                System.Diagnostics.Process.Start(pathFacture);

                MessageBox.Show("Facture en Word généré !", "Success", MessageBoxButtons.OK);
                ClearData();
            }
            else if (IDCli != 0 && Qtt != 0 && comboBoxType.SelectedItem != null && TypeText == "Devis")
            {
                WordDocument document = new WordDocument();

                Stream docStream = File.OpenRead(Path.GetFullPath(@"template/devis_template.doc"));
                document.Open(docStream, Syncfusion.DocIO.FormatType.Doc);
                docStream.Dispose();



                document.Replace("#nom#", box_nom.Text, true, true);
                document.Replace("#prenom#", box_prenom.Text, true, true);
                document.Replace("#adresse#", box_adresse.Text, true, true);
                document.Replace("#typedoc#", TypeText, true, true);


                string format = "yyyy-MM-dd HH:mm:ss";
                document.Replace("#date#", DateTime.Now.ToString(format), true, true);

                string typee = "SELECT `IDTYPE` FROM `type` WHERE `LIBELLE` = '" + TypeText + "'";
                MySqlCommand type = new MySqlCommand(typee, conn);
                int idtype = int.Parse(type.ExecuteScalar().ToString());


                string insertDocument = "INSERT INTO `document`(`IDUTILISATEUR`, `IDCLIENT`, `NUMERO`) VALUES ('" + idu + "','" + IDCli + "',0001);";
                string insertDevenir = "INSERT INTO `devenir`(`IDDOCUMENT`, `IDTYPE`, `DATEDOC`) VALUES (LAST_INSERT_ID(), '" + idtype + "','" + DateTime.Now.ToString(format) + "');";
                MySqlCommand cmd = new MySqlCommand(insertDocument, conn);
                cmd.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand(insertDevenir, conn);
                cmd2.ExecuteNonQuery();

                //IdDocument
                string SelectId = "SELECT `IDDOCUMENT` FROM `document` WHERE IDUTILISATEUR= '" + idu + "' AND IDCLIENT=(SELECT IDCLIENT FROM Clients WHERE NOM = '" + box_nom.Text + "')";
                MySqlCommand iddocument = new MySqlCommand(SelectId, conn);
                int IdDocument = int.Parse(iddocument.ExecuteScalar().ToString());


                


                BookmarksNavigator bookmarkNavigator = new BookmarksNavigator(document);
                bookmarkNavigator.MoveToBookmark("tableau");

                IWSection section = document.AddSection();

                //Entete
                //Ajouter d'un tableau
                IWTable table = section.AddTable();
                //Ajouter d'une ligne
                WTableRow row1 = table.AddRow(true, false);
                WTableCell cell1 = row1.AddCell();
                //Nom de la 1ere cellule
                cell1.AddParagraph().AppendText("Quantité");
                cell1 = row1.AddCell();
                //Nom de la 2eme cellule
                cell1.AddParagraph().AppendText("Description");
                cell1 = row1.AddCell();
                //Nom de la 3eme cellule
                cell1.AddParagraph().AppendText("Prix (€)");
                cell1 = row1.AddCell();
                //Nom de la 4eme cellule
                cell1.AddParagraph().AppendText("TVA (%)");
                cell1 = row1.AddCell();
                //Nom de la 5eme cellule
                cell1.AddParagraph().AppendText("Prix Total (€)");

                double sommetotalht = 0;
                double tvatotal = 0;

                foreach (DataGridViewRow row in dgvpresta.Rows)
                {
                    if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) != 0)
                    {
                        WTableRow az = table.AddRow(true, false);
                        WTableCell cell = az.AddCell();

                        cell.AddParagraph().AppendText(row.Cells[0].Value.ToString());
                        cell = az.AddCell();

                        cell.AddParagraph().AppendText(row.Cells[2].Value.ToString());
                        cell = az.AddCell();

                        cell.AddParagraph().AppendText(row.Cells[3].Value.ToString());
                        cell = az.AddCell();

                        cell.AddParagraph().AppendText(row.Cells[4].Value.ToString());
                        cell = az.AddCell();

                        double sommeparpresta = Convert.ToDouble(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[0].Value.ToString());
                        cell.AddParagraph().AppendText(sommeparpresta.ToString());


                        document.Replace("#tableau#", "", true, true);
                        bookmarkNavigator.InsertTable(table);


                        sommetotalht += Convert.ToDouble(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[0].Value.ToString());
                        tvatotal += Convert.ToDouble(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[0].Value.ToString()) * (Convert.ToDouble(row.Cells[4].Value.ToString()) / 100);




                        string insertConserve = "INSERT INTO `conserve`(`IDDOCUMENT`, `IDPRESTATION`, `QUANTITÉ`) VALUES (LAST_INSERT_ID(), '" + row.Cells[1].Value.ToString() + "', '" + row.Cells[0].Value.ToString() + "');";
                        MySqlCommand cmd1 = new MySqlCommand(insertConserve, conn);
                        cmd1.ExecuteNonQuery();


                    }
                }
                document.Replace("#totalht#", sommetotalht.ToString(), true, true);
                
               
                document.Replace("#tvatotal#", tvatotal.ToString(), true, true);

                double totalttc = sommetotalht + tvatotal;
                document.Replace("#totalttc#", totalttc.ToString(), true, true);

                //Convert TO PDF
                string pathDevis = @"Devis-Facture/AutoEntrepreneur - " + nomuser + @"/" + box_nom.Text + "_" + box_prenom.Text + @"/Devis\Devis N°" + IdDocument + " " + DateTime.Now.ToString("dd-MM-yyyy-HH-mm") + ".pdf";
                // If directory does not exist, create it.
                document.ChartToImageConverter = new ChartToImageConverter();
                DocToPDFConverter converter = new DocToPDFConverter();
                PdfDocument pdfdocument = converter.ConvertToPDF(document);
                pdfdocument.Save(pathDevis);
                docStream.Dispose();
                //Fin Convert TO PDF

                //Ouverture PDF
                System.Diagnostics.Process.Start(pathDevis);


                MessageBox.Show("Devis en Word généré !", "Success", MessageBoxButtons.OK);
                ClearData();
                
            }
            else
            {
            }

        }


    }
}
