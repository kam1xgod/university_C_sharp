
namespace lab_5
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
            this.StartWithoutLockButton = new System.Windows.Forms.Button();
            this.StartWithLockButton = new System.Windows.Forms.Button();
            this.ActionsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StartWithoutLockButton
            // 
            this.StartWithoutLockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartWithoutLockButton.Font = new System.Drawing.Font("Ubuntu Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartWithoutLockButton.Location = new System.Drawing.Point(416, 12);
            this.StartWithoutLockButton.Name = "StartWithoutLockButton";
            this.StartWithoutLockButton.Size = new System.Drawing.Size(110, 33);
            this.StartWithoutLockButton.TabIndex = 0;
            this.StartWithoutLockButton.Text = "w/out";
            this.StartWithoutLockButton.UseVisualStyleBackColor = true;
            this.StartWithoutLockButton.Click += new System.EventHandler(this.StartWithoutLockButton_Click);
            // 
            // StartWithLockButton
            // 
            this.StartWithLockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartWithLockButton.Font = new System.Drawing.Font("Ubuntu Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartWithLockButton.Location = new System.Drawing.Point(300, 12);
            this.StartWithLockButton.Name = "StartWithLockButton";
            this.StartWithLockButton.Size = new System.Drawing.Size(110, 33);
            this.StartWithLockButton.TabIndex = 1;
            this.StartWithLockButton.Text = "w/";
            this.StartWithLockButton.UseVisualStyleBackColor = true;
            this.StartWithLockButton.Click += new System.EventHandler(this.StartWithLockButton_Click);
            // 
            // ActionsTextBox
            // 
            this.ActionsTextBox.BackColor = System.Drawing.Color.White;
            this.ActionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActionsTextBox.Location = new System.Drawing.Point(12, 12);
            this.ActionsTextBox.Name = "ActionsTextBox";
            this.ActionsTextBox.Size = new System.Drawing.Size(282, 596);
            this.ActionsTextBox.TabIndex = 4;
            this.ActionsTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::lab_5.Properties.Resources.rem_png_by_mikaya_chan_dbjc2l8_pre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(954, 846);
            this.Controls.Add(this.ActionsTextBox);
            this.Controls.Add(this.StartWithLockButton);
            this.Controls.Add(this.StartWithoutLockButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "lab_5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartWithoutLockButton;
        private System.Windows.Forms.Button StartWithLockButton;
        private System.Windows.Forms.RichTextBox ActionsTextBox;
    }
}

