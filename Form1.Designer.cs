namespace Grade_Tracker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.classesListBoxLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newClassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.editClassButton = new System.Windows.Forms.Button();
            this.viewClassButton = new System.Windows.Forms.Button();
            this.removeClassButton = new System.Windows.Forms.Button();
            this.newClassButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // classesListBox
            // 
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.HorizontalScrollbar = true;
            this.classesListBox.Location = new System.Drawing.Point(14, 64);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.Size = new System.Drawing.Size(255, 264);
            this.classesListBox.TabIndex = 3;
            this.classesListBox.Click += new System.EventHandler(this.classesListBox_Click);
            this.classesListBox.SelectedIndexChanged += new System.EventHandler(this.classesListBox_SelectedIndexChanged);
            this.classesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.classesListBox_MouseDown);
            // 
            // classesListBoxLabel
            // 
            this.classesListBoxLabel.AutoSize = true;
            this.classesListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classesListBoxLabel.Location = new System.Drawing.Point(115, 24);
            this.classesListBoxLabel.Name = "classesListBoxLabel";
            this.classesListBoxLabel.Size = new System.Drawing.Size(182, 29);
            this.classesListBoxLabel.TabIndex = 4;
            this.classesListBoxLabel.Text = "Grade Tracker";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClassToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newClassToolStripMenuItem
            // 
            this.newClassToolStripMenuItem.Name = "newClassToolStripMenuItem";
            this.newClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newClassToolStripMenuItem.Text = "&New Class List";
            this.newClassToolStripMenuItem.Click += new System.EventHandler(this.newClassToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save_As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Load";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionToolStripMenuItem.Text = "Options";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClassToolStripMenuItem1,
            this.viewClassToolStripMenuItem,
            this.editClassToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // newClassToolStripMenuItem1
            // 
            this.newClassToolStripMenuItem1.Name = "newClassToolStripMenuItem1";
            this.newClassToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.newClassToolStripMenuItem1.Text = "New Class";
            this.newClassToolStripMenuItem1.Click += new System.EventHandler(this.newClassToolStripMenuItem1_Click);
            // 
            // viewClassToolStripMenuItem
            // 
            this.viewClassToolStripMenuItem.Name = "viewClassToolStripMenuItem";
            this.viewClassToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.viewClassToolStripMenuItem.Text = "View Class";
            this.viewClassToolStripMenuItem.Click += new System.EventHandler(this.viewClassToolStripMenuItem_Click);
            // 
            // editClassToolStripMenuItem
            // 
            this.editClassToolStripMenuItem.Name = "editClassToolStripMenuItem";
            this.editClassToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.editClassToolStripMenuItem.Text = "Edit Class";
            this.editClassToolStripMenuItem.Click += new System.EventHandler(this.editClassToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // editClassButton
            // 
            this.editClassButton.ForeColor = System.Drawing.Color.White;
            this.editClassButton.Image = global::Grade_Tracker.Properties.Resources.main_UI_Button_edit;
            this.editClassButton.Location = new System.Drawing.Point(302, 209);
            this.editClassButton.Name = "editClassButton";
            this.editClassButton.Size = new System.Drawing.Size(99, 40);
            this.editClassButton.TabIndex = 5;
            this.editClassButton.Text = "Edit";
            this.editClassButton.UseVisualStyleBackColor = true;
            this.editClassButton.Click += new System.EventHandler(this.editClassButton_Click);
            // 
            // viewClassButton
            // 
            this.viewClassButton.ForeColor = System.Drawing.Color.White;
            this.viewClassButton.Image = global::Grade_Tracker.Properties.Resources.main_UI_Button_view;
            this.viewClassButton.Location = new System.Drawing.Point(302, 132);
            this.viewClassButton.Name = "viewClassButton";
            this.viewClassButton.Size = new System.Drawing.Size(99, 40);
            this.viewClassButton.TabIndex = 2;
            this.viewClassButton.Text = "View";
            this.viewClassButton.UseVisualStyleBackColor = true;
            this.viewClassButton.Click += new System.EventHandler(this.viewClassButton_Click);
            // 
            // removeClassButton
            // 
            this.removeClassButton.ForeColor = System.Drawing.Color.White;
            this.removeClassButton.Image = global::Grade_Tracker.Properties.Resources.main_UI_Button_remove;
            this.removeClassButton.Location = new System.Drawing.Point(302, 288);
            this.removeClassButton.Name = "removeClassButton";
            this.removeClassButton.Size = new System.Drawing.Size(99, 40);
            this.removeClassButton.TabIndex = 1;
            this.removeClassButton.Text = "Remove";
            this.removeClassButton.UseVisualStyleBackColor = true;
            this.removeClassButton.Click += new System.EventHandler(this.removeClassButton_Click);
            // 
            // newClassButton
            // 
            this.newClassButton.ForeColor = System.Drawing.Color.White;
            this.newClassButton.Image = global::Grade_Tracker.Properties.Resources.main_UI_Button_Add_Class;
            this.newClassButton.Location = new System.Drawing.Point(302, 55);
            this.newClassButton.Name = "newClassButton";
            this.newClassButton.Size = new System.Drawing.Size(99, 40);
            this.newClassButton.TabIndex = 0;
            this.newClassButton.Text = "New Class";
            this.newClassButton.UseVisualStyleBackColor = true;
            this.newClassButton.Click += new System.EventHandler(this.newClassButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grade_Tracker.Properties.Resources.main_UI_listbox_border1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(427, 346);
            this.Controls.Add(this.editClassButton);
            this.Controls.Add(this.classesListBox);
            this.Controls.Add(this.viewClassButton);
            this.Controls.Add(this.removeClassButton);
            this.Controls.Add(this.newClassButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.classesListBoxLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Grade Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newClassButton;
        private System.Windows.Forms.Button removeClassButton;
        private System.Windows.Forms.Button viewClassButton;
        private System.Windows.Forms.Button editClassButton;
        public System.Windows.Forms.Label classesListBoxLabel;
        public System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newClassToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

