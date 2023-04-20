
namespace SD_RE_James_Clifford
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxLogin1 = new System.Windows.Forms.TextBox();
            this.tbxlogin2 = new System.Windows.Forms.TextBox();
            this.lblLogin1 = new System.Windows.Forms.Label();
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(111, 138);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxLogin1
            // 
            this.tbxLogin1.Location = new System.Drawing.Point(101, 49);
            this.tbxLogin1.Name = "tbxLogin1";
            this.tbxLogin1.Size = new System.Drawing.Size(141, 20);
            this.tbxLogin1.TabIndex = 1;
            // 
            // tbxlogin2
            // 
            this.tbxlogin2.Location = new System.Drawing.Point(101, 84);
            this.tbxlogin2.Name = "tbxlogin2";
            this.tbxlogin2.PasswordChar = '*';
            this.tbxlogin2.Size = new System.Drawing.Size(141, 20);
            this.tbxlogin2.TabIndex = 2;
            // 
            // lblLogin1
            // 
            this.lblLogin1.AutoSize = true;
            this.lblLogin1.Location = new System.Drawing.Point(42, 49);
            this.lblLogin1.Name = "lblLogin1";
            this.lblLogin1.Size = new System.Drawing.Size(53, 13);
            this.lblLogin1.TabIndex = 3;
            this.lblLogin1.Text = "username";
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Location = new System.Drawing.Point(43, 84);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(52, 13);
            this.lblLogin2.TabIndex = 4;
            this.lblLogin2.Text = "password";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 206);
            this.Controls.Add(this.lblLogin2);
            this.Controls.Add(this.lblLogin1);
            this.Controls.Add(this.tbxlogin2);
            this.Controls.Add(this.tbxLogin1);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxLogin1;
        private System.Windows.Forms.TextBox tbxlogin2;
        private System.Windows.Forms.Label lblLogin1;
        private System.Windows.Forms.Label lblLogin2;
    }
}