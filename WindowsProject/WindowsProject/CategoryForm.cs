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
           
        }
        ICategoryRepository repository;

        int user = LoginForm.LoginInfo.UserID;

        private void CategoryForm_Load(object sender, EventArgs e)
        {
           
            
        }
        public void funData(TextBox txtForm1)
        {
            lbl_UserId.Text = txtForm1.Text;
        }
        private void GetAll()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                repository = new CategoryRepository(context);
                dgw_Table.DataSource=  repository.GetAll();

               
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
          
            using (ShopManagementContext context = new ShopManagementContext())
            {
                repository = new CategoryRepository(context);
                Category category = new Category()
                {
                    Name = txb_Name.Text
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void Update(Category book)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {

                //var query = context.Books.Find(book.Id);
                var q = context.Entry(book);
                q.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
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
                var pr = new Product()
                {Id=5,
                    Name = tbx_productName.Text,
                    CategoryId = Convert.ToInt32(cmb_Category.Text.Split('.')[0]),

                    Price = Convert.ToInt32(txb_Price.Text),
                    Count = Convert.ToInt32(txb_Count.Text),
                    CreatedUser = user.Id,
                    PhoneNumber = user.Phone,
                    Status = 0
                };
                productRepository.Insert(pr);
            }






            }

            private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txb_Count_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

