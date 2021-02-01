
namespace WindowsProject
{
    partial class LoginForm
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
            this.lbl_Login = new System.Windows.Forms.Button();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.Location = new System.Drawing.Point(400, 197);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(102, 51);
            this.lbl_Login.TabIndex = 21;
            this.lbl_Login.Text = "Daxil ol";
            this.lbl_Login.UseVisualStyleBackColor = true;
            this.lbl_Login.UseWaitCursor = true;
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(374, 296);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(167, 51);
            this.btn_Registration.TabIndex = 20;
            this.btn_Registration.Text = "Qeydiyyatdan keçin";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.UseWaitCursor = true;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(322, 138);
            this.txb_Password.MaxLength = 20;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(239, 26);
            this.txb_Password.TabIndex = 18;
            this.txb_Password.UseWaitCursor = true;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(194, 83);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(118, 20);
            this.lbl_Email.TabIndex = 13;
            this.lbl_Email.Text = "Elektron Ünvan";
            this.lbl_Email.UseWaitCursor = true;
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(322, 77);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(239, 26);
            this.txb_Email.TabIndex = 16;
            this.txb_Email.UseWaitCursor = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(197, 144);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(42, 20);
            this.lbl_Password.TabIndex = 15;
            this.lbl_Password.Text = "Şifrə";
            this.lbl_Password.UseWaitCursor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.lbl_Password);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbl_Login;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label lbl_Password;
    }
}