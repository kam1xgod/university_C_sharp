namespace lab_3_new_ver.Forms
{
    partial class NewFolderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFolderForm));
            this.createFolderButton = new System.Windows.Forms.Button();
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.selectNewFolderPathList = new System.Windows.Forms.ComboBox();
            this.closeWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.showMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // createFolderButton
            // 
            this.createFolderButton.AutoSize = true;
            this.createFolderButton.BackColor = System.Drawing.Color.Azure;
            this.createFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createFolderButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createFolderButton.Location = new System.Drawing.Point(12, 678);
            this.createFolderButton.Name = "createFolderButton";
            this.createFolderButton.Size = new System.Drawing.Size(523, 36);
            this.createFolderButton.TabIndex = 1;
            this.createFolderButton.Text = "Create folder.";
            this.createFolderButton.UseVisualStyleBackColor = false;
            this.createFolderButton.Click += new System.EventHandler(this.CreateFolderButton_Click);
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.BackColor = System.Drawing.Color.Azure;
            this.folderNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.folderNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.folderNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.folderNameTextBox.Location = new System.Drawing.Point(12, 643);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(523, 29);
            this.folderNameTextBox.TabIndex = 0;
            this.folderNameTextBox.Text = "Write folder name.";
            // 
            // selectNewFolderPathList
            // 
            this.selectNewFolderPathList.BackColor = System.Drawing.Color.Azure;
            this.selectNewFolderPathList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectNewFolderPathList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.selectNewFolderPathList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectNewFolderPathList.FormattingEnabled = true;
            this.selectNewFolderPathList.Location = new System.Drawing.Point(12, 605);
            this.selectNewFolderPathList.Name = "selectNewFolderPathList";
            this.selectNewFolderPathList.Size = new System.Drawing.Size(523, 32);
            this.selectNewFolderPathList.TabIndex = 2;
            this.selectNewFolderPathList.SelectedIndexChanged += new System.EventHandler(this.NewFolderPathList_SelectedIndexChanged);
            this.selectNewFolderPathList.Click += new System.EventHandler(this.NewFolderPathList_Click);
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
            this.showMessageCheckBox.Location = new System.Drawing.Point(282, 718);
            this.showMessageCheckBox.Name = "showMessageCheckBox";
            this.showMessageCheckBox.Size = new System.Drawing.Size(235, 28);
            this.showMessageCheckBox.TabIndex = 3;
            this.showMessageCheckBox.Text = "Show success message.";
            this.showMessageCheckBox.UseVisualStyleBackColor = false;
            // 
            // NewFolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab_3_new_ver.Properties.Resources._8e7d4883355d540879ea6cce3c0f61e4;
            this.ClientSize = new System.Drawing.Size(547, 758);
            this.Controls.Add(this.showMessageCheckBox);
            this.Controls.Add(this.closeWindowCheckBox);
            this.Controls.Add(this.selectNewFolderPathList);
            this.Controls.Add(this.createFolderButton);
            this.Controls.Add(this.folderNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(563, 797);
            this.Name = "NewFolderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createFolderButton;
        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.ComboBox selectNewFolderPathList;
        private System.Windows.Forms.CheckBox closeWindowCheckBox;
        private System.Windows.Forms.CheckBox showMessageCheckBox;
    }
}