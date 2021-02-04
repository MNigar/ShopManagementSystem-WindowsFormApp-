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
            SetJanr();
        }
        ICategoryRepository repository;

       

        private void CategoryForm_Load(object sender, EventArgs e)
        {

            
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

        private void SetJanr()
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
    }
}
