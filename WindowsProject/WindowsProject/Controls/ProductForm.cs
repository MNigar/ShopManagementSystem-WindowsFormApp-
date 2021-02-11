using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsProject.DataBaseContext;
using WindowsProject.DatabaseRep;
using WindowsProject.Enums;
using WindowsProject.Models;

namespace WindowsProject
{

    public partial class ProductForm : Form
    {
        ICategoryRepository _categoryrepository;
        IProductRepository _productRepository;
        ILogProductRepository _logProductRepository;
        ICustomerRepository _customerRepository;
        IUserRepository _userRepository;
        public ProductForm()
        {
            InitializeComponent();
            GetAllProduct();
            SetCategory();
            SetUser();
          
        }
   
        private void Clear()
        {
            tbx_productName.Text = "";
            txb_Price.Text = "";
            txb_Count.Text = "";
            cmb_Category.SelectedIndex = 0;
            cmb_SearchDetail.SelectedIndex = 0;
            cmb_SearchCategory.SelectedIndex = 0;
            cmb_SearchByUserCategory.SelectedIndex = 0;
            rtb_Description.Text = "";

        }

        public void ButtonAction()
        {
            int userid = Convert.ToInt32(lbl_UserId.Text);
            using (ShopManagementContext context = new ShopManagementContext())
            {
                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();
                if (user.RoleId == (int)Enums.Role.Admin)

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
                    cmb_SearchCategory.Visible = false;

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
                    btn_SearchUSers.Visible = false;


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
                _categoryrepository = new CategoryRepository(context);
                var catlist = _categoryrepository.GetAll();

                cmb_Category.Items.Insert(0, "select");
                cmb_Category.SelectedIndex = 0;
               
                foreach (Category category in catlist.Where(c=>c.Status==0))
                {
                    cmb_Category.Items.Add(category.Id + "." + category.Name);
                    cmb_SearchCategory.Items.Add(category.Id + "." + category.Name);
                    cmb_SearchDetail.Items.Add(category.Id + "." + category.Name);
                    cmb_SearchByUserCategory.Items.Add(category.Id + "." + category.Name);
                }

                
                

                //cmb_SearchByUserCategory.Items.Insert(0, "select");
                
            }
        }
        private void SetUser()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                _userRepository = new UserRepository(context);
                cmb_User.Items.Insert(0, "select");
                cmb_User.SelectedIndex = 0;
                foreach (User user in _userRepository.GetAll())
                {
                    cmb_User.Items.Add(user.Id + "." + user.Name);
                
                }
            }
        }
        public void funData(TextBox txtForm1)
        {
            lbl_UserId.Text = txtForm1.Text;
        }
        private void SortByExpireDate()
         {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                _productRepository = new ProductRepository(context);
                _logProductRepository = new LogProductRepository(context); 
                var list = _productRepository.GetAll();
                var user = context.Users.Where(u => u.RoleId == (int)Enums.Role.Admin).FirstOrDefault();

                var sortedList = list.Where(p => p.ExpireDate.Day.CompareTo(DateTime.Now.Day) == 0);
                foreach (var i in sortedList)
                {
                    i.Status = (int)Enums.Status.Expired;
                    i.Name = i.Name;
                    i.Id = i.Id;
                    i.PhoneNumber = i.PhoneNumber;
                    i.Price = i.Price;
                    i.SoldedCount = i.SoldedCount;
                    i.ExpireDate = i.ExpireDate;
                    i.SoldedTotal = i.SoldedTotal;
                    i.UserId = i.UserId;
                    i.CategoryId = i.CategoryId;
                    i.Count = i.Count;
                    _productRepository.Update(i);
                    _productRepository.Save();
                    LogProduct logProduct = new LogProduct()
                    {
                        ProductId = i.Id,
                        Description = "İstifadə tarxi bitib",
                        Status = (int)Status.Expired,
                        UserId = user.Id,
                        Date = i.ExpireDate

                    };
                    _logProductRepository.Insert(logProduct);
                    _logProductRepository.Save();
                }
              
            }
        }
        private void GetAllProduct()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                SortByExpireDate();
                var query = context.Products.Where(y => y.Status == (int)Status.Active).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    UserName=product.User.Name,
                    product.UserId,

                    product.CategoryId,
                    Status=((Enums.Status)product.Status),
                    
                    product.PhoneNumber,
                    product.SoldedCount,
                    product.SoldedTotal,
                    product.ExpireDate

                }).ToList();

                dgw_ProductTable.DataSource = query;
               
            }

        }
        public void GetProductInsertedByUser()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                SortByExpireDate();
                int userid = Convert.ToInt32(lbl_UserId.Text);
                var query = context.Products.Where(y => y.Status == (int)Status.Active && y.UserId == userid).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    UserName = product.User.Name,
                    product.UserId,
                    product.CategoryId,
                    Status = ((Enums.Status)product.Status),
                    product.PhoneNumber,
                    product.SoldedCount,
                    product.SoldedTotal,
                    product.ExpireDate

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
                _productRepository = new ProductRepository(context);
                int userid = Convert.ToInt32(lbl_UserId.Text);
                var user = context.Users.Where(y => y.Id == userid).FirstOrDefault();
                if (String.IsNullOrEmpty(tbx_productName.Text) || String.IsNullOrEmpty(txb_Count.Text)
                    || String.IsNullOrEmpty(txb_Price.Text) || String.IsNullOrEmpty(cmb_Category.Text)
                    || cmb_Category.SelectedIndex==0)

                    
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
                        UserId = user.Id,
                        PhoneNumber = user.Phone,
                        Status = (int)Status.Active,
                        SoldedTotal = 0,
                        SoldedCount = 0,
                        ExpireDate = dtp_Expire.Value
                    };
                    _productRepository.Insert(pr);
                    _productRepository.Save();
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
        public void Actions()
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
                _productRepository = new ProductRepository(context);
                _logProductRepository = new LogProductRepository(context);
                int userid = Convert.ToInt32(lbl_UserId.Text);
                var user = context.Users.Where(y => y.Id == userid).FirstOrDefault();
                if (String.IsNullOrEmpty(tbx_productName.Text) || String.IsNullOrEmpty(txb_Count.Text)
                    || String.IsNullOrEmpty(txb_Price.Text) || String.IsNullOrEmpty(cmb_Category.Text) || rtb_Description.Text == "")
                {
                    MessageBox.Show("İzahat hissəsin doldurun");
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
                        UserId = user.Id,
                        PhoneNumber = user.Phone,
                        Status = (int)Status.Active,
                        ExpireDate = dtp_Expire.Value

                    };


                    LogProduct logProduct = new LogProduct()
                    {
                        ProductId = product.Id,
                        Description = rtb_Description.Text,
                        Status = (int)Status.Modified,
                        UserId = user.Id,
                        Date = DateTime.Now

                    };
                    _productRepository.Update(product);
                    _productRepository.Save();

                    _logProductRepository.Insert(logProduct);
                    _logProductRepository.Save();
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
            cmb_Category.SelectedItem = dgw_ProductTable.CurrentRow.Cells[7].Value.ToString() + "." + dgw_ProductTable.CurrentRow.Cells[4].Value.ToString();
            txb_Price.Text = dgw_ProductTable.CurrentRow.Cells[2].Value.ToString();
            txb_Count.Text = dgw_ProductTable.CurrentRow.Cells[3].Value.ToString();
            dtp_Expire.Value =(DateTime) dgw_ProductTable.CurrentRow.Cells[12].Value;
        }

        private void dgw_ProductTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                _productRepository = new ProductRepository(context);
                _logProductRepository = new LogProductRepository(context);
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

                        CategoryId = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[7].Value.ToString()),
                        Price = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()),
                        Count = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[3].Value.ToString()),
                        UserId = user.Id,
                        PhoneNumber = user.Phone,
                        Status = (int)Status.Deactive,
                        ExpireDate = dtp_Expire.Value
                    };

                    LogProduct logProduct = new LogProduct()
                    {
                        ProductId = product.Id,
                        Description = rtb_Description.Text,
                        Status = (int)Status.Deleted,
                        UserId = user.Id,
                        Date = DateTime.Now

                    };
                    _productRepository.Update(product);
                    _logProductRepository.Insert(logProduct);


                    _productRepository.Update(product);
                    _productRepository.Save();
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
                _productRepository = new ProductRepository(context);
                _customerRepository = new CustomerRepository(context);
                int currentUserId = Convert.ToInt32(lbl_UserId.Text);
                var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();

                var userid = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[7].Value.ToString());
                var user = context.Users.Where(u => u.Id == userid).FirstOrDefault();

                Product product = new Product()
                {
                    Id = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[0].Value),
                    Name = dgw_ProductTable.CurrentRow.Cells[1].Value.ToString(),

                    CategoryId = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[7].Value.ToString()),
                    Price = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()),
                    Count = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[3].Value.ToString()) - 1,
                    UserId = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[6].Value.ToString()),
                    PhoneNumber = user.Phone,
                    Status = (int)Status.Active,
                    SoldedCount = Convert.ToInt32(dgw_ProductTable.CurrentRow.Cells[10].Value.ToString()) + 1,
                    SoldedTotal = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[11].Value.ToString()) + Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()),
                    ExpireDate = (DateTime)dtp_Expire.Value
                    
                };


                var currentCustomer = context.Consumers.AsNoTracking().Where(c => c.CreatedUserId == currentUserId
                && c.ProductId == product.Id).FirstOrDefault();
                Customer customer = new Customer();
                customer.ProductId = product.Id;
                customer.CreatedUserId = currentUserId;
                customer.CreatedDate = DateTime.Now;
                if (product.UserId == currentUserId)
                {
                    MessageBox.Show("Özünüz daxil etdiyiniz məhsulu ala bilməzsiniz");

                }
                else
                {
                    bool check = true;
                    if (product.ExpireDate.Day - DateTime.Now.Day == 3)
                    {
                        check = false;
                        
                        if (MessageBox.Show("Mehsulun vaxtinin bitmeyine 3 gun qalib eminsinizmi?", "Raziliq", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            check = false;
                            MessageBox.Show("Almadiniz");
                        }
                        else { check = true; }
                    }
                    if (product.ExpireDate.Day - DateTime.Now.Day == 2)
                    {
                        check = false;
                      
                        if (MessageBox.Show("Mehsulun vaxtinin bitmeyine 2 gun qalib eminsinizmi?", "Raziliq", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            check = false;
                            MessageBox.Show("Almadiniz");
                        }
                        else { check = true; }
                    }
                    if (product.ExpireDate.Day - DateTime.Now.Day == 1)
                    {
                        check = false;
                      
                        if (MessageBox.Show("Mehsulun vaxtinin bitmeyine 1 gun qalib eminsinizmi?", "Raziliq", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            check = false;
                            MessageBox.Show("Almadiniz");
                        }
                        else { check = true; }
                    }
                    if (check == true)
                    {
                        if (currentCustomer == null)
                        {
                            customer.Count = 1;
                            customer.Price = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()) + product.Price;
                            _customerRepository.Insert(customer);
                        }
                        else
                        {
                            customer.Id = currentCustomer.Id;
                            currentCustomer.Count += 1;
                            customer.Price = Convert.ToDecimal(dgw_ProductTable.CurrentRow.Cells[2].Value.ToString()) + product.Price;

                            customer.Count = currentCustomer.Count;
                            _customerRepository.Update(customer);

                        }
                        if (product.Count == 0)
                        {
                            product.Status = (int)Status.Deactive;
                        }
                        _productRepository.Update(product);
                        _productRepository.Save();

                        _customerRepository.Save();
                        MessageBox.Show($"Teshekkurler {product.Name} mehsulu aldiniz");
                        GetAllProduct();
                    }
                }
            }
        }
        public void SearchByName()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                int currentUserId = Convert.ToInt32(lbl_UserId.Text);
                var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();

                var query = context.Products.Where(y => y.Status == (int)Status.Active && y.Name.Contains(txb_SearchName.Text)).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.UserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();

                
                dgw_ProductTable.DataSource = query;

            }
        }
        public void UserSearchByName()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                int currentUserId = Convert.ToInt32(lbl_UserId.Text);
                var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();

                var query = context.Products.Where(y => y.Status == (int)Status.Active && y.UserId == currentUserId &&
                y.Name.Contains(txb_SearchNameByUSer.Text)).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.UserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();

                //var search = query.Where(p => p.Name.Contains(txb_SearchNameByUSer.Text)).ToList();
                dgw_ProductTable.DataSource = query;

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
                    product.UserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();
                if (cmb_SearchCategory.SelectedIndex != 0)
                {
                    var search = query.Where(product => product.CategoryId == Convert.ToInt32(cmb_SearchCategory.Text.Split('.')[0])).ToList();
                    dgw_ProductTable.DataSource = search;

                }
                else
                {
                    dgw_ProductTable.DataSource = query;
                }



            }
        }

        private void SearchCategory()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                int currentUserId = Convert.ToInt32(lbl_UserId.Text);
                var currentUser = context.Users.Where(y => y.Id == currentUserId).FirstOrDefault();
                var query = context.Products.Where(y => y.Status == (int)Status.Active && y.UserId == currentUserId).Select(product => new
                {


                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.UserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();
                if (cmb_SearchByUserCategory.SelectedIndex != 0)
                {
                    var search = query.Where(product => product.CategoryId == Convert.ToInt32(cmb_SearchByUserCategory.Text.Split('.')[0])).ToList();
                    dgw_ProductTable.DataSource = search;
                }
                else
                {
                    dgw_ProductTable.DataSource = query;
                }
            }
        }
        private void txb_SearchName_TextChanged(object sender, EventArgs e)
        {
           
            SearchByName();
        }

        private void cmb_SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SearchCategoryAdmin();
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            
            GetAllProduct();
            cmb_SearchCategory.SelectedIndex = 0;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
          
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
                    product.UserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();

                if (!String.IsNullOrEmpty(txb_SearchDetailName.Text))
                {
                    query = query.Where(x => x.Name.ToLower().Contains(txb_SearchDetailName.Text.ToLower())).ToList();
                }
                if (!String.IsNullOrEmpty(txbSearchPrice.Text))
                {
                    query = query.Where(x => x.Price == Convert.ToDecimal(txbSearchPrice.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(txbSerachCount.Text))
                {
                    query = query.Where(x => x.Count == Convert.ToInt32(txbSerachCount.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(cmb_User.Text) && cmb_User.SelectedIndex!=0)
                {
                    query = query.Where(x => x.UserId == Convert.ToInt32(cmb_User.Text.Split('.')[0])).ToList();
                }
                if (!String.IsNullOrEmpty(cmb_SearchDetail.Text ) && cmb_SearchDetail.SelectedIndex != 0)
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
                var query = context.Products.Where(y => y.Status == (int)Status.Active && y.UserId == currentUserId).Select(product => new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Count,
                    Category = product.Category.Name,
                    product.CategoryId,
                    product.Status,
                    product.UserId,
                    product.PhoneNumber,
                    product.SoldedCount

                }).ToList();

                if (!String.IsNullOrEmpty(txb_SearchDetailName.Text))
                {
                    query = query.Where(x => x.Name.ToLower().Contains(txb_SearchDetailName.Text.ToLower())).ToList();
                }
                if (!String.IsNullOrEmpty(txbSearchPrice.Text))
                {
                    query = query.Where(x => x.Price == Convert.ToDecimal(txbSearchPrice.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(txbSerachCount.Text))
                {
                    query = query.Where(x => x.Count == Convert.ToInt32(txbSerachCount.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(cmb_User.Text))
                {
                    query = query.Where(x => x.UserId == Convert.ToInt32(cmb_User.Text.Split('.')[0])).ToList();
                }
                if (!String.IsNullOrEmpty(cmb_SearchDetail.Text))
                {
                    query = query.Where(x => x.CategoryId == Convert.ToInt32(cmb_SearchDetail.Text.Split('.')[0])).ToList();
                }
                dgw_ProductTable.DataSource = query;



            }
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
            cmb_SearchByUserCategory.SelectedIndex = 0;
            GetProductInsertedByUser();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
