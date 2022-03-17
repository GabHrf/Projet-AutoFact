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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneldrag = new System.Windows.Forms.Panel();
            this.btn_minimized = new System.Windows.Forms.Button();
            this.btn_leave = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.paneldrag.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mdp.Location = new System.Drawing.Point(452, 272);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(136, 28);
            this.label_mdp.TabIndex = 22;
            this.label_mdp.Text = "Mot de passe";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label_email.Location = new System.Drawing.Point(483, 176);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(60, 28);
            this.label_email.TabIndex = 19;
            this.label_email.Text = "Email";
            // 
            // btn_inscription
            // 
            this.btn_inscription.BackColor = System.Drawing.Color.Red;
            this.btn_inscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscription.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscription.ForeColor = System.Drawing.Color.White;
            this.btn_inscription.Location = new System.Drawing.Point(342, 390);
            this.btn_inscription.Name = "btn_inscription";
            this.btn_inscription.Size = new System.Drawing.Size(154, 36);
            this.btn_inscription.TabIndex = 4;
            this.btn_inscription.Text = "S\'inscrire";
            this.btn_inscription.UseVisualStyleBackColor = false;
            this.btn_inscription.Click += new System.EventHandler(this.btn_inscription_Click);
            // 
            // box_mdp
            // 
            this.box_mdp.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_mdp.Location = new System.Drawing.Point(342, 316);
            this.box_mdp.Name = "box_mdp";
            this.box_mdp.Size = new System.Drawing.Size(338, 31);
            this.box_mdp.TabIndex = 2;
            this.box_mdp.UseSystemPasswordChar = true;
            this.box_mdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_mdp_KeyPress);
            // 
            // box_mail
            // 
            this.box_mail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_mail.Location = new System.Drawing.Point(342, 213);
            this.box_mail.Name = "box_mail";
            this.box_mail.Size = new System.Drawing.Size(338, 31);
            this.box_mail.TabIndex = 1;
            this.box_mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_mail_KeyPress);
            // 
            // labelConnexion
            // 
            this.labelConnexion.AutoSize = true;
            this.labelConnexion.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexion.Location = new System.Drawing.Point(422, 87);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(171, 45);
            this.labelConnexion.TabIndex = 12;
            this.labelConnexion.Text = "Connexion";
            this.labelConnexion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_connexion
            // 
            this.btn_connexion.BackColor = System.Drawing.Color.Red;
            this.btn_connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connexion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.ForeColor = System.Drawing.Color.White;
            this.btn_connexion.Location = new System.Drawing.Point(526, 390);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(154, 36);
            this.btn_connexion.TabIndex = 3;
            this.btn_connexion.Text = "Se connecter";
            this.btn_connexion.UseVisualStyleBackColor = false;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(874, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 121);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel2.Location = new System.Drawing.Point(917, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 87);
            this.panel2.TabIndex = 25;
            // 
            // paneldrag
            // 
            this.paneldrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.paneldrag.Controls.Add(this.btn_minimized);
            this.paneldrag.Controls.Add(this.btn_leave);
            this.paneldrag.Location = new System.Drawing.Point(785, 0);
            this.paneldrag.Name = "paneldrag";
            this.paneldrag.Size = new System.Drawing.Size(215, 45);
            this.paneldrag.TabIndex = 28;
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
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-44, -39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 137);
            this.panel1.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel4.Location = new System.Drawing.Point(-7, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 74);
            this.panel4.TabIndex = 26;
            // 
            // ConnexionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.paneldrag);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.label_mdp);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.btn_inscription);
            this.Controls.Add(this.box_mdp);
            this.Controls.Add(this.box_mail);
            this.Controls.Add(this.labelConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnexionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion Page";
            this.Load += new System.EventHandler(this.ConnexionPage_Load);
            this.paneldrag.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Panel paneldrag;
        private System.Windows.Forms.Button btn_minimized;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}

