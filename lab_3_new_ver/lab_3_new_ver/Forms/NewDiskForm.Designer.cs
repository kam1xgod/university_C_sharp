namespace lab_3_new_ver.Forms
{
    partial class NewDiskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDiskForm));
            this.diskNameTextBox = new System.Windows.Forms.TextBox();
            this.createDiskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diskNameTextBox
            // 
            this.diskNameTextBox.BackColor = System.Drawing.Color.Azure;
            this.diskNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diskNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.diskNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.diskNameTextBox.Location = new System.Drawing.Point(12, 677);
            this.diskNameTextBox.Name = "diskNameTextBox";
            this.diskNameTextBox.Size = new System.Drawing.Size(523, 29);
            this.diskNameTextBox.TabIndex = 0;
            this.diskNameTextBox.Text = "Write here a disk name.";
            // 
            // createDiskButton
            // 
            this.createDiskButton.AutoSize = true;
            this.createDiskButton.BackColor = System.Drawing.Color.Azure;
            this.createDiskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createDiskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createDiskButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createDiskButton.Location = new System.Drawing.Point(12, 712);
            this.createDiskButton.Name = "createDiskButton";
            this.createDiskButton.Size = new System.Drawing.Size(523, 36);
            this.createDiskButton.TabIndex = 1;
            this.createDiskButton.Text = "Create disk.";
            this.createDiskButton.UseVisualStyleBackColor = false;
            this.createDiskButton.Click += new System.EventHandler(this.CreateDiskButton_Click);
            // 
            // NewDiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab_3_new_ver.Properties.Resources._6af33d16ca1013b58f063ad8f43ec27a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 758);
            this.Controls.Add(this.createDiskButton);
            this.Controls.Add(this.diskNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(563, 797);
            this.Name = "NewDiskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new disk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diskNameTextBox;
        private System.Windows.Forms.Button createDiskButton;
    }
}