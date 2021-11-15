
namespace Autofact
{
    partial class Client
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
            this.box_nom = new System.Windows.Forms.TextBox();
            this.box_prenom = new System.Windows.Forms.TextBox();
            this.box_adresse = new System.Windows.Forms.TextBox();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_adresse = new System.Windows.Forms.Label();
            this.label_client = new System.Windows.Forms.Label();
            this.btn_detailscli = new System.Windows.Forms.Button();
            this.btn_presta = new System.Windows.Forms.Button();
            this.pictureSupprimer = new System.Windows.Forms.PictureBox();
            this.pictureAjouter = new System.Windows.Forms.PictureBox();
            this.pictureModifier = new System.Windows.Forms.PictureBox();
            this.pictureActualiser = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSupprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAjouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureActualiser)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(35, 461);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(117, 56);
            this.btn_deconnexion.TabIndex = 0;
            this.btn_deconnexion.Text = "Deconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.Location = new System.Drawing.Point(35, 231);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(117, 56);
            this.btn_profil.TabIndex = 1;
            this.btn_profil.Text = "Profil";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(35, 117);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(117, 56);
            this.btn_clients.TabIndex = 2;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // dgvclient
            // 
            this.dgvclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclie,
            this.nomclie,
            this.prenomclie,
            this.adresseclie});
            this.dgvclient.Location = new System.Drawing.Point(227, 261);
            this.dgvclient.Name = "dgvclient";
            this.dgvclient.RowHeadersWidth = 51;
            this.dgvclient.RowTemplate.Height = 24;
            this.dgvclient.Size = new System.Drawing.Size(882, 362);
            this.dgvclient.TabIndex = 3;
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
            // box_nom
            // 
            this.box_nom.Location = new System.Drawing.Point(471, 115);
            this.box_nom.Name = "box_nom";
            this.box_nom.Size = new System.Drawing.Size(117, 22);
            this.box_nom.TabIndex = 8;
            // 
            // box_prenom
            // 
            this.box_prenom.Location = new System.Drawing.Point(733, 119);
            this.box_prenom.Name = "box_prenom";
            this.box_prenom.Size = new System.Drawing.Size(117, 22);
            this.box_prenom.TabIndex = 9;
            // 
            // box_adresse
            // 
            this.box_adresse.Location = new System.Drawing.Point(1047, 119);
            this.box_adresse.Name = "box_adresse";
            this.box_adresse.Size = new System.Drawing.Size(117, 22);
            this.box_adresse.TabIndex = 10;
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(395, 118);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(37, 17);
            this.label_nom.TabIndex = 11;
            this.label_nom.Text = "Nom";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Location = new System.Drawing.Point(660, 120);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(57, 17);
            this.label_prenom.TabIndex = 12;
            this.label_prenom.Text = "Prénom";
            // 
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Location = new System.Drawing.Point(965, 122);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(60, 17);
            this.label_adresse.TabIndex = 13;
            this.label_adresse.Text = "Adresse";
            // 
            // label_client
            // 
            this.label_client.AutoSize = true;
            this.label_client.Location = new System.Drawing.Point(742, 25);
            this.label_client.Name = "label_client";
            this.label_client.Size = new System.Drawing.Size(124, 17);
            this.label_client.TabIndex = 14;
            this.label_client.Text = "Informations Client";
            // 
            // btn_detailscli
            // 
            this.btn_detailscli.Location = new System.Drawing.Point(733, 204);
            this.btn_detailscli.Name = "btn_detailscli";
            this.btn_detailscli.Size = new System.Drawing.Size(106, 45);
            this.btn_detailscli.TabIndex = 19;
            this.btn_detailscli.Text = "Détails Client";
            this.btn_detailscli.UseVisualStyleBackColor = true;
            this.btn_detailscli.Click += new System.EventHandler(this.btn_detailscli_Click);
            // 
            // btn_presta
            // 
            this.btn_presta.Location = new System.Drawing.Point(35, 357);
            this.btn_presta.Name = "btn_presta";
            this.btn_presta.Size = new System.Drawing.Size(116, 63);
            this.btn_presta.TabIndex = 20;
            this.btn_presta.Text = "Enregistrer une Prestation";
            this.btn_presta.UseVisualStyleBackColor = true;
            // 
            // pictureSupprimer
            // 
            this.pictureSupprimer.BackgroundImage = global::Autofact.Properties.Resources.supprimer;
            this.pictureSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSupprimer.Location = new System.Drawing.Point(878, 208);
            this.pictureSupprimer.Name = "pictureSupprimer";
            this.pictureSupprimer.Size = new System.Drawing.Size(39, 36);
            this.pictureSupprimer.TabIndex = 18;
            this.pictureSupprimer.TabStop = false;
            this.pictureSupprimer.Click += new System.EventHandler(this.pictureSupprimer_Click);
            // 
            // pictureAjouter
            // 
            this.pictureAjouter.BackgroundImage = global::Autofact.Properties.Resources.ajouter;
            this.pictureAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAjouter.Location = new System.Drawing.Point(942, 208);
            this.pictureAjouter.Name = "pictureAjouter";
            this.pictureAjouter.Size = new System.Drawing.Size(42, 36);
            this.pictureAjouter.TabIndex = 17;
            this.pictureAjouter.TabStop = false;
            this.pictureAjouter.Click += new System.EventHandler(this.pictureAjouter_Click);
            // 
            // pictureModifier
            // 
            this.pictureModifier.BackgroundImage = global::Autofact.Properties.Resources.modifier;
            this.pictureModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureModifier.Location = new System.Drawing.Point(1005, 208);
            this.pictureModifier.Name = "pictureModifier";
            this.pictureModifier.Size = new System.Drawing.Size(43, 36);
            this.pictureModifier.TabIndex = 16;
            this.pictureModifier.TabStop = false;
            this.pictureModifier.Click += new System.EventHandler(this.pictureModifier_Click);
            // 
            // pictureActualiser
            // 
            this.pictureActualiser.BackgroundImage = global::Autofact.Properties.Resources.Actualiser;
            this.pictureActualiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureActualiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureActualiser.Location = new System.Drawing.Point(1064, 208);
            this.pictureActualiser.Name = "pictureActualiser";
            this.pictureActualiser.Size = new System.Drawing.Size(34, 34);
            this.pictureActualiser.TabIndex = 15;
            this.pictureActualiser.TabStop = false;
            this.pictureActualiser.Click += new System.EventHandler(this.pictureActualiser_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Enregistrer une prestation";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_presta);
            this.Controls.Add(this.btn_detailscli);
            this.Controls.Add(this.pictureSupprimer);
            this.Controls.Add(this.pictureAjouter);
            this.Controls.Add(this.pictureModifier);
            this.Controls.Add(this.pictureActualiser);
            this.Controls.Add(this.label_client);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.box_adresse);
            this.Controls.Add(this.box_prenom);
            this.Controls.Add(this.box_nom);
            this.Controls.Add(this.dgvclient);
            this.Controls.Add(this.btn_clients);
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_deconnexion);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSupprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAjouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureActualiser)).EndInit();
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
        private System.Windows.Forms.TextBox box_nom;
        private System.Windows.Forms.TextBox box_prenom;
        private System.Windows.Forms.TextBox box_adresse;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.Label label_client;
        private System.Windows.Forms.PictureBox pictureActualiser;
        private System.Windows.Forms.PictureBox pictureModifier;
        private System.Windows.Forms.PictureBox pictureAjouter;
        private System.Windows.Forms.PictureBox pictureSupprimer;
        private System.Windows.Forms.Button btn_detailscli;
        private System.Windows.Forms.Button btn_presta;
        private System.Windows.Forms.Button button1;
    }
}