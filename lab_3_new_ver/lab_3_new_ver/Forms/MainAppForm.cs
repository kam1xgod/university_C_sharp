using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using lab_3_new_ver.Forms;

namespace lab_3_new_ver
{
    
    public partial class MainForm : Form
    {
        public List<string> disks = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            //add all disk's names in DropDownList;
            //when in DropDownList selected disk change variety curDisk to current disk path.

            //I can easily make interpreter by adding richtextbox and label on left side.
            //each hitting of Enter button will simply do richTextBoxName += "\n" and then duplicate label little bit below.

        }

        private void SelectDiskList_Click(object sender, EventArgs e)
        {
            selectDiskList.Items.Clear();

            disks.Clear();

            WorkWithDIsks.scanForDisks(disks);
            foreach (string disk in disks)
            {
                selectDiskList.Items.Add(WorkWithDIsks.getDiskNameFromPath(Constants.ROOTPATH + "\\" + disk));
            }
        }

        private void SelectDiskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkWithDIsks.scanForDisks(disks);
            string curDisk = Constants.ROOTPATH + "\\disk" + selectDiskList.Text;
            string[] filesOnDisk = Directory.GetFiles(curDisk, "*.*", SearchOption.AllDirectories);
            long temp = 0;
            foreach (string file in filesOnDisk)
            {
                var info = new FileInfo(file);
                temp += info.Length;
            }
            if (temp >= Constants.VOLUMELIMIT)
            {
                MessageBox.Show("You can't work with this disk.\n" +
                    "Disk volume bigger than 2GB.",
                    "Error.",
                    MessageBoxButtons.OK);
                selectDiskList.SelectedItem = "";
            }
        }

        private void CreateNewDiskButton_Click(object sender, EventArgs e)
        {
            NewDiskForm createNewDiskForm = new NewDiskForm();
            createNewDiskForm.Show();
        }

        private void CreateNewDirInDiskButton_Click(object sender, EventArgs e)
        {
            if (selectDiskList.Text != "")
            {
                NewFolderForm nFolderF = new NewFolderForm(selectDiskList.SelectedItem.ToString());
                nFolderF.Show();
            }
            else
            {
                MessageBox.Show("Select disk, please.", "Error.", MessageBoxButtons.OK);
            }
        }

        private void CreateNewFileButton_Click(object sender, EventArgs e)
        {
            if (selectDiskList.Text != "")
            {
                NewFileForm nFileF = new NewFileForm(selectDiskList.SelectedItem.ToString());
                nFileF.Show();
            }
            else
            {
                MessageBox.Show("Select disk, please.", "Error.", MessageBoxButtons.OK);
            }
        }

        private void OpenCurDiskInExpButton_Click(object sender, EventArgs e)
        {
            if (selectDiskList.Text != "")
            {
                Process.Start(@Constants.ROOTPATH + "\\disk" + selectDiskList.Text);
            }
            else
            {
                MessageBox.Show("Select disk, please.", "Error.", MessageBoxButtons.OK);
            }
        }

        private void OpenInterpreterButton_Click(object sender, EventArgs e)
        {
            if (selectDiskList.Text == "")
            {
                CommandLine commandLine = new CommandLine() ;
                commandLine.Show();
            }
            else
            {
                CommandLine commandLine = new CommandLine();
                commandLine.Show();
            }
        }
    }
}
