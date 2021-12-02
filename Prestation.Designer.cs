
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
            this.dgvpresta = new System.Windows.Forms.DataGridView();
            this.idclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box_tva = new System.Windows.Forms.TextBox();
            this.box_prix = new System.Windows.Forms.TextBox();
            this.box_prestation = new System.Windows.Forms.TextBox();
            this.label_prestation = new System.Windows.Forms.Label();
            this.label_prix = new System.Windows.Forms.Label();
            this.label_tva = new System.Windows.Forms.Label();
            this.btn_createpresta = new System.Windows.Forms.Button();
            this.label_dgvprest = new System.Windows.Forms.Label();
            this.btn_actupresta = new System.Windows.Forms.Button();
            this.btn_supppresta = new System.Windows.Forms.Button();
            this.btn_modifpresta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpresta)).BeginInit();
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
            // dgvpresta
            // 
            this.dgvpresta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpresta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclie,
            this.nomclie,
            this.prenomclie,
            this.adresseclie});
            this.dgvpresta.Location = new System.Drawing.Point(295, 338);
            this.dgvpresta.Name = "dgvpresta";
            this.dgvpresta.RowHeadersWidth = 51;
            this.dgvpresta.RowTemplate.Height = 24;
            this.dgvpresta.Size = new System.Drawing.Size(711, 285);
            this.dgvpresta.TabIndex = 4;
            this.dgvpresta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpresta_CellClick);
            // 
            // idclie
            // 
            this.idclie.DataPropertyName = "IDPRESTATION";
            this.idclie.HeaderText = "Id Prestation";
            this.idclie.MinimumWidth = 6;
            this.idclie.Name = "idclie";
            this.idclie.Width = 125;
            // 
            // nomclie
            // 
            this.nomclie.DataPropertyName = "LIBELLE";
            this.nomclie.HeaderText = "Libelle";
            this.nomclie.MinimumWidth = 6;
            this.nomclie.Name = "nomclie";
            this.nomclie.Width = 125;
            // 
            // prenomclie
            // 
            this.prenomclie.DataPropertyName = "PRIX";
            this.prenomclie.HeaderText = "Prix";
            this.prenomclie.MinimumWidth = 6;
            this.prenomclie.Name = "prenomclie";
            this.prenomclie.Width = 125;
            // 
            // adresseclie
            // 
            this.adresseclie.DataPropertyName = "TVA";
            this.adresseclie.HeaderText = "TVA";
            this.adresseclie.MinimumWidth = 6;
            this.adresseclie.Name = "adresseclie";
            this.adresseclie.Width = 125;
            // 
            // box_tva
            // 
            this.box_tva.Location = new System.Drawing.Point(371, 190);
            this.box_tva.Name = "box_tva";
            this.box_tva.Size = new System.Drawing.Size(117, 22);
            this.box_tva.TabIndex = 16;
            // 
            // box_prix
            // 
            this.box_prix.Location = new System.Drawing.Point(371, 138);
            this.box_prix.Name = "box_prix";
            this.box_prix.Size = new System.Drawing.Size(117, 22);
            this.box_prix.TabIndex = 15;
            // 
            // box_prestation
            // 
            this.box_prestation.Location = new System.Drawing.Point(371, 81);
            this.box_prestation.Name = "box_prestation";
            this.box_prestation.Size = new System.Drawing.Size(117, 22);
            this.box_prestation.TabIndex = 14;
            // 
            // label_prestation
            // 
            this.label_prestation.AutoSize = true;
            this.label_prestation.Location = new System.Drawing.Point(276, 81);
            this.label_prestation.Name = "label_prestation";
            this.label_prestation.Size = new System.Drawing.Size(72, 17);
            this.label_prestation.TabIndex = 17;
            this.label_prestation.Text = "Prestation";
            // 
            // label_prix
            // 
            this.label_prix.AutoSize = true;
            this.label_prix.Location = new System.Drawing.Point(276, 138);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(31, 17);
            this.label_prix.TabIndex = 18;
            this.label_prix.Text = "Prix";
            // 
            // label_tva
            // 
            this.label_tva.AutoSize = true;
            this.label_tva.Location = new System.Drawing.Point(276, 190);
            this.label_tva.Name = "label_tva";
            this.label_tva.Size = new System.Drawing.Size(35, 17);
            this.label_tva.TabIndex = 19;
            this.label_tva.Text = "TVA";
            // 
            // btn_createpresta
            // 
            this.btn_createpresta.Location = new System.Drawing.Point(594, 81);
            this.btn_createpresta.Name = "btn_createpresta";
            this.btn_createpresta.Size = new System.Drawing.Size(130, 47);
            this.btn_createpresta.TabIndex = 20;
            this.btn_createpresta.Text = "Créer une prestation";
            this.btn_createpresta.UseVisualStyleBackColor = true;
            this.btn_createpresta.Click += new System.EventHandler(this.btn_createpresta_Click);
            // 
            // label_dgvprest
            // 
            this.label_dgvprest.AutoSize = true;
            this.label_dgvprest.Location = new System.Drawing.Point(292, 288);
            this.label_dgvprest.Name = "label_dgvprest";
            this.label_dgvprest.Size = new System.Drawing.Size(106, 17);
            this.label_dgvprest.TabIndex = 21;
            this.label_dgvprest.Text = "Vos prestations";
            // 
            // btn_actupresta
            // 
            this.btn_actupresta.Location = new System.Drawing.Point(876, 288);
            this.btn_actupresta.Name = "btn_actupresta";
            this.btn_actupresta.Size = new System.Drawing.Size(130, 29);
            this.btn_actupresta.TabIndex = 22;
            this.btn_actupresta.Text = "Actualiser";
            this.btn_actupresta.UseVisualStyleBackColor = true;
            this.btn_actupresta.Click += new System.EventHandler(this.btn_actupresta_Click);
            // 
            // btn_supppresta
            // 
            this.btn_supppresta.Location = new System.Drawing.Point(594, 261);
            this.btn_supppresta.Name = "btn_supppresta";
            this.btn_supppresta.Size = new System.Drawing.Size(130, 32);
            this.btn_supppresta.TabIndex = 23;
            this.btn_supppresta.Text = "Supprimer";
            this.btn_supppresta.UseVisualStyleBackColor = true;
            this.btn_supppresta.Click += new System.EventHandler(this.btn_supppresta_Click);
            // 
            // btn_modifpresta
            // 
            this.btn_modifpresta.Location = new System.Drawing.Point(594, 190);
            this.btn_modifpresta.Name = "btn_modifpresta";
            this.btn_modifpresta.Size = new System.Drawing.Size(130, 32);
            this.btn_modifpresta.TabIndex = 24;
            this.btn_modifpresta.Text = "Modifier";
            this.btn_modifpresta.UseVisualStyleBackColor = true;
            this.btn_modifpresta.Click += new System.EventHandler(this.btn_modifpresta_Click);
            // 
            // Prestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 635);
            this.Controls.Add(this.btn_modifpresta);
            this.Controls.Add(this.btn_supppresta);
            this.Controls.Add(this.btn_actupresta);
            this.Controls.Add(this.label_dgvprest);
            this.Controls.Add(this.btn_createpresta);
            this.Controls.Add(this.label_tva);
            this.Controls.Add(this.label_prix);
            this.Controls.Add(this.label_prestation);
            this.Controls.Add(this.box_tva);
            this.Controls.Add(this.box_prix);
            this.Controls.Add(this.box_prestation);
            this.Controls.Add(this.dgvpresta);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_clients);
            this.Name = "Prestation";
            this.Text = "Prestation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpresta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.DataGridView dgvpresta;
        private System.Windows.Forms.TextBox box_tva;
        private System.Windows.Forms.TextBox box_prix;
        private System.Windows.Forms.TextBox box_prestation;
        private System.Windows.Forms.Label label_prestation;
        private System.Windows.Forms.Label label_prix;
        private System.Windows.Forms.Label label_tva;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclie;
        private System.Windows.Forms.Button btn_createpresta;
        private System.Windows.Forms.Label label_dgvprest;
        private System.Windows.Forms.Button btn_actupresta;
        private System.Windows.Forms.Button btn_supppresta;
        private System.Windows.Forms.Button btn_modifpresta;
    }
}