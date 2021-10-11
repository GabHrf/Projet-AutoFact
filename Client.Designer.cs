
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
            this.btn_actualiserclient = new System.Windows.Forms.Button();
            this.idclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ajoutclie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(35, 345);
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
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(35, 117);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(117, 56);
            this.btn_clients.TabIndex = 2;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = true;
            // 
            // dgvclient
            // 
            this.dgvclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclie,
            this.nomclie,
            this.prenomclie,
            this.adresseclie});
            this.dgvclient.Location = new System.Drawing.Point(204, 153);
            this.dgvclient.Name = "dgvclient";
            this.dgvclient.RowHeadersWidth = 51;
            this.dgvclient.RowTemplate.Height = 24;
            this.dgvclient.Size = new System.Drawing.Size(711, 350);
            this.dgvclient.TabIndex = 3;
            // 
            // btn_actualiserclient
            // 
            this.btn_actualiserclient.Location = new System.Drawing.Point(897, 93);
            this.btn_actualiserclient.Name = "btn_actualiserclient";
            this.btn_actualiserclient.Size = new System.Drawing.Size(133, 37);
            this.btn_actualiserclient.TabIndex = 4;
            this.btn_actualiserclient.Text = "Actualiser";
            this.btn_actualiserclient.UseVisualStyleBackColor = true;
            this.btn_actualiserclient.Click += new System.EventHandler(this.btn_actualiserclient_Click);
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
            // btn_ajoutclie
            // 
            this.btn_ajoutclie.Location = new System.Drawing.Point(693, 93);
            this.btn_ajoutclie.Name = "btn_ajoutclie";
            this.btn_ajoutclie.Size = new System.Drawing.Size(158, 35);
            this.btn_ajoutclie.TabIndex = 5;
            this.btn_ajoutclie.Text = "Ajouter un client";
            this.btn_ajoutclie.UseVisualStyleBackColor = true;
            this.btn_ajoutclie.Click += new System.EventHandler(this.btn_ajoutclie_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(940, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ajoutclie);
            this.Controls.Add(this.btn_actualiserclient);
            this.Controls.Add(this.dgvclient);
            this.Controls.Add(this.btn_clients);
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_deconnexion);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.DataGridView dgvclient;
        private System.Windows.Forms.Button btn_actualiserclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclie;
        private System.Windows.Forms.Button btn_ajoutclie;
        private System.Windows.Forms.Button button1;
    }
}