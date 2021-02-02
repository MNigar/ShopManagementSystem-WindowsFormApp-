using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProject.DAL;
using WindowsProject.DALnew;
using WindowsProject.DataBaseContext;
using WindowsProject.Models;

namespace WindowsProject
{
    public partial class RegistrationForm : Form
    {
        //Idbclass<User> _repository=new Idbclass<User>();
        private readonly IShopManagementrepository _repository;
      
        public RegistrationForm()
        {
            InitializeComponent();
           
        }
        private Form _loginForm;
        public RegistrationForm(Form form) : this()
        {
            _loginForm = form;
        }
        public RegistrationForm(IShopManagementrepository repository)
        {
           _repository = repository;
            
        }
        Idbclass dbclass = new Idbclass();
        LoginForm login = new LoginForm();
        private void btn_Registration_Click(object sender, EventArgs e)
           
        {


            using (ShopManagementContext context = new ShopManagementContext())
            {
                User user = new User();
                user.Id = 2;
                user.Name = txb_Name.Text;
                user.Surname = txb_Surname.Text;
                user.Email = txb_Email.Text;
                user.Phone = txb_PhoneNumber.Text;
                user.Password = txb_Password.Text;
                user.RoleId = 2;
                user.CreatedDate = DateTime.Now;
                user.Status = 0;
                if (!string.IsNullOrEmpty(txb_Email.Text)
               && Regex.IsMatch(txb_Email.Text, @"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$")
               && !string.IsNullOrEmpty(txb_Name.Text)
               && !string.IsNullOrEmpty(txb_Surname.Text)
               && !string.IsNullOrEmpty(txb_PhoneNumber.Text)
               && Regex.IsMatch(txb_PhoneNumber.Text, @"^([+994])+(50|55|51|77|70|99|10|60)+[0-9]{7}$")
               && !string.IsNullOrEmpty(txb_Password.Text) && txb_Password.Text.Length > 8)
                {
                    dbclass.Insert(user);
                    login.Show();
                    
                }
                else
                {
                    MessageBox.Show("Yalnish");
                }
                

            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            
            login.Show();
        }
    }
}
