namespace Grade_Tracker
{
    partial class ClassInformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassInformationForm));
            this.gradeCategoriesListBox = new System.Windows.Forms.ListBox();
            this.gradeCategoriesListBoxLabel = new System.Windows.Forms.Label();
            this.gradeReportListBox = new System.Windows.Forms.ListBox();
            this.currentGradeLabel = new System.Windows.Forms.Label();
            this.classInformationNameLabel = new System.Windows.Forms.Label();
            this.currentGradeResult = new System.Windows.Forms.Label();
            this.gradeListBoxLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteReportButton = new System.Windows.Forms.Button();
            this.editReportButton = new System.Windows.Forms.Button();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.editCategoryButton = new System.Windows.Forms.Button();
            this.newReportButton = new System.Windows.Forms.Button();
            this.newCategoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeCategoriesListBox
            // 
            this.gradeCategoriesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeCategoriesListBox.FormattingEnabled = true;
            this.gradeCategoriesListBox.Location = new System.Drawing.Point(26, 79);
            this.gradeCategoriesListBox.Name = "gradeCategoriesListBox";
            this.gradeCategoriesListBox.Size = new System.Drawing.Size(135, 262);
            this.gradeCategoriesListBox.TabIndex = 0;
            this.gradeCategoriesListBox.SelectedIndexChanged += new System.EventHandler(this.gradeCategoriesListBox_SelectedIndexChanged);
            // 
            // gradeCategoriesListBoxLabel
            // 
            this.gradeCategoriesListBoxLabel.AutoSize = true;
            this.gradeCategoriesListBoxLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gradeCategoriesListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeCategoriesListBoxLabel.Location = new System.Drawing.Point(22, 56);
            this.gradeCategoriesListBoxLabel.Name = "gradeCategoriesListBoxLabel";
            this.gradeCategoriesListBoxLabel.Size = new System.Drawing.Size(90, 18);
            this.gradeCategoriesListBoxLabel.TabIndex = 1;
            this.gradeCategoriesListBoxLabel.Text = "Categories";
            this.gradeCategoriesListBoxLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // gradeReportListBox
            // 
            this.gradeReportListBox.BackColor = System.Drawing.Color.White;
            this.gradeReportListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeReportListBox.FormattingEnabled = true;
            this.gradeReportListBox.Location = new System.Drawing.Point(397, 79);
            this.gradeReportListBox.Name = "gradeReportListBox";
            this.gradeReportListBox.Size = new System.Drawing.Size(210, 262);
            this.gradeReportListBox.TabIndex = 3;
            this.gradeReportListBox.SelectedIndexChanged += new System.EventHandler(this.gradeReportListBox_SelectedIndexChanged);
            // 
            // currentGradeLabel
            // 
            this.currentGradeLabel.AutoSize = true;
            this.currentGradeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.currentGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGradeLabel.Location = new System.Drawing.Point(159, 370);
            this.currentGradeLabel.Name = "currentGradeLabel";
            this.currentGradeLabel.Size = new System.Drawing.Size(194, 29);
            this.currentGradeLabel.TabIndex = 8;
            this.currentGradeLabel.Text = "Current Grade -";
            // 
            // classInformationNameLabel
            // 
            this.classInformationNameLabel.AutoSize = true;
            this.classInformationNameLabel.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classInformationNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.classInformationNameLabel.Location = new System.Drawing.Point(201, 14);
            this.classInformationNameLabel.Name = "classInformationNameLabel";
            this.classInformationNameLabel.Size = new System.Drawing.Size(178, 36);
            this.classInformationNameLabel.TabIndex = 13;
            this.classInformationNameLabel.Text = "Class Name";
            // 
            // currentGradeResult
            // 
            this.currentGradeResult.AutoSize = true;
            this.currentGradeResult.BackColor = System.Drawing.SystemColors.Control;
            this.currentGradeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGradeResult.Location = new System.Drawing.Point(349, 370);
            this.currentGradeResult.Name = "currentGradeResult";
            this.currentGradeResult.Size = new System.Drawing.Size(64, 29);
            this.currentGradeResult.TabIndex = 15;
            this.currentGradeResult.Text = "0  %";
            this.currentGradeResult.Click += new System.EventHandler(this.currentGradeResult_Click);
            // 
            // gradeListBoxLabel
            // 
            this.gradeListBoxLabel.AutoSize = true;
            this.gradeListBoxLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gradeListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeListBoxLabel.Location = new System.Drawing.Point(397, 58);
            this.gradeListBoxLabel.Name = "gradeListBoxLabel";
            this.gradeListBoxLabel.Size = new System.Drawing.Size(63, 18);
            this.gradeListBoxLabel.TabIndex = 16;
            this.gradeListBoxLabel.Text = "Grades";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grade_Tracker.Properties.Resources.classInformationForm_listbox_borders_black1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // deleteReportButton
            // 
            this.deleteReportButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteReportButton.Image = global::Grade_Tracker.Properties.Resources.main_UI_Button_remove;
            this.deleteReportButton.Location = new System.Drawing.Point(292, 257);
            this.deleteReportButton.Name = "deleteReportButton";
            this.deleteReportButton.Size = new System.Drawing.Size(99, 40);
            this.deleteReportButton.TabIndex = 12;
            this.deleteReportButton.Text = "Delete Grade";
            this.deleteReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteReportButton.UseVisualStyleBackColor = true;
            this.deleteReportButton.Click += new System.EventHandler(this.deleteReportButton_Click);
            // 
            // editReportButton
            // 
            this.editReportButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editReportButton.Image = global::Grade_Tracker.Properties.Resources.main_UI_Button_edit;
            this.editReportButton.Location = new System.Drawing.Point(292, 180);
            this.editReportButton.Name = "editReportButton";
            this.editReportButton.Size = new System.Drawing.Size(99, 40);
            this.editReportButton.TabIndex = 11;
            this.editReportButton.Text = "Edit Grade";
            this.editReportButton.UseVisualStyleBackColor = true;
            this.editReportButton.Click += new System.EventHandler(this.editReportButton_Click);
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteCategoryButton.Image = global::Grade_Tracker.Properties.Resources.main_UI_Button_remove;
            this.deleteCategoryButton.Location = new System.Drawing.Point(167, 257);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(99, 40);
            this.deleteCategoryButton.TabIndex = 10;
            this.deleteCategoryButton.Text = "Delete";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.editCategoryButton.Image = global::Grade_Tracker.Properties.Resources.main_UI_Button_edit;
            this.editCategoryButton.Location = new System.Drawing.Point(167, 180);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(99, 40);
            this.editCategoryButton.TabIndex = 9;
            this.editCategoryButton.Text = "Edit Category";
            this.editCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editCategoryButton.UseVisualStyleBackColor = true;
            this.editCategoryButton.Click += new System.EventHandler(this.editCategoryButton_Click);
            // 
            // newReportButton
            // 
            this.newReportButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newReportButton.Image = global::Grade_Tracker.Properties.Resources.main_UI_Button_Add_Class;
            this.newReportButton.Location = new System.Drawing.Point(294, 108);
            this.newReportButton.Name = "newReportButton";
            this.newReportButton.Size = new System.Drawing.Size(99, 40);
            this.newReportButton.TabIndex = 5;
            this.newReportButton.Text = "New Grade";
            this.newReportButton.UseVisualStyleBackColor = true;
            this.newReportButton.Click += new System.EventHandler(this.newReportButton_Click);
            // 
            // newCategoryButton
            // 
            this.newCategoryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.newCategoryButton.Image = global::Grade_Tracker.Properties.Resources.main_UI_Button_Add_Class;
            this.newCategoryButton.Location = new System.Drawing.Point(167, 108);
            this.newCategoryButton.Name = "newCategoryButton";
            this.newCategoryButton.Size = new System.Drawing.Size(99, 40);
            this.newCategoryButton.TabIndex = 2;
            this.newCategoryButton.Text = "New Category";
            this.newCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newCategoryButton.UseVisualStyleBackColor = true;
            this.newCategoryButton.Click += new System.EventHandler(this.newCategoryButton_Click);
            // 
            // ClassInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 397);
            this.Controls.Add(this.gradeListBoxLabel);
            this.Controls.Add(this.currentGradeResult);
            this.Controls.Add(this.deleteReportButton);
            this.Controls.Add(this.editReportButton);
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.editCategoryButton);
            this.Controls.Add(this.currentGradeLabel);
            this.Controls.Add(this.newReportButton);
            this.Controls.Add(this.gradeReportListBox);
            this.Controls.Add(this.newCategoryButton);
            this.Controls.Add(this.gradeCategoriesListBoxLabel);
            this.Controls.Add(this.gradeCategoriesListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.classInformationNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClassInformationForm";
            this.Text = "ClassInformationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClassInformationForm_FormClosed);
            this.Load += new System.EventHandler(this.ClassInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gradeCategoriesListBoxLabel;
        private System.Windows.Forms.Button newCategoryButton;
        private System.Windows.Forms.Button newReportButton;
        private System.Windows.Forms.Label currentGradeLabel;
        private System.Windows.Forms.Button editCategoryButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Button editReportButton;
        private System.Windows.Forms.Button deleteReportButton;
        public System.Windows.Forms.Label classInformationNameLabel;
        private System.Windows.Forms.Label currentGradeResult;
        public System.Windows.Forms.ListBox gradeCategoriesListBox;
        public System.Windows.Forms.ListBox gradeReportListBox;
        private System.Windows.Forms.Label gradeListBoxLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}