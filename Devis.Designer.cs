
namespace Autofact
{
    partial class Devis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.btn_profil = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.dgvclient = new System.Windows.Forms.DataGridView();
            this.idclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_choixClie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_nom = new System.Windows.Forms.TextBox();
            this.box_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_dgvprest = new System.Windows.Forms.Label();
            this.dgvpresta = new System.Windows.Forms.DataGridView();
            this.btn_actucli = new System.Windows.Forms.Button();
            this.btn_actupresta = new System.Windows.Forms.Button();
            this.box_montanttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Quantité = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_converttoword = new System.Windows.Forms.Button();
            this.btn_converttopdf = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpresta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(28, 358);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(112, 43);
            this.btn_deconnexion.TabIndex = 5;
            this.btn_deconnexion.Text = "Déconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.Location = new System.Drawing.Point(28, 245);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(112, 44);
            this.btn_profil.TabIndex = 4;
            this.btn_profil.Text = "Profil";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(28, 134);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(112, 49);
            this.btn_clients.TabIndex = 3;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // dgvclient
            // 
            this.dgvclient.AllowUserToAddRows = false;
            this.dgvclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclie,
            this.nomclie,
            this.prenomclie,
            this.adresseclie});
            this.dgvclient.Location = new System.Drawing.Point(155, 79);
            this.dgvclient.Name = "dgvclient";
            this.dgvclient.RowHeadersWidth = 51;
            this.dgvclient.RowTemplate.Height = 24;
            this.dgvclient.Size = new System.Drawing.Size(566, 270);
            this.dgvclient.TabIndex = 6;
            this.dgvclient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclient_CellClick);
            // 
            // idclie
            // 
            this.idclie.DataPropertyName = "IDCLIENT";
            this.idclie.HeaderText = "Id Client";
            this.idclie.MinimumWidth = 6;
            this.idclie.Name = "idclie";
            this.idclie.Width = 125;
            // 
            // nomclie
            // 
            this.nomclie.DataPropertyName = "NOM";
            this.nomclie.HeaderText = "Nom";
            this.nomclie.MinimumWidth = 6;
            this.nomclie.Name = "nomclie";
            this.nomclie.Width = 125;
            // 
            // prenomclie
            // 
            this.prenomclie.DataPropertyName = "PRENOM";
            this.prenomclie.HeaderText = "Prénom";
            this.prenomclie.MinimumWidth = 6;
            this.prenomclie.Name = "prenomclie";
            this.prenomclie.Width = 125;
            // 
            // adresseclie
            // 
            this.adresseclie.DataPropertyName = "ADRESSE";
            this.adresseclie.HeaderText = "Adresse Postal";
            this.adresseclie.MinimumWidth = 6;
            this.adresseclie.Name = "adresseclie";
            this.adresseclie.Width = 125;
            // 
            // label_choixClie
            // 
            this.label_choixClie.AutoSize = true;
            this.label_choixClie.Location = new System.Drawing.Point(368, 44);
            this.label_choixClie.Name = "label_choixClie";
            this.label_choixClie.Size = new System.Drawing.Size(99, 17);
            this.label_choixClie.TabIndex = 7;
            this.label_choixClie.Text = "Choix du client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Client selectionné :";
            // 
            // box_nom
            // 
            this.box_nom.Location = new System.Drawing.Point(240, 427);
            this.box_nom.Name = "box_nom";
            this.box_nom.ReadOnly = true;
            this.box_nom.Size = new System.Drawing.Size(133, 22);
            this.box_nom.TabIndex = 25;
            // 
            // box_prenom
            // 
            this.box_prenom.Location = new System.Drawing.Point(240, 493);
            this.box_prenom.Name = "box_prenom";
            this.box_prenom.ReadOnly = true;
            this.box_prenom.Size = new System.Drawing.Size(133, 22);
            this.box_prenom.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Prénom :";
            // 
            // label_dgvprest
            // 
            this.label_dgvprest.AutoSize = true;
            this.label_dgvprest.Location = new System.Drawing.Point(1051, 44);
            this.label_dgvprest.Name = "label_dgvprest";
            this.label_dgvprest.Size = new System.Drawing.Size(116, 17);
            this.label_dgvprest.TabIndex = 30;
            this.label_dgvprest.Text = "Choix prestations";
            // 
            // dgvpresta
            // 
            this.dgvpresta.AllowUserToAddRows = false;
            this.dgvpresta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpresta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantité,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvpresta.Location = new System.Drawing.Point(727, 79);
            this.dgvpresta.Name = "dgvpresta";
            this.dgvpresta.RowHeadersWidth = 51;
            this.dgvpresta.RowTemplate.Height = 24;
            this.dgvpresta.Size = new System.Drawing.Size(782, 270);
            this.dgvpresta.TabIndex = 29;
            // 
            // btn_actucli
            // 
            this.btn_actucli.Location = new System.Drawing.Point(476, 33);
            this.btn_actucli.Name = "btn_actucli";
            this.btn_actucli.Size = new System.Drawing.Size(160, 27);
            this.btn_actucli.TabIndex = 32;
            this.btn_actucli.Text = "Actualiser Clients";
            this.btn_actucli.UseVisualStyleBackColor = true;
            this.btn_actucli.Click += new System.EventHandler(this.btn_actucli_Click);
            // 
            // btn_actupresta
            // 
            this.btn_actupresta.Location = new System.Drawing.Point(1173, 33);
            this.btn_actupresta.Name = "btn_actupresta";
            this.btn_actupresta.Size = new System.Drawing.Size(163, 28);
            this.btn_actupresta.TabIndex = 33;
            this.btn_actupresta.Text = "Actualiser Prestation";
            this.btn_actupresta.UseVisualStyleBackColor = true;
            this.btn_actupresta.Click += new System.EventHandler(this.btn_actupresta_Click);
            // 
            // box_montanttotal
            // 
            this.box_montanttotal.Location = new System.Drawing.Point(867, 418);
            this.box_montanttotal.Name = "box_montanttotal";
            this.box_montanttotal.ReadOnly = true;
            this.box_montanttotal.Size = new System.Drawing.Size(210, 22);
            this.box_montanttotal.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(864, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Montant total :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Calculer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Quantité
            // 
            this.Quantité.DataPropertyName = "QUANTITÉ";
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Quantité.MinimumWidth = 6;
            this.Quantité.Name = "Quantité";
            this.Quantité.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDPRESTATION";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Prestation";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LIBELLE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Libelle";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRIX";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TVA";
            this.dataGridViewTextBoxColumn4.HeaderText = "TVA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // btn_converttoword
            // 
            this.btn_converttoword.Location = new System.Drawing.Point(912, 560);
            this.btn_converttoword.Name = "btn_converttoword";
            this.btn_converttoword.Size = new System.Drawing.Size(165, 34);
            this.btn_converttoword.TabIndex = 37;
            this.btn_converttoword.Text = "Générer un Word";
            this.btn_converttoword.UseVisualStyleBackColor = true;
            this.btn_converttoword.Click += new System.EventHandler(this.btn_converttoword_Click);
            // 
            // btn_converttopdf
            // 
            this.btn_converttopdf.Location = new System.Drawing.Point(1118, 560);
            this.btn_converttopdf.Name = "btn_converttopdf";
            this.btn_converttopdf.Size = new System.Drawing.Size(165, 34);
            this.btn_converttopdf.TabIndex = 38;
            this.btn_converttopdf.Text = "Générer un PDF";
            this.btn_converttopdf.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Facture",
            "Devis",
            "Avoir"});
            this.comboBox1.Location = new System.Drawing.Point(727, 570);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Type du document :";
            // 
            // Devis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 637);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_converttopdf);
            this.Controls.Add(this.btn_converttoword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_montanttotal);
            this.Controls.Add(this.btn_actupresta);
            this.Controls.Add(this.btn_actucli);
            this.Controls.Add(this.label_dgvprest);
            this.Controls.Add(this.dgvpresta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_prenom);
            this.Controls.Add(this.box_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_choixClie);
            this.Controls.Add(this.dgvclient);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_clients);
            this.Name = "Devis";
            this.Text = "Devis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpresta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.DataGridView dgvclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclie;
        private System.Windows.Forms.Label label_choixClie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_nom;
        private System.Windows.Forms.TextBox box_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_dgvprest;
        private System.Windows.Forms.DataGridView dgvpresta;
        private System.Windows.Forms.Button btn_actucli;
        private System.Windows.Forms.Button btn_actupresta;
        private System.Windows.Forms.TextBox box_montanttotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btn_converttoword;
        private System.Windows.Forms.Button btn_converttopdf;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}