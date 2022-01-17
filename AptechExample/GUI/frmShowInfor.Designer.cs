
namespace AptechExample.GUI
{
    partial class frmShowInfor
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
            this.lblShowInfor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShowInfor
            // 
            this.lblShowInfor.AutoSize = true;
            this.lblShowInfor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblShowInfor.ForeColor = System.Drawing.Color.Red;
            this.lblShowInfor.Location = new System.Drawing.Point(97, 53);
            this.lblShowInfor.Name = "lblShowInfor";
            this.lblShowInfor.Size = new System.Drawing.Size(64, 25);
            this.lblShowInfor.TabIndex = 0;
            this.lblShowInfor.Text = "label1";
            // 
            // frmShowInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 147);
            this.Controls.Add(this.lblShowInfor);
            this.Name = "frmShowInfor";
            this.Text = "frmShowInfor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowInfor;
    }
}