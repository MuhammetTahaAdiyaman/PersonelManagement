namespace Personel_Kayit
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Sehirler = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Meslek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Sehirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meslek)).BeginInit();
            this.SuspendLayout();
            // 
            // Sehirler
            // 
            chartArea1.Name = "ChartArea1";
            this.Sehirler.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Sehirler.Legends.Add(legend1);
            this.Sehirler.Location = new System.Drawing.Point(12, 61);
            this.Sehirler.Name = "Sehirler";
            this.Sehirler.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sehirler";
            this.Sehirler.Series.Add(series1);
            this.Sehirler.Size = new System.Drawing.Size(429, 300);
            this.Sehirler.TabIndex = 0;
            this.Sehirler.Text = "chart1";
            // 
            // Meslek
            // 
            chartArea2.Name = "ChartArea1";
            this.Meslek.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Meslek.Legends.Add(legend2);
            this.Meslek.Location = new System.Drawing.Point(505, 61);
            this.Meslek.Name = "Meslek";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Meslek-Maas";
            this.Meslek.Series.Add(series2);
            this.Meslek.Size = new System.Drawing.Size(429, 300);
            this.Meslek.TabIndex = 1;
            this.Meslek.Text = "chart2";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.Meslek);
            this.Controls.Add(this.Sehirler);
            this.Name = "FrmGrafikler";
            this.Text = "FrmGrafikler";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sehirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meslek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Sehirler;
        private System.Windows.Forms.DataVisualization.Charting.Chart Meslek;
    }
}