
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
            this.btnQueryLivestock3 = new System.Windows.Forms.Button();
            this.lblQueryLivestock2 = new System.Windows.Forms.Label();
            this.lblQueryLivestock1 = new System.Windows.Forms.Label();
            this.cbxQueryLivestock = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnQueryLivestock3
            // 
            this.btnQueryLivestock3.Location = new System.Drawing.Point(320, 13);
            this.btnQueryLivestock3.Name = "btnQueryLivestock3";
            this.btnQueryLivestock3.Size = new System.Drawing.Size(75, 23);
            this.btnQueryLivestock3.TabIndex = 9;
            this.btnQueryLivestock3.Text = "return";
            this.btnQueryLivestock3.UseVisualStyleBackColor = true;
            this.btnQueryLivestock3.Click += new System.EventHandler(this.btnfrmQueryLivestock3_Click);
            // 
            // lblQueryLivestock2
            // 
            this.lblQueryLivestock2.AutoSize = true;
            this.lblQueryLivestock2.Location = new System.Drawing.Point(11, 83);
            this.lblQueryLivestock2.Name = "lblQueryLivestock2";
            this.lblQueryLivestock2.Size = new System.Drawing.Size(53, 13);
            this.lblQueryLivestock2.TabIndex = 8;
            this.lblQueryLivestock2.Text = "Livestock";
            // 
            // lblQueryLivestock1
            // 
            this.lblQueryLivestock1.AutoSize = true;
            this.lblQueryLivestock1.Location = new System.Drawing.Point(77, 18);
            this.lblQueryLivestock1.Name = "lblQueryLivestock1";
            this.lblQueryLivestock1.Size = new System.Drawing.Size(39, 13);
            this.lblQueryLivestock1.TabIndex = 7;
            this.lblQueryLivestock1.Text = "search";
            // 
            // cbxQueryLivestock
            // 
            this.cbxQueryLivestock.FormattingEnabled = true;
            this.cbxQueryLivestock.Location = new System.Drawing.Point(155, 15);
            this.cbxQueryLivestock.Name = "cbxQueryLivestock";
            this.cbxQueryLivestock.Size = new System.Drawing.Size(121, 21);
            this.cbxQueryLivestock.TabIndex = 6;
            this.cbxQueryLivestock.SelectedIndexChanged += new System.EventHandler(this.cbxQueryLivestock_SelectedIndexChanged);
            // 
            // frmQueryLivestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 289);
            this.ControlBox = false;
            this.Controls.Add(this.btnQueryLivestock3);
            this.Controls.Add(this.lblQueryLivestock2);
            this.Controls.Add(this.lblQueryLivestock1);
            this.Controls.Add(this.cbxQueryLivestock);
            this.Name = "frmQueryLivestock";
            this.Text = "frmQueryLivestock";
            this.Load += new System.EventHandler(this.frmQueryLivestock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQueryLivestock3;
        private System.Windows.Forms.Label lblQueryLivestock2;
        private System.Windows.Forms.Label lblQueryLivestock1;
        private System.Windows.Forms.ComboBox cbxQueryLivestock;
    }
}