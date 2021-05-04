using System;
using System.Windows.Forms;

namespace lab_3_new_ver.Forms
{
    public partial class NewDiskForm : Form
    {
        public NewDiskForm()
        {
            InitializeComponent();
        }

        private void CreateDiskButton_Click(object sender, EventArgs e)
        {
            WorkWithDIsks.createNewDisk("disk" + diskNameTextBox.Text);
        }
    }
}
