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
using WindowsProject.Enums;
using WindowsProject.Models;

namespace WindowsProject
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            GetAllProduct();
            SetCategory();
        }
        ICategoryRepository repository;
        IProductRepository productRepository;
        ILogProductRepository logProductRepository;
        ICustomerRepository customerRepository;
        private void Clear()
        {
            tbx_productName.Text = "";
            txb_Price.Text = "";
            txb_Count.Text = "";

            rtb_Description.Text = "";

        }
        
        public void ButtonAction()
        {
            int userid = Convert.ToInt32(lbl_UserId.Text);
            using (ShopManagementContext context = new ShopManagementContext())
            {
                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();
                if(user.RoleId==(int)Enums.Role.Admin)

                {
                    btn_Buy.Visible = true;

                }
                else
                {
                    btn_Buy.Visible = false;

                }

            }
               
        }
        public void SearchtextBox()
        {
            int userid = Convert.ToInt32(lbl_UserId.Text);
            using (ShopManagementContext context = new ShopManagementContext())
            {
                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();
                if (user.RoleId == (int)Enums.Role.Admin)

                {
                    txb_SearchNameByUSer.Visible = false;
                    cmb_SearchByUserCategory.Visible = false;
                    txb_SearchName.Visible = true;
                    cmb_SearchCategory.Visible = true;
                }
                else
                {
                    txb_SearchNameByUSer.Visible = true;
                    cmb_SearchByUserCategory.Visible = true;
                    txb_SearchName.Visible = false;
                    cmb_SearchCategory.Visible= false;

                }

            }

        }
        public void SearchR()
        {
            int userid = Convert.ToInt32(lbl_UserId.Text);
            using (ShopManagementContext context = new ShopManagementContext())
            {
                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();
                if (user.RoleId == (int)Enums.Role.Admin)

                {
                    btn_SearchByUser.Visible = false;
                    btn_Search.Visible = true;
                  
                 
                }
                else
                {
                    btn_SearchByUser.Visible = true;
                    btn_Search.Visible = false;
                    

                }

            }

        }
        public void btn()
        {
            int userid = Convert.ToInt32(lbl_UserId.Text);
            using (ShopManagementContext context = new ShopManagementContext())
            {
                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();
                if (user.RoleId == (int)Enums.Role.Admin)

                {
                    btn_GetAll.Visible = true;
                    btn_SearchUSers.Visible = false ;


                }
                else
                {
                    btn_GetAll.Visible = false;
                    btn_SearchUSers.Visible = true;

                }

            }

        }
        private void SetCategory()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                repository = new CategoryRepository(context);
                foreach (Category category in repository.GetAll())
                {
                    cmb_Category.Items.Add(category.Id + "." + category.Name);
                    cmb_SearchCategory.Items.Add(category.Id + "." + category.Name);
                    cmb_SearchDetail.Items.Add(category.Id + "." + category.Name); 
                    cmb_SearchByUserCategory.Items.Add(category.Id + "." + category.Name);
                }
            }
        }
        public void funData(TextBox txtForm1)
        {
            lbl_UserId.Text = txtForm1.Text;
        }
       
        private void  GetAllProduct()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                var query = context.Products.Where(y => y.Status == (int)Status.Active).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.CreatedUserId,
                    product.PhoneNumber,
                    product.SoldedCount,
                    product.SoldedTotal

                }).ToList();
                dgw_ProductTable.DataSource = query;
              
            }

        }
        public void GetProductInsertedByUser()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
               int  userid = Convert.ToInt32(lbl_UserId.Text);
                var query = context.Products.Where(y => y.Status == (int)Status.Active && y.CreatedUserId==userid).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.CreatedUserId,
                    product.PhoneNumber,
                    product.SoldedTotal

                }).ToList();
                dgw_ProductTable.DataSource = query;
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            
        }

       

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                productRepository = new ProductRepository(context);
                int userid = Convert.ToInt32(lbl_UserId.Text);
                var user = context.Users.Where(y => y.Id == userid).FirstOrDefault();
                if (String.IsNullOrEmpty(tbx_productName.Text) || String.IsNullOrEmpty(txb_Count.Text)
                    || String.IsNullOrEmpty(txb_Price.Text) || String.IsNullOrEmpty(cmb_Category.Text))
                {
                    MessageBox.Show("Xanalari doldurun");
                }
                else
                {

                    Product pr = new Product()
                    {

                        Name = tbx_productName.Text,
                        CategoryId = Convert.ToInt32(cmb_Category.Text.Split('.')[0]),
                        Price = Convert.ToDecimal(txb_Price.Text),
                        Count = Convert.ToInt32(txb_Count.Text),
                        CreatedUserId = user.Id,
                        PhoneNumber = user.Phone,
                        Status = (int)Status.Active,
                        SoldedTotal = 0,
                        SoldedCount = 0
                    };
                    productRepository.Insert(pr);
                    productRepository.Save();
                    if (user.RoleId == (int)Enums.Role.Admin)
                    {
                        GetAllProduct();
                    }
                    else
                    {
                        GetProductInsertedByUser();
                       
                    }
                    Clear();
                }
            }
        }
        private void dgw_ProductTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cmb_Category.SelectedItem = dgw_ProductTable.CurrentRow.Cells[3].Value.ToString() + "." + dgw_ProductTable.CurrentRow.Cells[4].Value.ToString();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
        public  void Actions()
        {
            int userid = Convert.ToInt32(lbl_UserId.Text);
            using (ShopManagementContext context = new ShopManagementContext())
            {
                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();
                if (user.RoleId != (int)Enums.Role.Admin)

                {
                    tabControl1.TabPages.Remove(tabPage1);
                }
               
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                productRepository = new ProductRepository(context);
                logProductRepository = new LogProductRepository(context);
                int userid = Convert.ToInt32(lbl_UserId.Text);
                var user = context.Users.Where(y => y.Id == userid).FirstOrDefault();
                if (String.IsNullOrEmpty(tbx_productName.Text) || String.IsNullOrEmpty(txb_Count.Text)
                    || String.IsNullOrEmpty(txb_Price.Text) || String.IsNullOrEmpty(cmb_Category.Text) || rtb_Description.Text == "")
                {
                    MessageBox.Show("Xanalari doldurun");
                }
               
                    else
                    {
                        Product product = new Product()
                        {
                            Id = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[0].Value),
                            Name = tbx_productName.Text,
                            CategoryId = Convert.ToInt32(cmb_Category.Text.Split('.')[0]),
                            Price = Convert.ToDecimal(txb_Price.Text),
                            Count = Convert.ToInt32(txb_Count.Text),
                            CreatedUserId = user.Id,
                            PhoneNumber = user.Phone,
                            Status = (int)Status.Active,

                        };


                        LogProduct logProduct = new LogProduct()
                        {
                            ProductId = product.Id,
                            Description = rtb_Description.Text,
                            Status = (int)Status.Modified,
                            UserId = user.Id,
                            Date = DateTime.Now

                        };
                        productRepository.Update(product);
                        productRepository.Save();

                        logProductRepository.Insert(logProduct);
                        logProductRepository.Save();
                        Clear();

                        if (user.RoleId == (int)Enums.Role.Admin)
                        {
                        GetAllProduct();
                    }
                        else
                    {
                        GetProductInsertedByUser();
                        
                        }
                    
                }
            }
        }

        private void dgw_ProductTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            tbx_productName.Text = dgw_ProductTable.CurrentRow.Cells[1].Value.ToString();
            cmb_Category.SelectedItem = dgw_ProductTable.CurrentRow.Cells[5].Value.ToString() + "." + dgw_ProductTable.CurrentRow.Cells[4].Value.ToString();
            txb_Price.Text = dgw_ProductTable.CurrentRow.Cells[2].Value.ToString();
            txb_Count.Text = dgw_ProductTable.CurrentRow.Cells[3].Value.ToString();

        }

        private void dgw_ProductTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                productRepository = new ProductRepository(context);
                logProductRepository = new LogProductRepository(context);
                int userid = Convert.ToInt32(lbl_UserId.Text);
                var user = context.Users.Where(y => y.Id == userid).FirstOrDefault();
                if (rtb_Description.Text == "")
                {
                    MessageBox.Show("Izahat mətnini daxil edin");
                }
                else
                {

                    Product product = new Product()
                    {
                        Id = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[0].Value),
                        Name = dgw_ProductTable.CurrentRow.Cells[1].Value.ToString(),

                        CategoryId = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[5].Value.ToString()),
                        Price = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()),
                        Count = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[3].Value.ToString()),
                        CreatedUserId = user.Id,
                        PhoneNumber = user.Phone,
                        Status = (int)Status.Deactive,

                    };

                    LogProduct logProduct = new LogProduct()
                    {
                        ProductId = product.Id,
                        Description = rtb_Description.Text,
                        Status = (int)Status.Deleted,
                        UserId = user.Id,
                        Date = DateTime.Now

                    };
                    productRepository.Update(product);
                    logProductRepository.Insert(logProduct);


                    productRepository.Update(product);
                    productRepository.Save();
                    if (user.RoleId == (int)Enums.Role.Admin)
                    {
                        GetAllProduct();
                        
                    }
                    else
                    {
                        GetProductInsertedByUser();
                    }
                }
            }
        }

        private void btn_ClearInput_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                productRepository = new ProductRepository(context);
                customerRepository = new CustomerRepository(context);
                int currentUserId = Convert.ToInt32(lbl_UserId.Text);
                var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();
                
                var userid = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[7].Value.ToString());
                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();
                Product product = new Product()
                {
                    Id = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[0].Value),
                    Name = dgw_ProductTable.CurrentRow.Cells[1].Value.ToString(),

                    CategoryId = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[5].Value.ToString()),
                    Price = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()),
                    Count = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[3].Value.ToString()) - 1,
                    CreatedUserId = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[7].Value.ToString()),
                    PhoneNumber = user.Phone,
                    Status = (int)Status.Active,
                    SoldedCount= Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[9].Value.ToString()) +1,
                    SoldedTotal = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[10].Value.ToString())+ Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString())
                };
               
               
                var currentCustomer = context.Consumers.AsNoTracking().Where(c => c.UserId == currentUserId
                && c.ProductId == product.Id).FirstOrDefault();
                Consumer customer = new Consumer();               
                customer.ProductId = product.Id;
                customer.UserId = currentUserId;
                customer.CreatedDate = DateTime.Now;
                if (customer.UserId == userid)
                {
                    MessageBox.Show("Özünüz daxil etdiyiniz məhsulu ala bilməzsiniz");

                }
                else
                {
                    if (currentCustomer == null)
                    {
                        customer.Count = 1;
                        customer.Price = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()) + product.Price;
                        customerRepository.Insert(customer);
                    }
                    else
                    {
                        customer.Id = currentCustomer.Id;
                        currentCustomer.Count += 1;
                        customer.Price = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()) + product.Price;

                        customer.Count = currentCustomer.Count;
                        customerRepository.Update(customer);

                    }
                    if (product.Count == 0)
                    {
                        product.Status = (int)Status.Deactive;
                    }
                    productRepository.Update(product);
                    productRepository.Save();

                    customerRepository.Save();

                    GetAllProduct();
                }
            }
        }
        public void SearchByName()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                int currentUserId = Convert.ToInt32(lbl_UserId.Text);
                var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();

                var query = context.Products.Where(y => y.Status == (int)Status.Active).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.CreatedUserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();

                var search = query.Where(p => p.Name.Contains(txb_SearchName.Text)).ToList();
                dgw_ProductTable.DataSource = search;

            }
        }
        public void UserSearchByName()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                int currentUserId = Convert.ToInt32(lbl_UserId.Text);
                var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();

                var query = context.Products.Where(y => y.Status == (int)Status.Active && y.CreatedUserId==currentUserId).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.CreatedUserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();

                var search = query.Where(p => p.Name.Contains(txb_SearchNameByUSer.Text)).ToList();
                dgw_ProductTable.DataSource = search;

            }
        }
        
        public void SearchCategoryAdmin()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                int currentUserId = Convert.ToInt32(lbl_UserId.Text);
                var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();




                var query = context.Products.Where(y => y.Status == (int)Status.Active).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.CreatedUserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();
                var search = query.Where(product => product.CategoryId == Convert.ToInt32(cmb_SearchCategory.Text.Split('.')[0])).ToList();
                dgw_ProductTable.DataSource = search;



            }
        }

        private void SearchCategory()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                int currentUserId = Convert.ToInt32(lbl_UserId.Text);
                var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();

                var query = context.Products.Where(y => y.Status == (int)Status.Active && y.CreatedUserId == currentUserId).Select(product => new
                {


                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.CreatedUserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();
                var search = query.Where(product => product.CategoryId == Convert.ToInt32(cmb_SearchByUserCategory.Text.Split('.')[0])).ToList();
                dgw_ProductTable.DataSource = search;
            }
        }
       private void txb_SearchName_TextChanged(object sender, EventArgs e)
      {
            //using (ShopManagementContext context = new ShopManagementContext())
            //{

            //    int currentUserId = Convert.ToInt32(lbl_UserId.Text);
            //    var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();
            //    if (currentUser.RoleId == (int)Enums.Role.Admin)
            //    {
            //        SearchByName();
            //    }

            //    else
            //    {
            //        UserSearchByName();
            //    }
            //}
            SearchByName();
        }

        private void cmb_SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (ShopManagementContext context = new ShopManagementContext())
            //{
            //    int currentUserId = Convert.ToInt32(lbl_UserId.Text);
            //    var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();
            //    if (currentUser.RoleId == (int)Enums.Role.Admin)
            //    {
            //        SearchCategoryAdmin();
            //    }

            //    else
            //    {
            //        SearchCategory();
            //    }
            //}
            SearchCategoryAdmin();
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            //using (ShopManagementContext context = new ShopManagementContext())
            //{
            //    int currentUserId = Convert.ToInt32(lbl_UserId.Text);
            //    var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();
            //    if (currentUser.RoleId == (int)Enums.Role.Admin)
            //    { GetAllProduct(); }
            //    else { 
            //        GetProductInsertedByUser();
            //    }
            //}
            GetAllProduct();
        }
        
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //using (ShopManagementContext context = new ShopManagementContext())
            //{
            //    int currentUserId = Convert.ToInt32(lbl_UserId.Text);
            //    var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();
            //    if (currentUser.RoleId == (int)Enums.Role.Admin)
            //    {
            //        SearchAll ();
            //    }

            //    else
            //    {
            //        SearchbyUser();
            //    }
            //}
            SearchAll();


        }
        private void SearchAll()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                var query = context.Products.Where(y => y.Status == (int)Status.Active).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.CreatedUserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();

                if (!String.IsNullOrEmpty(txb_SearchDetailName.Text))
                {
                    query = query.Where(x => x.Name.Contains(txb_SearchDetailName.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(txbSearchPrice.Text))
                {
                    query = query.Where(x => x.Price == Convert.ToDecimal(txbSearchPrice.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(txbSerachCount.Text))
                {
                    query = query.Where(x => x.Count == Convert.ToInt32(txbSerachCount.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(txb_UserId.Text))
                {
                    query = query.Where(x => x.CreatedUserId == Convert.ToInt32(txb_UserId.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(cmb_SearchDetail.Text))
                {
                    query = query.Where(x => x.CategoryId == Convert.ToInt32(cmb_SearchDetail.Text.Split('.')[0])).ToList();
                }
                dgw_ProductTable.DataSource = query;






            }
        }

        private void SearchbyUser()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                int currentUserId = Convert.ToInt32(lbl_UserId.Text);
                var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();
                var query = context.Products.Where(y => y.Status == (int)Status.Active && y.CreatedUserId== currentUserId).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.CreatedUserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();

                if (!String.IsNullOrEmpty(txb_SearchDetailName.Text))
                {
                    query = query.Where(x => x.Name.Contains(txb_SearchDetailName.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(txbSearchPrice.Text))
                {
                    query = query.Where(x => x.Price == Convert.ToDecimal(txbSearchPrice.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(txbSerachCount.Text))
                {
                    query = query.Where(x => x.Count == Convert.ToInt32(txbSerachCount.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(txb_UserId.Text))
                {
                    query = query.Where(x => x.CreatedUserId == Convert.ToInt32(txb_UserId.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(cmb_SearchDetail.Text))
                {
                    query = query.Where(x => x.CategoryId == Convert.ToInt32(cmb_SearchDetail.Text.Split('.')[0])).ToList();
                }
                dgw_ProductTable.DataSource = query;






            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CountS_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_SearchByUser_Click(object sender, EventArgs e)
        {
            SearchbyUser();
        }

        private void txb_SearchNameByUSer_TextChanged(object sender, EventArgs e)
        {
            UserSearchByName();
        }

        private void cmb_SearchByUserCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCategory();
        }

        private void btn_SearchUSers_Click(object sender, EventArgs e)
        {
            btn_GetAll.Visible = false;
            GetProductInsertedByUser();
        }
    }
}
