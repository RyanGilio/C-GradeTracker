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
using Microsoft.VisualBasic;
using System.IO;

namespace Grade_Tracker
{
    public partial class Form1 : Form
    {
        //ClassContainer is the object that holds the list of classes, it's tied to the classesListBox
        private ClassContainer classContainer = new ClassContainer();

        //classesBinding is used for binding the list in the class container to the listBox
        BindingSource classesBinding = new BindingSource();

        //This string is used for save and load functions, because of this it's a global variable
        private string fileName = "";


        public Form1()
        {
            //Default initialization
            InitializeComponent();

            //Adding the ContextMenuStrip to the listBox upon initialization
            classesListBox.ContextMenuStrip = contextMenuStrip1;
        }

        //Untouched
        private void Form1_Load(object sender, EventArgs e)
        {       
        }


        /// <summary>
        /// Created method that takes the classesBinding and updates the information by setting the datasource to null and readding the new information
        /// </summary>
        private void updateInformation()
        {
            classesBinding.DataSource = null;
            classesBinding.DataSource = classContainer.classCategoriesContainer;
            classesListBox.DataSource = classesBinding;

            classesListBox.DisplayMember = "Display";
            classesListBox.ValueMember = "Display";
        }

        //Untouched
        private void classesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// newClassbutton_Click creaets a NewClass form and does a show dialog so the parent window can't be interacted with.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newClassButton_Click(object sender, EventArgs e)
        {
            NewClass newClassForm = new NewClass();
            newClassForm.newClassContainer = classContainer;
            classContainer.AcceptedChanges += new EventHandler(classContainer_AcceptedChanges);
            newClassForm.ShowDialog();
        }


        /// <summary>
        /// Redundant updateInformation method, might look into removing this for readability.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classContainer_AcceptedChanges(object sender, EventArgs e)
        {
            
            classesListBox.DataSource = null; //Important to refresh, this took me way too long to figure out
            classesBinding.DataSource = classContainer.classCategoriesContainer;
            classesListBox.DataSource = classesBinding;

            classesListBox.DisplayMember = "Display";
            classesListBox.ValueMember = "Display";
            classesBinding.EndEdit();
            
        }


        /// <summary>
        /// removeClassbutton, deletes the currently selected item in the listBox or displays a messageBox if nothing is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeClassButton_Click(object sender, EventArgs e)
        {
            //If there is something selected in the ListBox then
            if (classesListBox.SelectedItem != null)
            {
                //Display a messagebox
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + classContainer.classCategoriesContainer[classesListBox.SelectedIndex].className, "Delete Class Confirmation", MessageBoxButtons.YesNoCancel);

                // If the result of the message box is not yes, return.
                if (dr != DialogResult.Yes)
                {
                    return;
                }
                //Otherwise remove the item and update the changes
                classesBinding.Remove(classesListBox.SelectedItem);
                classContainer_AcceptedChanges(sender, e);
            }
            //Otherwise show a message box
            else
            {
                MessageBox.Show("A class needs to be selected before it can be removed.");
            }
        }

