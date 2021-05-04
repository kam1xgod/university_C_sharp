using System.Windows.Forms;

namespace lab_3_new_ver
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createNewDiskButton = new System.Windows.Forms.Button();
            this.createNewDirInDiskButton = new System.Windows.Forms.Button();
            this.createNewFileButton = new System.Windows.Forms.Button();
            this.openCurDiskInExpButton = new System.Windows.Forms.Button();
            this.openICMDButton = new System.Windows.Forms.Button();
            this.selectDiskLabel = new System.Windows.Forms.Label();
            this.selectDiskList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createNewDiskButton
            // 
            this.createNewDiskButton.AutoSize = true;
            this.createNewDiskButton.BackColor = System.Drawing.Color.Azure;
            this.createNewDiskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewDiskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewDiskButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createNewDiskButton.Location = new System.Drawing.Point(12, 552);
            this.createNewDiskButton.Name = "createNewDiskButton";
            this.createNewDiskButton.Size = new System.Drawing.Size(519, 36);
            this.createNewDiskButton.TabIndex = 0;
            this.createNewDiskButton.Text = "Create new disk.";
            this.createNewDiskButton.UseVisualStyleBackColor = false;
            this.createNewDiskButton.Click += new System.EventHandler(this.CreateNewDiskButton_Click);
            // 
            // createNewDirInDiskButton
            // 
            this.createNewDirInDiskButton.AutoSize = true;
            this.createNewDirInDiskButton.BackColor = System.Drawing.Color.Azure;
            this.createNewDirInDiskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewDirInDiskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewDirInDiskButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createNewDirInDiskButton.Location = new System.Drawing.Point(12, 592);
            this.createNewDirInDiskButton.Name = "createNewDirInDiskButton";
            this.createNewDirInDiskButton.Size = new System.Drawing.Size(519, 36);
            this.createNewDirInDiskButton.TabIndex = 1;
            this.createNewDirInDiskButton.Text = "Create new folder in current disk.";
            this.createNewDirInDiskButton.UseVisualStyleBackColor = false;
            this.createNewDirInDiskButton.Click += new System.EventHandler(this.CreateNewDirInDiskButton_Click);
            // 
            // createNewFileButton
            // 
            this.createNewFileButton.AutoSize = true;
            this.createNewFileButton.BackColor = System.Drawing.Color.Azure;
            this.createNewFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createNewFileButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createNewFileButton.Location = new System.Drawing.Point(12, 632);
            this.createNewFileButton.Name = "createNewFileButton";
            this.createNewFileButton.Size = new System.Drawing.Size(519, 36);
            this.createNewFileButton.TabIndex = 1;
            this.createNewFileButton.Text = "Create new file in current disk.";
            this.createNewFileButton.UseVisualStyleBackColor = false;
            this.createNewFileButton.Click += new System.EventHandler(this.CreateNewFileButton_Click);
            // 
            // openCurDiskInExpButton
            // 
            this.openCurDiskInExpButton.AutoSize = true;
            this.openCurDiskInExpButton.BackColor = System.Drawing.Color.Azure;
            this.openCurDiskInExpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCurDiskInExpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openCurDiskInExpButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.openCurDiskInExpButton.Location = new System.Drawing.Point(12, 672);
            this.openCurDiskInExpButton.Name = "openCurDiskInExpButton";
            this.openCurDiskInExpButton.Size = new System.Drawing.Size(519, 36);
            this.openCurDiskInExpButton.TabIndex = 1;
            this.openCurDiskInExpButton.Text = "Open current disk in explorer.";
            this.openCurDiskInExpButton.UseVisualStyleBackColor = false;
            this.openCurDiskInExpButton.Click += new System.EventHandler(this.OpenCurDiskInExpButton_Click);
            // 
            // openICMDButton
            // 
            this.openICMDButton.AutoSize = true;
            this.openICMDButton.BackColor = System.Drawing.Color.Azure;
            this.openICMDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openICMDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.openICMDButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.openICMDButton.Location = new System.Drawing.Point(12, 712);
            this.openICMDButton.Name = "openICMDButton";
            this.openICMDButton.Size = new System.Drawing.Size(519, 36);
            this.openICMDButton.TabIndex = 1;
            this.openICMDButton.Text = "Open Command line.";
            this.openICMDButton.UseVisualStyleBackColor = false;
            this.openICMDButton.Click += new System.EventHandler(this.OpenInterpreterButton_Click);
            // 
            // selectDiskLabel
            // 
            this.selectDiskLabel.AutoSize = true;
            this.selectDiskLabel.BackColor = System.Drawing.Color.Azure;
            this.selectDiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectDiskLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectDiskLabel.Location = new System.Drawing.Point(12, 487);
            this.selectDiskLabel.Name = "selectDiskLabel";
            this.selectDiskLabel.Size = new System.Drawing.Size(105, 24);
            this.selectDiskLabel.TabIndex = 3;
            this.selectDiskLabel.Text = "Select disk:";
            // 
            // selectDiskList
            // 
            this.selectDiskList.BackColor = System.Drawing.Color.Azure;
            this.selectDiskList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDiskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectDiskList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectDiskList.FormattingEnabled = true;
            this.selectDiskList.Location = new System.Drawing.Point(12, 514);
            this.selectDiskList.Name = "selectDiskList";
            this.selectDiskList.Size = new System.Drawing.Size(519, 32);
            this.selectDiskList.TabIndex = 4;
            this.selectDiskList.SelectedIndexChanged += new System.EventHandler(this.SelectDiskList_SelectedIndexChanged);
            this.selectDiskList.Click += new System.EventHandler(this.SelectDiskList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::lab_3_new_ver.Properties.Resources._7790ad1a1f58d5fc7276e2ab78d604b81;
            this.ClientSize = new System.Drawing.Size(547, 758);
            this.Controls.Add(this.selectDiskList);
            this.Controls.Add(this.selectDiskLabel);
            this.Controls.Add(this.openICMDButton);
            this.Controls.Add(this.openCurDiskInExpButton);
            this.Controls.Add(this.createNewFileButton);
            this.Controls.Add(this.createNewDirInDiskButton);
            this.Controls.Add(this.createNewDiskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(563, 797);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewDiskButton;
        private System.Windows.Forms.Button createNewDirInDiskButton;
        private System.Windows.Forms.Button createNewFileButton;
        private System.Windows.Forms.Button openCurDiskInExpButton;
        private System.Windows.Forms.Button openICMDButton;
        private System.Windows.Forms.Label selectDiskLabel;
        public System.Windows.Forms.ComboBox selectDiskList;
    }
}

