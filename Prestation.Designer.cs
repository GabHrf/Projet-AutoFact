
namespace Autofact
{
    partial class Prestation
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
            this.btn_clients = new System.Windows.Forms.Button();
            this.btn_profil = new System.Windows.Forms.Button();
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.dgvclient = new System.Windows.Forms.DataGridView();
            this.idclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_adresse = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.box_adresse = new System.Windows.Forms.TextBox();
            this.box_prenom = new System.Windows.Forms.TextBox();
            this.box_nom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(12, 108);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(112, 49);
            this.btn_clients.TabIndex = 0;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.Location = new System.Drawing.Point(12, 219);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(112, 44);
            this.btn_profil.TabIndex = 1;
            this.btn_profil.Text = "Profil";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(12, 332);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(112, 43);
            this.btn_deconnexion.TabIndex = 2;
            this.btn_deconnexion.Text = "Déconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // dgvclient
            // 
            this.dgvclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclie,
            this.nomclie,
            this.prenomclie,
            this.adresseclie});
            this.dgvclient.Location = new System.Drawing.Point(158, 219);
            this.dgvclient.Name = "dgvclient";
            this.dgvclient.RowHeadersWidth = 51;
            this.dgvclient.RowTemplate.Height = 24;
            this.dgvclient.Size = new System.Drawing.Size(594, 285);
            this.dgvclient.TabIndex = 4;
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
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Location = new System.Drawing.Point(189, 156);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(60, 17);
            this.label_adresse.TabIndex = 19;
            this.label_adresse.Text = "Adresse";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Location = new System.Drawing.Point(189, 103);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(57, 17);
            this.label_prenom.TabIndex = 18;
            this.label_prenom.Text = "Prénom";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(189, 48);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(37, 17);
            this.label_nom.TabIndex = 17;
            this.label_nom.Text = "Nom";
            // 
            // box_adresse
            // 
            this.box_adresse.Location = new System.Drawing.Point(275, 156);
            this.box_adresse.Name = "box_adresse";
            this.box_adresse.Size = new System.Drawing.Size(117, 22);
            this.box_adresse.TabIndex = 16;
            // 
            // box_prenom
            // 
            this.box_prenom.Location = new System.Drawing.Point(275, 100);
            this.box_prenom.Name = "box_prenom";
            this.box_prenom.Size = new System.Drawing.Size(117, 22);
            this.box_prenom.TabIndex = 15;
            // 
            // box_nom
            // 
            this.box_nom.Location = new System.Drawing.Point(275, 48);
            this.box_nom.Name = "box_nom";
            this.box_nom.Size = new System.Drawing.Size(117, 22);
            this.box_nom.TabIndex = 14;
            // 
            // Prestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 635);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.box_adresse);
            this.Controls.Add(this.box_prenom);
            this.Controls.Add(this.box_nom);
            this.Controls.Add(this.dgvclient);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_clients);
            this.Name = "Prestation";
            this.Text = "Prestation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.DataGridView dgvclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclie;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.TextBox box_adresse;
        private System.Windows.Forms.TextBox box_prenom;
        private System.Windows.Forms.TextBox box_nom;
    }
}