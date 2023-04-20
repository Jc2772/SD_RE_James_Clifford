
namespace SD_RE_James_Clifford
{
    partial class frmManageLivestock
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
            this.cbxManageLivestock1 = new System.Windows.Forms.ComboBox();
            this.lblManageLivestock1 = new System.Windows.Forms.Label();
            this.lblManageLivestock2 = new System.Windows.Forms.Label();
            this.ipdManageLivestock1 = new System.Windows.Forms.TextBox();
            this.lblManageLivestock3 = new System.Windows.Forms.Label();
            this.btnManageLivestock2 = new System.Windows.Forms.Button();
            this.btnManageLivestock1 = new System.Windows.Forms.Button();
            this.btnManagelivestock3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxManageLivestock1
            // 
            this.cbxManageLivestock1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxManageLivestock1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxManageLivestock1.FormattingEnabled = true;
            this.cbxManageLivestock1.Location = new System.Drawing.Point(67, 19);
            this.cbxManageLivestock1.Name = "cbxManageLivestock1";
            this.cbxManageLivestock1.Size = new System.Drawing.Size(336, 21);
            this.cbxManageLivestock1.TabIndex = 0;
            this.cbxManageLivestock1.SelectedIndexChanged += new System.EventHandler(this.cbxManageLivestock1_SelectedIndexChanged);
            // 
            // lblManageLivestock1
            // 
            this.lblManageLivestock1.AutoSize = true;
            this.lblManageLivestock1.Location = new System.Drawing.Point(12, 22);
            this.lblManageLivestock1.Name = "lblManageLivestock1";
            this.lblManageLivestock1.Size = new System.Drawing.Size(49, 13);
            this.lblManageLivestock1.TabIndex = 1;
            this.lblManageLivestock1.Text = "livestock";
            // 
            // lblManageLivestock2
            // 
            this.lblManageLivestock2.AutoSize = true;
            this.lblManageLivestock2.Location = new System.Drawing.Point(12, 84);
            this.lblManageLivestock2.Name = "lblManageLivestock2";
            this.lblManageLivestock2.Size = new System.Drawing.Size(49, 13);
            this.lblManageLivestock2.TabIndex = 2;
            this.lblManageLivestock2.Text = "livestock";
            // 
            // ipdManageLivestock1
            // 
            this.ipdManageLivestock1.Location = new System.Drawing.Point(381, 293);
            this.ipdManageLivestock1.MaxLength = 8;
            this.ipdManageLivestock1.Name = "ipdManageLivestock1";
            this.ipdManageLivestock1.Size = new System.Drawing.Size(100, 20);
            this.ipdManageLivestock1.TabIndex = 5;
            // 
            // lblManageLivestock3
            // 
            this.lblManageLivestock3.AutoSize = true;
            this.lblManageLivestock3.Location = new System.Drawing.Point(320, 296);
            this.lblManageLivestock3.Name = "lblManageLivestock3";
            this.lblManageLivestock3.Size = new System.Drawing.Size(55, 13);
            this.lblManageLivestock3.TabIndex = 8;
            this.lblManageLivestock3.Text = "Sale Price";
            // 
            // btnManageLivestock2
            // 
            this.btnManageLivestock2.Location = new System.Drawing.Point(381, 333);
            this.btnManageLivestock2.Name = "btnManageLivestock2";
            this.btnManageLivestock2.Size = new System.Drawing.Size(100, 23);
            this.btnManageLivestock2.TabIndex = 9;
            this.btnManageLivestock2.Text = "Register Sale";
            this.btnManageLivestock2.UseVisualStyleBackColor = true;
            this.btnManageLivestock2.Click += new System.EventHandler(this.btnManageLivestock2_Click);
            // 
            // btnManageLivestock1
            // 
            this.btnManageLivestock1.Location = new System.Drawing.Point(423, 12);
            this.btnManageLivestock1.Name = "btnManageLivestock1";
            this.btnManageLivestock1.Size = new System.Drawing.Size(75, 23);
            this.btnManageLivestock1.TabIndex = 10;
            this.btnManageLivestock1.Text = "Return";
            this.btnManageLivestock1.UseVisualStyleBackColor = true;
            this.btnManageLivestock1.Click += new System.EventHandler(this.btnManageLivestock1_Click);
            // 
            // btnManagelivestock3
            // 
            this.btnManagelivestock3.Location = new System.Drawing.Point(15, 333);
            this.btnManagelivestock3.Name = "btnManagelivestock3";
            this.btnManagelivestock3.Size = new System.Drawing.Size(114, 23);
            this.btnManagelivestock3.TabIndex = 11;
            this.btnManagelivestock3.Text = "Remove Booking";
            this.btnManagelivestock3.UseVisualStyleBackColor = true;
            this.btnManagelivestock3.Click += new System.EventHandler(this.btnManagelivestock3_Click);
            // 
            // frmManageLivestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 368);
            this.ControlBox = false;
            this.Controls.Add(this.btnManagelivestock3);
            this.Controls.Add(this.btnManageLivestock1);
            this.Controls.Add(this.btnManageLivestock2);
            this.Controls.Add(this.lblManageLivestock3);
            this.Controls.Add(this.ipdManageLivestock1);
            this.Controls.Add(this.lblManageLivestock2);
            this.Controls.Add(this.lblManageLivestock1);
            this.Controls.Add(this.cbxManageLivestock1);
            this.Name = "frmManageLivestock";
            this.Text = "Manage Livestock";
            this.Load += new System.EventHandler(this.frmManageLivestock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxManageLivestock1;
        private System.Windows.Forms.Label lblManageLivestock1;
        private System.Windows.Forms.Label lblManageLivestock2;
        private System.Windows.Forms.TextBox ipdManageLivestock1;
        private System.Windows.Forms.Label lblManageLivestock3;
        private System.Windows.Forms.Button btnManageLivestock2;
        private System.Windows.Forms.Button btnManageLivestock1;
        private System.Windows.Forms.Button btnManagelivestock3;
    }
}