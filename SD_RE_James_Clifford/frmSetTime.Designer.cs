
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
            this.lblSetTime2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblSetTime3 = new System.Windows.Forms.Label();
            this.ipdSetTime1 = new System.Windows.Forms.TextBox();
            this.ipdSetTime2 = new System.Windows.Forms.TextBox();
            this.btnSetTime1 = new System.Windows.Forms.Button();
            this.btnSetTime2 = new System.Windows.Forms.Button();
            this.btnSetTime3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dpkSetTime
            // 
            this.dpkSetTime.Location = new System.Drawing.Point(58, 30);
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
            // lblSetTime2
            // 
            this.lblSetTime2.AutoSize = true;
            this.lblSetTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTime2.Location = new System.Drawing.Point(9, 69);
            this.lblSetTime2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetTime2.Name = "lblSetTime2";
            this.lblSetTime2.Size = new System.Drawing.Size(77, 17);
            this.lblSetTime2.TabIndex = 2;
            this.lblSetTime2.Text = "Start Time:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblSetTime3
            // 
            this.lblSetTime3.AutoSize = true;
            this.lblSetTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTime3.Location = new System.Drawing.Point(7, 122);
            this.lblSetTime3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetTime3.Name = "lblSetTime3";
            this.lblSetTime3.Size = new System.Drawing.Size(79, 17);
            this.lblSetTime3.TabIndex = 3;
            this.lblSetTime3.Text = "Finish time:";
            // 
            // ipdSetTime1
            // 
            this.ipdSetTime1.Location = new System.Drawing.Point(82, 69);
            this.ipdSetTime1.Margin = new System.Windows.Forms.Padding(2);
            this.ipdSetTime1.MaxLength = 5;
            this.ipdSetTime1.Name = "ipdSetTime1";
            this.ipdSetTime1.Size = new System.Drawing.Size(33, 20);
            this.ipdSetTime1.TabIndex = 4;
            this.ipdSetTime1.Text = "00:00";
            // 
            // ipdSetTime2
            // 
            this.ipdSetTime2.Location = new System.Drawing.Point(90, 122);
            this.ipdSetTime2.Margin = new System.Windows.Forms.Padding(2);
            this.ipdSetTime2.MaxLength = 5;
            this.ipdSetTime2.Name = "ipdSetTime2";
            this.ipdSetTime2.Size = new System.Drawing.Size(33, 20);
            this.ipdSetTime2.TabIndex = 5;
            this.ipdSetTime2.Text = "24:00";
            // 
            // btnSetTime1
            // 
            this.btnSetTime1.Location = new System.Drawing.Point(12, 185);
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
            this.btnSetTime2.Location = new System.Drawing.Point(220, 185);
            this.btnSetTime2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetTime2.Name = "btnSetTime2";
            this.btnSetTime2.Size = new System.Drawing.Size(64, 26);
            this.btnSetTime2.TabIndex = 7;
            this.btnSetTime2.Text = "Return";
            this.btnSetTime2.UseVisualStyleBackColor = true;
            // 
            // btnSetTime3
            // 
            this.btnSetTime3.Location = new System.Drawing.Point(110, 185);
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
            this.ClientSize = new System.Drawing.Size(293, 242);
            this.Controls.Add(this.btnSetTime3);
            this.Controls.Add(this.btnSetTime2);
            this.Controls.Add(this.btnSetTime1);
            this.Controls.Add(this.ipdSetTime2);
            this.Controls.Add(this.ipdSetTime1);
            this.Controls.Add(this.lblSetTime3);
            this.Controls.Add(this.lblSetTime2);
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
        private System.Windows.Forms.Label lblSetTime2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox ipdSetTime2;
        private System.Windows.Forms.TextBox ipdSetTime1;
        private System.Windows.Forms.Label lblSetTime3;
        private System.Windows.Forms.Button btnSetTime1;
        private System.Windows.Forms.Button btnSetTime2;
        private System.Windows.Forms.Button btnSetTime3;
    }
}