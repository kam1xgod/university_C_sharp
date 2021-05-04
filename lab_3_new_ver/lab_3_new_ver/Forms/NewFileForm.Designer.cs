namespace lab_3_new_ver.Forms
{
    partial class NewFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFileForm));
            this.selectNewFilePathList = new System.Windows.Forms.ComboBox();
            this.createFileButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.closeWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.showMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // selectNewFilePathList
            // 
            this.selectNewFilePathList.BackColor = System.Drawing.Color.Azure;
            this.selectNewFilePathList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectNewFilePathList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.selectNewFilePathList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectNewFilePathList.FormattingEnabled = true;
            this.selectNewFilePathList.Location = new System.Drawing.Point(12, 605);
            this.selectNewFilePathList.Name = "selectNewFilePathList";
            this.selectNewFilePathList.Size = new System.Drawing.Size(523, 32);
            this.selectNewFilePathList.TabIndex = 0;
            this.selectNewFilePathList.SelectedIndexChanged += new System.EventHandler(this.SelectFilePathList_SelectedIndexChanged);
            this.selectNewFilePathList.Click += new System.EventHandler(this.SelectFilePathList_Click);
            // 
            // createFileButton
            // 
            this.createFileButton.AutoSize = true;
            this.createFileButton.BackColor = System.Drawing.Color.Azure;
            this.createFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createFileButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createFileButton.Location = new System.Drawing.Point(12, 678);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(523, 36);
            this.createFileButton.TabIndex = 1;
            this.createFileButton.Text = "Create file.";
            this.createFileButton.UseVisualStyleBackColor = false;
            this.createFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.BackColor = System.Drawing.Color.Azure;
            this.fileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fileNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fileNameTextBox.Location = new System.Drawing.Point(12, 643);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(523, 29);
            this.fileNameTextBox.TabIndex = 2;
            this.fileNameTextBox.Text = "Write your file name here.";
            // 
            // closeWindowCheckBox
            // 
            this.closeWindowCheckBox.AutoSize = true;
            this.closeWindowCheckBox.BackColor = System.Drawing.Color.Azure;
            this.closeWindowCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindowCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.closeWindowCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeWindowCheckBox.Location = new System.Drawing.Point(12, 718);
            this.closeWindowCheckBox.Name = "closeWindowCheckBox";
            this.closeWindowCheckBox.Size = new System.Drawing.Size(261, 28);
            this.closeWindowCheckBox.TabIndex = 3;
            this.closeWindowCheckBox.Text = "Close window after creating.";
            this.closeWindowCheckBox.UseVisualStyleBackColor = false;
            // 
            // showMessageCheckBox
            // 
            this.showMessageCheckBox.AutoSize = true;
            this.showMessageCheckBox.BackColor = System.Drawing.Color.Azure;
            this.showMessageCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMessageCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.showMessageCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showMessageCheckBox.Location = new System.Drawing.Point(297, 718);
            this.showMessageCheckBox.Name = "showMessageCheckBox";
            this.showMessageCheckBox.Size = new System.Drawing.Size(235, 28);
            this.showMessageCheckBox.TabIndex = 4;
            this.showMessageCheckBox.Text = "Show success message.";
            this.showMessageCheckBox.UseVisualStyleBackColor = false;
            // 
            // NewFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab_3_new_ver.Properties.Resources._09addc0a2412f5f66e497d7d1d18cfe1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 758);
            this.Controls.Add(this.showMessageCheckBox);
            this.Controls.Add(this.closeWindowCheckBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.createFileButton);
            this.Controls.Add(this.selectNewFilePathList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(563, 797);
            this.Name = "NewFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new file ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectNewFilePathList;
        private System.Windows.Forms.Button createFileButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.CheckBox closeWindowCheckBox;
        private System.Windows.Forms.CheckBox showMessageCheckBox;
    }
}