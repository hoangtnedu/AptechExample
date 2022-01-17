
namespace AptechExample.GUI
{
    partial class frmEntry
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Quan ly van ban");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Laptrinhungdung");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("CNTT", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ketoan");
            this.imgListPersionalImage = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisplayImage = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAddListItem = new System.Windows.Forms.TextBox();
            this.btnAddListView = new System.Windows.Forms.Button();
            this.lvExample = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.treeExample = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgListPersionalImage
            // 
            this.imgListPersionalImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListPersionalImage.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListPersionalImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisplayImage);
            this.groupBox1.Controls.Add(this.pbImg);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHovaTen);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnDisplayImage
            // 
            this.btnDisplayImage.Location = new System.Drawing.Point(341, 167);
            this.btnDisplayImage.Name = "btnDisplayImage";
            this.btnDisplayImage.Size = new System.Drawing.Size(99, 23);
            this.btnDisplayImage.TabIndex = 1;
            this.btnDisplayImage.Text = "Display Image";
            this.btnDisplayImage.UseVisualStyleBackColor = true;
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(327, 22);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(131, 126);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 8;
            this.pbImg.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(126, 70);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và tên: ";
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(126, 27);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(155, 20);
            this.txtHovaTen.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAddListItem);
            this.groupBox2.Controls.Add(this.btnAddListView);
            this.groupBox2.Controls.Add(this.lvExample);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 211);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtAddListItem
            // 
            this.txtAddListItem.Location = new System.Drawing.Point(317, 57);
            this.txtAddListItem.Name = "txtAddListItem";
            this.txtAddListItem.Size = new System.Drawing.Size(100, 20);
            this.txtAddListItem.TabIndex = 0;
            // 
            // btnAddListView
            // 
            this.btnAddListView.Location = new System.Drawing.Point(308, 130);
            this.btnAddListView.Name = "btnAddListView";
            this.btnAddListView.Size = new System.Drawing.Size(75, 23);
            this.btnAddListView.TabIndex = 1;
            this.btnAddListView.Text = "AddList";
            this.btnAddListView.UseVisualStyleBackColor = true;
            // 
            // lvExample
            // 
            this.lvExample.HideSelection = false;
            this.lvExample.Location = new System.Drawing.Point(85, 57);
            this.lvExample.Name = "lvExample";
            this.lvExample.Size = new System.Drawing.Size(121, 97);
            this.lvExample.TabIndex = 2;
            this.lvExample.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddNode);
            this.groupBox3.Controls.Add(this.treeExample);
            this.groupBox3.Location = new System.Drawing.Point(527, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 411);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(105, 382);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(75, 23);
            this.btnAddNode.TabIndex = 0;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // treeExample
            // 
            this.treeExample.Location = new System.Drawing.Point(6, 27);
            this.treeExample.Name = "treeExample";
            treeNode1.Name = "n1";
            treeNode1.Text = "Quan ly van ban";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Laptrinhungdung";
            treeNode3.Name = "Node0";
            treeNode3.Text = "CNTT";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Ketoan";
            this.treeExample.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.treeExample.Size = new System.Drawing.Size(262, 345);
            this.treeExample.TabIndex = 1;
            // 
            // frmEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEntry";
            this.Text = "frmEntry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgListPersionalImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisplayImage;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAddListItem;
        private System.Windows.Forms.Button btnAddListView;
        private System.Windows.Forms.ListView lvExample;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView treeExample;
        private System.Windows.Forms.Button btnAddNode;
    }
}