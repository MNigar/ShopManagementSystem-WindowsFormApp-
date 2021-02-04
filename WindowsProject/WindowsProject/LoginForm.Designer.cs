
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(267, 128);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(68, 33);
            this.btn_Login.TabIndex = 21;
            this.btn_Login.Text = "Daxil ol";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.UseWaitCursor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(249, 192);
            this.btn_Registration.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(111, 33);
            this.btn_Registration.TabIndex = 20;
            this.btn_Registration.Text = "Qeydiyyatdan keçin";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.UseWaitCursor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(215, 90);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Password.MaxLength = 20;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(161, 20);
            this.txb_Password.TabIndex = 18;
            this.txb_Password.UseWaitCursor = true;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(129, 54);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(81, 13);
            this.lbl_Email.TabIndex = 13;
            this.lbl_Email.Text = "Elektron Ünvan";
            this.lbl_Email.UseWaitCursor = true;
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(215, 50);
            this.txb_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(161, 20);
            this.txb_Email.TabIndex = 16;
            this.txb_Email.UseWaitCursor = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(131, 94);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(28, 13);
            this.lbl_Password.TabIndex = 15;
            this.lbl_Password.Text = "Şifrə";
            this.lbl_Password.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 168);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.UseWaitCursor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.lbl_Password);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox textBox1;
    }
}