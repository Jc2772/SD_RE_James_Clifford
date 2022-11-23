
namespace SD_RE_James_Clifford
{
    partial class frmNewAccount
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
            this.btnAccountAdd = new System.Windows.Forms.Button();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblAccountAddress1 = new System.Windows.Forms.Label();
            this.lblAccountPhone = new System.Windows.Forms.Label();
            this.lblAccountEmail = new System.Windows.Forms.Label();
            this.ipdAccountName = new System.Windows.Forms.TextBox();
            this.btnAccountReturn = new System.Windows.Forms.Button();
            this.ipdAccountAddress1 = new System.Windows.Forms.TextBox();
            this.ipdAccountPhone = new System.Windows.Forms.TextBox();
            this.ipdAccountEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.Location = new System.Drawing.Point(184, 366);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAccountAdd.TabIndex = 0;
            this.btnAccountAdd.Text = "Add";
            this.btnAccountAdd.UseVisualStyleBackColor = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(22, 41);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(35, 13);
            this.lblAccountName.TabIndex = 3;
            this.lblAccountName.Text = "Name";
            // 
            // lblAccountAddress1
            // 
            this.lblAccountAddress1.AutoSize = true;
            this.lblAccountAddress1.Location = new System.Drawing.Point(22, 78);
            this.lblAccountAddress1.Name = "lblAccountAddress1";
            this.lblAccountAddress1.Size = new System.Drawing.Size(45, 13);
            this.lblAccountAddress1.TabIndex = 4;
            this.lblAccountAddress1.Text = "Address";
            // 
            // lblAccountPhone
            // 
            this.lblAccountPhone.AutoSize = true;
            this.lblAccountPhone.Location = new System.Drawing.Point(22, 117);
            this.lblAccountPhone.Name = "lblAccountPhone";
            this.lblAccountPhone.Size = new System.Drawing.Size(78, 13);
            this.lblAccountPhone.TabIndex = 5;
            this.lblAccountPhone.Text = "Phone Number";
            // 
            // lblAccountEmail
            // 
            this.lblAccountEmail.AutoSize = true;
            this.lblAccountEmail.Location = new System.Drawing.Point(22, 161);
            this.lblAccountEmail.Name = "lblAccountEmail";
            this.lblAccountEmail.Size = new System.Drawing.Size(32, 13);
            this.lblAccountEmail.TabIndex = 6;
            this.lblAccountEmail.Text = "Email";
            // 
            // ipdAccountName
            // 
            this.ipdAccountName.Location = new System.Drawing.Point(89, 38);
            this.ipdAccountName.MaxLength = 30;
            this.ipdAccountName.Name = "ipdAccountName";
            this.ipdAccountName.Size = new System.Drawing.Size(100, 20);
            this.ipdAccountName.TabIndex = 7;
            // 
            // btnAccountReturn
            // 
            this.btnAccountReturn.Location = new System.Drawing.Point(364, 12);
            this.btnAccountReturn.Name = "btnAccountReturn";
            this.btnAccountReturn.Size = new System.Drawing.Size(75, 23);
            this.btnAccountReturn.TabIndex = 8;
            this.btnAccountReturn.Text = "Return";
            this.btnAccountReturn.UseVisualStyleBackColor = true;
            this.btnAccountReturn.Click += new System.EventHandler(this.btnAccountReturn_Click);
            // 
            // ipdAccountAddress1
            // 
            this.ipdAccountAddress1.Location = new System.Drawing.Point(89, 78);
            this.ipdAccountAddress1.MaxLength = 30;
            this.ipdAccountAddress1.Name = "ipdAccountAddress1";
            this.ipdAccountAddress1.Size = new System.Drawing.Size(100, 20);
            this.ipdAccountAddress1.TabIndex = 9;
            // 
            // ipdAccountPhone
            // 
            this.ipdAccountPhone.Location = new System.Drawing.Point(106, 117);
            this.ipdAccountPhone.MaxLength = 12;
            this.ipdAccountPhone.Name = "ipdAccountPhone";
            this.ipdAccountPhone.Size = new System.Drawing.Size(127, 20);
            this.ipdAccountPhone.TabIndex = 10;
            // 
            // ipdAccountEmail
            // 
            this.ipdAccountEmail.Location = new System.Drawing.Point(89, 158);
            this.ipdAccountEmail.MaxLength = 30;
            this.ipdAccountEmail.Name = "ipdAccountEmail";
            this.ipdAccountEmail.Size = new System.Drawing.Size(100, 20);
            this.ipdAccountEmail.TabIndex = 11;
            // 
            // frmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.ipdAccountEmail);
            this.Controls.Add(this.ipdAccountPhone);
            this.Controls.Add(this.ipdAccountAddress1);
            this.Controls.Add(this.btnAccountReturn);
            this.Controls.Add(this.ipdAccountName);
            this.Controls.Add(this.lblAccountEmail);
            this.Controls.Add(this.lblAccountPhone);
            this.Controls.Add(this.lblAccountAddress1);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.btnAccountAdd);
            this.Name = "frmNewAccount";
            this.Text = "frmNewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccountAdd;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblAccountAddress1;
        private System.Windows.Forms.Label lblAccountPhone;
        private System.Windows.Forms.Label lblAccountEmail;
        private System.Windows.Forms.TextBox ipdAccountName;
        private System.Windows.Forms.Button btnAccountReturn;
        private System.Windows.Forms.TextBox ipdAccountAddress1;
        private System.Windows.Forms.TextBox ipdAccountPhone;
        private System.Windows.Forms.TextBox ipdAccountEmail;
    }
}