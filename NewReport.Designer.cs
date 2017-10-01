namespace Grade_Tracker
{
    partial class NewReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReport));
            this.reportNameLabel = new System.Windows.Forms.Label();
            this.reportScoreLabel = new System.Windows.Forms.Label();
            this.reportNameTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox1 = new System.Windows.Forms.TextBox();
            this.scoreTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newReportConfirmButton = new System.Windows.Forms.Button();
            this.newReportCancelButton = new System.Windows.Forms.Button();
            this.droppedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // reportNameLabel
            // 
            this.reportNameLabel.AutoSize = true;
            this.reportNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportNameLabel.Location = new System.Drawing.Point(19, 26);
            this.reportNameLabel.Name = "reportNameLabel";
            this.reportNameLabel.Size = new System.Drawing.Size(104, 20);
            this.reportNameLabel.TabIndex = 0;
            this.reportNameLabel.Text = "Report Name";
            // 
            // reportScoreLabel
            // 
            this.reportScoreLabel.AutoSize = true;
            this.reportScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportScoreLabel.Location = new System.Drawing.Point(70, 64);
            this.reportScoreLabel.Name = "reportScoreLabel";
            this.reportScoreLabel.Size = new System.Drawing.Size(51, 20);
            this.reportScoreLabel.TabIndex = 1;
            this.reportScoreLabel.Text = "Score";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.Location = new System.Drawing.Point(129, 26);
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.reportNameTextBox.TabIndex = 2;
            // 
            // scoreTextBox1
            // 
            this.scoreTextBox1.Location = new System.Drawing.Point(129, 65);
            this.scoreTextBox1.Name = "scoreTextBox1";
            this.scoreTextBox1.Size = new System.Drawing.Size(31, 20);
            this.scoreTextBox1.TabIndex = 3;
            this.scoreTextBox1.TextChanged += new System.EventHandler(this.scoreTextBox1_TextChanged);
            this.scoreTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scoreTextBox1_KeyPress);
            // 
            // scoreTextBox2
            // 
            this.scoreTextBox2.Location = new System.Drawing.Point(170, 65);
            this.scoreTextBox2.Name = "scoreTextBox2";
            this.scoreTextBox2.Size = new System.Drawing.Size(31, 20);
            this.scoreTextBox2.TabIndex = 4;
            this.scoreTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scoreTextBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "/";
            // 
            // newReportConfirmButton
            // 
            this.newReportConfirmButton.Location = new System.Drawing.Point(179, 104);
            this.newReportConfirmButton.Name = "newReportConfirmButton";
            this.newReportConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.newReportConfirmButton.TabIndex = 6;
            this.newReportConfirmButton.Text = "Confirm";
            this.newReportConfirmButton.UseVisualStyleBackColor = true;
            this.newReportConfirmButton.Click += new System.EventHandler(this.newReportConfirmButton_Click);
            // 
            // newReportCancelButton
            // 
            this.newReportCancelButton.Location = new System.Drawing.Point(70, 104);
            this.newReportCancelButton.Name = "newReportCancelButton";
            this.newReportCancelButton.Size = new System.Drawing.Size(75, 23);
            this.newReportCancelButton.TabIndex = 7;
            this.newReportCancelButton.Text = "Cancel";
            this.newReportCancelButton.UseVisualStyleBackColor = true;
            this.newReportCancelButton.Click += new System.EventHandler(this.newReportCancelButton_Click);
            // 
            // droppedCheckBox
            // 
            this.droppedCheckBox.AutoSize = true;
            this.droppedCheckBox.Location = new System.Drawing.Point(213, 67);
            this.droppedCheckBox.Name = "droppedCheckBox";
            this.droppedCheckBox.Size = new System.Drawing.Size(67, 17);
            this.droppedCheckBox.TabIndex = 8;
            this.droppedCheckBox.Text = "Dropped";
            this.droppedCheckBox.UseVisualStyleBackColor = true;
            this.droppedCheckBox.CheckedChanged += new System.EventHandler(this.droppedCheckBox_CheckedChanged);
            // 
            // NewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 139);
            this.Controls.Add(this.droppedCheckBox);
            this.Controls.Add(this.newReportCancelButton);
            this.Controls.Add(this.newReportConfirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreTextBox2);
            this.Controls.Add(this.scoreTextBox1);
            this.Controls.Add(this.reportNameTextBox);
            this.Controls.Add(this.reportScoreLabel);
            this.Controls.Add(this.reportNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewReport";
            this.Text = "NewReport";
            this.Load += new System.EventHandler(this.NewReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportNameLabel;
        private System.Windows.Forms.Label reportScoreLabel;
        private System.Windows.Forms.TextBox reportNameTextBox;
        private System.Windows.Forms.TextBox scoreTextBox1;
        private System.Windows.Forms.TextBox scoreTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newReportConfirmButton;
        private System.Windows.Forms.Button newReportCancelButton;
        private System.Windows.Forms.CheckBox droppedCheckBox;
    }
}