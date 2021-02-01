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
        public RegistrationForm(IShopManagementrepository repository)
        {
           _repository = repository;
            
        }
        Idbclass dbclass = new Idbclass();

        private void btn_Registration_Click(object sender, EventArgs e)
           
        {


            using (ShopManagementContext context = new ShopManagementContext())
            {
                User user = new User();
                user.Id = 2;
                user.Name = txb_Name.Text;
                user.Surname = txt_Surname.Text;
                user.Email = txb_Email.Text;
                user.Phone = txb_PhoneNumber.Text;
                user.Password = txb_Password.Text;
                user.RoleId = 2;
                dbclass.Insert(user);

            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
