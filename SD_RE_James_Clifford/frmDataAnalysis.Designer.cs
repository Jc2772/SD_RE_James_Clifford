
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
            this.lblDataAnalysis = new System.Windows.Forms.Label();
            this.cbxDataAnalysis = new System.Windows.Forms.ComboBox();
            this.btnDataAnalysis = new System.Windows.Forms.Button();
            this.crtDataAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.crtDataAnalysis)).BeginInit();
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
            // cbxDataAnalysis
            // 
            this.cbxDataAnalysis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDataAnalysis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDataAnalysis.FormattingEnabled = true;
            this.cbxDataAnalysis.Location = new System.Drawing.Point(12, 25);
            this.cbxDataAnalysis.Name = "cbxDataAnalysis";
            this.cbxDataAnalysis.Size = new System.Drawing.Size(121, 21);
            this.cbxDataAnalysis.TabIndex = 2;
            this.cbxDataAnalysis.SelectedIndexChanged += new System.EventHandler(this.cbxDataAnalysis_SelectedIndexChanged);
            // 
            // btnDataAnalysis
            // 
            this.btnDataAnalysis.Location = new System.Drawing.Point(713, 12);
            this.btnDataAnalysis.Name = "btnDataAnalysis";
            this.btnDataAnalysis.Size = new System.Drawing.Size(75, 23);
            this.btnDataAnalysis.TabIndex = 3;
            this.btnDataAnalysis.Text = "return";
            this.btnDataAnalysis.UseVisualStyleBackColor = true;
            this.btnDataAnalysis.Click += new System.EventHandler(this.btnDataAnalysis_Click);
            // 
            // crtDataAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.crtDataAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtDataAnalysis.Legends.Add(legend1);
            this.crtDataAnalysis.Location = new System.Drawing.Point(216, 104);
            this.crtDataAnalysis.Name = "crtDataAnalysis";
            this.crtDataAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crtDataAnalysis.Series.Add(series1);
            this.crtDataAnalysis.Size = new System.Drawing.Size(377, 300);
            this.crtDataAnalysis.TabIndex = 4;
            this.crtDataAnalysis.Visible = false;
            // 
            // frmDataAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.crtDataAnalysis);
            this.Controls.Add(this.btnDataAnalysis);
            this.Controls.Add(this.cbxDataAnalysis);
            this.Controls.Add(this.lblDataAnalysis);
            this.Name = "frmDataAnalysis";
            this.Text = "ite";
            this.Load += new System.EventHandler(this.frmDataAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtDataAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataAnalysis;
        private System.Windows.Forms.ComboBox cbxDataAnalysis;
        private System.Windows.Forms.Button btnDataAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtDataAnalysis;
    }
}