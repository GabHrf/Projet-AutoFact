
namespace Autofact
{
    partial class ConnexionPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.TextBox();
            this.btn_inscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscription";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(361, 170);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(161, 22);
            this.mail.TabIndex = 1;
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(361, 218);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(161, 22);
            this.mdp.TabIndex = 2;
            // 
            // btn_inscription
            // 
            this.btn_inscription.Location = new System.Drawing.Point(383, 290);
            this.btn_inscription.Name = "btn_inscription";
            this.btn_inscription.Size = new System.Drawing.Size(138, 26);
            this.btn_inscription.TabIndex = 3;
            this.btn_inscription.Text = "S\'inscrire";
            this.btn_inscription.UseVisualStyleBackColor = true;
            this.btn_inscription.Click += new System.EventHandler(this.btn_inscription_Click);
            // 
            // ConnexionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 507);
            this.Controls.Add(this.btn_inscription);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label1);
            this.Name = "ConnexionPage";
            this.Text = "ConnexionPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.Button btn_inscription;
    }
}