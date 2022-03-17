
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
            this.paneldrag = new System.Windows.Forms.Panel();
            this.btn_minimized = new System.Windows.Forms.Button();
            this.btn_leave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.paneldrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInscription
            // 
            this.labelInscription.AutoSize = true;
            this.labelInscription.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelInscription.Location = new System.Drawing.Point(414, 58);
            this.labelInscription.Name = "labelInscription";
            this.labelInscription.Size = new System.Drawing.Size(190, 45);
            this.labelInscription.TabIndex = 0;
            this.labelInscription.Text = "Inscription";
            // 
            // box_mail
            // 
            this.box_mail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_mail.Location = new System.Drawing.Point(351, 181);
            this.box_mail.Name = "box_mail";
            this.box_mail.Size = new System.Drawing.Size(338, 31);
            this.box_mail.TabIndex = 1;
            this.box_mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_mail_KeyPress);
            // 
            // box_mdp
            // 
            this.box_mdp.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_mdp.Location = new System.Drawing.Point(351, 389);
            this.box_mdp.Name = "box_mdp";
            this.box_mdp.Size = new System.Drawing.Size(338, 31);
            this.box_mdp.TabIndex = 4;
            this.box_mdp.UseSystemPasswordChar = true;
            this.box_mdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_mdp_KeyPress);
            // 
            // btn_inscription
            // 
            this.btn_inscription.BackColor = System.Drawing.Color.Red;
            this.btn_inscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscription.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscription.ForeColor = System.Drawing.Color.White;
            this.btn_inscription.Location = new System.Drawing.Point(535, 515);
            this.btn_inscription.Name = "btn_inscription";
            this.btn_inscription.Size = new System.Drawing.Size(154, 36);
            this.btn_inscription.TabIndex = 6;
            this.btn_inscription.Text = "S\'inscrire";
            this.btn_inscription.UseVisualStyleBackColor = false;
            this.btn_inscription.Click += new System.EventHandler(this.btn_inscription_Click);
            // 
            // box_nom
            // 
            this.box_nom.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_nom.Location = new System.Drawing.Point(351, 248);
            this.box_nom.Name = "box_nom";
            this.box_nom.Size = new System.Drawing.Size(338, 31);
            this.box_nom.TabIndex = 2;
            this.box_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_nom_KeyPress);
            // 
            // box_prenom
            // 
            this.box_prenom.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_prenom.Location = new System.Drawing.Point(351, 321);
            this.box_prenom.Name = "box_prenom";
            this.box_prenom.Size = new System.Drawing.Size(338, 31);
            this.box_prenom.TabIndex = 3;
            this.box_prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_prenom_KeyPress);
            // 
            // box_confmdp
            // 
            this.box_confmdp.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_confmdp.Location = new System.Drawing.Point(351, 460);
            this.box_confmdp.Name = "box_confmdp";
            this.box_confmdp.Size = new System.Drawing.Size(338, 31);
            this.box_confmdp.TabIndex = 5;
            this.box_confmdp.UseSystemPasswordChar = true;
            this.box_confmdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_confmdp_KeyPress);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(475, 150);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(60, 28);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "Email";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label_nom.Location = new System.Drawing.Point(475, 217);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(54, 28);
            this.label_nom.TabIndex = 8;
            this.label_nom.Text = "Nom";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label_prenom.Location = new System.Drawing.Point(475, 290);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(79, 28);
            this.label_prenom.TabIndex = 9;
            this.label_prenom.Text = "Prénom";
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label_mdp.Location = new System.Drawing.Point(443, 358);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(136, 28);
            this.label_mdp.TabIndex = 10;
            this.label_mdp.Text = "Mot de passe";
            // 
            // label_confmdp
            // 
            this.label_confmdp.AutoSize = true;
            this.label_confmdp.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label_confmdp.Location = new System.Drawing.Point(383, 429);
            this.label_confmdp.Name = "label_confmdp";
            this.label_confmdp.Size = new System.Drawing.Size(290, 28);
            this.label_confmdp.TabIndex = 11;
            this.label_confmdp.Text = "Confirmation de Mot de passe";
            this.label_confmdp.UseMnemonic = false;
            // 
            // btn_connexion
            // 
            this.btn_connexion.BackColor = System.Drawing.Color.Red;
            this.btn_connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connexion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.ForeColor = System.Drawing.Color.White;
            this.btn_connexion.Location = new System.Drawing.Point(351, 515);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(154, 36);
            this.btn_connexion.TabIndex = 7;
            this.btn_connexion.Text = "Se Connecter";
            this.btn_connexion.UseVisualStyleBackColor = false;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // paneldrag
            // 
            this.paneldrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.paneldrag.Controls.Add(this.btn_minimized);
            this.paneldrag.Controls.Add(this.btn_leave);
            this.paneldrag.Location = new System.Drawing.Point(785, 0);
            this.paneldrag.Name = "paneldrag";
            this.paneldrag.Size = new System.Drawing.Size(215, 45);
            this.paneldrag.TabIndex = 30;
            this.paneldrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneldrag_MouseDown);
            this.paneldrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneldrag_MouseMove);
            this.paneldrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneldrag_MouseUp);
            // 
            // btn_minimized
            // 
            this.btn_minimized.BackgroundImage = global::Autofact.Properties.Resources.icons8_réduire_la_fenêtre_96;
            this.btn_minimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimized.FlatAppearance.BorderSize = 0;
            this.btn_minimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimized.Location = new System.Drawing.Point(89, 4);
            this.btn_minimized.Name = "btn_minimized";
            this.btn_minimized.Size = new System.Drawing.Size(49, 36);
            this.btn_minimized.TabIndex = 29;
            this.btn_minimized.UseVisualStyleBackColor = true;
            this.btn_minimized.Click += new System.EventHandler(this.btn_minimized_Click);
            // 
            // btn_leave
            // 
            this.btn_leave.BackgroundImage = global::Autofact.Properties.Resources.icons8_macos_fermer_96__1_;
            this.btn_leave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_leave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_leave.FlatAppearance.BorderSize = 0;
            this.btn_leave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_leave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave.Location = new System.Drawing.Point(153, 3);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(59, 39);
            this.btn_leave.TabIndex = 27;
            this.btn_leave.UseVisualStyleBackColor = true;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel4.Location = new System.Drawing.Point(-7, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 74);
            this.panel4.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(-44, -39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 137);
            this.panel1.TabIndex = 28;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel2.Location = new System.Drawing.Point(917, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 87);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(874, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 121);
            this.panel3.TabIndex = 31;
            // 
            // InscriptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paneldrag);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.box_nom);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.label_confmdp);
            this.Controls.Add(this.label_mdp);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.box_confmdp);
            this.Controls.Add(this.box_prenom);
            this.Controls.Add(this.btn_inscription);
            this.Controls.Add(this.box_mdp);
            this.Controls.Add(this.box_mail);
            this.Controls.Add(this.labelInscription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InscriptionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription Page";
            this.paneldrag.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel paneldrag;
        private System.Windows.Forms.Button btn_minimized;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}