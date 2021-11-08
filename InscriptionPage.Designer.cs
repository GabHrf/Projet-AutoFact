
namespace Autofact
{
    partial class InscriptionPage
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
            this.labelInscription = new System.Windows.Forms.Label();
            this.box_mail = new System.Windows.Forms.TextBox();
            this.box_mdp = new System.Windows.Forms.TextBox();
            this.btn_inscription = new System.Windows.Forms.Button();
            this.box_nom = new System.Windows.Forms.TextBox();
            this.box_prenom = new System.Windows.Forms.TextBox();
            this.box_confmdp = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_mdp = new System.Windows.Forms.Label();
            this.label_confmdp = new System.Windows.Forms.Label();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInscription
            // 
            this.labelInscription.AutoSize = true;
            this.labelInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscription.Location = new System.Drawing.Point(377, 42);
            this.labelInscription.Name = "labelInscription";
            this.labelInscription.Size = new System.Drawing.Size(128, 29);
            this.labelInscription.TabIndex = 0;
            this.labelInscription.Text = "Inscription";
            // 
            // box_mail
            // 
            this.box_mail.Location = new System.Drawing.Point(443, 122);
            this.box_mail.Name = "box_mail";
            this.box_mail.Size = new System.Drawing.Size(273, 22);
            this.box_mail.TabIndex = 1;
            this.box_mail.TextChanged += new System.EventHandler(this.box_mail_TextChanged);
            this.box_mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_mail_KeyPress);
            // 
            // box_mdp
            // 
            this.box_mdp.Location = new System.Drawing.Point(443, 324);
            this.box_mdp.Name = "box_mdp";
            this.box_mdp.Size = new System.Drawing.Size(273, 22);
            this.box_mdp.TabIndex = 4;
            this.box_mdp.UseSystemPasswordChar = true;
            this.box_mdp.TextChanged += new System.EventHandler(this.box_mdp_TextChanged);
            this.box_mdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_mdp_KeyPress);
            // 
            // btn_inscription
            // 
            this.btn_inscription.Location = new System.Drawing.Point(568, 465);
            this.btn_inscription.Name = "btn_inscription";
            this.btn_inscription.Size = new System.Drawing.Size(138, 26);
            this.btn_inscription.TabIndex = 6;
            this.btn_inscription.Text = "S\'inscrire";
            this.btn_inscription.UseVisualStyleBackColor = true;
            this.btn_inscription.Click += new System.EventHandler(this.btn_inscription_Click);
            // 
            // box_nom
            // 
            this.box_nom.Location = new System.Drawing.Point(443, 187);
            this.box_nom.Name = "box_nom";
            this.box_nom.Size = new System.Drawing.Size(273, 22);
            this.box_nom.TabIndex = 2;
            this.box_nom.TextChanged += new System.EventHandler(this.box_nom_TextChanged);
            this.box_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_nom_KeyPress);
            // 
            // box_prenom
            // 
            this.box_prenom.Location = new System.Drawing.Point(443, 250);
            this.box_prenom.Name = "box_prenom";
            this.box_prenom.Size = new System.Drawing.Size(273, 22);
            this.box_prenom.TabIndex = 3;
            this.box_prenom.TextChanged += new System.EventHandler(this.box_prenom_TextChanged);
            this.box_prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_prenom_KeyPress);
            // 
            // box_confmdp
            // 
            this.box_confmdp.Location = new System.Drawing.Point(443, 389);
            this.box_confmdp.Name = "box_confmdp";
            this.box_confmdp.Size = new System.Drawing.Size(273, 22);
            this.box_confmdp.TabIndex = 5;
            this.box_confmdp.UseSystemPasswordChar = true;
            this.box_confmdp.TextChanged += new System.EventHandler(this.box_confmdp_TextChanged);
            this.box_confmdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_confmdp_KeyPress);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(350, 122);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 20);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "Email";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(357, 187);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(44, 20);
            this.label_nom.TabIndex = 8;
            this.label_nom.Text = "Nom";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.Location = new System.Drawing.Point(334, 250);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(67, 20);
            this.label_prenom.TabIndex = 9;
            this.label_prenom.Text = "Prénom";
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mdp.Location = new System.Drawing.Point(291, 324);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(110, 20);
            this.label_mdp.TabIndex = 10;
            this.label_mdp.Text = "Mot de passe";
            // 
            // label_confmdp
            // 
            this.label_confmdp.AutoSize = true;
            this.label_confmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confmdp.Location = new System.Drawing.Point(168, 389);
            this.label_confmdp.Name = "label_confmdp";
            this.label_confmdp.Size = new System.Drawing.Size(233, 20);
            this.label_confmdp.TabIndex = 11;
            this.label_confmdp.Text = "Confirmation de Mot de passe";
            this.label_confmdp.UseMnemonic = false;
            this.label_confmdp.Click += new System.EventHandler(this.label_confmdp_Click);
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(288, 465);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(138, 26);
            this.btn_connexion.TabIndex = 12;
            this.btn_connexion.Text = "Se Connecter";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // InscriptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 525);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.label_confmdp);
            this.Controls.Add(this.label_mdp);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.box_confmdp);
            this.Controls.Add(this.box_prenom);
            this.Controls.Add(this.box_nom);
            this.Controls.Add(this.btn_inscription);
            this.Controls.Add(this.box_mdp);
            this.Controls.Add(this.box_mail);
            this.Controls.Add(this.labelInscription);
            this.Name = "InscriptionPage";
            this.Text = "ConnexionPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInscription;
        private System.Windows.Forms.TextBox box_mdp;
        private System.Windows.Forms.Button btn_inscription;
        private System.Windows.Forms.TextBox box_nom;
        private System.Windows.Forms.TextBox box_prenom;
        private System.Windows.Forms.TextBox box_confmdp;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_mdp;
        private System.Windows.Forms.Label label_confmdp;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.TextBox box_mail;
    }
}