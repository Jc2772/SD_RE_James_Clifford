﻿
namespace SD_RE_James_Clifford
{
    partial class frmLivestockHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivestockHome));
            this.imgLivestockHome = new System.Windows.Forms.PictureBox();
            this.btnLivestockHome7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageOwnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerOwnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatederegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAuctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerLivestockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryLivestockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleAuctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewYearlyAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLifestockSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgLivestockHome)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLivestockHome
            // 
            this.imgLivestockHome.Image = ((System.Drawing.Image)(resources.GetObject("imgLivestockHome.Image")));
            this.imgLivestockHome.Location = new System.Drawing.Point(172, 123);
            this.imgLivestockHome.Name = "imgLivestockHome";
            this.imgLivestockHome.Size = new System.Drawing.Size(447, 273);
            this.imgLivestockHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLivestockHome.TabIndex = 4;
            this.imgLivestockHome.TabStop = false;
            // 
            // btnLivestockHome7
            // 
            this.btnLivestockHome7.Location = new System.Drawing.Point(801, 0);
            this.btnLivestockHome7.Name = "btnLivestockHome7";
            this.btnLivestockHome7.Size = new System.Drawing.Size(35, 24);
            this.btnLivestockHome7.TabIndex = 6;
            this.btnLivestockHome7.Text = "Exit";
            this.btnLivestockHome7.UseVisualStyleBackColor = true;
            this.btnLivestockHome7.Click += new System.EventHandler(this.btnLivestockHome7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageOwnersToolStripMenuItem,
            this.manageAuctionsToolStripMenuItem,
            this.dataAnalysisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageOwnersToolStripMenuItem
            // 
            this.manageOwnersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerOwnersToolStripMenuItem,
            this.updatederegisterToolStripMenuItem});
            this.manageOwnersToolStripMenuItem.Name = "manageOwnersToolStripMenuItem";
            this.manageOwnersToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.manageOwnersToolStripMenuItem.Text = "manage owners";
            // 
            // registerOwnersToolStripMenuItem
            // 
            this.registerOwnersToolStripMenuItem.Name = "registerOwnersToolStripMenuItem";
            this.registerOwnersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerOwnersToolStripMenuItem.Text = "register owners";
            this.registerOwnersToolStripMenuItem.Click += new System.EventHandler(this.registerOwnersToolStripMenuItem_Click);
            // 
            // updatederegisterToolStripMenuItem
            // 
            this.updatederegisterToolStripMenuItem.Name = "updatederegisterToolStripMenuItem";
            this.updatederegisterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updatederegisterToolStripMenuItem.Text = "update/deregister";
            this.updatederegisterToolStripMenuItem.Click += new System.EventHandler(this.updatederegisterToolStripMenuItem_Click);
            // 
            // manageAuctionsToolStripMenuItem
            // 
            this.manageAuctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerLivestockToolStripMenuItem,
            this.registerSaleToolStripMenuItem,
            this.queryLivestockToolStripMenuItem,
            this.scheduleAuctionToolStripMenuItem});
            this.manageAuctionsToolStripMenuItem.Name = "manageAuctionsToolStripMenuItem";
            this.manageAuctionsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.manageAuctionsToolStripMenuItem.Text = "ManageAuctions";
            // 
            // registerLivestockToolStripMenuItem
            // 
            this.registerLivestockToolStripMenuItem.Name = "registerLivestockToolStripMenuItem";
            this.registerLivestockToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.registerLivestockToolStripMenuItem.Text = "register livestock";
            this.registerLivestockToolStripMenuItem.Click += new System.EventHandler(this.registerLivestockToolStripMenuItem_Click);
            // 
            // registerSaleToolStripMenuItem
            // 
            this.registerSaleToolStripMenuItem.Name = "registerSaleToolStripMenuItem";
            this.registerSaleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.registerSaleToolStripMenuItem.Text = "register sale";
            this.registerSaleToolStripMenuItem.Click += new System.EventHandler(this.registerSaleToolStripMenuItem_Click);
            // 
            // queryLivestockToolStripMenuItem
            // 
            this.queryLivestockToolStripMenuItem.Name = "queryLivestockToolStripMenuItem";
            this.queryLivestockToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.queryLivestockToolStripMenuItem.Text = "query livestock";
            this.queryLivestockToolStripMenuItem.Click += new System.EventHandler(this.queryLivestockToolStripMenuItem_Click);
            // 
            // scheduleAuctionToolStripMenuItem
            // 
            this.scheduleAuctionToolStripMenuItem.Name = "scheduleAuctionToolStripMenuItem";
            this.scheduleAuctionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.scheduleAuctionToolStripMenuItem.Text = "Schedule auction";
            this.scheduleAuctionToolStripMenuItem.Click += new System.EventHandler(this.scheduleAuctionToolStripMenuItem_Click);
            // 
            // dataAnalysisToolStripMenuItem
            // 
            this.dataAnalysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewYearlyAnalysisToolStripMenuItem,
            this.viewLifestockSalesToolStripMenuItem});
            this.dataAnalysisToolStripMenuItem.Name = "dataAnalysisToolStripMenuItem";
            this.dataAnalysisToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.dataAnalysisToolStripMenuItem.Text = "data analysis";
            // 
            // viewYearlyAnalysisToolStripMenuItem
            // 
            this.viewYearlyAnalysisToolStripMenuItem.Name = "viewYearlyAnalysisToolStripMenuItem";
            this.viewYearlyAnalysisToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewYearlyAnalysisToolStripMenuItem.Text = "view yearly analysis";
            // 
            // viewLifestockSalesToolStripMenuItem
            // 
            this.viewLifestockSalesToolStripMenuItem.Name = "viewLifestockSalesToolStripMenuItem";
            this.viewLifestockSalesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewLifestockSalesToolStripMenuItem.Text = "view lifestock sales";
            // 
            // frmLivestockHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 486);
            this.Controls.Add(this.btnLivestockHome7);
            this.Controls.Add(this.imgLivestockHome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLivestockHome";
            this.Text = "Livestock auction home";
            ((System.ComponentModel.ISupportInitialize)(this.imgLivestockHome)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLivestockHome;
        private System.Windows.Forms.Button btnLivestockHome7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageOwnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerOwnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatederegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAuctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerLivestockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryLivestockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleAuctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewYearlyAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLifestockSalesToolStripMenuItem;
    }
}

