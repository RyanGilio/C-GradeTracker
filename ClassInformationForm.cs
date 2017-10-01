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
    public partial class ClassInformationForm : Form
    {
        BindingSource categoriesBinding = new BindingSource();
        BindingSource reportsBinding = new BindingSource();

        public int sumOfGradeWeights = 0;

        public ClassCategoriesContainer classCategoriesContainer = new ClassCategoriesContainer();

        public ClassInformationForm()
        {
            InitializeComponent();
        }

        private void ClassInformationForm_Load(object sender, EventArgs e)
        {
            UpdateInformation(sender, e);
            viewCategoryButton_Click(sender, e);
            if (gradeReportListBox.SelectedItem == null)
            {
                deleteReportButton.Enabled = false;
                editReportButton.Enabled = false;
            }
            gradeReportListBox.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gradeCategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewCategoryButton_Click(sender, e);
            gradeReportListBox.SelectedIndex = -1;

        }

        private void ClassInformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void newCategoryButton_Click(object sender, EventArgs e)
        {
            NewCategory tempCategoryForm = new NewCategory(this);
            tempCategoryForm.tempClassCategoriesContainer = classCategoriesContainer;
            tempCategoryForm.ShowDialog();
        }

        public void UpdateInformation(object sender, EventArgs e)
        {
            categoriesBinding.DataSource = null;
            categoriesBinding.DataSource = classCategoriesContainer.classContainerList;
            gradeCategoriesListBox.DataSource = categoriesBinding;

            gradeCategoriesListBox.DisplayMember = "Display";
            gradeCategoriesListBox.ValueMember = "Display";

            int index_box1 = 0;
            int index_box2 = 0;
            float sumOfScores = 0F;
            float sumOfMaxPoints = 0F;
            float weightedGrade = 0F;
            sumOfGradeWeights = 0;

            while (index_box1 < classCategoriesContainer.classContainerList.Count)
            {
                index_box2 = 0;
                sumOfScores = 0F;
                sumOfMaxPoints = 0F;
                sumOfGradeWeights = sumOfGradeWeights + Int32.Parse(classCategoriesContainer.classContainerList[index_box1].categoryWeight.ToString());

                while (index_box2 < classCategoriesContainer.classContainerList[index_box1].gradeReportList.Count)
                {
                    if (classCategoriesContainer.classContainerList[index_box1].gradeReportList[index_box2].droppedString != "Dropped")
                    {
                        sumOfMaxPoints = sumOfMaxPoints + Int32.Parse(classCategoriesContainer.classContainerList[index_box1].gradeReportList[index_box2].maxPoints.ToString());
                        sumOfScores = sumOfScores + float.Parse(classCategoriesContainer.classContainerList[index_box1].gradeReportList[index_box2].gradeReportScore.ToString());
                    }
                    
                    index_box2++;
                }
                if (sumOfMaxPoints != 0)
                {
                    weightedGrade = weightedGrade + (sumOfScores / sumOfMaxPoints) * Int32.Parse(classCategoriesContainer.classContainerList[index_box1].categoryWeight.ToString());
                }
                index_box1++;
            }
            
            currentGradeResult.Text = weightedGrade.ToString("0.00") + "%";
            
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            
            if  (gradeCategoriesListBox.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex].categoryName , "Delete Class Confirmation", MessageBoxButtons.YesNoCancel);
                if (dr != DialogResult.Yes)
                {
                    return;
                }
                categoriesBinding.Remove(gradeCategoriesListBox.SelectedItem);
                UpdateInformation(sender, e);
                reportsBinding.DataSource = null;
                gradeReportListBox.DataSource = reportsBinding;

                gradeReportListBox.DisplayMember = "";
                gradeReportListBox.ValueMember = "";
                
            }
            else
            {
                MessageBox.Show("A class needs to be selected before it can be removed.");
            }
        }

        public void viewCategoryButton_Click(object sender, EventArgs e)
        {
            if (gradeCategoriesListBox.SelectedItem != null)
            {
                reportsBinding.DataSource = null;
                reportsBinding.DataSource = classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex].gradeReportList;
                gradeReportListBox.DataSource = reportsBinding;

                gradeReportListBox.DisplayMember = "Display";
                gradeReportListBox.ValueMember = "Display";
            }
        }

        private void newReportButton_Click(object sender, EventArgs e)
        {
            if (gradeCategoriesListBox.SelectedItem != null)
            {
                NewReport newReportForm = new NewReport(this);
                newReportForm.classCategoryReportList = classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex];
                newReportForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a category first.");
            }
        }

        private void gradeReportListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gradeReportListBox.SelectedItem != null)
            {
                deleteReportButton.Enabled = true;
                editReportButton.Enabled = true;
            }
            else
            {
                deleteReportButton.Enabled = false;
                editReportButton.Enabled = false;
            }
        }

        private void editCategoryButton_Click(object sender, EventArgs e)
        {
            EditCategory editCategoryForm = new EditCategory();
            editCategoryForm.categoryTextBox.Text = classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex].categoryName;
            editCategoryForm.weightedPercentageTextBox.Text =  classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex].categoryWeight.ToString();
            editCategoryForm.tempClassCategoriesContainer = classCategoriesContainer;
            editCategoryForm.index = gradeCategoriesListBox.SelectedIndex;

            editCategoryForm.ShowDialog();
        }

        private void editReportButton_Click(object sender, EventArgs e)
        {
            EditReport editReportForm = new EditReport(this);
            if (gradeReportListBox.SelectedItem != null)
            {
                editReportForm.reportNameTextBox.Text = classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex].gradeReportList[gradeReportListBox.SelectedIndex].gradeReportName;
                editReportForm.scoreTextBox1.Text = classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex].gradeReportList[gradeReportListBox.SelectedIndex].gradeReportScore.ToString();
                editReportForm.scoreTextBox2.Text = classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex].gradeReportList[gradeReportListBox.SelectedIndex].maxPoints.ToString();

                editReportForm.tempClassCategoriesContainer = classCategoriesContainer;
                editReportForm.categoriesIndex = gradeCategoriesListBox.SelectedIndex;
                editReportForm.reportsIndex = gradeReportListBox.SelectedIndex;
                if (classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex].gradeReportList[gradeReportListBox.SelectedIndex].droppedString == "Dropped")
                {
                    editReportForm.droppedCheckBox.CheckState = CheckState.Checked;
                }
                
                editReportForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a report to edit.");
            }
                
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateInformation(sender, e);      
        }

        private void deleteReportButton_Click(object sender, EventArgs e)
        {
            if (gradeReportListBox.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this report?", "Delete Report", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    reportsBinding.Remove(classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex].gradeReportList[gradeReportListBox.SelectedIndex]);
                    reportsBinding.DataSource = null;
                    reportsBinding.DataSource = classCategoriesContainer.classContainerList[gradeCategoriesListBox.SelectedIndex].gradeReportList;
                    gradeReportListBox.DataSource = reportsBinding;

                    gradeReportListBox.DisplayMember = "Display";
                    gradeReportListBox.ValueMember = "Display";
                    gradeReportListBox.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Please select a report to delete");
            }   
        }

        private void currentGradeResult_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
