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

namespace WindowsProject
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
    
        }
        ProductForm productForm = new ProductForm();
        private void button1_Click(object sender, EventArgs e)
        {
            productForm.Actions();

            productForm.Show();
           

        }
        public delegate void delPassData(TextBox text);
        public void funData(TextBox txtForm1)
        {
            textBox1.Text = txtForm1.Text;
         
        }


        private void IndexForm_Load(object sender, EventArgs e)
        {
            delPassData del = new delPassData(productForm.funData);
            del(this.textBox1);
            using (ShopManagementContext context = new ShopManagementContext())
            {
                int userid = Convert.ToInt32(textBox1.Text);
                var query = context.Users.Where(u => u.Id == userid).FirstOrDefault();
                if (query.RoleId == (int)Enums.Role.User)
                {
                    btn_Category.Visible = false;
                }
            }
               


               

        }

        private void lbl_UserId_Click(object sender, EventArgs e)
        {

        }

        private void btn_YourProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm1 = new ProductForm();
            delPassData del = new delPassData(productForm1.funData);
            del(this.textBox1);
            productForm1.GetProductInsertedByUser();
            productForm1.ButtonAction();
            productForm1.Show();
            productForm1.SearchR();
            productForm1.SearchtextBox();
            productForm1.btn();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            delPassData del = new delPassData(reportForm.funData);
            del(this.textBox1);
            int userid = Convert.ToInt32(textBox1.Text);
            reportForm.ReportForUser(userid);
            reportForm.Show();

        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();

        }
    }
}
