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

namespace WindowsProject.Controls
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            GetAll();
          
        }
        ICategoryRepository repository;



        


        private void GetAll()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                repository = new CategoryRepository(context);
                var query = repository.GetAll();
                var t = query.Where(y => y.Status == 0).ToList();
                dgw_Table.DataSource = t;
            }
        }
        private void btn_Insert_Click_1(object sender, EventArgs e)
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {
                repository = new CategoryRepository(context);
                Category category = new Category()
                {
                    Name = txb_Name.Text,
                    Status = 0
                };
                repository.Insert(category);
                repository.Save();
                GetAll();
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
                    Name = txb_Name.Text,
                };
                repository.Update(book);
                repository.Save();
                GetAll();
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
                repository.Save();
                GetAll();
            }
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void txb_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgw_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_Name.Text = dgw_Table.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
