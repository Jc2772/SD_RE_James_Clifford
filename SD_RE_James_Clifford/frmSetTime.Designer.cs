
namespace SD_RE_James_Clifford
{
    partial class frmSetTime
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
            this.dpkSetTime = new System.Windows.Forms.DateTimePicker();
            this.lblSetTime1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnSetTime1 = new System.Windows.Forms.Button();
            this.btnSetTime2 = new System.Windows.Forms.Button();
            this.btnSetTime3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dpkSetTime
            // 
            this.dpkSetTime.Location = new System.Drawing.Point(55, 32);
            this.dpkSetTime.Margin = new System.Windows.Forms.Padding(2);
            this.dpkSetTime.Name = "dpkSetTime";
            this.dpkSetTime.Size = new System.Drawing.Size(192, 20);
            this.dpkSetTime.TabIndex = 0;
            // 
            // lblSetTime1
            // 
            this.lblSetTime1.AutoSize = true;
            this.lblSetTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTime1.Location = new System.Drawing.Point(9, 32);
            this.lblSetTime1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetTime1.Name = "lblSetTime1";
            this.lblSetTime1.Size = new System.Drawing.Size(42, 17);
            this.lblSetTime1.TabIndex = 1;
            this.lblSetTime1.Text = "Date:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnSetTime1
            // 
            this.btnSetTime1.Location = new System.Drawing.Point(12, 77);
            this.btnSetTime1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetTime1.Name = "btnSetTime1";
            this.btnSetTime1.Size = new System.Drawing.Size(52, 26);
            this.btnSetTime1.TabIndex = 6;
            this.btnSetTime1.Text = "Add";
            this.btnSetTime1.UseVisualStyleBackColor = true;
            this.btnSetTime1.Click += new System.EventHandler(this.btnSetTime1_Click);
            // 
            // btnSetTime2
            // 
            this.btnSetTime2.Location = new System.Drawing.Point(218, 77);
            this.btnSetTime2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetTime2.Name = "btnSetTime2";
            this.btnSetTime2.Size = new System.Drawing.Size(64, 26);
            this.btnSetTime2.TabIndex = 7;
            this.btnSetTime2.Text = "Return";
            this.btnSetTime2.UseVisualStyleBackColor = true;
            // 
            // btnSetTime3
            // 
            this.btnSetTime3.Location = new System.Drawing.Point(110, 77);
            this.btnSetTime3.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetTime3.Name = "btnSetTime3";
            this.btnSetTime3.Size = new System.Drawing.Size(62, 26);
            this.btnSetTime3.TabIndex = 8;
            this.btnSetTime3.Text = "Cancel";
            this.btnSetTime3.UseVisualStyleBackColor = true;
            // 
            // frmSetTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 132);
            this.Controls.Add(this.btnSetTime3);
            this.Controls.Add(this.btnSetTime2);
            this.Controls.Add(this.btnSetTime1);
            this.Controls.Add(this.lblSetTime1);
            this.Controls.Add(this.dpkSetTime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSetTime";
            this.Text = "Schedule Auction";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpkSetTime;
        private System.Windows.Forms.Label lblSetTime1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnSetTime1;
        private System.Windows.Forms.Button btnSetTime2;
        private System.Windows.Forms.Button btnSetTime3;
    }
}