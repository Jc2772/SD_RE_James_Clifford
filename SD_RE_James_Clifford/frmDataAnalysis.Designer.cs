
namespace SD_RE_James_Clifford
{
    partial class frmDataAnalysis
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
            this.lblDataAnalysis = new System.Windows.Forms.Label();
            this.btnDataAnalysis = new System.Windows.Forms.Button();
            this.crtDataAnalysis1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxDataAnalysis2 = new System.Windows.Forms.ComboBox();
            this.crtDataAnalysis2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.crtDataAnalysis1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtDataAnalysis2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataAnalysis
            // 
            this.lblDataAnalysis.AutoSize = true;
            this.lblDataAnalysis.Location = new System.Drawing.Point(12, 9);
            this.lblDataAnalysis.Name = "lblDataAnalysis";
            this.lblDataAnalysis.Size = new System.Drawing.Size(53, 13);
            this.lblDataAnalysis.TabIndex = 1;
            this.lblDataAnalysis.Text = "view data";
            // 
            // btnDataAnalysis
            // 
            this.btnDataAnalysis.Location = new System.Drawing.Point(601, 12);
            this.btnDataAnalysis.Name = "btnDataAnalysis";
            this.btnDataAnalysis.Size = new System.Drawing.Size(75, 23);
            this.btnDataAnalysis.TabIndex = 3;
            this.btnDataAnalysis.Text = "return";
            this.btnDataAnalysis.UseVisualStyleBackColor = true;
            this.btnDataAnalysis.Click += new System.EventHandler(this.btnDataAnalysis_Click);
            // 
            // crtDataAnalysis1
            // 
            this.crtDataAnalysis1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.crtDataAnalysis1.BackImageTransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.crtDataAnalysis1.BackSecondaryColor = System.Drawing.SystemColors.ActiveCaption;
            this.crtDataAnalysis1.BorderlineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.crtDataAnalysis1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtDataAnalysis1.Legends.Add(legend1);
            this.crtDataAnalysis1.Location = new System.Drawing.Point(12, 66);
            this.crtDataAnalysis1.Name = "crtDataAnalysis1";
            this.crtDataAnalysis1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crtDataAnalysis1.Series.Add(series1);
            this.crtDataAnalysis1.Size = new System.Drawing.Size(331, 581);
            this.crtDataAnalysis1.TabIndex = 4;
            this.crtDataAnalysis1.Visible = false;
            // 
            // cbxDataAnalysis2
            // 
            this.cbxDataAnalysis2.FormattingEnabled = true;
            this.cbxDataAnalysis2.Location = new System.Drawing.Point(12, 25);
            this.cbxDataAnalysis2.Name = "cbxDataAnalysis2";
            this.cbxDataAnalysis2.Size = new System.Drawing.Size(104, 21);
            this.cbxDataAnalysis2.TabIndex = 5;
            this.cbxDataAnalysis2.SelectedIndexChanged += new System.EventHandler(this.cbxDataAnalysis2_SelectedIndexChanged);
            // 
            // crtDataAnalysis2
            // 
            this.crtDataAnalysis2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea2.Name = "ChartArea1";
            this.crtDataAnalysis2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crtDataAnalysis2.Legends.Add(legend2);
            this.crtDataAnalysis2.Location = new System.Drawing.Point(349, 66);
            this.crtDataAnalysis2.Name = "crtDataAnalysis2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.crtDataAnalysis2.Series.Add(series2);
            this.crtDataAnalysis2.Size = new System.Drawing.Size(327, 581);
            this.crtDataAnalysis2.TabIndex = 6;
            this.crtDataAnalysis2.Text = "chart1";
            this.crtDataAnalysis2.Visible = false;
            // 
            // frmDataAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 659);
            this.ControlBox = false;
            this.Controls.Add(this.crtDataAnalysis2);
            this.Controls.Add(this.cbxDataAnalysis2);
            this.Controls.Add(this.crtDataAnalysis1);
            this.Controls.Add(this.btnDataAnalysis);
            this.Controls.Add(this.lblDataAnalysis);
            this.Name = "frmDataAnalysis";
            this.Text = "Data Analysis";
            this.Load += new System.EventHandler(this.frmDataAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtDataAnalysis1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtDataAnalysis2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataAnalysis;
        private System.Windows.Forms.Button btnDataAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtDataAnalysis1;
        private System.Windows.Forms.ComboBox cbxDataAnalysis2;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtDataAnalysis2;
    }
}