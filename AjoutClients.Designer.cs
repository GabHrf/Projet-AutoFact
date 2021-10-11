
namespace Autofact
{
    partial class AjoutClients
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
            this.btn_ajoutclie = new System.Windows.Forms.Button();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_adresse = new System.Windows.Forms.Label();
            this.box_nom = new System.Windows.Forms.TextBox();
            this.box_prenom = new System.Windows.Forms.TextBox();
            this.box_adresse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ajoutclie
            // 
            this.btn_ajoutclie.Location = new System.Drawing.Point(611, 361);
            this.btn_ajoutclie.Name = "btn_ajoutclie";
            this.btn_ajoutclie.Size = new System.Drawing.Size(181, 68);
            this.btn_ajoutclie.TabIndex = 0;
            this.btn_ajoutclie.Text = "Ajouter un client";
            this.btn_ajoutclie.UseVisualStyleBackColor = true;
            this.btn_ajoutclie.Click += new System.EventHandler(this.btn_ajoutclie_Click);
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(392, 96);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(37, 17);
            this.label_nom.TabIndex = 1;
            this.label_nom.Text = "Nom";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Location = new System.Drawing.Point(392, 169);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(57, 17);
            this.label_prenom.TabIndex = 2;
            this.label_prenom.Text = "Prénom";
            // 
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Location = new System.Drawing.Point(392, 233);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(60, 17);
            this.label_adresse.TabIndex = 3;
            this.label_adresse.Text = "Adresse";
            // 
            // box_nom
            // 
            this.box_nom.Location = new System.Drawing.Point(509, 96);
            this.box_nom.Name = "box_nom";
            this.box_nom.Size = new System.Drawing.Size(109, 22);
            this.box_nom.TabIndex = 4;
            // 
            // box_prenom
            // 
            this.box_prenom.Location = new System.Drawing.Point(509, 164);
            this.box_prenom.Name = "box_prenom";
            this.box_prenom.Size = new System.Drawing.Size(109, 22);
            this.box_prenom.TabIndex = 5;
            // 
            // box_adresse
            // 
            this.box_adresse.Location = new System.Drawing.Point(509, 230);
            this.box_adresse.Name = "box_adresse";
            this.box_adresse.Size = new System.Drawing.Size(109, 22);
            this.box_adresse.TabIndex = 6;
            // 
            // AjoutClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 487);
            this.Controls.Add(this.box_adresse);
            this.Controls.Add(this.box_prenom);
            this.Controls.Add(this.box_nom);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.btn_ajoutclie);
            this.Name = "AjoutClients";
            this.Text = "AjoutClients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajoutclie;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.TextBox box_nom;
        private System.Windows.Forms.TextBox box_prenom;
        private System.Windows.Forms.TextBox box_adresse;
    }
}