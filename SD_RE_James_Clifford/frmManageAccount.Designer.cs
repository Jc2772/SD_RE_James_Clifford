
namespace SD_RE_James_Clifford
{
    partial class frmManageAccount
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
            this.cbx = new System.Windows.Forms.ComboBox();
            this.lblManageAccounts1 = new System.Windows.Forms.Label();
            this.lblManageAccounts2 = new System.Windows.Forms.Label();
            this.btnManageAccount1 = new System.Windows.Forms.Button();
            this.btnManageAccount2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx
            // 
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(156, 12);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(121, 21);
            this.cbx.TabIndex = 0;
            // 
            // lblManageAccounts1
            // 
            this.lblManageAccounts1.AutoSize = true;
            this.lblManageAccounts1.Location = new System.Drawing.Point(78, 15);
            this.lblManageAccounts1.Name = "lblManageAccounts1";
            this.lblManageAccounts1.Size = new System.Drawing.Size(39, 13);
            this.lblManageAccounts1.TabIndex = 1;
            this.lblManageAccounts1.Text = "search";
            // 
            // lblManageAccounts2
            // 
            this.lblManageAccounts2.AutoSize = true;
            this.lblManageAccounts2.Location = new System.Drawing.Point(12, 98);
            this.lblManageAccounts2.Name = "lblManageAccounts2";
            this.lblManageAccounts2.Size = new System.Drawing.Size(0, 13);
            this.lblManageAccounts2.TabIndex = 2;
            // 
            // btnManageAccount1
            // 
            this.btnManageAccount1.Location = new System.Drawing.Point(81, 415);
            this.btnManageAccount1.Name = "btnManageAccount1";
            this.btnManageAccount1.Size = new System.Drawing.Size(75, 23);
            this.btnManageAccount1.TabIndex = 3;
            this.btnManageAccount1.Text = "Update";
            this.btnManageAccount1.UseVisualStyleBackColor = true;
            this.btnManageAccount1.Click += new System.EventHandler(this.btnManageAccount1_Click);
            // 
            // btnManageAccount2
            // 
            this.btnManageAccount2.Location = new System.Drawing.Point(293, 415);
            this.btnManageAccount2.Name = "btnManageAccount2";
            this.btnManageAccount2.Size = new System.Drawing.Size(75, 23);
            this.btnManageAccount2.TabIndex = 4;
            this.btnManageAccount2.Text = "Remove";
            this.btnManageAccount2.UseVisualStyleBackColor = true;
            // 
            // frmManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.btnManageAccount2);
            this.Controls.Add(this.btnManageAccount1);
            this.Controls.Add(this.lblManageAccounts2);
            this.Controls.Add(this.lblManageAccounts1);
            this.Controls.Add(this.cbx);
            this.Name = "frmManageAccount";
            this.Text = "frmManageAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.Label lblManageAccounts1;
        private System.Windows.Forms.Label lblManageAccounts2;
        private System.Windows.Forms.Button btnManageAccount1;
        private System.Windows.Forms.Button btnManageAccount2;
    }
}