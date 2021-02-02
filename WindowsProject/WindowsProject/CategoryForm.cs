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
using WindowsProject.Models;

namespace WindowsProject
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            dgw_Table.DataSource = GetAll();
        }


        Categoryclass dbclass = new Categoryclass();

        private void CategoryForm_Load(object sender, EventArgs e)
        {

            
        }
        private List<Category> GetAll()
        {
            return dbclass.GetAll();
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                Name = txb_Name.Text
            };
            dbclass.Insert(category);

        }
    }
}
