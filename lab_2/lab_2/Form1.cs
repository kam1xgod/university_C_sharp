using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace lab_2
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            load();
        }

        //апи функция для просмотра памяти
        [DllImport("kernel32.dll")]
        public static extern void GlobalMemoryStatus(ref MEMORYSTATUS lpBuffer);
        //
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);
        //
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        //
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        //
        public struct MEMORYSTATUS
        {
            public UInt32 dwLength;
            public UInt32 dwMemoryLoad;           //процент занятой памяти
            public UInt32 dwTotalPhys;
            public UInt32 dwAvailPhys;
            public UInt32 dwTotalPageFile;
            public UInt32 dwAvailPageFile;
            public UInt32 dwTotalVirtual;         //общее количество виртуальной памяти(файл подкачки)
            public UInt32 dwAvailVirtual;         //свободное количество виртуальной памяти(файл подкачки)
        }
        //функция для считывания памяти


        public void load()

        {
            //объявляем переменную типа мемористатус
            MEMORYSTATUS memStatus = new MEMORYSTATUS();
            //вызываем функцию с аргументом мемори статус
            GlobalMemoryStatus(ref memStatus);


            ramPercentsLabel.Text = "Используемая память: " + memStatus.dwMemoryLoad.ToString() + " %";
            virtualAllLabel.Text = "Общая виртуальная память: " + (memStatus.dwTotalVirtual).ToString();
            virtualEmptyLabel.Text = "Свободная виртуальная память: " + memStatus.dwAvailVirtual.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string[] temp = processIDList.SelectedItem.ToString().Split(' ');
            int ProcessID = Convert.ToInt32(temp[0]);
            Process process = Process.GetProcessById(ProcessID);
            IntPtr processHandle = OpenProcess(0x0020, false, process.Id);
            int bytesWritten = 0;
            byte[] buffer = Encoding.Unicode.GetBytes(bufferTextBox.Text + "\0");
            IntPtr baseAdress = (IntPtr)Marshal.StringToHGlobalAnsi(memoryAdressTextBox.Text);
            WriteProcessMemory(processHandle, baseAdress, buffer, buffer.Length, ref bytesWritten);
            //textBoxToWorkWith.Text = Encoding.Unicode.GetString(buffer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tmp = processIDList.SelectedItem.ToString().Split(' ');
            int PID = Convert.ToInt32(tmp[0]);
            Process process = Process.GetProcessById(PID);
            IntPtr processHandle = OpenProcess(0x0010, false, process.Id);
            int lenght = Encoding.Unicode.GetBytes(bufferTextBox.Text + "\0").Length;
            int bytesRead = 0;
            byte[] buffer = new byte[lenght];
            IntPtr baseAdress = (IntPtr)Marshal.StringToHGlobalAnsi(memoryAdressTextBox.Text);
            ReadProcessMemory(processHandle, baseAdress, buffer, buffer.Length, ref bytesRead);
            foundLabel.Text = $"Found { Encoding.Unicode.GetString(buffer) }, read { bytesRead.ToString() } bytes.";
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process instance in processes)
            {
                processIDList.Items.Add(new ProcessInfo(instance));
            }
            processIDList.SelectedIndex = 0;
        }

        class ProcessInfo
        {
            Process _process;
            public ProcessInfo(Process process)
            {
                _process = process;
            }
            public override string ToString() { return string.Format("{0} {1}", _process.Id, _process.ProcessName); }
            public void Kill()
            {
                _process.Refresh();
                if (!_process.HasExited)
                {
                    _process.Kill();
                }
            }
        }
    }
}