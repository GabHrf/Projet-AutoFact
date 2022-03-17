
namespace Autofact
{
    partial class Document
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvclient = new System.Windows.Forms.DataGridView();
            this.idclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_choixClie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_nom = new System.Windows.Forms.TextBox();
            this.box_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_dgvprest = new System.Windows.Forms.Label();
            this.dgvpresta = new System.Windows.Forms.DataGridView();
            this.box_montanttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calcul = new System.Windows.Forms.Button();
            this.btn_converttopdf = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.box_adresse = new System.Windows.Forms.TextBox();
            this.Quantite = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpresta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvclient
            // 
            this.dgvclient.AllowUserToAddRows = false;
            this.dgvclient.AllowUserToDeleteRows = false;
            this.dgvclient.AllowUserToResizeRows = false;
            this.dgvclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvclient.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvclient.ColumnHeadersHeight = 35;
            this.dgvclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclie,
            this.nomclie,
            this.prenomclie,
            this.adresseclie});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvclient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvclient.Location = new System.Drawing.Point(38, 138);
            this.dgvclient.Name = "dgvclient";
            this.dgvclient.ReadOnly = true;
            this.dgvclient.RowHeadersVisible = false;
            this.dgvclient.RowHeadersWidth = 51;
            this.dgvclient.RowTemplate.Height = 24;
            this.dgvclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclient.Size = new System.Drawing.Size(1036, 166);
            this.dgvclient.TabIndex = 6;
            this.dgvclient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclient_CellClick);
            // 
            // idclie
            // 
            this.idclie.DataPropertyName = "IDCLIENT";
            this.idclie.HeaderText = "Id Client";
            this.idclie.MinimumWidth = 6;
            this.idclie.Name = "idclie";
            this.idclie.ReadOnly = true;
            // 
            // nomclie
            // 
            this.nomclie.DataPropertyName = "NOM";
            this.nomclie.HeaderText = "Nom";
            this.nomclie.MinimumWidth = 6;
            this.nomclie.Name = "nomclie";
            this.nomclie.ReadOnly = true;
            // 
            // prenomclie
            // 
            this.prenomclie.DataPropertyName = "PRENOM";
            this.prenomclie.HeaderText = "Prénom";
            this.prenomclie.MinimumWidth = 6;
            this.prenomclie.Name = "prenomclie";
            this.prenomclie.ReadOnly = true;
            // 
            // adresseclie
            // 
            this.adresseclie.DataPropertyName = "ADRESSE";
            this.adresseclie.HeaderText = "Adresse Postal";
            this.adresseclie.MinimumWidth = 6;
            this.adresseclie.Name = "adresseclie";
            this.adresseclie.ReadOnly = true;
            // 
            // label_choixClie
            // 
            this.label_choixClie.AutoSize = true;
            this.label_choixClie.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_choixClie.Location = new System.Drawing.Point(33, 92);
            this.label_choixClie.Name = "label_choixClie";
            this.label_choixClie.Size = new System.Drawing.Size(150, 25);
            this.label_choixClie.TabIndex = 7;
            this.label_choixClie.Text = "Choix du client :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Client selectionné :";
            // 
            // box_nom
            // 
            this.box_nom.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nom.Location = new System.Drawing.Point(141, 632);
            this.box_nom.Name = "box_nom";
            this.box_nom.ReadOnly = true;
            this.box_nom.Size = new System.Drawing.Size(133, 31);
            this.box_nom.TabIndex = 25;
            // 
            // box_prenom
            // 
            this.box_prenom.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_prenom.Location = new System.Drawing.Point(141, 677);
            this.box_prenom.Name = "box_prenom";
            this.box_prenom.ReadOnly = true;
            this.box_prenom.Size = new System.Drawing.Size(133, 31);
            this.box_prenom.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(53, 680);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Prénom :";
            // 
            // label_dgvprest
            // 
            this.label_dgvprest.AutoSize = true;
            this.label_dgvprest.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_dgvprest.Location = new System.Drawing.Point(33, 354);
            this.label_dgvprest.Name = "label_dgvprest";
            this.label_dgvprest.Size = new System.Drawing.Size(169, 25);
            this.label_dgvprest.TabIndex = 30;
            this.label_dgvprest.Text = "Choix prestations :";
            // 
            // dgvpresta
            // 
            this.dgvpresta.AllowUserToAddRows = false;
            this.dgvpresta.AllowUserToDeleteRows = false;
            this.dgvpresta.AllowUserToResizeRows = false;
            this.dgvpresta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpresta.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpresta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpresta.ColumnHeadersHeight = 35;
            this.dgvpresta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvpresta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantite,
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
            this.dgvpresta.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvpresta.Location = new System.Drawing.Point(38, 397);
            this.dgvpresta.Name = "dgvpresta";
            this.dgvpresta.RowHeadersVisible = false;
            this.dgvpresta.RowHeadersWidth = 51;
            this.dgvpresta.RowTemplate.Height = 24;
            this.dgvpresta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpresta.Size = new System.Drawing.Size(1036, 166);
            this.dgvpresta.TabIndex = 29;
            this.dgvpresta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpresta_CellClick);
            // 
            // box_montanttotal
            // 
            this.box_montanttotal.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_montanttotal.Location = new System.Drawing.Point(869, 591);
            this.box_montanttotal.Name = "box_montanttotal";
            this.box_montanttotal.ReadOnly = true;
            this.box_montanttotal.Size = new System.Drawing.Size(210, 31);
            this.box_montanttotal.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(727, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Montant total :";
            // 
            // btn_calcul
            // 
            this.btn_calcul.BackColor = System.Drawing.Color.Red;
            this.btn_calcul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcul.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.btn_calcul.ForeColor = System.Drawing.Color.White;
            this.btn_calcul.Location = new System.Drawing.Point(967, 633);
            this.btn_calcul.Name = "btn_calcul";
            this.btn_calcul.Size = new System.Drawing.Size(112, 31);
            this.btn_calcul.TabIndex = 36;
            this.btn_calcul.Text = "Calculer";
            this.btn_calcul.UseVisualStyleBackColor = false;
            this.btn_calcul.Click += new System.EventHandler(this.btn_calcul_Click);
            // 
            // btn_converttopdf
            // 
            this.btn_converttopdf.BackColor = System.Drawing.Color.Red;
            this.btn_converttopdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_converttopdf.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.btn_converttopdf.ForeColor = System.Drawing.Color.White;
            this.btn_converttopdf.Location = new System.Drawing.Point(897, 722);
            this.btn_converttopdf.Name = "btn_converttopdf";
            this.btn_converttopdf.Size = new System.Drawing.Size(177, 34);
            this.btn_converttopdf.TabIndex = 37;
            this.btn_converttopdf.Text = "Générer en PDF";
            this.btn_converttopdf.UseVisualStyleBackColor = false;
            this.btn_converttopdf.Click += new System.EventHandler(this.btn_converttopdf_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Facture",
            "Devis"});
            this.comboBoxType.Location = new System.Drawing.Point(717, 725);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(141, 32);
            this.comboBoxType.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(523, 727);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Type du document :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(46, 725);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Adresse :";
            // 
            // box_adresse
            // 
            this.box_adresse.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_adresse.Location = new System.Drawing.Point(141, 721);
            this.box_adresse.Name = "box_adresse";
            this.box_adresse.ReadOnly = true;
            this.box_adresse.Size = new System.Drawing.Size(133, 31);
            this.box_adresse.TabIndex = 41;
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "QUANTITÉ";
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Quantite.MinimumWidth = 6;
            this.Quantite.Name = "Quantite";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDPRESTATION";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Prestation";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LIBELLE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Libelle";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRIX";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TVA";
            this.dataGridViewTextBoxColumn4.HeaderText = "TVA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 800);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_adresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.btn_converttopdf);
            this.Controls.Add(this.btn_calcul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_montanttotal);
            this.Controls.Add(this.label_dgvprest);
            this.Controls.Add(this.dgvpresta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_prenom);
            this.Controls.Add(this.box_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_choixClie);
            this.Controls.Add(this.dgvclient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Document";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Page";
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpresta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclie;
        private System.Windows.Forms.Label label_choixClie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_nom;
        private System.Windows.Forms.TextBox box_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_dgvprest;
        private System.Windows.Forms.DataGridView dgvpresta;
        private System.Windows.Forms.TextBox box_montanttotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calcul;
        private System.Windows.Forms.Button btn_converttopdf;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_adresse;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}