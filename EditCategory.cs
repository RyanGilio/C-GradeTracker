using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradeTrackerLibrary;

namespace Grade_Tracker
{
    public partial class EditCategory : Form
    {

        public ClassCategoriesContainer tempClassCategoriesContainer = new ClassCategoriesContainer();
        public int index = 0;


        public EditCategory()
        {
            InitializeComponent();
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {

        }

        private void newCategoryConfirmButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(weightedPercentageTextBox.Text) || String.IsNullOrEmpty(categoryTextBox.Text))
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                tempClassCategoriesContainer.classContainerList[index].categoryName = categoryTextBox.Text;
                tempClassCategoriesContainer.classContainerList[index].categoryWeight = Int32.Parse(weightedPercentageTextBox.Text);
                this.Close();
            }
        }

        private void newCategoryCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
