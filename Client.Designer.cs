
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.box_nom = new System.Windows.Forms.TextBox();
            this.box_prenom = new System.Windows.Forms.TextBox();
            this.box_adresse = new System.Windows.Forms.TextBox();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_adresse = new System.Windows.Forms.Label();
            this.btn_detailscli = new System.Windows.Forms.Button();
            this.dgvclient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnDeselectionner = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).BeginInit();
            this.SuspendLayout();
            // 
            // box_nom
            // 
            resources.ApplyResources(this.box_nom, "box_nom");
            this.box_nom.Name = "box_nom";
            // 
            // box_prenom
            // 
            resources.ApplyResources(this.box_prenom, "box_prenom");
            this.box_prenom.Name = "box_prenom";
            // 
            // box_adresse
            // 
            resources.ApplyResources(this.box_adresse, "box_adresse");
            this.box_adresse.Name = "box_adresse";
            // 
            // label_nom
            // 
            resources.ApplyResources(this.label_nom, "label_nom");
            this.label_nom.Name = "label_nom";
            // 
            // label_prenom
            // 
            resources.ApplyResources(this.label_prenom, "label_prenom");
            this.label_prenom.Name = "label_prenom";
            // 
            // label_adresse
            // 
            resources.ApplyResources(this.label_adresse, "label_adresse");
            this.label_adresse.Name = "label_adresse";
            // 
            // btn_detailscli
            // 
            resources.ApplyResources(this.btn_detailscli, "btn_detailscli");
            this.btn_detailscli.Name = "btn_detailscli";
            this.btn_detailscli.UseVisualStyleBackColor = true;
            this.btn_detailscli.Click += new System.EventHandler(this.btn_detailscli_Click);
            // 
            // dgvclient
            // 
            this.dgvclient.AllowUserToAddRows = false;
            this.dgvclient.AllowUserToDeleteRows = false;
            this.dgvclient.AllowUserToResizeRows = false;
            this.dgvclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvclient.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.dgvclient, "dgvclient");
            this.dgvclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvclient.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvclient.Name = "dgvclient";
            this.dgvclient.ReadOnly = true;
            this.dgvclient.RowHeadersVisible = false;
            this.dgvclient.RowTemplate.Height = 24;
            this.dgvclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclient_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDCLIENT";
            this.dataGridViewTextBoxColumn1.FillWeight = 97.77731F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOM";
            this.dataGridViewTextBoxColumn2.FillWeight = 100.543F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRENOM";
            this.dataGridViewTextBoxColumn3.FillWeight = 101.1772F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ADRESSE";
            this.dataGridViewTextBoxColumn4.FillWeight = 100.5025F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Red;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnAjouter, "btnAjouter");
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Red;
            this.btnModifier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnModifier, "btnModifier");
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.Red;
            this.btnSupp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnSupp, "btnSupp");
            this.btnSupp.ForeColor = System.Drawing.Color.White;
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnDeselectionner
            // 
            this.btnDeselectionner.BackColor = System.Drawing.Color.Red;
            this.btnDeselectionner.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnDeselectionner, "btnDeselectionner");
            this.btnDeselectionner.ForeColor = System.Drawing.Color.White;
            this.btnDeselectionner.Name = "btnDeselectionner";
            this.btnDeselectionner.UseVisualStyleBackColor = false;
            this.btnDeselectionner.Click += new System.EventHandler(this.btnDeselectionner_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.Red;
            this.btnActualiser.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnActualiser, "btnActualiser");
            this.btnActualiser.ForeColor = System.Drawing.Color.White;
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
            // 
            // Client
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnDeselectionner);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvclient);
            this.Controls.Add(this.btn_detailscli);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.box_adresse);
            this.Controls.Add(this.box_prenom);
            this.Controls.Add(this.box_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox box_nom;
        private System.Windows.Forms.TextBox box_prenom;
        private System.Windows.Forms.TextBox box_adresse;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.Button btn_detailscli;
        private System.Windows.Forms.DataGridView dgvclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnDeselectionner;
        private System.Windows.Forms.Button btnActualiser;
    }
}