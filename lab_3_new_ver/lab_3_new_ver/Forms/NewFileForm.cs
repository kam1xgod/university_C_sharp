using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace lab_3_new_ver.Forms
{
    public partial class NewFileForm : Form
    {
        public List<string> folders;
        public static string curDisk = "";
        string curPath = Constants.ROOTPATH;

        public NewFileForm(string curDisk)
        {
            NewFileForm.curDisk = curDisk;
            curPath += "\\disk" + curDisk;
            folders = new List<string>(Directory.GetDirectories(curPath));

            InitializeComponent();

            foreach (string folder in folders)
            {
                if (WorkWithFolders.checkFolderHaveSubFolders(folder) == false)
                {
                    selectNewFilePathList.Items.Add(WorkWithFolders.getFolderNameFromPath(folder));
                }
                else
                {
                    selectNewFilePathList.Items.Add(WorkWithFolders.getFolderNameFromPath(folder));
                    foreach (string subFolderName in WorkWithFolders.getSubFoldersNamesFromPath(folder, curDisk))
                    {
                        selectNewFilePathList.Items.Add(subFolderName);
                    }
                }
            }
        }

        public NewFileForm()
        {
            InitializeComponent();
        }

        private void SelectFilePathList_Click(object sender, EventArgs e)
        {
            selectNewFilePathList.Items.Clear();
            folders.Clear();
            folders = new List<string>(Directory.GetDirectories(curPath));

            foreach (string folder in folders)
            {
                if (WorkWithFolders.checkFolderHaveSubFolders(folder) == false)
                {
                    selectNewFilePathList.Items.Add(WorkWithFolders.getFolderNameFromPath(folder));
                }
                else
                {
                    selectNewFilePathList.Items.Add(WorkWithFolders.getFolderNameFromPath(folder));
                    foreach (string subFolderName in WorkWithFolders.getSubFoldersNamesFromPath(folder, curDisk))
                    {
                        selectNewFilePathList.Items.Add(subFolderName);
                    }
                }
            }
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            if (WorkWithFiles.checkIfFileNameCorrect(fileNameTextBox.Text) == true)
            {
                if (File.Exists(curPath) == false)
                {
                    File.Create(curPath + "\\" + fileNameTextBox.Text);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("File with this name already exists.\n" +
                        "Do you want to create it anyway?\n" +
                        "Note: it will delete old file.",
                        "Error.",
                        MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(curPath + "\\" + fileNameTextBox.Text);
                        File.Create(curPath + "\\" + fileNameTextBox.Text);
                    }
                }

                if (showMessageCheckBox.Checked == true)
                {
                    MessageBox.Show("File was created successfully.", "Success.", MessageBoxButtons.OK);
                }

                if (closeWindowCheckBox.Checked == true)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("File name is incorrect.", "Error.", MessageBoxButtons.OK);
            }
        }

        private void SelectFilePathList_SelectedIndexChanged(object sender, EventArgs e)
        {
            curPath += "\\" + selectNewFilePathList.Text;
        }
    }
}
