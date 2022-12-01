
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
            this.lblDataAnalysis = new System.Windows.Forms.Label();
            this.cbxDataAnalysis = new System.Windows.Forms.ComboBox();
            this.btnDataAnalysis = new System.Windows.Forms.Button();
            this.pcbViewData = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbViewData)).BeginInit();
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
            this.cbxDataAnalysis.FormattingEnabled = true;
            this.cbxDataAnalysis.Location = new System.Drawing.Point(12, 25);
            this.cbxDataAnalysis.Name = "cbxDataAnalysis";
            this.cbxDataAnalysis.Size = new System.Drawing.Size(121, 21);
            this.cbxDataAnalysis.TabIndex = 2;
            // 
            // btnDataAnalysis
            // 
            this.btnDataAnalysis.Location = new System.Drawing.Point(713, 12);
            this.btnDataAnalysis.Name = "btnDataAnalysis";
            this.btnDataAnalysis.Size = new System.Drawing.Size(75, 23);
            this.btnDataAnalysis.TabIndex = 3;
            this.btnDataAnalysis.Text = "button1";
            this.btnDataAnalysis.UseVisualStyleBackColor = true;
            this.btnDataAnalysis.Click += new System.EventHandler(this.btnDataAnalysis_Click);
            // 
            // pcbViewData
            // 
            this.pcbViewData.Location = new System.Drawing.Point(12, 52);
            this.pcbViewData.Name = "pcbViewData";
            this.pcbViewData.Size = new System.Drawing.Size(776, 386);
            this.pcbViewData.TabIndex = 4;
            this.pcbViewData.TabStop = false;
            // 
            // frmDataAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pcbViewData);
            this.Controls.Add(this.btnDataAnalysis);
            this.Controls.Add(this.cbxDataAnalysis);
            this.Controls.Add(this.lblDataAnalysis);
            this.Name = "frmDataAnalysis";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataAnalysis;
        private System.Windows.Forms.ComboBox cbxDataAnalysis;
        private System.Windows.Forms.Button btnDataAnalysis;
        private System.Windows.Forms.PictureBox pcbViewData;
    }
}