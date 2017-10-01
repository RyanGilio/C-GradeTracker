namespace Grade_Tracker
{
    partial class NewClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewClass));
            this.newClassButtonConfirm = new System.Windows.Forms.Button();
            this.newClassTextBox = new System.Windows.Forms.TextBox();
            this.newClassTextBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newClassButtonConfirm
            // 
            this.newClassButtonConfirm.Location = new System.Drawing.Point(233, 27);
            this.newClassButtonConfirm.Name = "newClassButtonConfirm";
            this.newClassButtonConfirm.Size = new System.Drawing.Size(75, 23);
            this.newClassButtonConfirm.TabIndex = 0;
            this.newClassButtonConfirm.Text = "Confirm";
            this.newClassButtonConfirm.UseVisualStyleBackColor = true;
            this.newClassButtonConfirm.Click += new System.EventHandler(this.newClassButtonConfirm_Click);
            // 
            // newClassTextBox
            // 
            this.newClassTextBox.Location = new System.Drawing.Point(97, 30);
            this.newClassTextBox.Name = "newClassTextBox";
            this.newClassTextBox.Size = new System.Drawing.Size(100, 20);
            this.newClassTextBox.TabIndex = 1;
            this.newClassTextBox.TextChanged += new System.EventHandler(this.newClassTextBox_TextChanged);
            this.newClassTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newClassTextBox_KeyDown);
            // 
            // newClassTextBoxLabel
            // 
            this.newClassTextBoxLabel.AutoSize = true;
            this.newClassTextBoxLabel.Location = new System.Drawing.Point(28, 33);
            this.newClassTextBoxLabel.Name = "newClassTextBoxLabel";
            this.newClassTextBoxLabel.Size = new System.Drawing.Size(63, 13);
            this.newClassTextBoxLabel.TabIndex = 2;
            this.newClassTextBoxLabel.Text = "Class Name";
            // 
            // NewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 71);
            this.Controls.Add(this.newClassTextBoxLabel);
            this.Controls.Add(this.newClassTextBox);
            this.Controls.Add(this.newClassButtonConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewClass";
            this.Text = "NewClass";
            this.Load += new System.EventHandler(this.NewClass_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newClassButtonConfirm;
        private System.Windows.Forms.TextBox newClassTextBox;
        private System.Windows.Forms.Label newClassTextBoxLabel;
    }
}