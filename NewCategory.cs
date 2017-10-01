using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using GradeTrackerLibrary;

namespace Grade_Tracker
{
    public partial class NewCategory : Form
    {
        public ClassCategoriesContainer tempClassCategoriesContainer = new ClassCategoriesContainer();
        ClassInformationForm classInformationForm;

        public NewCategory(ClassInformationForm parent)
        {
            this.InitializeComponent();
            classInformationForm = parent;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void weightedPercentageTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        void OnTextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = (string)textBox.Tag;
            }
        }

        private void newCategoryCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void weightedPercentageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void newCategoryConfirmButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(weightedPercentageTextBox.Text) || String.IsNullOrEmpty(categoryTextBox.Text))
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                tempClassCategoriesContainer.classContainerList.Add(new ClassCategory { categoryName = categoryTextBox.Text, categoryWeight = Int32.Parse(weightedPercentageTextBox.Text) });
                classInformationForm.UpdateInformation(sender, e);
                this.Close();
            }
        }

        private void NewCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
