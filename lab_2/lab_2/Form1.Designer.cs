namespace lab_2
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.readMemoryButton = new System.Windows.Forms.Button();
            this.memoryAdressTextBox = new System.Windows.Forms.TextBox();
            this.processIDList = new System.Windows.Forms.ComboBox();
            this.ramPercentsLabel = new System.Windows.Forms.Label();
            this.virtualAllLabel = new System.Windows.Forms.Label();
            this.virtualEmptyLabel = new System.Windows.Forms.Label();
            this.bufferTextBox = new System.Windows.Forms.TextBox();
            this.writeMemoryButton = new System.Windows.Forms.Button();
            this.foundLabel = new System.Windows.Forms.Label();
            this.textBoxToWorkWith = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readMemoryButton
            // 
            this.readMemoryButton.Location = new System.Drawing.Point(9, 20);
            this.readMemoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.readMemoryButton.Name = "readMemoryButton";
            this.readMemoryButton.Size = new System.Drawing.Size(132, 20);
            this.readMemoryButton.TabIndex = 0;
            this.readMemoryButton.Text = "Найти.";
            this.readMemoryButton.UseVisualStyleBackColor = true;
            this.readMemoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // memoryAdressTextBox
            // 
            this.memoryAdressTextBox.Location = new System.Drawing.Point(146, 20);
            this.memoryAdressTextBox.Name = "memoryAdressTextBox";
            this.memoryAdressTextBox.Size = new System.Drawing.Size(100, 20);
            this.memoryAdressTextBox.TabIndex = 2;
            // 
            // processIDList
            // 
            this.processIDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processIDList.FormattingEnabled = true;
            this.processIDList.Location = new System.Drawing.Point(252, 19);
            this.processIDList.Name = "processIDList";
            this.processIDList.Size = new System.Drawing.Size(121, 21);
            this.processIDList.Sorted = true;
            this.processIDList.TabIndex = 4;
            // 
            // ramPercentsLabel
            // 
            this.ramPercentsLabel.AutoSize = true;
            this.ramPercentsLabel.Location = new System.Drawing.Point(12, 344);
            this.ramPercentsLabel.Name = "ramPercentsLabel";
            this.ramPercentsLabel.Size = new System.Drawing.Size(0, 13);
            this.ramPercentsLabel.TabIndex = 5;
            // 
            // virtualAllLabel
            // 
            this.virtualAllLabel.AutoSize = true;
            this.virtualAllLabel.Location = new System.Drawing.Point(12, 322);
            this.virtualAllLabel.Name = "virtualAllLabel";
            this.virtualAllLabel.Size = new System.Drawing.Size(0, 13);
            this.virtualAllLabel.TabIndex = 6;
            // 
            // virtualEmptyLabel
            // 
            this.virtualEmptyLabel.AutoSize = true;
            this.virtualEmptyLabel.Location = new System.Drawing.Point(12, 299);
            this.virtualEmptyLabel.Name = "virtualEmptyLabel";
            this.virtualEmptyLabel.Size = new System.Drawing.Size(0, 13);
            this.virtualEmptyLabel.TabIndex = 7;
            // 
            // bufferTextBox
            // 
            this.bufferTextBox.Location = new System.Drawing.Point(146, 47);
            this.bufferTextBox.Name = "bufferTextBox";
            this.bufferTextBox.Size = new System.Drawing.Size(100, 20);
            this.bufferTextBox.TabIndex = 8;
            // 
            // writeMemoryButton
            // 
            this.writeMemoryButton.Location = new System.Drawing.Point(9, 46);
            this.writeMemoryButton.Name = "writeMemoryButton";
            this.writeMemoryButton.Size = new System.Drawing.Size(131, 23);
            this.writeMemoryButton.TabIndex = 9;
            this.writeMemoryButton.Text = "Записать.";
            this.writeMemoryButton.UseVisualStyleBackColor = true;
            this.writeMemoryButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // foundLabel
            // 
            this.foundLabel.AutoSize = true;
            this.foundLabel.Location = new System.Drawing.Point(12, 99);
            this.foundLabel.Name = "foundLabel";
            this.foundLabel.Size = new System.Drawing.Size(35, 13);
            this.foundLabel.TabIndex = 10;
            this.foundLabel.Text = "пшпш";
            // 
            // textBoxToWorkWith
            // 
            this.textBoxToWorkWith.Location = new System.Drawing.Point(9, 75);
            this.textBoxToWorkWith.Name = "textBoxToWorkWith";
            this.textBoxToWorkWith.Size = new System.Drawing.Size(100, 20);
            this.textBoxToWorkWith.TabIndex = 8;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.foundLabel);
            this.Controls.Add(this.writeMemoryButton);
            this.Controls.Add(this.textBoxToWorkWith);
            this.Controls.Add(this.bufferTextBox);
            this.Controls.Add(this.virtualEmptyLabel);
            this.Controls.Add(this.virtualAllLabel);
            this.Controls.Add(this.ramPercentsLabel);
            this.Controls.Add(this.processIDList);
            this.Controls.Add(this.memoryAdressTextBox);
            this.Controls.Add(this.readMemoryButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "App";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readMemoryButton;
        private System.Windows.Forms.TextBox memoryAdressTextBox;
        private System.Windows.Forms.ComboBox processIDList;
        private System.Windows.Forms.Label ramPercentsLabel;
        private System.Windows.Forms.Label virtualAllLabel;
        private System.Windows.Forms.Label virtualEmptyLabel;
        private System.Windows.Forms.TextBox bufferTextBox;
        private System.Windows.Forms.Button writeMemoryButton;
        private System.Windows.Forms.Label foundLabel;
        private System.Windows.Forms.TextBox textBoxToWorkWith;
    }
}

