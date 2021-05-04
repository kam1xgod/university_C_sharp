using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace lab_3_new_ver.Forms
{
    public partial class NewFolderForm : Form
    {
        public List<string> folders;
        public static string curDisk = "";
        string curPath = Constants.ROOTPATH;

        public NewFolderForm()
        {
            InitializeComponent();
        }

        public NewFolderForm(string curDisk)
        {
            NewFolderForm.curDisk = curDisk;
            curPath += "\\disk" + curDisk;
            folders = new List<string>(Directory.GetDirectories(curPath));

            InitializeComponent();

            foreach (string folder in folders)
            {
                if (WorkWithFolders.checkFolderHaveSubFolders(folder) == false)
                {
                    selectNewFolderPathList.Items.Add(WorkWithFolders.getFolderNameFromPath(folder));
                }
                else
                {
                    selectNewFolderPathList.Items.Add(WorkWithFolders.getFolderNameFromPath(folder));
                    foreach (string subFolderName in WorkWithFolders.getSubFoldersNamesFromPath(folder, curDisk))
                    {
                        selectNewFolderPathList.Items.Add(subFolderName);
                    }
                }
            }
        }



        private void CreateFolderButton_Click(object sender, EventArgs e)
        {
            if (WorkWithFolders.checkIfFolderNameCorrect(folderNameTextBox.Text) == true)
            {
                if (WorkWithFolders.checkFolderExists(folderNameTextBox.Text, curPath) == false)
                {
                    Directory.CreateDirectory(curPath + "\\" + folderNameTextBox.Text);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Folder with this name already exist.\n" +
                        "Do you want to create it anyway?\n" +
                        "Note: it will delete old folder with all files.",
                        "Folder already exists",
                        MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Directory.Delete(curPath + "\\" + folderNameTextBox.Text, true);
                        Directory.CreateDirectory(curPath + "\\" + folderNameTextBox.Text);
                    }
                }

                if (showMessageCheckBox.Checked == true)
                {
                    MessageBox.Show("Folder was created successfully.", "Success.", MessageBoxButtons.OK);
                }

                if (closeWindowCheckBox.Checked == true)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Folder name is incorrect.", "Error.", MessageBoxButtons.OK);
                folderNameTextBox.Text = "";
                folderNameTextBox.Focus();
            }
        }
    
    private void NewFolderPathList_Click(object sender, EventArgs e)
        {
            selectNewFolderPathList.Items.Clear();

            folders.Clear();
            folders = new List<string>(Directory.GetDirectories(Constants.ROOTPATH + "\\disk" + curDisk));

            foreach (string folder in folders)
            {
                if (WorkWithFolders.checkFolderHaveSubFolders(folder) == false)
                {
                    selectNewFolderPathList.Items.Add(WorkWithFolders.getFolderNameFromPath(folder));
                }
                else
                {
                    selectNewFolderPathList.Items.Add(WorkWithFolders.getFolderNameFromPath(folder));
                    foreach (string subFolderName in WorkWithFolders.getSubFoldersNamesFromPath(folder, curDisk))
                    {
                        selectNewFolderPathList.Items.Add(subFolderName);
                    }
                }
            }
        }

        private void NewFolderPathList_SelectedIndexChanged(object sender, EventArgs e)
        {
            curPath += "\\" + selectNewFolderPathList.Text;
        }
    }
}
