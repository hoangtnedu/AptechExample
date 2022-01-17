
namespace Lab4.GUI
{
    partial class GiaiPTbac1
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
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoiGiai = new System.Windows.Forms.Label();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(165, 33);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 0;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(165, 69);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hệ số a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hệ số b";
            // 
            // lblLoiGiai
            // 
            this.lblLoiGiai.AutoSize = true;
            this.lblLoiGiai.Location = new System.Drawing.Point(106, 110);
            this.lblLoiGiai.Name = "lblLoiGiai";
            this.lblLoiGiai.Size = new System.Drawing.Size(35, 13);
            this.lblLoiGiai.TabIndex = 3;
            this.lblLoiGiai.Text = "label3";
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Location = new System.Drawing.Point(127, 160);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiPT.TabIndex = 4;
            this.btnGiaiPT.Text = "Giải PT";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.btnGiaiPT_Click);
            // 
            // GiaiPTbac1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 208);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.lblLoiGiai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Name = "GiaiPTbac1";
            this.Text = "Giải phương trình bậc nhất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoiGiai;
        private System.Windows.Forms.Button btnGiaiPT;
    }
}