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
    public partial class NewReport : Form
    {

        public ClassCategoriesContainer classCategoriesContainer = new ClassCategoriesContainer();
        public ClassCategory classCategoryReportList = new ClassCategory();
        ClassInformationForm classInformationForm;

        public NewReport(ClassInformationForm parent)
        {
            InitializeComponent();
            classInformationForm = parent;
        }

        private void scoreTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch!= '.' || !Decimal.TryParse(scoreTextBox1.Text+ch, out x))
            {
                 e.Handled = true;
            }
           
        }

        private void scoreTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(scoreTextBox2.Text + ch, out x))
            {
                e.Handled = true;
            }

        }

        private void newReportCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newReportConfirmButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(reportNameLabel.Text) || String.IsNullOrEmpty(scoreTextBox1.Text) || String.IsNullOrEmpty(scoreTextBox2.Text))
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                string droppedText = "";
                if (droppedCheckBox.Checked == true)
                {
                    droppedText = "Dropped";
                }
                classCategoryReportList.gradeReportList.Add(new GradeReport { gradeReportName = reportNameTextBox.Text, gradeReportScore =  float.Parse(scoreTextBox1.Text), maxPoints = Int32.Parse(scoreTextBox2.Text), droppedString = droppedText});
                int categoryIndex = classInformationForm.gradeCategoriesListBox.SelectedIndex;
                classInformationForm.viewCategoryButton_Click(sender, e);
                classInformationForm.UpdateInformation(sender, e);
                classInformationForm.gradeCategoriesListBox.SelectedIndex = categoryIndex;
                classInformationForm.gradeReportListBox.SelectedIndex = -1;
                
                this.Close();
            }
        }
            

        private void NewReport_Load(object sender, EventArgs e)
        {

        }

        private void scoreTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void droppedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
