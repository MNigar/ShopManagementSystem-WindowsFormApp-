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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            SetCategory();
        }
        ICategoryRepository repository;
        IProductRepository productRepository;
        private void dgw_ProductTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

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
        public void funData(TextBox txtForm1)
        {
            textBox1.Text = txtForm1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                productRepository = new ProductRepository(context);
                int userid = Convert.ToInt32(textBox1.Text);
                var user = context.Users.Where(y => y.Id == userid).FirstOrDefault();
                Product pr = new Product()
                {
                    Name = tbx_productName.Text,
                    CategoryId = Convert.ToInt32(cmb_Category.Text.Split('.')[0]),
                    Price = Convert.ToInt32(txb_Price.Text),
                    Count = Convert.ToInt32(txb_Count.Text),
                    CreatedUserId = user.Id,
                    PhoneNumber = user.Phone,
                    Status = 0
                };
                productRepository.Insert(pr);
            }
        }
    }
}
