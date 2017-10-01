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
    public partial class EditReport : Form
    {
        public ClassCategoriesContainer tempClassCategoriesContainer = new ClassCategoriesContainer();
        public int categoriesIndex = 0;
        public int reportsIndex = 0;
        ClassInformationForm classInformationForm;

        public EditReport(ClassInformationForm passedForm)
        {
            classInformationForm = passedForm;
            InitializeComponent();
        }

        private void EditReport_Load(object sender, EventArgs e)
        {

        }

        private void newReportConfirmButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(reportNameLabel.Text) || String.IsNullOrEmpty(scoreTextBox1.Text) || String.IsNullOrEmpty(scoreTextBox2.Text))
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                if (droppedCheckBox.Checked == true)
                {
                    tempClassCategoriesContainer.classContainerList[categoriesIndex].gradeReportList[reportsIndex].droppedString = "Dropped";
                }
                else
                {
                    tempClassCategoriesContainer.classContainerList[categoriesIndex].gradeReportList[reportsIndex].droppedString = "";
                }
                tempClassCategoriesContainer.classContainerList[categoriesIndex].gradeReportList[reportsIndex].gradeReportName = reportNameTextBox.Text;
                tempClassCategoriesContainer.classContainerList[categoriesIndex].gradeReportList[reportsIndex].maxPoints = Int32.Parse(scoreTextBox2.Text);
                tempClassCategoriesContainer.classContainerList[categoriesIndex].gradeReportList[reportsIndex].gradeReportScore = float.Parse(scoreTextBox1.Text);

                int getIndex = classInformationForm.gradeCategoriesListBox.SelectedIndex;
                classInformationForm.viewCategoryButton_Click(sender, e);
                classInformationForm.UpdateInformation(sender, e);
                classInformationForm.gradeCategoriesListBox.SelectedIndex = getIndex;
                classInformationForm.gradeReportListBox.SelectedIndex = -1;
                this.Close();
            }
        }

        private void newReportCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
