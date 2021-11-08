
namespace Autofact
{
    partial class RecapMensuelUser
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
            this.chartRecapMensUser = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRecapMensUser)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRecapMensUser
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRecapMensUser.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRecapMensUser.Legends.Add(legend1);
            this.chartRecapMensUser.Location = new System.Drawing.Point(29, 24);
            this.chartRecapMensUser.Name = "chartRecapMensUser";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRecapMensUser.Series.Add(series1);
            this.chartRecapMensUser.Size = new System.Drawing.Size(755, 418);
            this.chartRecapMensUser.TabIndex = 0;
            this.chartRecapMensUser.Text = "RecapMensuelUser";
            this.chartRecapMensUser.Click += new System.EventHandler(this.chartRecapMensUser_Click);
            // 
            // RecapMensuelUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartRecapMensUser);
            this.Name = "RecapMensuelUser";
            this.Text = "RecapMensuelUser";
            ((System.ComponentModel.ISupportInitialize)(this.chartRecapMensUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRecapMensUser;
    }
}