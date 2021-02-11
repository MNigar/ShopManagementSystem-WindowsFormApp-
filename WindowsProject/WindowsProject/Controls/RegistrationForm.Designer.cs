
namespace WindowsProject
{
    partial class RegistrationForm
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Surname = new System.Windows.Forms.TextBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_Registration = new System.Windows.Forms.GroupBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.gb_Registration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(72, 95);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(29, 20);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Ad";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(72, 152);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(54, 20);
            this.lbl_Surname.TabIndex = 1;
            this.lbl_Surname.Text = "Soyad";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(69, 208);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(118, 20);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Elektron Ünvan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(72, 309);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(42, 20);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Şifrə";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(196, 95);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(240, 26);
            this.txb_Name.TabIndex = 5;
            // 
            // txb_Surname
            // 
            this.txb_Surname.Location = new System.Drawing.Point(196, 146);
            this.txb_Surname.Name = "txb_Surname";
            this.txb_Surname.Size = new System.Drawing.Size(240, 26);
            this.txb_Surname.TabIndex = 6;
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(196, 202);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(240, 26);
            this.txb_Email.TabIndex = 7;
            // 
            // txb_PhoneNumber
            // 
            this.txb_PhoneNumber.Location = new System.Drawing.Point(196, 251);
            this.txb_PhoneNumber.Name = "txb_PhoneNumber";
            this.txb_PhoneNumber.Size = new System.Drawing.Size(240, 26);
            this.txb_PhoneNumber.TabIndex = 8;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(196, 303);
            this.txb_Password.MaxLength = 20;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(240, 26);
            this.txb_Password.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 10;
            // 
            // gb_Registration
            // 
            this.gb_Registration.Controls.Add(this.btn_Login);
            this.gb_Registration.Controls.Add(this.btn_Registration);
            this.gb_Registration.Controls.Add(this.lbl_PhoneNumber);
            this.gb_Registration.Controls.Add(this.txb_Password);
            this.gb_Registration.Controls.Add(this.lbl_Name);
            this.gb_Registration.Controls.Add(this.lbl_Surname);
            this.gb_Registration.Controls.Add(this.txb_PhoneNumber);
            this.gb_Registration.Controls.Add(this.lbl_Email);
            this.gb_Registration.Controls.Add(this.txb_Email);
            this.gb_Registration.Controls.Add(this.label4);
            this.gb_Registration.Controls.Add(this.txb_Surname);
            this.gb_Registration.Controls.Add(this.lbl_Password);
            this.gb_Registration.Controls.Add(this.txb_Name);
            this.gb_Registration.Location = new System.Drawing.Point(302, 29);
            this.gb_Registration.Name = "gb_Registration";
            this.gb_Registration.Size = new System.Drawing.Size(586, 525);
            this.gb_Registration.TabIndex = 11;
            this.gb_Registration.TabStop = false;
            this.gb_Registration.Text = "Registration";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(273, 428);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(102, 51);
            this.btn_Login.TabIndex = 12;
            this.btn_Login.Text = "Daxil olun";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(232, 355);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(166, 51);
            this.btn_Registration.TabIndex = 11;
            this.btn_Registration.Text = "Qeydiyyatdan keçin";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(68, 257);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(124, 20);
            this.lbl_PhoneNumber.TabIndex = 10;
            this.lbl_PhoneNumber.Text = "Telefon Nömrəsi";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 566);
            this.Controls.Add(this.gb_Registration);
            this.Controls.Add(this.label6);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.gb_Registration.ResumeLayout(false);
            this.gb_Registration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Surname;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_PhoneNumber;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_Registration;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.Button btn_Login;
    }
}