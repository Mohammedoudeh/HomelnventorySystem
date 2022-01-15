namespace HomelnventorySystem
{
    partial class frmMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User Profile");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Shopping Items");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("My Inventory");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Statistics and Charts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Home Invetory System", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelApp = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.treeViewNavigaion = new System.Windows.Forms.TreeView();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1183, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(21, 38);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(226, 23);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Home lnventory System";
            // 
            // panelApp
            // 
            this.panelApp.BackColor = System.Drawing.Color.White;
            this.panelApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelApp.Controls.Add(this.btnExit);
            this.panelApp.Controls.Add(this.lblDisplayName);
            this.panelApp.Controls.Add(this.pictureBox1);
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApp.Location = new System.Drawing.Point(0, 100);
            this.panelApp.Margin = new System.Windows.Forms.Padding(2);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(1183, 100);
            this.panelApp.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1061, 60);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(104, 38);
            this.lblDisplayName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(167, 23);
            this.lblDisplayName.TabIndex = 1;
            this.lblDisplayName.Text = "Mohammed Hani";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigation.Controls.Add(this.treeViewNavigaion);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 200);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(272, 583);
            this.panelNavigation.TabIndex = 2;
            // 
            // treeViewNavigaion
            // 
            this.treeViewNavigaion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewNavigaion.Location = new System.Drawing.Point(0, 0);
            this.treeViewNavigaion.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewNavigaion.Name = "treeViewNavigaion";
            treeNode1.Name = "NodeUserprofile";
            treeNode1.Text = "User Profile";
            treeNode2.Name = "NodeShoppingItems";
            treeNode2.Text = "Shopping Items";
            treeNode3.Name = "NodeMyInventory";
            treeNode3.Text = "My Inventory";
            treeNode4.Name = "NodeStatisticsAndCharts";
            treeNode4.Text = "Statistics and Charts";
            treeNode5.Name = "NodeRoot";
            treeNode5.Text = "Home Invetory System";
            this.treeViewNavigaion.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeViewNavigaion.Size = new System.Drawing.Size(270, 581);
            this.treeViewNavigaion.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(272, 200);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(911, 583);
            this.panelContent.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1183, 783);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "HomelnventorySystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelApp.ResumeLayout(false);
            this.panelApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelApp;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TreeView treeViewNavigaion;
    }
}