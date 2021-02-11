using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProject.Controls;
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
        IUserRepository _repository;
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
                _repository = new UserRepository(context);
                var userList = _repository.GetAll();
                string email = txb_Email.Text;
                string password = txb_Password.Text;
                if (string.IsNullOrEmpty(txb_Email.Text) && string.IsNullOrEmpty(txb_Password.Text))
                {
                    MessageBox.Show("Email və ya şifrə  daxil edilməyib");

                }
                else
                {
                    var user = userList.Where(p => p.Email == email).FirstOrDefault();
                    var result = _repository.IfExist(email, password, userList);
                    //if(!string.IsNullOrEmpty(txb_Email.Text) && !string.IsNullOrEmpty(txb_Password.Text)                
                    //    && userList.Any(user=> user.Email.ToLower()==txb_Email.Text.ToLower() && user.Password == txb_Password.Text))
                    if (result)
                    {
                        if (user.RoleId == 1)
                        {

                            textBox1.Text = Convert.ToString(user.Id);


                            IndexForm index = new IndexForm();
                            CategoryForm form = new CategoryForm();
                            delPassData del = new delPassData(index.funData);
                            del(this.textBox1);
                            index.Show();
                        }
                        else
                        {
                            textBox1.Text = Convert.ToString(user.Id);


                            IndexForm index = new IndexForm();
                            CategoryForm form = new CategoryForm();
                            delPassData del = new delPassData(index.funData);
                            del(this.textBox1);
                            index.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email və ya şifrə doğru daxil edilməyib");
                    }
                }
            }

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
