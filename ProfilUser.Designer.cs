
namespace Autofact
{
    partial class ProfilUser
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
            this.btn_recapMensuel = new System.Windows.Forms.Button();
            this.btn_recapTrimestriel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(45, 97);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(140, 45);
            this.btn_clients.TabIndex = 0;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.Location = new System.Drawing.Point(45, 234);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(140, 32);
            this.btn_profil.TabIndex = 1;
            this.btn_profil.Text = "Profil";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(45, 328);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(140, 32);
            this.btn_deconnexion.TabIndex = 2;
            this.btn_deconnexion.Text = "Déconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // btn_recapMensuel
            // 
            this.btn_recapMensuel.Location = new System.Drawing.Point(376, 222);
            this.btn_recapMensuel.Name = "btn_recapMensuel";
            this.btn_recapMensuel.Size = new System.Drawing.Size(94, 57);
            this.btn_recapMensuel.TabIndex = 3;
            this.btn_recapMensuel.Text = "Récapitulatif\r\nMensuel\r\n";
            this.btn_recapMensuel.UseVisualStyleBackColor = true;
            // 
            // btn_recapTrimestriel
            // 
            this.btn_recapTrimestriel.Location = new System.Drawing.Point(580, 222);
            this.btn_recapTrimestriel.Name = "btn_recapTrimestriel";
            this.btn_recapTrimestriel.Size = new System.Drawing.Size(94, 57);
            this.btn_recapTrimestriel.TabIndex = 4;
            this.btn_recapTrimestriel.Text = "Récapitulatif\r\nTrimestriel";
            this.btn_recapTrimestriel.UseVisualStyleBackColor = true;
            // 
            // ProfilUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_recapTrimestriel);
            this.Controls.Add(this.btn_recapMensuel);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_clients);
            this.Name = "ProfilUser";
            this.Text = "ProfilUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.Button btn_recapMensuel;
        private System.Windows.Forms.Button btn_recapTrimestriel;
    }
}