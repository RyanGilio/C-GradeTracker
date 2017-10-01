namespace Grade_Tracker
{
    partial class NewCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCategory));
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBoxLabel = new System.Windows.Forms.Label();
            this.weightedPercentageTextBoxLabel = new System.Windows.Forms.Label();
            this.weightedPercentageTextBox = new System.Windows.Forms.TextBox();
            this.percentSymbolTextLabel = new System.Windows.Forms.Label();
            this.newCategoryConfirmButton = new System.Windows.Forms.Button();
            this.newCategoryCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.AcceptsTab = true;
            this.categoryTextBox.Location = new System.Drawing.Point(104, 18);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 0;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // categoryTextBoxLabel
            // 
            this.categoryTextBoxLabel.AutoSize = true;
            this.categoryTextBoxLabel.Location = new System.Drawing.Point(9, 25);
            this.categoryTextBoxLabel.Name = "categoryTextBoxLabel";
            this.categoryTextBoxLabel.Size = new System.Drawing.Size(80, 13);
            this.categoryTextBoxLabel.TabIndex = 1;
            this.categoryTextBoxLabel.Text = "Category Name";
            this.categoryTextBoxLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // weightedPercentageTextBoxLabel
            // 
            this.weightedPercentageTextBoxLabel.AutoSize = true;
            this.weightedPercentageTextBoxLabel.Location = new System.Drawing.Point(48, 68);
            this.weightedPercentageTextBoxLabel.Name = "weightedPercentageTextBoxLabel";
            this.weightedPercentageTextBoxLabel.Size = new System.Drawing.Size(41, 13);
            this.weightedPercentageTextBoxLabel.TabIndex = 3;
            this.weightedPercentageTextBoxLabel.Text = "Weight";
            // 
            // weightedPercentageTextBox
            // 
            this.weightedPercentageTextBox.Location = new System.Drawing.Point(104, 61);
            this.weightedPercentageTextBox.Name = "weightedPercentageTextBox";
            this.weightedPercentageTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightedPercentageTextBox.TabIndex = 2;
            this.weightedPercentageTextBox.TextChanged += new System.EventHandler(this.weightedPercentageTextBox_TextChanged);
            this.weightedPercentageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightedPercentageTextBox_KeyPress);
            // 
            // percentSymbolTextLabel
            // 
            this.percentSymbolTextLabel.AutoSize = true;
            this.percentSymbolTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentSymbolTextLabel.Location = new System.Drawing.Point(204, 63);
            this.percentSymbolTextLabel.Name = "percentSymbolTextLabel";
            this.percentSymbolTextLabel.Size = new System.Drawing.Size(19, 15);
            this.percentSymbolTextLabel.TabIndex = 4;
            this.percentSymbolTextLabel.Text = "%";
            // 
            // newCategoryConfirmButton
            // 
            this.newCategoryConfirmButton.Location = new System.Drawing.Point(129, 110);
            this.newCategoryConfirmButton.Name = "newCategoryConfirmButton";
            this.newCategoryConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.newCategoryConfirmButton.TabIndex = 5;
            this.newCategoryConfirmButton.Text = "Confirm";
            this.newCategoryConfirmButton.UseVisualStyleBackColor = true;
            this.newCategoryConfirmButton.Click += new System.EventHandler(this.newCategoryConfirmButton_Click);
            // 
            // newCategoryCloseButton
            // 
            this.newCategoryCloseButton.Location = new System.Drawing.Point(32, 110);
            this.newCategoryCloseButton.Name = "newCategoryCloseButton";
            this.newCategoryCloseButton.Size = new System.Drawing.Size(75, 23);
            this.newCategoryCloseButton.TabIndex = 6;
            this.newCategoryCloseButton.Text = "Close";
            this.newCategoryCloseButton.UseVisualStyleBackColor = true;
            this.newCategoryCloseButton.Click += new System.EventHandler(this.newCategoryCloseButton_Click);
            // 
            // NewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 145);
            this.Controls.Add(this.newCategoryCloseButton);
            this.Controls.Add(this.newCategoryConfirmButton);
            this.Controls.Add(this.percentSymbolTextLabel);
            this.Controls.Add(this.weightedPercentageTextBoxLabel);
            this.Controls.Add(this.weightedPercentageTextBox);
            this.Controls.Add(this.categoryTextBoxLabel);
            this.Controls.Add(this.categoryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewCategory";
            this.Text = "NewCategory";
            this.Load += new System.EventHandler(this.NewCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label categoryTextBoxLabel;
        private System.Windows.Forms.Label weightedPercentageTextBoxLabel;
        private System.Windows.Forms.TextBox weightedPercentageTextBox;
        private System.Windows.Forms.Label percentSymbolTextLabel;
        private System.Windows.Forms.Button newCategoryConfirmButton;
        private System.Windows.Forms.Button newCategoryCloseButton;
    }
}