        /// <summary>
        /// On form exit, the user will be prompted if they want to save before exiting the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save before quitting?", "Grade Tracker", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                //If the file has no name then run save_as
                if (fileName == "")
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                //Otherwise save file
                else
                {
                    saveClasses();
                }
            }
            //On option cancel, keep form open, otherwise close without saving
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            
        }


        private void editClassButton_Click(object sender, EventArgs e)
        {
            if (classesListBox.SelectedItem != null)
            {
                string newName = Microsoft.VisualBasic.Interaction.InputBox("New class name?");
                classContainer.classCategoriesContainer[classesListBox.SelectedIndex].className = newName;
                classContainer_AcceptedChanges(sender, e);
            }
            else
            {
                MessageBox.Show("A class needs to be selected before it can be edited.", "Grade Tracker");

            }
        }

        private void viewClassButton_Click(object sender, EventArgs e)
        {
            ClassInformationForm classInformationForm = new ClassInformationForm();
            if (classesListBox.SelectedItem != null)
            {
                
                classInformationForm.classCategoriesContainer = classContainer.classCategoriesContainer[classesListBox.SelectedIndex];
                classInformationForm.classInformationNameLabel.Text = classContainer.classCategoriesContainer[classesListBox.SelectedIndex].className;
                classInformationForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("A class needs to be selected before it can be viewed.", "Grade Tracker");
            }

            
        }


        private void saveClasses()
        {
            List<String> classInformation = new List<string>();            
            if (fileName != "")
            {
                FileStream fileCreate = File.Open(fileName, FileMode.Create);
                StreamWriter writeFile = new StreamWriter(fileCreate);
                int classContainerIterator = 0;
                int gradeCategoriesIterator = 0;
                int reportListIterator = 0;
                while (classContainerIterator < classContainer.classCategoriesContainer.Count)
                {
                    classInformation.Add("Class");
                    classInformation.Add(classContainer.classCategoriesContainer[classContainerIterator].className.ToString());
                    while (gradeCategoriesIterator < classContainer.classCategoriesContainer[classContainerIterator].classContainerList.Count)
                    {
                        classInformation.Add("Category");
                        classInformation.Add(classContainer.classCategoriesContainer[classContainerIterator].classContainerList[gradeCategoriesIterator].categoryName.ToString()
                                            + "," +
                                             classContainer.classCategoriesContainer[classContainerIterator].classContainerList[gradeCategoriesIterator].categoryWeight.ToString());
                        while (reportListIterator < classContainer.classCategoriesContainer[classContainerIterator].classContainerList[gradeCategoriesIterator].gradeReportList.Count)
                        {
                            classInformation.Add("Report");
                            classInformation.Add(classContainer.classCategoriesContainer[classContainerIterator].classContainerList[gradeCategoriesIterator].gradeReportList[reportListIterator].gradeReportName.ToString()
                                                + "," +
                                                classContainer.classCategoriesContainer[classContainerIterator].classContainerList[gradeCategoriesIterator].gradeReportList[reportListIterator].gradeReportScore.ToString()
                                                + "," +
                                                classContainer.classCategoriesContainer[classContainerIterator].classContainerList[gradeCategoriesIterator].gradeReportList[reportListIterator].maxPoints.ToString()
                                                + "," +
                                                classContainer.classCategoriesContainer[classContainerIterator].classContainerList[gradeCategoriesIterator].gradeReportList[reportListIterator].droppedString);
                            reportListIterator++;
                        }
                        gradeCategoriesIterator++;
                        reportListIterator = 0;
                    }
                    classContainerIterator++;
                    gradeCategoriesIterator = 0;
                }
                for (int i = 0; i < classInformation.Count; i++)
                {
                    writeFile.WriteLine(classInformation[i]);
                }
                writeFile.Close();
            }
        }

        private void loadClasses()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = Path.GetExtension(openFileDialog1.FileName);
                if (ext != ".gttxt")
                {
                    MessageBox.Show("Unknown extension, please select a file with a .gttxt extension");

                }
                else
                {
                    fileName = openFileDialog1.FileName;
                    StreamReader readFile = new StreamReader(openFileDialog1.FileName);
                    string line = "";
                    string readClassName = "";
                    int index_1 = 0;
                    int index_2 = 0;
                    int onFirstRun = 0;
                    line = readFile.ReadLine();
                    while (line != null)
                    {
                        if (line == "Class")
                        {
                            readClassName = readFile.ReadLine();
                            classContainer.classCategoriesContainer.Add(new ClassCategoriesContainer { className = readClassName, classContainerList = new List<GradeTrackerLibrary.ClassCategory>() });
                            line = readFile.ReadLine();
                            if (onFirstRun != 0)
                            {
                                index_1++;
                            }
                            onFirstRun++;
                            index_2 = 0;
                        }
                        if (line == "Category")
                        {
                            line = readFile.ReadLine();
                            string newCategory = "";
                            string newWeight = "";
                            string tracker = "";
                            for (int i = 0; i < line.Length; i++)
                            {
                                if (line[i] == ',')
                                {
                                    newCategory = tracker;
                                    tracker = "";
                                    continue;
                                }
                                tracker = tracker + line[i];
                            }
                            newWeight = tracker;
                            classContainer.classCategoriesContainer[index_1].classContainerList.Add(new ClassCategory { categoryName = newCategory, categoryWeight = Int32.Parse(newWeight), gradeReportList = new List<GradeReport>() });
                            line = readFile.ReadLine();


                        }
                        if (line == "Report")
                        {
                            line = readFile.ReadLine();
                            while (line != "Category" && line != "Class" && line != null)
                            {
                                if (line == "Report")
                                {
                                    line = readFile.ReadLine();
                                }
                                string newReportName = "";
                                float newReportScore = 0;
                                int newMaxPoints = 0;
                                string tracker = "";
                                string dropped = "";
                                int condition = 0;
                                for (int i = 0; i < line.Length; i++)
                                {
                                    if (line[i] == ',')
                                    {
                                        if (condition == 0)
                                        {
                                            newReportName = tracker;
                                            condition++;
                                        }
                                        else if (condition == 1)
                                        {
                                            newReportScore = float.Parse(tracker);
                                            condition++;
                                        }
                                        else if (condition == 2)
                                        {
                                            newMaxPoints = Int32.Parse(tracker);
                                            condition++;
                                        }
                                        tracker = "";
                                        continue;
                                    }

                                    tracker = tracker + line[i];
                                }
                                line = readFile.ReadLine();
                                if (condition == 2)
                                {
                                    newMaxPoints = Int32.Parse(tracker);
                                }
                                else
                                {
                                    dropped = tracker;
                                }
                                classContainer.classCategoriesContainer[index_1].classContainerList[index_2].gradeReportList.Add(new GradeReport { gradeReportName = newReportName, gradeReportScore = newReportScore, maxPoints = newMaxPoints, droppedString = dropped });
                            }
                            index_2++;
                        }
                    }
                    readFile.Close();
                    updateInformation();
                    
                }
            }
        }

        private void newClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Create a new Class List? (Current progress will not be saved)", "Create New Class List", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                classContainer = new ClassContainer();
                fileName = "";
                updateInformation();
            }
        }
       

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
            saveClasses();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (classesListBox.SelectedItem == null)
            {
                viewClassToolStripMenuItem.Enabled = false;
                editClassToolStripMenuItem.Enabled = false;
                removeToolStripMenuItem.Enabled = false;
            }
            else
            {
                viewClassToolStripMenuItem.Enabled = true;
                editClassToolStripMenuItem.Enabled = true;
                removeToolStripMenuItem.Enabled = true;
            }
        }

        private void newClassToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newClassButton_Click(sender, e);
        }

        private void viewClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewClassButton_Click(sender, e);     
        }

        private void classesListBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs) e;
            if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                classesListBox.SelectedIndex = classesListBox.IndexFromPoint(me.X, me.Y);
            }
        }

        private void classesListBox_MouseDown(object sender, MouseEventArgs e)
        {
            classesListBox.SelectedIndex = classesListBox.IndexFromPoint(e.X, e.Y);
        }

        private void editClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editClassButton_Click(sender, e);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeClassButton_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GradeTracker\nRelease - Version 1.12\nCreated by - Ryan Gilio");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadClasses();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "GTTX|*.gttxt";
            saveFileDialog1.DefaultExt = ".gttxt";
            saveFileDialog1.ShowDialog();
            fileName = saveFileDialog1.FileName;
            saveClasses();
        }
    }
}
