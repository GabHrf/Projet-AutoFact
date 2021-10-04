namespace Autofact
{
    partial class ConnexionPage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_mdp = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.btn_inscription = new System.Windows.Forms.Button();
            this.box_mdp = new System.Windows.Forms.TextBox();
            this.box_mail = new System.Windows.Forms.TextBox();
            this.labelConnexion = new System.Windows.Forms.Label();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mdp.Location = new System.Drawing.Point(135, 160);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(110, 20);
            this.label_mdp.TabIndex = 22;
            this.label_mdp.Text = "Mot de passe";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(194, 88);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 20);
            this.label_email.TabIndex = 19;
            this.label_email.Text = "Email";
            // 
            // btn_inscription
            // 
            this.btn_inscription.Location = new System.Drawing.Point(47, 322);
            this.btn_inscription.Name = "btn_inscription";
            this.btn_inscription.Size = new System.Drawing.Size(138, 26);
            this.btn_inscription.TabIndex = 18;
            this.btn_inscription.Text = "S\'inscrire";
            this.btn_inscription.UseVisualStyleBackColor = true;
            this.btn_inscription.Click += new System.EventHandler(this.btn_inscription_Click);
            // 
            // box_mdp
            // 
            this.box_mdp.Location = new System.Drawing.Point(280, 160);
            this.box_mdp.Name = "box_mdp";
            this.box_mdp.Size = new System.Drawing.Size(241, 22);
            this.box_mdp.TabIndex = 2;
            this.box_mdp.UseSystemPasswordChar = true;
            // 
            // box_mail
            // 
            this.box_mail.Location = new System.Drawing.Point(280, 86);
            this.box_mail.Name = "box_mail";
            this.box_mail.Size = new System.Drawing.Size(241, 22);
            this.box_mail.TabIndex = 1;
            // 
            // labelConnexion
            // 
            this.labelConnexion.AutoSize = true;
            this.labelConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexion.Location = new System.Drawing.Point(233, 22);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(133, 29);
            this.labelConnexion.TabIndex = 12;
            this.labelConnexion.Text = "Connexion";
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(383, 322);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(138, 26);
            this.btn_connexion.TabIndex = 23;
            this.btn_connexion.Text = "Se connecter";
            this.btn_connexion.UseVisualStyleBackColor = true;
            // 
            // ConnexionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.label_mdp);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.btn_inscription);
            this.Controls.Add(this.box_mdp);
            this.Controls.Add(this.box_mail);
            this.Controls.Add(this.labelConnexion);
            this.Name = "ConnexionPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_mdp;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button btn_inscription;
        private System.Windows.Forms.TextBox box_mdp;
        private System.Windows.Forms.TextBox box_mail;
        private System.Windows.Forms.Label labelConnexion;
        private System.Windows.Forms.Button btn_connexion;
    }
}

