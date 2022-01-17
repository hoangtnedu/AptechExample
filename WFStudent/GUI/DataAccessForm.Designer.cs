
namespace WFStudent.GUI
{
    partial class DataAccessForm
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
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAccesstoDatabase = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAccessbyLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(161, 66);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(136, 20);
            this.txtServerName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(161, 105);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(136, 20);
            this.txtDatabaseName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database Name";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(161, 147);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(136, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(161, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(136, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(161, 224);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "label5";
            // 
            // btnAccesstoDatabase
            // 
            this.btnAccesstoDatabase.Location = new System.Drawing.Point(28, 258);
            this.btnAccesstoDatabase.Name = "btnAccesstoDatabase";
            this.btnAccesstoDatabase.Size = new System.Drawing.Size(146, 23);
            this.btnAccesstoDatabase.TabIndex = 10;
            this.btnAccesstoDatabase.Text = "Access Windows Conn";
            this.btnAccesstoDatabase.UseVisualStyleBackColor = true;
            this.btnAccesstoDatabase.Click += new System.EventHandler(this.btnAccesstoDatabase_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(69, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "CONNECTION TO DATABASE";
            // 
            // btnAccessbyLogin
            // 
            this.btnAccessbyLogin.Location = new System.Drawing.Point(197, 258);
            this.btnAccessbyLogin.Name = "btnAccessbyLogin";
            this.btnAccessbyLogin.Size = new System.Drawing.Size(123, 23);
            this.btnAccessbyLogin.TabIndex = 11;
            this.btnAccessbyLogin.Text = "Access by Login";
            this.btnAccessbyLogin.UseVisualStyleBackColor = true;
            this.btnAccessbyLogin.Click += new System.EventHandler(this.btnAccessbyLogin_Click);
            // 
            // DataAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 293);
            this.Controls.Add(this.btnAccessbyLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAccesstoDatabase);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerName);
            this.Name = "DataAccessForm";
            this.Text = "DataAccessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAccesstoDatabase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAccessbyLogin;
    }
}