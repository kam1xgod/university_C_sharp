using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        }

        //апи функция для просмотра памяти
        [DllImport("kernel32.dll")]
        //для выделения памяти
        public static extern IntPtr GlobalAlloc(int con, int size);
        [DllImport("kernel32.dll")]
        //для освобождения
        public static extern int GlobalFree(IntPtr start);
        [DllImport("kernel32.dll")]
        public static extern void GlobalMemoryStatus(ref MEMORYSTATUS lpBuffer);
        //
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int
            dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        //
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int
        hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize,
        ref int lpNumberOfBytesRead);

        //
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int
            lpBaseAddress,
            byte[] lpBuffer, int dwSize, ref int
            lpNumberOfBytesWritten);
        //
        public struct MEMORYSTATUS
        {
            public UInt32 dwLength;               //Размер структуры, в байтах
            public UInt32 dwMemoryLoad;           //процент занятой памяти
            public UInt32 dwTotalPhys;            //общее кол-во физической(оперативной) памяти
            public UInt32 dwAvailPhys;            //свободное кол-во физической(оперативной) памяти
            public UInt32 dwTotalPageFile;        //предел памяти для системы или текущего процесса
            public UInt32 dwAvailPageFile;        //Максимальный объем памяти,который текущий процесс может передать в байтах.
            public UInt32 dwTotalVirtual;         //общее количество виртуальной памяти(файл подкачки)
            public UInt32 dwAvailVirtual;         //свободное количество виртуальной памяти(файл подкачки)
            public UInt32 dwAvailExtendedVirtual; //Зарезервировано. Постоянно 0.
        }
        //функция для считывания памяти


        public void load()

        {
            //объявляем переменную типа мемористатус
            MEMORYSTATUS memStatus = new MEMORYSTATUS();
            //вызываем функцию с аргументом мемори статус
            GlobalMemoryStatus(ref memStatus);


            ram_percents.Text = "Используемая память: " + memStatus.dwMemoryLoad.ToString() + " %";
            virtual_all.Text = "Общая виртуальная память: " + (memStatus.dwTotalVirtual).ToString();
            virtual_empty.Text = "Свободная виртуальная память: " + memStatus.dwAvailVirtual.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string[] temp = comboBox1.SelectedItem.ToString().Split(' ');
            int ProcessID = Convert.ToInt32(temp[0]);
            Process process = Process.GetProcessById(ProcessID);
            IntPtr processHandle = OpenProcess(0x0010, false, process.Id);
            int bytesWritten = 0;
            byte[] buffer = Encoding.Unicode.GetBytes(textBox1.Text + "\0");
            WriteProcessMemory((int)processHandle, Int32.Parse(textBox1.Text, System.Globalization.NumberStyles.HexNumber),
                buffer, buffer.Length, ref bytesWritten);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] temp = comboBox1.SelectedItem.ToString().Split(' ');
            int ProcessID = Convert.ToInt32(temp[0]);
            Process process = Process.GetProcessById(ProcessID);
            IntPtr processHandle = OpenProcess(0x0010, false, process.Id);
            int length = Encoding.Unicode.GetBytes(textBox2.Text + "\0").Length;
            int bytesRead = 0;
            byte[] buffer = new byte[length];
            ReadProcessMemory((int)processHandle, Int32.Parse(textBox1.Text, System.Globalization.NumberStyles.HexNumber), buffer, buffer.Length, ref bytesRead);
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
                comboBox1.Items.Add(new ProcessInfo(instance));
            }
            comboBox1.SelectedIndex = 0;
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