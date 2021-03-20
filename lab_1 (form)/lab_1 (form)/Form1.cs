using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace lab_1__form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FirstPriority.SelectedIndex = 2;
            SecondPriority.SelectedIndex = 2;
            ThirdPriority.SelectedIndex = 2;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            FillNum1.Enabled = false;
            FillNum2.Enabled = false;
            FillNum3.Enabled = false;

            var first_filling_thread = new Thread(delegate () { StartFilling(Convert.ToInt32(FillNum1.Text), FirstCanProgress); }); //fisrt.
            ThreadPriorityChange(FirstPriority.SelectedIndex, first_filling_thread);
            first_filling_thread.IsBackground = true;
            first_filling_thread.Start();

            var second_filling_thread = new Thread(delegate () { StartFilling(Convert.ToInt32(FillNum2.Text), SecondCanProgress); }); //second.
            ThreadPriorityChange(SecondPriority.SelectedIndex, second_filling_thread);
            second_filling_thread.IsBackground = true;
            second_filling_thread.Start();

            var third_filling_thread = new Thread(delegate () { StartFilling(Convert.ToInt32(FillNum3.Text), ThirdCanProgress); }); //third.
            ThreadPriorityChange(ThirdPriority.SelectedIndex, third_filling_thread);
            third_filling_thread.IsBackground = true;
            third_filling_thread.Start();

            var first_thread_status_check = new Thread(delegate () { ThreadStatusCheck(first_filling_thread, Thread1Status); }); //first thread status.
            first_thread_status_check.IsBackground = true;
            first_thread_status_check.Start();

            var second_thread_status_check = new Thread(delegate () { ThreadStatusCheck(second_filling_thread, Thread2Status); }); //second thread status.
            second_thread_status_check.IsBackground = true;
            second_thread_status_check.Start();

            var third_thread_status_check = new Thread(delegate () { ThreadStatusCheck(third_filling_thread, Thread3Status); }); //third thread status.
            third_thread_status_check.IsBackground = true;
            third_thread_status_check.Start();

            FirstPriority.Enabled = false;
            SecondPriority.Enabled = false;
            ThirdPriority.Enabled = false;
        }

        private delegate void DisplayStatusDelegate(int i, RichTextBox box);
        private delegate void ThreadStatusDelegate(Thread thread, CheckBox box);

        private void StartFilling(int j, RichTextBox box)
        {

            for (int i = 0; i <= 100; i = i + j)
            {
                CanStatusUpgrade(i, box);
            }
        }

        private void CanStatusUpgrade(int i, RichTextBox box)
        {
            box.Invoke(new DisplayStatusDelegate(DisplayStatus), i, box);
            Thread.Sleep(500);
        }

        private void DisplayStatus(int i, RichTextBox box)
        {
            box.Clear();
            box.Text = i.ToString();
            box.ReadOnly = true;
        }

        private void ThreadStatusCheck(Thread thread, CheckBox box)
        {
            while (true)
            {
                box.Invoke(new ThreadStatusDelegate(ThreadStatus), thread, box);
                Thread.Sleep(1000);
            }
        }

        private void ThreadStatus(Thread thread, CheckBox box)
        {
            if (thread.IsAlive == true)
            {
                box.Checked = true;
            }
            else
            {
                box.Checked = false;
            }
        }

        private void ThreadPriorityChange(int p, Thread thread)
        {
            switch (p)
            {
                case 0:
                    thread.Priority = ThreadPriority.Highest;
                    break;
                case 1:
                    thread.Priority = ThreadPriority.AboveNormal;
                    break;
                case 2:
                    thread.Priority = ThreadPriority.Normal;
                    break;
                case 3:
                    thread.Priority = ThreadPriority.BelowNormal;
                    break;
                case 4:
                    thread.Priority = ThreadPriority.Lowest;
                    break;
            }
        }
    }
}
