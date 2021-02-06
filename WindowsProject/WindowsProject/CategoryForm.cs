using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProject.DatabaseRep;
using WindowsProject.DataBaseContext;
using WindowsProject.Models;

namespace WindowsProject
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            GetAll();
            SetCategory();
            GetAllProduct();
           
        }
        ICategoryRepository repository;
        ILogProductRepository logProductRepository;
        int user = LoginForm.LoginInfo.UserID;

      
        public void funData(TextBox txtForm1)
        {
            lbl_UserId.Text = txtForm1.Text;
        }
        private void GetAll()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                repository = new CategoryRepository(context);
                var query= repository.GetAll();
                var t= query.Where(y => y.Status == 0).ToList();
                dgw_Table.DataSource = t;              
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
          
            using (ShopManagementContext context = new ShopManagementContext())
            {
                repository = new CategoryRepository(context);
                Category category = new Category()
                {
                    Name = txb_Name.Text,
                    Status=0
                };
               repository.Insert(category);
                
                GetAll();
            }

        }

        private void dgw_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_UpdateName.Text = dgw_Table.CurrentRow.Cells[1].Value.ToString();
            //cmb_Janr.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString() + "." + dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        
        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                repository = new CategoryRepository(context);
                Category book = new Category()
                {
                    Id = Convert.ToInt32(dgw_Table.CurrentRow.Cells[0].Value),
                    Name = txb_UpdateName.Text,
                };             
                repository.Update(book);
                GetAll();
            }
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void SetCategory()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                repository = new CategoryRepository(context);
                foreach (Category category in repository.GetAll())
                {
                    cmb_Category.Items.Add(category.Id + "." + category.Name);
                    cmb_UpdatePr.Items.Add(category.Id + "." + category.Name);
                }
            }
        }
        IProductRepository productRepository;
        private void button1_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                productRepository = new ProductRepository(context);
                int userid = Convert.ToInt32(lbl_UserId.Text);
                var user = context.Users.Where(y => y.Id == userid).FirstOrDefault();
                Product pr = new Product()
                {
                    Name = tbx_productName.Text,
                    CategoryId = Convert.ToInt32(cmb_Category.Text.Split('.')[0]),
                    Price = Convert.ToInt32(txb_Price.Text),
                    Count = Convert.ToInt32(txb_Count.Text),
                    CreatedUserId = user.Id,
                    PhoneNumber = user.Phone,
                    Status = 0,
                    SoldedTotal=0,
                    SoldedCount=0
                };
                productRepository.Insert(pr);
                GetAllProduct();
            }
        }
        private void GetAllProduct()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                var query = context.Products.Where(y=>y.Status==0).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.CreatedUserId,
                    product.PhoneNumber

                }).ToList();
                dgw_ProductTable.DataSource = query;
            }
            
        }

       
        private void dgw_ProductTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_PrUpdateName.Text = dgw_ProductTable.CurrentRow.Cells[1].Value.ToString();
            cmb_UpdatePr.SelectedItem = dgw_ProductTable.CurrentRow.Cells[5].Value.ToString() + "." + dgw_ProductTable.CurrentRow.Cells[4].Value.ToString();
            txb_PrUpdatePrice.Text = dgw_ProductTable.CurrentRow.Cells[2].Value.ToString();
            txb_PrUpdateCount.Text= dgw_ProductTable.CurrentRow.Cells[3].Value.ToString();
            
            //cmb_Category.SelectedItem = dgw_ProductTable.CurrentRow.Cells[3].Value.ToString() + "." + dgw_ProductTable.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                productRepository = new ProductRepository(context);
                logProductRepository = new LogProductRepository(context);
                int userid = Convert.ToInt32(lbl_UserId.Text);
                var user = context.Users.Where(y => y.Id == userid).FirstOrDefault();
                Product product = new Product()
                {
                    Id = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[0].Value),
                    Name = txb_PrUpdateName.Text,
                    CategoryId= Convert.ToInt32(cmb_UpdatePr.Text.Split('.')[0]),
                    Price= Convert.ToDecimal(txb_PrUpdatePrice.Text),
                    Count = Convert.ToInt32(txb_PrUpdateCount.Text),
                    CreatedUserId=user.Id,
                    PhoneNumber=user.Phone,
                    Status=0,

                };
                if (rtb_Description.Text == null)
                {
                    MessageBox.Show("Izahat mətnini daxil edin");
                }
                else
                {
                    LogProduct logProduct = new LogProduct()
                    {
                        ProductId = product.Id,
                        Description = rtb_Description.Text,
                        Status = 1,
                        UserId = user.Id,
                        Date = DateTime.Now

                    };
                    productRepository.Update(product);
                    logProductRepository.Insert(logProduct);
                }
               
                GetAllProduct();
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            GetAllProduct();
        }

        private void btn_DeletePr_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                productRepository = new ProductRepository(context);
                int userid = Convert.ToInt32(lbl_UserId.Text);
                var user = context.Users.Where(y => y.Id == userid).FirstOrDefault();
                Product product = new Product()
                {
                    Id = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[0].Value),
                    Name = dgw_ProductTable.CurrentRow.Cells[1].Value.ToString(),

                    CategoryId = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[5].Value.ToString()),
                    Price = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()),
                    Count = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[3].Value.ToString()),
                    CreatedUserId = user.Id,
                    PhoneNumber = user.Phone,
                    Status = 1,

                };

                productRepository.Update(product);
                GetAllProduct();
            }
        }

        private void btn_DeleteCategory_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                repository = new CategoryRepository(context);

                Category product = new Category()
                {
                    Id = Convert.ToInt32(dgw_Table.CurrentRow.Cells[0].Value),
                    Name = dgw_Table.CurrentRow.Cells[1].Value.ToString(),
                    Status = 1

                };

                repository.Update(product);
                GetAll();
            }
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {

            using(ShopManagementContext context=new ShopManagementContext())
            {
                productRepository = new ProductRepository(context);

                var userid = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[7].Value.ToString());
                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();
                Product product = new Product()
                {
                    Id = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[0].Value),
                    Name = dgw_ProductTable.CurrentRow.Cells[1].Value.ToString(),

                    CategoryId = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[5].Value.ToString()),
                    Price = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()),
                    Count = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[3].Value.ToString())-1,
                    CreatedUserId = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[7].Value.ToString()),
                    PhoneNumber = user.Phone,
                    Status = 0,
                   


                };
                productRepository.Update(product);
                if (product.Count == 0)
                {
                    product.Status = 1;
                }
                GetAllProduct();
            }


        }
    }
 }

