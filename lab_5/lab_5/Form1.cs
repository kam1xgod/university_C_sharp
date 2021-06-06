using System;
using System.Threading;
using System.Windows.Forms;

namespace lab_5
{
    public partial class MainForm : Form
    {
        private bool isStarted = false;

        Thread Dasha;
        Thread Masha;

        Object scissors = new Object();
        Object paper = new Object();
        private bool lockTaken = false;

        public MainForm()
        {
            InitializeComponent();
            Thread.CurrentThread.Name = "Main";
        }

        private void StartWithoutLockButton_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                Object scissors = new Object();
                Object paper = new Object();
                isStarted = true;
                Dasha = new Thread(() => startMakingSKittyWithoutLock(scissors, paper));
                Masha = new Thread(() => startMakingDoggyWithoutLock(scissors, paper));
                Dasha.Name = "Dasha";
                Masha.Name = "Masha";
                Dasha.Start();
                Masha.Start();
                return;
            }
            isStarted = false;
        }

        private void StartWithLockButton_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                isStarted = true;
                Dasha = new Thread(() => startMakingKitty(scissors, paper));
                Masha = new Thread(() => startMakingDoggy(scissors, paper));
                Dasha.Name = "Dasha";
                Masha.Name = "Masha";
                Dasha.Start();
                Masha.Start();
                return;
            }
            isStarted = false;
        }

        private void startMakingKitty(Object scissors, Object paper)
        {
            string temp;
            while (isStarted)
            {
                lock(scissors)
                {
                    temp = $"{Thread.CurrentThread.Name} took scissors.\n";
                    ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                    Thread.Sleep(1000);
                    temp = $"{ Thread.CurrentThread.Name } waiting for another instrument.\n";
                    ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                    Thread.Sleep(1000);
                    lockTaken = false;
                    detectDeadlock(paper);
                    lock (paper)
                    {
                        temp = $"{Thread.CurrentThread.Name} took paper.\n";
                        ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                        Thread.Sleep(1000);
                        temp = $"{ Thread.CurrentThread.Name } waiting for another instrument.\n";
                        ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        private void startMakingDoggy(Object scissors, Object paper)
        {
            string temp;
            while (isStarted)
            {
                lock (paper)
                {
                    temp = $"{Thread.CurrentThread.Name} took paper.\n";
                    ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                    Thread.Sleep(1000);
                    temp = $"{ Thread.CurrentThread.Name } waiting for another instrument.\n";
                    ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                    Thread.Sleep(1000);
                    lockTaken = false;
                    detectDeadlock(scissors);
                    lock (scissors)
                    {
                        temp = $"{Thread.CurrentThread.Name} took scissors.\n";
                        ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                        Thread.Sleep(1000);
                        temp = $"{ Thread.CurrentThread.Name } waiting for another instrument.\n";
                        ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                        Thread.Sleep(1000);
                    }
                }
            }
        }
        
        private void startMakingSKittyWithoutLock(Object scissors, Object paper)
        {
            string temp;
            while (isStarted)
            {
                lock(paper)
                {
                    temp = $"{Thread.CurrentThread.Name} took paper.\n";
                    ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                }
                Thread.Sleep(1000);
                temp = $"{ Thread.CurrentThread.Name } waiting for another instrument.\n";
                ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                Thread.Sleep(1000);
                lock (scissors) {
                    temp = $"{Thread.CurrentThread.Name} took scissors.\n";
                    ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                }
                Thread.Sleep(1000);
                temp = $"{ Thread.CurrentThread.Name } waiting for another instrument.\n";
                ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                Thread.Sleep(1000);
            }
        }

        private void startMakingDoggyWithoutLock(Object scissors, Object paper)
        {
            string temp;
            while (isStarted)
            {
                lock(scissors)
                {
                    temp = $"{Thread.CurrentThread.Name} took scissors.\n";
                    ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                }
                Thread.Sleep(1000);
                temp = $"{ Thread.CurrentThread.Name } waiting for another instrument.\n";
                ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                Thread.Sleep(1000);
                lock (paper) {
                    temp = $"{Thread.CurrentThread.Name} took paper.\n";
                    ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                }
                Thread.Sleep(1000);
                temp = $"{ Thread.CurrentThread.Name } waiting for another instrument.\n";
                ActionsTextBox.BeginInvoke(new Action(() => ActionsTextBox.AppendText(temp)));
                Thread.Sleep(1000);
            }
        }

        private void detectDeadlock(Object resY)
        {
            try
            {
                Monitor.TryEnter(resY, 1000, ref lockTaken);
                if (lockTaken)
                {
                    ActionsTextBox.Invoke(new Action(() => ActionsTextBox.AppendText($"Nah. Not a deadlock.\n")));
                    return;
                }
                ActionsTextBox.Invoke(new Action(() => ActionsTextBox.AppendText($"Congratulations! You've reached deadlock, buddy.\n")));
            }
            finally
            {
                if (lockTaken)
                {
                    Monitor.Exit(resY);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Dasha != null && Masha != null)
            {
                if (Dasha.IsAlive && Masha.IsAlive)
                {
                    Dasha.Abort();
                    Masha.Abort();
                }
            }
            //very funny.
        }
    }
}