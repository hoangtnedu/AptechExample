
namespace AptechExample
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePaswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excerciceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exp1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.excerciceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.changePaswordToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "&System";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "&Login";
            // 
            // changePaswordToolStripMenuItem
            // 
            this.changePaswordToolStripMenuItem.Name = "changePaswordToolStripMenuItem";
            this.changePaswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePaswordToolStripMenuItem.Text = "&Change Pasword";
            // 
            // excerciceToolStripMenuItem
            // 
            this.excerciceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exp1ToolStripMenuItem});
            this.excerciceToolStripMenuItem.Name = "excerciceToolStripMenuItem";
            this.excerciceToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.excerciceToolStripMenuItem.Text = "Excercice";
            // 
            // exp1ToolStripMenuItem
            // 
            this.exp1ToolStripMenuItem.Name = "exp1ToolStripMenuItem";
            this.exp1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exp1ToolStripMenuItem.Text = "Exp1";
            this.exp1ToolStripMenuItem.Click += new System.EventHandler(this.exp1ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 396);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Application Example";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePaswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excerciceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exp1ToolStripMenuItem;
    }
}