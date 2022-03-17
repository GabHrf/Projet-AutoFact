
namespace Autofact
{
    partial class Prestation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvpresta = new System.Windows.Forms.DataGridView();
            this.idclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box_tva = new System.Windows.Forms.TextBox();
            this.box_prix = new System.Windows.Forms.TextBox();
            this.box_prestation = new System.Windows.Forms.TextBox();
            this.label_prestation = new System.Windows.Forms.Label();
            this.label_prix = new System.Windows.Forms.Label();
            this.label_tva = new System.Windows.Forms.Label();
            this.btn_createpresta = new System.Windows.Forms.Button();
            this.btn_actupresta = new System.Windows.Forms.Button();
            this.btn_supppresta = new System.Windows.Forms.Button();
            this.btn_modifpresta = new System.Windows.Forms.Button();
            this.btn_deselect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpresta)).BeginInit();
            this.SuspendLayout();
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
            this.idclie,
            this.nomclie,
            this.prenomclie,
            this.adresseclie});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpresta.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvpresta.Location = new System.Drawing.Point(63, 245);
            this.dgvpresta.Name = "dgvpresta";
            this.dgvpresta.ReadOnly = true;
            this.dgvpresta.RowHeadersVisible = false;
            this.dgvpresta.RowHeadersWidth = 51;
            this.dgvpresta.RowTemplate.Height = 24;
            this.dgvpresta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpresta.Size = new System.Drawing.Size(980, 534);
            this.dgvpresta.TabIndex = 4;
            this.dgvpresta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpresta_CellClick);
            // 
            // idclie
            // 
            this.idclie.DataPropertyName = "IDPRESTATION";
            this.idclie.HeaderText = "Id Prestation";
            this.idclie.MinimumWidth = 6;
            this.idclie.Name = "idclie";
            this.idclie.ReadOnly = true;
            // 
            // nomclie
            // 
            this.nomclie.DataPropertyName = "LIBELLE";
            this.nomclie.HeaderText = "Libelle";
            this.nomclie.MinimumWidth = 6;
            this.nomclie.Name = "nomclie";
            this.nomclie.ReadOnly = true;
            // 
            // prenomclie
            // 
            this.prenomclie.DataPropertyName = "PRIX";
            this.prenomclie.HeaderText = "Prix";
            this.prenomclie.MinimumWidth = 6;
            this.prenomclie.Name = "prenomclie";
            this.prenomclie.ReadOnly = true;
            // 
            // adresseclie
            // 
            this.adresseclie.DataPropertyName = "TVA";
            this.adresseclie.HeaderText = "TVA";
            this.adresseclie.MinimumWidth = 6;
            this.adresseclie.Name = "adresseclie";
            this.adresseclie.ReadOnly = true;
            // 
            // box_tva
            // 
            this.box_tva.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_tva.Location = new System.Drawing.Point(873, 113);
            this.box_tva.Name = "box_tva";
            this.box_tva.Size = new System.Drawing.Size(117, 31);
            this.box_tva.TabIndex = 16;
            // 
            // box_prix
            // 
            this.box_prix.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_prix.Location = new System.Drawing.Point(608, 114);
            this.box_prix.Name = "box_prix";
            this.box_prix.Size = new System.Drawing.Size(117, 31);
            this.box_prix.TabIndex = 15;
            // 
            // box_prestation
            // 
            this.box_prestation.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.box_prestation.Location = new System.Drawing.Point(369, 113);
            this.box_prestation.Name = "box_prestation";
            this.box_prestation.Size = new System.Drawing.Size(117, 31);
            this.box_prestation.TabIndex = 14;
            // 
            // label_prestation
            // 
            this.label_prestation.AutoSize = true;
            this.label_prestation.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prestation.Location = new System.Drawing.Point(246, 117);
            this.label_prestation.Name = "label_prestation";
            this.label_prestation.Size = new System.Drawing.Size(109, 25);
            this.label_prestation.TabIndex = 17;
            this.label_prestation.Text = "Prestation :";
            // 
            // label_prix
            // 
            this.label_prix.AutoSize = true;
            this.label_prix.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prix.Location = new System.Drawing.Point(541, 116);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(58, 25);
            this.label_prix.TabIndex = 18;
            this.label_prix.Text = "Prix :";
            // 
            // label_tva
            // 
            this.label_tva.AutoSize = true;
            this.label_tva.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tva.Location = new System.Drawing.Point(803, 116);
            this.label_tva.Name = "label_tva";
            this.label_tva.Size = new System.Drawing.Size(61, 25);
            this.label_tva.TabIndex = 19;
            this.label_tva.Text = "TVA :";
            // 
            // btn_createpresta
            // 
            this.btn_createpresta.BackColor = System.Drawing.Color.Red;
            this.btn_createpresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createpresta.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createpresta.ForeColor = System.Drawing.Color.White;
            this.btn_createpresta.Location = new System.Drawing.Point(23, 175);
            this.btn_createpresta.Name = "btn_createpresta";
            this.btn_createpresta.Size = new System.Drawing.Size(193, 38);
            this.btn_createpresta.TabIndex = 20;
            this.btn_createpresta.Text = "Ajouter prestation";
            this.btn_createpresta.UseVisualStyleBackColor = false;
            this.btn_createpresta.Click += new System.EventHandler(this.btn_createpresta_Click);
            // 
            // btn_actupresta
            // 
            this.btn_actupresta.BackColor = System.Drawing.Color.Red;
            this.btn_actupresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actupresta.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actupresta.ForeColor = System.Drawing.Color.White;
            this.btn_actupresta.Location = new System.Drawing.Point(921, 175);
            this.btn_actupresta.Name = "btn_actupresta";
            this.btn_actupresta.Size = new System.Drawing.Size(158, 38);
            this.btn_actupresta.TabIndex = 22;
            this.btn_actupresta.Text = "Actualiser";
            this.btn_actupresta.UseVisualStyleBackColor = false;
            this.btn_actupresta.Click += new System.EventHandler(this.btn_actupresta_Click);
            // 
            // btn_supppresta
            // 
            this.btn_supppresta.BackColor = System.Drawing.Color.Red;
            this.btn_supppresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supppresta.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supppresta.ForeColor = System.Drawing.Color.White;
            this.btn_supppresta.Location = new System.Drawing.Point(432, 175);
            this.btn_supppresta.Name = "btn_supppresta";
            this.btn_supppresta.Size = new System.Drawing.Size(218, 38);
            this.btn_supppresta.TabIndex = 23;
            this.btn_supppresta.Text = "Supprimer Prestation";
            this.btn_supppresta.UseVisualStyleBackColor = false;
            this.btn_supppresta.Click += new System.EventHandler(this.btn_supppresta_Click);
            // 
            // btn_modifpresta
            // 
            this.btn_modifpresta.BackColor = System.Drawing.Color.Red;
            this.btn_modifpresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifpresta.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifpresta.ForeColor = System.Drawing.Color.White;
            this.btn_modifpresta.Location = new System.Drawing.Point(222, 175);
            this.btn_modifpresta.Name = "btn_modifpresta";
            this.btn_modifpresta.Size = new System.Drawing.Size(204, 38);
            this.btn_modifpresta.TabIndex = 24;
            this.btn_modifpresta.Text = "Modifier Prestation";
            this.btn_modifpresta.UseVisualStyleBackColor = false;
            this.btn_modifpresta.Click += new System.EventHandler(this.btn_modifpresta_Click);
            // 
            // btn_deselect
            // 
            this.btn_deselect.BackColor = System.Drawing.Color.Red;
            this.btn_deselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deselect.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deselect.ForeColor = System.Drawing.Color.White;
            this.btn_deselect.Location = new System.Drawing.Point(656, 175);
            this.btn_deselect.Name = "btn_deselect";
            this.btn_deselect.Size = new System.Drawing.Size(259, 38);
            this.btn_deselect.TabIndex = 35;
            this.btn_deselect.Text = "Déselectionner prestation";
            this.btn_deselect.UseVisualStyleBackColor = false;
            this.btn_deselect.Click += new System.EventHandler(this.btn_deselect_Click);
            // 
            // Prestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 800);
            this.Controls.Add(this.btn_deselect);
            this.Controls.Add(this.btn_modifpresta);
            this.Controls.Add(this.btn_supppresta);
            this.Controls.Add(this.btn_actupresta);
            this.Controls.Add(this.btn_createpresta);
            this.Controls.Add(this.label_tva);
            this.Controls.Add(this.label_prix);
            this.Controls.Add(this.label_prestation);
            this.Controls.Add(this.box_tva);
            this.Controls.Add(this.box_prix);
            this.Controls.Add(this.box_prestation);
            this.Controls.Add(this.dgvpresta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prestation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestation Page";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpresta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvpresta;
        private System.Windows.Forms.TextBox box_tva;
        private System.Windows.Forms.TextBox box_prix;
        private System.Windows.Forms.TextBox box_prestation;
        private System.Windows.Forms.Label label_prestation;
        private System.Windows.Forms.Label label_prix;
        private System.Windows.Forms.Label label_tva;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclie;
        private System.Windows.Forms.Button btn_createpresta;
        private System.Windows.Forms.Button btn_actupresta;
        private System.Windows.Forms.Button btn_supppresta;
        private System.Windows.Forms.Button btn_modifpresta;
        private System.Windows.Forms.Button btn_deselect;
    }
}