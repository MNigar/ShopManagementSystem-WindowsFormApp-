
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
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(400, 197);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(102, 51);
            this.btn_Login.TabIndex = 21;
            this.btn_Login.Text = "Daxil ol";
            this.btn_Login.UseMnemonic = false;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(374, 295);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(166, 51);
            this.btn_Registration.TabIndex = 20;
            this.btn_Registration.Text = "Qeydiyyatdan keçin";
            this.btn_Registration.UseVisualStyleBackColor = false;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(194, 83);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(118, 20);
            this.lbl_Email.TabIndex = 13;
            this.lbl_Email.Text = "Elektron Ünvan";
            this.lbl_Email.UseMnemonic = false;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(196, 145);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(42, 20);
            this.lbl_Password.TabIndex = 15;
            this.lbl_Password.Text = "Şifrə";
            this.lbl_Password.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 258);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.Visible = false;
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(390, 83);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(212, 26);
            this.txb_Email.TabIndex = 23;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(390, 145);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(212, 26);
            this.txb_Password.TabIndex = 24;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 561);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Password);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_Password;
    }
}