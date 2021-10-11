
namespace Autofact
{
    partial class Accueil
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
            this.SuspendLayout();
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(564, 83);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(182, 42);
            this.btn_clients.TabIndex = 0;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.Location = new System.Drawing.Point(359, 222);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(182, 42);
            this.btn_profil.TabIndex = 1;
            this.btn_profil.Text = "Profil";
            this.btn_profil.UseVisualStyleBackColor = true;
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(474, 358);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(182, 42);
            this.btn_deconnexion.TabIndex = 2;
            this.btn_deconnexion.Text = "Déconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 560);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_clients);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_deconnexion;
    }
}