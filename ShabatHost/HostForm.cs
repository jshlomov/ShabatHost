using ShabatHost.DAL;
using ShabatHost.DAL.Model;
using ShabatHost.DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShabatHost
{
    public partial class HostForm : Form
    {
        CategoryRepository categoryRepository;

        public HostForm(CategoryRepository repository)
        {
            InitializeComponent();
            categoryRepository = repository;
            LoadCategories();
        }

        private void LoadCategories()
        {
            List<CategoryModel> categories = categoryRepository.FindAll();
            listView_viewCategories.Clear();
            foreach (CategoryModel category in categories)
            {
                listView_viewCategories.Items.Add(category.Name);
            }
            //listView_viewCategories.Items.AddRange(categories.Select(category => new ListViewItem(category.CategoryName)).ToArray());
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Category.Text))
            {
                MessageBox.Show("הכנס קטגוריה");
                return;
            }

            try
            {
                bool result = categoryRepository.Insert(new CategoryModel(textBox_Category.Text.ToString(), 0));
                if (!result) MessageBox.Show("לא ניתן להוסיף");

                LoadCategories();
                textBox_Category.Text = "";
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
