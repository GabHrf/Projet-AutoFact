
namespace Autofact
{
    partial class detailsclient
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_annee = new System.Windows.Forms.ComboBox();
            this.label_annee = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(240, 161);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(789, 391);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBox_annee
            // 
            this.comboBox_annee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_annee.FormattingEnabled = true;
            this.comboBox_annee.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018"});
            this.comboBox_annee.Location = new System.Drawing.Point(240, 115);
            this.comboBox_annee.Name = "comboBox_annee";
            this.comboBox_annee.Size = new System.Drawing.Size(160, 24);
            this.comboBox_annee.TabIndex = 2;
            this.comboBox_annee.Tag = "";
            // 
            // label_annee
            // 
            this.label_annee.AutoSize = true;
            this.label_annee.Location = new System.Drawing.Point(240, 91);
            this.label_annee.Name = "label_annee";
            this.label_annee.Size = new System.Drawing.Size(49, 17);
            this.label_annee.TabIndex = 3;
            this.label_annee.Text = "Année";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(32, 106);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(37, 17);
            this.label_nom.TabIndex = 4;
            this.label_nom.Text = "Nom";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Location = new System.Drawing.Point(32, 148);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(57, 17);
            this.label_prenom.TabIndex = 5;
            this.label_prenom.Text = "Prenom";
            // 
            // detailsclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 585);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_annee);
            this.Controls.Add(this.comboBox_annee);
            this.Controls.Add(this.chart1);
            this.Name = "detailsclient";
            this.Text = "detailsclient";
            this.Load += new System.EventHandler(this.detailsclient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox_annee;
        private System.Windows.Forms.Label label_annee;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
    }
}