namespace lab_1__form_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FirstCanStatus = new System.Windows.Forms.RichTextBox();
            this.FirstCanProgress = new System.Windows.Forms.RichTextBox();
            this.SecondCanStatus = new System.Windows.Forms.RichTextBox();
            this.SecondCanProgress = new System.Windows.Forms.RichTextBox();
            this.ThirdCanStatus = new System.Windows.Forms.RichTextBox();
            this.ThirdCanProgress = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.FillNum2 = new System.Windows.Forms.NumericUpDown();
            this.FillNum3 = new System.Windows.Forms.NumericUpDown();
            this.FillNum1 = new System.Windows.Forms.NumericUpDown();
            this.Thread1Status = new System.Windows.Forms.CheckBox();
            this.Thread2Status = new System.Windows.Forms.CheckBox();
            this.Thread3Status = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstPriority = new System.Windows.Forms.ComboBox();
            this.SecondPriority = new System.Windows.Forms.ComboBox();
            this.ThirdPriority = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FillNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillNum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillNum1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstCanStatus
            // 
            this.FirstCanStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FirstCanStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstCanStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstCanStatus.Location = new System.Drawing.Point(17, 16);
            this.FirstCanStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstCanStatus.Name = "FirstCanStatus";
            this.FirstCanStatus.ReadOnly = true;
            this.FirstCanStatus.Size = new System.Drawing.Size(149, 23);
            this.FirstCanStatus.TabIndex = 0;
            this.FirstCanStatus.Text = "first can status:";
            // 
            // FirstCanProgress
            // 
            this.FirstCanProgress.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FirstCanProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstCanProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstCanProgress.Location = new System.Drawing.Point(175, 16);
            this.FirstCanProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstCanProgress.Name = "FirstCanProgress";
            this.FirstCanProgress.ReadOnly = true;
            this.FirstCanProgress.Size = new System.Drawing.Size(133, 23);
            this.FirstCanProgress.TabIndex = 0;
            this.FirstCanProgress.Text = "зап. по:";
            // 
            // SecondCanStatus
            // 
            this.SecondCanStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SecondCanStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondCanStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondCanStatus.Location = new System.Drawing.Point(17, 47);
            this.SecondCanStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SecondCanStatus.Name = "SecondCanStatus";
            this.SecondCanStatus.ReadOnly = true;
            this.SecondCanStatus.Size = new System.Drawing.Size(149, 23);
            this.SecondCanStatus.TabIndex = 0;
            this.SecondCanStatus.Text = "second can status:";
            // 
            // SecondCanProgress
            // 
            this.SecondCanProgress.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SecondCanProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondCanProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondCanProgress.Location = new System.Drawing.Point(175, 47);
            this.SecondCanProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SecondCanProgress.Name = "SecondCanProgress";
            this.SecondCanProgress.ReadOnly = true;
            this.SecondCanProgress.Size = new System.Drawing.Size(133, 23);
            this.SecondCanProgress.TabIndex = 0;
            this.SecondCanProgress.Text = "зап. по:";
            // 
            // ThirdCanStatus
            // 
            this.ThirdCanStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ThirdCanStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThirdCanStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdCanStatus.Location = new System.Drawing.Point(17, 78);
            this.ThirdCanStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThirdCanStatus.Name = "ThirdCanStatus";
            this.ThirdCanStatus.ReadOnly = true;
            this.ThirdCanStatus.Size = new System.Drawing.Size(149, 23);
            this.ThirdCanStatus.TabIndex = 0;
            this.ThirdCanStatus.Text = "third can status:";
            // 
            // ThirdCanProgress
            // 
            this.ThirdCanProgress.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ThirdCanProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThirdCanProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdCanProgress.Location = new System.Drawing.Point(175, 78);
            this.ThirdCanProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThirdCanProgress.Name = "ThirdCanProgress";
            this.ThirdCanProgress.ReadOnly = true;
            this.ThirdCanProgress.Size = new System.Drawing.Size(133, 23);
            this.ThirdCanProgress.TabIndex = 0;
            this.ThirdCanProgress.Text = "зап. по:";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(190)))));
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(17, 491);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(267, 48);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start Filling";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // FillNum2
            // 
            this.FillNum2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FillNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FillNum2.Location = new System.Drawing.Point(316, 46);
            this.FillNum2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FillNum2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FillNum2.Name = "FillNum2";
            this.FillNum2.Size = new System.Drawing.Size(160, 18);
            this.FillNum2.TabIndex = 3;
            this.FillNum2.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // FillNum3
            // 
            this.FillNum3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FillNum3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FillNum3.Location = new System.Drawing.Point(316, 76);
            this.FillNum3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FillNum3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FillNum3.Name = "FillNum3";
            this.FillNum3.Size = new System.Drawing.Size(160, 18);
            this.FillNum3.TabIndex = 3;
            this.FillNum3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // FillNum1
            // 
            this.FillNum1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FillNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FillNum1.Location = new System.Drawing.Point(316, 16);
            this.FillNum1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FillNum1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FillNum1.Name = "FillNum1";
            this.FillNum1.Size = new System.Drawing.Size(160, 18);
            this.FillNum1.TabIndex = 3;
            this.FillNum1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Thread1Status
            // 
            this.Thread1Status.AutoCheck = false;
            this.Thread1Status.AutoSize = true;
            this.Thread1Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(190)))));
            this.Thread1Status.Location = new System.Drawing.Point(848, 486);
            this.Thread1Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Thread1Status.Name = "Thread1Status";
            this.Thread1Status.Size = new System.Drawing.Size(135, 21);
            this.Thread1Status.TabIndex = 4;
            this.Thread1Status.Text = "thread number 1";
            this.Thread1Status.UseVisualStyleBackColor = false;
            // 
            // Thread2Status
            // 
            this.Thread2Status.AutoCheck = false;
            this.Thread2Status.AutoSize = true;
            this.Thread2Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(190)))));
            this.Thread2Status.Location = new System.Drawing.Point(848, 505);
            this.Thread2Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Thread2Status.Name = "Thread2Status";
            this.Thread2Status.Size = new System.Drawing.Size(135, 21);
            this.Thread2Status.TabIndex = 4;
            this.Thread2Status.Text = "thread number 2";
            this.Thread2Status.UseVisualStyleBackColor = false;
            // 
            // Thread3Status
            // 
            this.Thread3Status.AutoCheck = false;
            this.Thread3Status.AutoSize = true;
            this.Thread3Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(190)))));
            this.Thread3Status.Location = new System.Drawing.Point(848, 524);
            this.Thread3Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Thread3Status.Name = "Thread3Status";
            this.Thread3Status.Size = new System.Drawing.Size(135, 21);
            this.Thread3Status.TabIndex = 4;
            this.Thread3Status.Text = "thread number 3";
            this.Thread3Status.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(223)))), ((int)(((byte)(190)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(625, 500);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Threads Status:";
            // 
            // FirstPriority
            // 
            this.FirstPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstPriority.FormattingEnabled = true;
            this.FirstPriority.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FirstPriority.Items.AddRange(new object[] {
            "Highest",
            "Above normal",
            "Normal",
            "Below normal",
            "Lowest"});
            this.FirstPriority.Location = new System.Drawing.Point(484, 10);
            this.FirstPriority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstPriority.Name = "FirstPriority";
            this.FirstPriority.Size = new System.Drawing.Size(160, 24);
            this.FirstPriority.TabIndex = 6;
            // 
            // SecondPriority
            // 
            this.SecondPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondPriority.FormattingEnabled = true;
            this.SecondPriority.Items.AddRange(new object[] {
            "Highest",
            "Above normal",
            "Normal",
            "Below normal",
            "Lowest"});
            this.SecondPriority.Location = new System.Drawing.Point(484, 44);
            this.SecondPriority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SecondPriority.Name = "SecondPriority";
            this.SecondPriority.Size = new System.Drawing.Size(160, 24);
            this.SecondPriority.TabIndex = 6;
            // 
            // ThirdPriority
            // 
            this.ThirdPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThirdPriority.FormattingEnabled = true;
            this.ThirdPriority.Items.AddRange(new object[] {
            "Highest",
            "Above normal",
            "Normal",
            "Below normal",
            "Lowest"});
            this.ThirdPriority.Location = new System.Drawing.Point(484, 75);
            this.ThirdPriority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThirdPriority.Name = "ThirdPriority";
            this.ThirdPriority.Size = new System.Drawing.Size(160, 24);
            this.ThirdPriority.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ThirdPriority);
            this.Controls.Add(this.SecondPriority);
            this.Controls.Add(this.FirstPriority);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Thread3Status);
            this.Controls.Add(this.Thread2Status);
            this.Controls.Add(this.Thread1Status);
            this.Controls.Add(this.FillNum1);
            this.Controls.Add(this.FillNum3);
            this.Controls.Add(this.FillNum2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ThirdCanProgress);
            this.Controls.Add(this.ThirdCanStatus);
            this.Controls.Add(this.SecondCanProgress);
            this.Controls.Add(this.SecondCanStatus);
            this.Controls.Add(this.FirstCanProgress);
            this.Controls.Add(this.FirstCanStatus);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "first lab.";
            ((System.ComponentModel.ISupportInitialize)(this.FillNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillNum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillNum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FirstCanStatus;
        private System.Windows.Forms.RichTextBox FirstCanProgress;
        private System.Windows.Forms.RichTextBox SecondCanStatus;
        private System.Windows.Forms.RichTextBox SecondCanProgress;
        private System.Windows.Forms.RichTextBox ThirdCanStatus;
        private System.Windows.Forms.RichTextBox ThirdCanProgress;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown FillNum2;
        private System.Windows.Forms.NumericUpDown FillNum3;
        private System.Windows.Forms.NumericUpDown FillNum1;
        private System.Windows.Forms.CheckBox Thread1Status;
        private System.Windows.Forms.CheckBox Thread2Status;
        private System.Windows.Forms.CheckBox Thread3Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FirstPriority;
        private System.Windows.Forms.ComboBox SecondPriority;
        private System.Windows.Forms.ComboBox ThirdPriority;
    }
}

