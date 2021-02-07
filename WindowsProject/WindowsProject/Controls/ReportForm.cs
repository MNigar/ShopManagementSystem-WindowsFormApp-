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
using WindowsProject.Models;

namespace WindowsProject
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            SetCategory();
        }
#pragma warning disable CS0169 // The field 'ReportForm.repository' is never used
        ICustomerRepository repository;
#pragma warning restore CS0169 // The field 'ReportForm.repository' is never used
        ICategoryRepository catrepository;
        private void SetCategory()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                catrepository = new CategoryRepository(context);
                foreach (Category category in catrepository.GetAll())
                {
                   
                    cmb_SearchDetail.Items.Add(category.Id + "." + category.Name);
                }
            }
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(lbl_UserId.Text);
            ReportForUser( userid);
        }
        public void funData(TextBox txtForm1)
        {
            lbl_UserId.Text = txtForm1.Text;
        }
        public void ReportForUser(int userid)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {

                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();
            
                if (user.RoleId == (int)Enums.Role.User)
                {                     
                    var l = (from Product in context.Products
                            join Customer in context.Consumers on Product.Id equals Customer.ProductId
                            where Product.CreatedUserId==userid
                            select new
                                  {
                                Product.Name,
                                Customer.UserId,
                                User=Customer.User.Name,
                                Customer.Count,
                                Category=Product.Category.Name,
                                Product.CategoryId,
                               Customer.Price
                        

                            }).Distinct().ToList();


                    dgw_Reporttable.DataSource =l ;
                    


                }
                else
                {
                    var l = (from Product in context.Products
                             join LogProduct in context.LogProducts on Product.Id equals LogProduct.ProductId
                             
                             select new
                             {
                                 Product.Name,
                                 Product.Id,
                                 Product.SoldedCount,
                                 Product.Count,
                                 CategoryID = Product.Category.Name,
                                 Product.CategoryId,
                                 Product.SoldedTotal,
                                 ModifiedUserID = LogProduct.UserId != 0 ? LogProduct.User.Name : " ",
                                 Description = LogProduct.Description != null ? LogProduct.Description : " ",
                                 Status = ((Enums.Status)LogProduct.Status).ToString() != "" ? ((Enums.Status)LogProduct.Status).ToString() : ((Enums.Status)Product.Status).ToString()
                             }).Distinct().ToList();
                    var t = (from Product in context.Products
                             where Product.LogProduct.Select(n => n.ProductId).Contains(Product.Id) == false
                             select new
                             {
                                 Product.Name,
                                 Product.Id,
                                 Product.SoldedCount,
                                 Product.Count,
                                 CategoryID = Product.Category.Name,
                                 Product.CategoryId,
                                 Product.SoldedTotal,
                                 ModifiedUserID = "",
                                 Description = "",
                                 Status = ((Enums.Status)Product.Status).ToString()
                             }).Distinct().ToList();

                    var u = l.Union(t).Distinct().ToList();
                    dgw_Reporttable.DataSource = u;

                }

            }

        }

       

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                int userid = Convert.ToInt32(lbl_UserId.Text);
                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();
                //repository = new CustomerRepository(context);
                //var productUserId = context.Products.Where(u => u.CreatedUserId == userid).Select(u=>u.Id).ToList();
                //vavarr query = context.Customers.Where(c => productUserId.Contains(c.ProductId)).ToList();

                if (user.RoleId == (int)Enums.Role.Admin)
                {



                    var l = (from Product in context.Products
                             join LogProduct in context.LogProducts on Product.Id equals LogProduct.ProductId
                             select new
                             {
                                 Product.Name,
                                 Product.Id,
                                 Product.SoldedCount,
                                 
                                 Product.Count,
                                 CategoryID = Product.Category.Name,
                                 Product.CategoryId,
                                 ModifiedUserID = LogProduct.UserId != 0 ? LogProduct.User.Name : " ",
                                 Description = LogProduct.Description != null ? LogProduct.Description : " ",
                                 Status = ((Enums.Status)LogProduct.Status).ToString() != "" ? ((Enums.Status)LogProduct.Status).ToString() : ((Enums.Status)Product.Status).ToString()
                             }).Distinct().ToList();
                    var t = (from Product in context.Products
                             where Product.LogProduct.Select(n => n.ProductId).Contains(Product.Id) == false 
                             select new
                             {
                                 Product.Name,
                                 Product.Id,
                                 Product.SoldedCount,
                                 Product.Count,
                                 CategoryID=Product.Category.Name,
                                 Product.CategoryId,

                                 ModifiedUserID = "",
                                 Description = "",
                                 Status = ((Enums.Status)Product.Status).ToString()
                             }).Distinct().ToList();

                    var u = l.Union(t).Distinct().ToList();
                    dgw_Reporttable.DataSource = u;


                    if (!String.IsNullOrEmpty(txb_SearchDetailName.Text))
                    {
                        u = u.Where(x => x.Name.Contains(txb_SearchDetailName.Text)).ToList();
                    }
                    //if (!String.IsNullOrEmpty(txbSearchPrice.Text))
                    //{
                    //    u = u.Where(x => x. == Convert.ToDecimal(txbSearchPrice.Text)).ToList();
                    //}
                    if (!String.IsNullOrEmpty(txbSerachCount.Text))
                    {
                        u = u.Where(x => x.SoldedCount == Convert.ToInt32(txbSerachCount.Text)).ToList();
                    }
                    if (!String.IsNullOrEmpty(txb_UserId.Text))
                    {
                        u = u.Where(x => x.ModifiedUserID == txb_UserId.Text).ToList();
                    }
                    if (!String.IsNullOrEmpty(cmb_SearchDetail.Text))
                    {
                        u = u.Where(x => x.CategoryId== Convert.ToInt32(cmb_SearchDetail.Text.Split('.')[0])).ToList();
                    }
                    dgw_Reporttable.DataSource = u;

                }

                else
                {
                    var u= (from Product in context.Products
                             join Customer in context.Consumers on Product.Id equals Customer.ProductId
                             where Product.CreatedUserId == userid
                             select new
                             {
                                 Product.Name,
                                 Customer.UserId,
                                 User = Customer.User.Name,

                                 Customer.Count,
                                 Category = Product.Category.Name,
                                 Product.CategoryId,
                                 Customer.Price

                             }).Distinct().ToList();


                    if (!String.IsNullOrEmpty(txb_SearchDetailName.Text))
                    {
                        u = u.Where(x => x.Name.Contains(txb_SearchDetailName.Text)).ToList();
                    }
                    //if (!String.IsNullOrEmpty(txbSearchPrice.Text))
                    //{
                    //    u = u.Where(x => x. == Convert.ToDecimal(txbSearchPrice.Text)).ToList();
                    //}
                    if (!String.IsNullOrEmpty(txbSerachCount.Text))
                    {
                        u = u.Where(x => x.Count == Convert.ToInt32(txbSerachCount.Text)).ToList();
                    }
                    if (!String.IsNullOrEmpty(cmb_SearchDetail.Text))
                    {
                        u = u.Where(x => x.Category == cmb_SearchDetail.Text.Split('.')[1]).ToList();
                    }
                    if (!String.IsNullOrEmpty(txb_UserId.Text))
                    {
                        u = u.Where(x => x.User == txb_UserId.Text).ToList();
                    }
                    dgw_Reporttable.DataSource = u;
                }

            }
        }

            private void cmb_SearchDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbSearchPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSerachCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_SearchDetailName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_CategoryS_Click(object sender, EventArgs e)
        {

        }

        private void dgw_Reporttable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
