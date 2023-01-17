
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
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(80, 141);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxLogin1
            // 
            this.tbxLogin1.Location = new System.Drawing.Point(70, 52);
            this.tbxLogin1.Name = "tbxLogin1";
            this.tbxLogin1.Size = new System.Drawing.Size(100, 20);
            this.tbxLogin1.TabIndex = 1;
            // 
            // tbxlogin2
            // 
            this.tbxlogin2.Location = new System.Drawing.Point(70, 87);
            this.tbxlogin2.Name = "tbxlogin2";
            this.tbxlogin2.PasswordChar = '*';
            this.tbxlogin2.Size = new System.Drawing.Size(100, 20);
            this.tbxlogin2.TabIndex = 2;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 176);
            this.Controls.Add(this.tbxlogin2);
            this.Controls.Add(this.tbxLogin1);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxLogin1;
        private System.Windows.Forms.TextBox tbxlogin2;
    }
}