﻿
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
            this.ipdRegisterSale1 = new System.Windows.Forms.TextBox();
            this.lblRegisterSale3 = new System.Windows.Forms.Label();
            this.btnRegisterSale2 = new System.Windows.Forms.Button();
            this.btnRegisterSale1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxRegisterSale1
            // 
            this.cbxRegisterSale1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRegisterSale1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRegisterSale1.FormattingEnabled = true;
            this.cbxRegisterSale1.Location = new System.Drawing.Point(67, 19);
            this.cbxRegisterSale1.Name = "cbxRegisterSale1";
            this.cbxRegisterSale1.Size = new System.Drawing.Size(336, 21);
            this.cbxRegisterSale1.TabIndex = 0;
            this.cbxRegisterSale1.SelectedIndexChanged += new System.EventHandler(this.cbxRegisterSale1_SelectedIndexChanged);
            // 
            // lblRegisterSale1
            // 
            this.lblRegisterSale1.AutoSize = true;
            this.lblRegisterSale1.Location = new System.Drawing.Point(12, 22);
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
            // ipdRegisterSale1
            // 
            this.ipdRegisterSale1.Location = new System.Drawing.Point(398, 84);
            this.ipdRegisterSale1.MaxLength = 8;
            this.ipdRegisterSale1.Name = "ipdRegisterSale1";
            this.ipdRegisterSale1.Size = new System.Drawing.Size(100, 20);
            this.ipdRegisterSale1.TabIndex = 5;
            // 
            // lblRegisterSale3
            // 
            this.lblRegisterSale3.AutoSize = true;
            this.lblRegisterSale3.Location = new System.Drawing.Point(337, 87);
            this.lblRegisterSale3.Name = "lblRegisterSale3";
            this.lblRegisterSale3.Size = new System.Drawing.Size(55, 13);
            this.lblRegisterSale3.TabIndex = 8;
            this.lblRegisterSale3.Text = "Sale Price";
            // 
            // btnRegisterSale2
            // 
            this.btnRegisterSale2.Location = new System.Drawing.Point(211, 330);
            this.btnRegisterSale2.Name = "btnRegisterSale2";
            this.btnRegisterSale2.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterSale2.TabIndex = 9;
            this.btnRegisterSale2.Text = "Submit";
            this.btnRegisterSale2.UseVisualStyleBackColor = true;
            this.btnRegisterSale2.Click += new System.EventHandler(this.btnRegisterSale2_Click);
            // 
            // btnRegisterSale1
            // 
            this.btnRegisterSale1.Location = new System.Drawing.Point(423, 12);
            this.btnRegisterSale1.Name = "btnRegisterSale1";
            this.btnRegisterSale1.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterSale1.TabIndex = 10;
            this.btnRegisterSale1.Text = "Return";
            this.btnRegisterSale1.UseVisualStyleBackColor = true;
            this.btnRegisterSale1.Click += new System.EventHandler(this.btnRegisterSale1_Click);
            // 
            // frmRegisterSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 368);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegisterSale1);
            this.Controls.Add(this.btnRegisterSale2);
            this.Controls.Add(this.lblRegisterSale3);
            this.Controls.Add(this.ipdRegisterSale1);
            this.Controls.Add(this.lblRegisterSale2);
            this.Controls.Add(this.lblRegisterSale1);
            this.Controls.Add(this.cbxRegisterSale1);
            this.Name = "frmRegisterSale";
            this.Text = "frmRegisterSale";
            this.Load += new System.EventHandler(this.frmRegisterSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxRegisterSale1;
        private System.Windows.Forms.Label lblRegisterSale1;
        private System.Windows.Forms.Label lblRegisterSale2;
        private System.Windows.Forms.TextBox ipdRegisterSale1;
        private System.Windows.Forms.Label lblRegisterSale3;
        private System.Windows.Forms.Button btnRegisterSale2;
        private System.Windows.Forms.Button btnRegisterSale1;
    }
}