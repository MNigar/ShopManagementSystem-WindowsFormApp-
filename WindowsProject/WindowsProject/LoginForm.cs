using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProject.DAL;

namespace WindowsProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        Idbclass dbclass = new Idbclass();
        private void LoginForm_Load(object sender, EventArgs e)
        {
            


        }

        

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            reg.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var userList = dbclass.GetAll();
            string email = txb_Email.Text;
            string password = txb_Password.Text;
            var result = dbclass.IfExist(email, password, userList);
            //if(!string.IsNullOrEmpty(txb_Email.Text) && !string.IsNullOrEmpty(txb_Password.Text)                
            //    && userList.Any(user=> user.Email.ToLower()==txb_Email.Text.ToLower() && user.Password == txb_Password.Text))
            if (result)
            {
                CategoryForm categoryForm = new CategoryForm();
                categoryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email və ya şifrə doğru daxil edilməyib");
            }

        }
    }
}
