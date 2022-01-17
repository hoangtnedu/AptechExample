
namespace WFStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentBussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentOOPInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.studentBussToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseAccessToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "&System";
            // 
            // databaseAccessToolStripMenuItem
            // 
            this.databaseAccessToolStripMenuItem.Name = "databaseAccessToolStripMenuItem";
            this.databaseAccessToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.databaseAccessToolStripMenuItem.Text = "Database Access";
            this.databaseAccessToolStripMenuItem.Click += new System.EventHandler(this.databaseAccessToolStripMenuItem_Click);
            // 
            // studentBussToolStripMenuItem
            // 
            this.studentBussToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInformationToolStripMenuItem,
            this.studentOOPInformationToolStripMenuItem});
            this.studentBussToolStripMenuItem.Name = "studentBussToolStripMenuItem";
            this.studentBussToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.studentBussToolStripMenuItem.Text = "Student Buss";
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            this.studentInformationToolStripMenuItem.Click += new System.EventHandler(this.studentInformationToolStripMenuItem_Click);
            // 
            // studentOOPInformationToolStripMenuItem
            // 
            this.studentOOPInformationToolStripMenuItem.Name = "studentOOPInformationToolStripMenuItem";
            this.studentOOPInformationToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.studentOOPInformationToolStripMenuItem.Text = "Student OOP Information";
            this.studentOOPInformationToolStripMenuItem.Click += new System.EventHandler(this.studentOOPInformationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "STUDENT MANAGEMENT SYSTEM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentBussToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentOOPInformationToolStripMenuItem;
    }
}

