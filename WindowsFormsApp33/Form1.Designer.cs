namespace WindowsFormsApp33
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Calculate");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("UTULITES", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ROOM1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ROOM2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ROOM", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("STUDENT_NAME");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("STUDENT_ID");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("STUDENT", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            this.MainPanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(152, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(719, 515);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node11";
            treeNode1.Text = "Calculate";
            treeNode2.Name = "Node10";
            treeNode2.Text = "UTULITES";
            treeNode3.Name = "Node16";
            treeNode3.Text = "ROOM1";
            treeNode4.Name = "Node17";
            treeNode4.Text = "ROOM2";
            treeNode5.Name = "Node14";
            treeNode5.Text = "ROOM";
            treeNode6.Name = "Node18";
            treeNode6.Text = "STUDENT_NAME";
            treeNode7.Name = "Node19";
            treeNode7.Text = "STUDENT_ID";
            treeNode8.Name = "Node15";
            treeNode8.Text = "STUDENT";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(134, 515);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 539);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TreeView treeView1;
    }
}

