
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
            this.cbxManageAccount = new System.Windows.Forms.ComboBox();
            this.lblManageAccounts1 = new System.Windows.Forms.Label();
            this.lblManageAccounts2 = new System.Windows.Forms.Label();
            this.btnManageAccount1 = new System.Windows.Forms.Button();
            this.btnManageAccount2 = new System.Windows.Forms.Button();
            this.btnManageAccounts3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxManageAccount
            // 
            this.cbxManageAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxManageAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxManageAccount.FormattingEnabled = true;
            this.cbxManageAccount.Location = new System.Drawing.Point(156, 12);
            this.cbxManageAccount.Name = "cbxManageAccount";
            this.cbxManageAccount.Size = new System.Drawing.Size(121, 21);
            this.cbxManageAccount.TabIndex = 0;
            this.cbxManageAccount.DropDown += new System.EventHandler(this.cbxManageAccount_DropDown);
            this.cbxManageAccount.SelectedIndexChanged += new System.EventHandler(this.cbxManageAccount_SelectedIndexChanged);
            this.cbxManageAccount.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbxManageAccount_PreviewKeyDown);
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
            this.lblManageAccounts2.Location = new System.Drawing.Point(12, 70);
            this.lblManageAccounts2.Name = "lblManageAccounts2";
            this.lblManageAccounts2.Size = new System.Drawing.Size(84, 13);
            this.lblManageAccounts2.TabIndex = 2;
            this.lblManageAccounts2.Text = "Account Display";
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
            this.btnManageAccount2.Click += new System.EventHandler(this.btnManageAccount2_Click);
            // 
            // btnManageAccounts3
            // 
            this.btnManageAccounts3.Location = new System.Drawing.Point(352, 5);
            this.btnManageAccounts3.Name = "btnManageAccounts3";
            this.btnManageAccounts3.Size = new System.Drawing.Size(75, 23);
            this.btnManageAccounts3.TabIndex = 5;
            this.btnManageAccounts3.Text = "return";
            this.btnManageAccounts3.UseVisualStyleBackColor = true;
            this.btnManageAccounts3.Click += new System.EventHandler(this.btnManageAccounts3_Click);
            // 
            // frmManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnManageAccounts3);
            this.Controls.Add(this.btnManageAccount2);
            this.Controls.Add(this.btnManageAccount1);
            this.Controls.Add(this.lblManageAccounts2);
            this.Controls.Add(this.lblManageAccounts1);
            this.Controls.Add(this.cbxManageAccount);
            this.Name = "frmManageAccount";
            this.Text = "Manage Account";
            this.Load += new System.EventHandler(this.frmManageAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxManageAccount;
        private System.Windows.Forms.Label lblManageAccounts1;
        private System.Windows.Forms.Label lblManageAccounts2;
        private System.Windows.Forms.Button btnManageAccount1;
        private System.Windows.Forms.Button btnManageAccount2;
        private System.Windows.Forms.Button btnManageAccounts3;
    }
}