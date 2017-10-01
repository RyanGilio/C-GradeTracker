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
    public partial class NewClass : Form
    {
        public ClassContainer newClassContainer = new ClassContainer();

        public NewClass()
        {
            InitializeComponent();
            
        }

        private void NewClass_Load(object sender, EventArgs e)
        {

        }

        private void newClassTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void newClassButtonConfirm_Click(object sender, EventArgs e)
        {
            if (newClassTextBox.Text == "")
            {
                MessageBox.Show("Please enter something into the field.");
                return; 
            }
            newClassContainer.classCategoriesContainer.Add(new ClassCategoriesContainer { className = newClassTextBox.Text, classContainerList = new List<ClassCategory>() });
            newClassContainer.AcceptChanges();
            this.Close();
        }

        private void newClassTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newClassButtonConfirm_Click(sender, e);
            }
        }

        private void NewClass_Load_1(object sender, EventArgs e)
        {

        }

        
        
       
    }
}
