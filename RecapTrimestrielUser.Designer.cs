
namespace Autofact
{
    partial class RecapTrimestrielUser
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
            this.chartRecapTrimUser = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRecapTrimUser)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRecapTrimUser
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRecapTrimUser.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRecapTrimUser.Legends.Add(legend1);
            this.chartRecapTrimUser.Location = new System.Drawing.Point(31, 24);
            this.chartRecapTrimUser.Name = "chartRecapTrimUser";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRecapTrimUser.Series.Add(series1);
            this.chartRecapTrimUser.Size = new System.Drawing.Size(733, 409);
            this.chartRecapTrimUser.TabIndex = 0;
            this.chartRecapTrimUser.Text = "RecapTrimestrielUser";
            // 
            // RecapTrimestrielUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartRecapTrimUser);
            this.Name = "RecapTrimestrielUser";
            this.Text = "RecapTrimestrielUser";
            ((System.ComponentModel.ISupportInitialize)(this.chartRecapTrimUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRecapTrimUser;
    }
}