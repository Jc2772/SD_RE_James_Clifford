
namespace SD_RE_James_Clifford
{
    partial class frmQueryLivestock
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
            this.btnfrmQueryLivestock3 = new System.Windows.Forms.Button();
            this.lblfrmQueryLivestock2 = new System.Windows.Forms.Label();
            this.lblfrmQueryLivestock1 = new System.Windows.Forms.Label();
            this.cbxfrmQueryLivestock = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnfrmQueryLivestock3
            // 
            this.btnfrmQueryLivestock3.Location = new System.Drawing.Point(320, 13);
            this.btnfrmQueryLivestock3.Name = "btnfrmQueryLivestock3";
            this.btnfrmQueryLivestock3.Size = new System.Drawing.Size(75, 23);
            this.btnfrmQueryLivestock3.TabIndex = 9;
            this.btnfrmQueryLivestock3.Text = "return";
            this.btnfrmQueryLivestock3.UseVisualStyleBackColor = true;
            this.btnfrmQueryLivestock3.Click += new System.EventHandler(this.btnfrmQueryLivestock3_Click);
            // 
            // lblfrmQueryLivestock2
            // 
            this.lblfrmQueryLivestock2.AutoSize = true;
            this.lblfrmQueryLivestock2.Location = new System.Drawing.Point(11, 83);
            this.lblfrmQueryLivestock2.Name = "lblfrmQueryLivestock2";
            this.lblfrmQueryLivestock2.Size = new System.Drawing.Size(84, 13);
            this.lblfrmQueryLivestock2.TabIndex = 8;
            this.lblfrmQueryLivestock2.Text = "Account Display";
            // 
            // lblfrmQueryLivestock1
            // 
            this.lblfrmQueryLivestock1.AutoSize = true;
            this.lblfrmQueryLivestock1.Location = new System.Drawing.Point(77, 18);
            this.lblfrmQueryLivestock1.Name = "lblfrmQueryLivestock1";
            this.lblfrmQueryLivestock1.Size = new System.Drawing.Size(39, 13);
            this.lblfrmQueryLivestock1.TabIndex = 7;
            this.lblfrmQueryLivestock1.Text = "search";
            // 
            // cbxfrmQueryLivestock
            // 
            this.cbxfrmQueryLivestock.FormattingEnabled = true;
            this.cbxfrmQueryLivestock.Location = new System.Drawing.Point(155, 15);
            this.cbxfrmQueryLivestock.Name = "cbxfrmQueryLivestock";
            this.cbxfrmQueryLivestock.Size = new System.Drawing.Size(121, 21);
            this.cbxfrmQueryLivestock.TabIndex = 6;
            this.cbxfrmQueryLivestock.SelectedIndexChanged += new System.EventHandler(this.cbxfrmQueryLivestock_SelectedIndexChanged);
            // 
            // frmQueryLivestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 289);
            this.Controls.Add(this.btnfrmQueryLivestock3);
            this.Controls.Add(this.lblfrmQueryLivestock2);
            this.Controls.Add(this.lblfrmQueryLivestock1);
            this.Controls.Add(this.cbxfrmQueryLivestock);
            this.Name = "frmQueryLivestock";
            this.Text = "frmQueryLivestock";
            this.Load += new System.EventHandler(this.frmQueryLivestock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfrmQueryLivestock3;
        private System.Windows.Forms.Label lblfrmQueryLivestock2;
        private System.Windows.Forms.Label lblfrmQueryLivestock1;
        private System.Windows.Forms.ComboBox cbxfrmQueryLivestock;
    }
}