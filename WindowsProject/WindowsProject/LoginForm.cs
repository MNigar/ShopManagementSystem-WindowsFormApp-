using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProject.DataBaseContext;
using WindowsProject.DatabaseRep;

namespace WindowsProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        IUserRepository repository;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            


        }
        public delegate void delPassData(TextBox text);
        public static class LoginInfo
        {
            public static int UserID;
        }
        private void btn_Registration_Click(object sender, EventArgs e)
        {
            //RegistrationForm reg = new RegistrationForm();
            //reg.ShowDialog();
            RegistrationForm registration = new RegistrationForm(this);

            registration.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext()) {
                repository = new UserRepository(context);
                var userList = repository.GetAll();
                string email = txb_Email.Text;
                string password = txb_Password.Text;
                var user = userList.Where(p=>p.Email == email).FirstOrDefault();
                var result = repository.IfExist(email, password, userList);
                //if(!string.IsNullOrEmpty(txb_Email.Text) && !string.IsNullOrEmpty(txb_Password.Text)                
                //    && userList.Any(user=> user.Email.ToLower()==txb_Email.Text.ToLower() && user.Password == txb_Password.Text))
                if (result)
                {
                    if (user.RoleId == 2)
                    {
                       
                        textBox1.Text = Convert.ToString(user.Id);

                        CategoryForm categoryForm = new CategoryForm();
                

                      
                        delPassData del = new delPassData(categoryForm.funData);
                        del(this.textBox1);
                        categoryForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Welcome");
                    }
                }
                else
                {
                    MessageBox.Show("Email və ya şifrə doğru daxil edilməyib");
                }
            }

        }
    }
}
