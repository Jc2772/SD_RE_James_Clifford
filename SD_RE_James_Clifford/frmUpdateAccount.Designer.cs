
namespace SD_RE_James_Clifford
{
    partial class frmUpdateAccount
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
            this.ipdUpdateEmail = new System.Windows.Forms.TextBox();
            this.ipdUpdatePhone = new System.Windows.Forms.TextBox();
            this.ipdUpdateAddress1 = new System.Windows.Forms.TextBox();
            this.ipdUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.lblUpdatePhone = new System.Windows.Forms.Label();
            this.lblUpdateAddress1 = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipdUpdateEmail
            // 
            this.ipdUpdateEmail.Location = new System.Drawing.Point(105, 163);
            this.ipdUpdateEmail.MaxLength = 30;
            this.ipdUpdateEmail.Name = "ipdUpdateEmail";
            this.ipdUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.ipdUpdateEmail.TabIndex = 19;
            // 
            // ipdUpdatePhone
            // 
            this.ipdUpdatePhone.Location = new System.Drawing.Point(122, 122);
            this.ipdUpdatePhone.MaxLength = 12;
            this.ipdUpdatePhone.Name = "ipdUpdatePhone";
            this.ipdUpdatePhone.Size = new System.Drawing.Size(127, 20);
            this.ipdUpdatePhone.TabIndex = 18;
            // 
            // ipdUpdateAddress1
            // 
            this.ipdUpdateAddress1.Location = new System.Drawing.Point(105, 83);
            this.ipdUpdateAddress1.MaxLength = 30;
            this.ipdUpdateAddress1.Name = "ipdUpdateAddress1";
            this.ipdUpdateAddress1.Size = new System.Drawing.Size(100, 20);
            this.ipdUpdateAddress1.TabIndex = 17;
            // 
            // ipdUpdateName
            // 
            this.ipdUpdateName.Location = new System.Drawing.Point(105, 43);
            this.ipdUpdateName.MaxLength = 30;
            this.ipdUpdateName.Name = "ipdUpdateName";
            this.ipdUpdateName.Size = new System.Drawing.Size(100, 20);
            this.ipdUpdateName.TabIndex = 16;
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(38, 166);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(32, 13);
            this.lblUpdateEmail.TabIndex = 15;
            this.lblUpdateEmail.Text = "Email";
            // 
            // lblUpdatePhone
            // 
            this.lblUpdatePhone.AutoSize = true;
            this.lblUpdatePhone.Location = new System.Drawing.Point(38, 122);
            this.lblUpdatePhone.Name = "lblUpdatePhone";
            this.lblUpdatePhone.Size = new System.Drawing.Size(78, 13);
            this.lblUpdatePhone.TabIndex = 14;
            this.lblUpdatePhone.Text = "Phone Number";
            // 
            // lblUpdateAddress1
            // 
            this.lblUpdateAddress1.AutoSize = true;
            this.lblUpdateAddress1.Location = new System.Drawing.Point(38, 83);
            this.lblUpdateAddress1.Name = "lblUpdateAddress1";
            this.lblUpdateAddress1.Size = new System.Drawing.Size(45, 13);
            this.lblUpdateAddress1.TabIndex = 13;
            this.lblUpdateAddress1.Text = "Address";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(38, 46);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateName.TabIndex = 12;
            this.lblUpdateName.Text = "Name";
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(105, 204);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAccount.TabIndex = 20;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // frmUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 239);
            this.ControlBox = false;
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.ipdUpdateEmail);
            this.Controls.Add(this.ipdUpdatePhone);
            this.Controls.Add(this.ipdUpdateAddress1);
            this.Controls.Add(this.ipdUpdateName);
            this.Controls.Add(this.lblUpdateEmail);
            this.Controls.Add(this.lblUpdatePhone);
            this.Controls.Add(this.lblUpdateAddress1);
            this.Controls.Add(this.lblUpdateName);
            this.Name = "frmUpdateAccount";
            this.Text = "Update account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipdUpdateEmail;
        private System.Windows.Forms.TextBox ipdUpdatePhone;
        private System.Windows.Forms.TextBox ipdUpdateAddress1;
        private System.Windows.Forms.TextBox ipdUpdateName;
        private System.Windows.Forms.Label lblUpdateEmail;
        private System.Windows.Forms.Label lblUpdatePhone;
        private System.Windows.Forms.Label lblUpdateAddress1;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.Button btnUpdateAccount;
    }
}