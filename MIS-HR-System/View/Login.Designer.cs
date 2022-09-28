namespace MIS_HR_System.View
{
    partial class Login
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
            this.pnlLoginHeader = new System.Windows.Forms.Panel();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.btnLoginLogin = new MIS_HR_System.Models.flatButton();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.txtLoginIDNum = new System.Windows.Forms.TextBox();
            this.lblLoginIDNum = new System.Windows.Forms.Label();
            this.btnLoginSignUp = new MIS_HR_System.Models.flatButtonGray();
            this.pnlLoginHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginHeader
            // 
            this.pnlLoginHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.pnlLoginHeader.Controls.Add(this.lblLoginTitle);
            this.pnlLoginHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoginHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginHeader.Name = "pnlLoginHeader";
            this.pnlLoginHeader.Size = new System.Drawing.Size(266, 68);
            this.pnlLoginHeader.TabIndex = 0;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Bebas Neue Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.Khaki;
            this.lblLoginTitle.Location = new System.Drawing.Point(12, 18);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(73, 38);
            this.lblLoginTitle.TabIndex = 3;
            this.lblLoginTitle.Text = "LOGIN";
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.btnLoginLogin.Font = new System.Drawing.Font("Antonio", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLogin.ForeColor = System.Drawing.Color.Khaki;
            this.btnLoginLogin.Location = new System.Drawing.Point(12, 211);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.OnMouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(129)))));
            this.btnLoginLogin.Size = new System.Drawing.Size(113, 39);
            this.btnLoginLogin.TabIndex = 29;
            this.btnLoginLogin.Text = "LOGIN";
            this.btnLoginLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginLogin.UseVisualStyleBackColor = false;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLoginPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPass.Font = new System.Drawing.Font("Pangram Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPass.Location = new System.Drawing.Point(12, 170);
            this.txtLoginPass.Multiline = true;
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.PasswordChar = '*';
            this.txtLoginPass.Size = new System.Drawing.Size(241, 29);
            this.txtLoginPass.TabIndex = 34;
            this.txtLoginPass.Text = "test";
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Font = new System.Drawing.Font("Bebas Neue Regular", 15.75F);
            this.lblLoginPass.Location = new System.Drawing.Point(7, 144);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(81, 25);
            this.lblLoginPass.TabIndex = 33;
            this.lblLoginPass.Text = "PASSWORD";
            // 
            // txtLoginIDNum
            // 
            this.txtLoginIDNum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLoginIDNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginIDNum.Font = new System.Drawing.Font("Pangram Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginIDNum.Location = new System.Drawing.Point(12, 111);
            this.txtLoginIDNum.Multiline = true;
            this.txtLoginIDNum.Name = "txtLoginIDNum";
            this.txtLoginIDNum.Size = new System.Drawing.Size(241, 29);
            this.txtLoginIDNum.TabIndex = 32;
            this.txtLoginIDNum.Text = "2014123456";
            // 
            // lblLoginIDNum
            // 
            this.lblLoginIDNum.AutoSize = true;
            this.lblLoginIDNum.Font = new System.Drawing.Font("Bebas Neue Regular", 15.75F);
            this.lblLoginIDNum.Location = new System.Drawing.Point(7, 85);
            this.lblLoginIDNum.Name = "lblLoginIDNum";
            this.lblLoginIDNum.Size = new System.Drawing.Size(78, 25);
            this.lblLoginIDNum.TabIndex = 31;
            this.lblLoginIDNum.Text = "ID NUMBER";
            // 
            // btnLoginSignUp
            // 
            this.btnLoginSignUp.BackColor = System.Drawing.Color.DimGray;
            this.btnLoginSignUp.Font = new System.Drawing.Font("Antonio", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLoginSignUp.ForeColor = System.Drawing.Color.Khaki;
            this.btnLoginSignUp.Location = new System.Drawing.Point(140, 211);
            this.btnLoginSignUp.Name = "btnLoginSignUp";
            this.btnLoginSignUp.OnMouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(129)))));
            this.btnLoginSignUp.Size = new System.Drawing.Size(113, 39);
            this.btnLoginSignUp.TabIndex = 35;
            this.btnLoginSignUp.Text = "SIGN UP";
            this.btnLoginSignUp.UseVisualStyleBackColor = false;
            this.btnLoginSignUp.Click += new System.EventHandler(this.btnLoginSignUp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 265);
            this.Controls.Add(this.btnLoginSignUp);
            this.Controls.Add(this.txtLoginPass);
            this.Controls.Add(this.lblLoginPass);
            this.Controls.Add(this.txtLoginIDNum);
            this.Controls.Add(this.lblLoginIDNum);
            this.Controls.Add(this.btnLoginLogin);
            this.Controls.Add(this.pnlLoginHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.pnlLoginHeader.ResumeLayout(false);
            this.pnlLoginHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginHeader;
        private System.Windows.Forms.Label lblLoginTitle;
        private Models.flatButton btnLoginLogin;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.TextBox txtLoginIDNum;
        private System.Windows.Forms.Label lblLoginIDNum;
        private Models.flatButtonGray btnLoginSignUp;
    }
}