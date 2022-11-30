
namespace SD_RE_James_Clifford
{
    partial class frmRegisterSale
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
            this.cbxRegisterSale1 = new System.Windows.Forms.ComboBox();
            this.lblRegisterSale1 = new System.Windows.Forms.Label();
            this.lblRegisterSale2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxRegisterSale1
            // 
            this.cbxRegisterSale1.FormattingEnabled = true;
            this.cbxRegisterSale1.Location = new System.Drawing.Point(12, 25);
            this.cbxRegisterSale1.Name = "cbxRegisterSale1";
            this.cbxRegisterSale1.Size = new System.Drawing.Size(121, 21);
            this.cbxRegisterSale1.TabIndex = 0;
            // 
            // lblRegisterSale1
            // 
            this.lblRegisterSale1.AutoSize = true;
            this.lblRegisterSale1.Location = new System.Drawing.Point(39, 9);
            this.lblRegisterSale1.Name = "lblRegisterSale1";
            this.lblRegisterSale1.Size = new System.Drawing.Size(49, 13);
            this.lblRegisterSale1.TabIndex = 1;
            this.lblRegisterSale1.Text = "livestock";
            // 
            // lblRegisterSale2
            // 
            this.lblRegisterSale2.AutoSize = true;
            this.lblRegisterSale2.Location = new System.Drawing.Point(12, 84);
            this.lblRegisterSale2.Name = "lblRegisterSale2";
            this.lblRegisterSale2.Size = new System.Drawing.Size(49, 13);
            this.lblRegisterSale2.TabIndex = 2;
            this.lblRegisterSale2.Text = "livestock";
            // 
            // frmRegisterSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegisterSale2);
            this.Controls.Add(this.lblRegisterSale1);
            this.Controls.Add(this.cbxRegisterSale1);
            this.Name = "frmRegisterSale";
            this.Text = "frmRegisterSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxRegisterSale1;
        private System.Windows.Forms.Label lblRegisterSale1;
        private System.Windows.Forms.Label lblRegisterSale2;
    }
}