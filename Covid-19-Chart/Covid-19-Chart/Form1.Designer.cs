namespace Covid_19_Chart
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlcovidstaafgrafiek = new System.Windows.Forms.Panel();
            this.covidstaafgrafiek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlcovidgrafieken = new System.Windows.Forms.Panel();
            this.covidgrafieken = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btncovidgrafieken = new System.Windows.Forms.Button();
            this.btncovidstaafgrafiek = new System.Windows.Forms.Button();
            this.pnlcovidstaafgrafiek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.covidstaafgrafiek)).BeginInit();
            this.pnlcovidgrafieken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.covidgrafieken)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlcovidstaafgrafiek
            // 
            this.pnlcovidstaafgrafiek.Controls.Add(this.covidstaafgrafiek);
            this.pnlcovidstaafgrafiek.Location = new System.Drawing.Point(0, 0);
            this.pnlcovidstaafgrafiek.Name = "pnlcovidstaafgrafiek";
            this.pnlcovidstaafgrafiek.Size = new System.Drawing.Size(1204, 678);
            this.pnlcovidstaafgrafiek.TabIndex = 0;
            // 
            // covidstaafgrafiek
            // 
            chartArea1.Name = "ChartArea1";
            this.covidstaafgrafiek.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.covidstaafgrafiek.Legends.Add(legend1);
            this.covidstaafgrafiek.Location = new System.Drawing.Point(12, 55);
            this.covidstaafgrafiek.Name = "covidstaafgrafiek";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Confirmed";
            this.covidstaafgrafiek.Series.Add(series1);
            this.covidstaafgrafiek.Size = new System.Drawing.Size(1162, 590);
            this.covidstaafgrafiek.TabIndex = 0;
            this.covidstaafgrafiek.Text = "chart3";
            // 
            // pnlcovidgrafieken
            // 
            this.pnlcovidgrafieken.Controls.Add(this.covidgrafieken);
            this.pnlcovidgrafieken.Location = new System.Drawing.Point(0, 0);
            this.pnlcovidgrafieken.Name = "pnlcovidgrafieken";
            this.pnlcovidgrafieken.Size = new System.Drawing.Size(1204, 678);
            this.pnlcovidgrafieken.TabIndex = 1;
            // 
            // covidgrafieken
            // 
            chartArea2.Name = "ChartArea1";
            this.covidgrafieken.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.covidgrafieken.Legends.Add(legend2);
            this.covidgrafieken.Location = new System.Drawing.Point(12, 55);
            this.covidgrafieken.Name = "covidgrafieken";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "CovidConfirmed";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "CovidRecovered";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "CovidDeaths";
            this.covidgrafieken.Series.Add(series2);
            this.covidgrafieken.Series.Add(series3);
            this.covidgrafieken.Series.Add(series4);
            this.covidgrafieken.Size = new System.Drawing.Size(1147, 595);
            this.covidgrafieken.TabIndex = 0;
            this.covidgrafieken.Text = "chart4";
            // 
            // btncovidgrafieken
            // 
            this.btncovidgrafieken.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncovidgrafieken.Location = new System.Drawing.Point(202, 12);
            this.btncovidgrafieken.Name = "btncovidgrafieken";
            this.btncovidgrafieken.Size = new System.Drawing.Size(174, 36);
            this.btncovidgrafieken.TabIndex = 2;
            this.btncovidgrafieken.Text = "Covid grafieken";
            this.btncovidgrafieken.UseVisualStyleBackColor = true;
            this.btncovidgrafieken.Click += new System.EventHandler(this.btncovidgrafieken_Click);
            // 
            // btncovidstaafgrafiek
            // 
            this.btncovidstaafgrafiek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncovidstaafgrafiek.Location = new System.Drawing.Point(12, 12);
            this.btncovidstaafgrafiek.Name = "btncovidstaafgrafiek";
            this.btncovidstaafgrafiek.Size = new System.Drawing.Size(174, 36);
            this.btncovidstaafgrafiek.TabIndex = 3;
            this.btncovidstaafgrafiek.Text = "Covidstaafgrafiek";
            this.btncovidstaafgrafiek.UseVisualStyleBackColor = true;
            this.btncovidstaafgrafiek.Click += new System.EventHandler(this.btncovidstaafgrafiek_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1204, 678);
            this.Controls.Add(this.btncovidstaafgrafiek);
            this.Controls.Add(this.btncovidgrafieken);
            this.Controls.Add(this.pnlcovidgrafieken);
            this.Controls.Add(this.pnlcovidstaafgrafiek);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlcovidstaafgrafiek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.covidstaafgrafiek)).EndInit();
            this.pnlcovidgrafieken.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.covidgrafieken)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel pnlcovidstaafgrafiek;
        private System.Windows.Forms.DataVisualization.Charting.Chart covidstaafgrafiek;
        private System.Windows.Forms.Panel pnlcovidgrafieken;
        private System.Windows.Forms.DataVisualization.Charting.Chart covidgrafieken;
        private System.Windows.Forms.Button btncovidgrafieken;
        private System.Windows.Forms.Button btncovidstaafgrafiek;
    }
}

