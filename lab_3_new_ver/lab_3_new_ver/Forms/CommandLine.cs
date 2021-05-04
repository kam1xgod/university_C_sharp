using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace lab_3_new_ver.Forms
{
    public partial class CommandLine : Form
    {
        private Label curDirLabel;
        public TextBox curTextLine;
        private int offsetY = 22;
        private int msgoffset = 4;
        private bool hasMsg = false;

        private int curLabelX;
        private int curLabelY;
        private int curTextBoxX;
        private int curTextBoxY;

        private string curDir = Constants.ROOTPATH;
        private char curDisk;

        public CommandLine()
        {
            InitializeComponent();
            curDisk = 'C';
        }

        private void textLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                curTextLine.Enabled = false;
                string command = curTextLine.Text;
                if (command.Trim() == "")
                {
                    nextLine();
                    return;
                }
                string result = execute(command);
                if (result != null && result.Trim() != "")
                {
                    hasMsg = true;
                    addMessage(result);
                }
                nextLine();
            }
        }

        private void CommandLine_Load(object sender, EventArgs e)
        {
            pathLabel.Text = getFSPathFromAbsolutePath(curDir);
            curDirLabel = pathLabel;
            curTextLine = textLine;
            curLabelX = curDirLabel.Location.X;
            curLabelY = curDirLabel.Location.Y;
            curTextBoxX = curTextLine.Location.X;
            curTextBoxY = curTextLine.Location.Y;
            textLine.Focus();
            curDir += "\\disk" + curDisk;
            curDirLabel.Text = getFSPathFromAbsolutePath(curDir);
        }

        private void nextLine()
        {
            Label uLabel = new Label();
            uLabel.Text = curDirLabel.Text;
            uLabel.ForeColor = curDirLabel.ForeColor;
            uLabel.Width = curDirLabel.Width;
            uLabel.Font = curDirLabel.Font;
            curLabelY += offsetY + (hasMsg ? msgoffset : 0);
            Point pp = new Point(curLabelX, curLabelY);
            uLabel.Location = pp;
            panel1.Controls.Add(uLabel);
            pathLabel.Enabled = false;

            TextBox tLine = new TextBox();
            curTextBoxY += offsetY + (hasMsg ? msgoffset : 0);
            Point ppp = new Point(curTextBoxX, curTextBoxY);
            tLine.Location = ppp;
            tLine.Width = curTextLine.Width;
            tLine.KeyPress += textLine_KeyPress;
            tLine.ForeColor = curTextLine.ForeColor;
            tLine.BackColor = curTextLine.BackColor;
            tLine.BorderStyle = curTextLine.BorderStyle;
            tLine.Font = curTextLine.Font;
            panel1.Controls.Add(tLine);
            curTextLine = tLine;
            curTextLine.Focus();
            hasMsg = false;
        }

        private void addMessage(string result)
        {
            Label msg = new Label();
            msg.ForeColor = curDirLabel.ForeColor;
            msg.Font = curDirLabel.Font;
            msg.Text = result;
            msg.Width = (int)getContentSize(result).Width + 12;
            msg.Height = (int)getContentSize(result).Height + 23;
            Point pp = new Point(curLabelX, curLabelY + 26);
            msgoffset = msg.Height;
            msg.Location = pp;
            panel1.Controls.Add(msg);
        }

        private SizeF getContentSize(string content)
        {
            Font f = new Font("Microsoft Sans Serif", 14);
            Graphics g = panel1.CreateGraphics();
            SizeF siF = g.MeasureString(content, f);
            return siF;
        }

        private string execute(string command)
        {
            //dir — getDirectories; 1
            //rmdir — deleteDirectory; 2 
            //del — delete one file; 3 
            //cppy — copy; 4 
            //md, mkdir — make new dir; 6
            //move — move file or directory; 7
            //mf, mkfile — make new file; 9
            //cd — change directory; 10

            string[] cmdAndPar = command.Split(' ');
            string cmd = cmdAndPar[0];
            switch (cmd)
            {
                case "dir":
                    string dirsAndFiles = "";

                    if (Directory.GetDirectories(curDir).Length != 0)
                    {
                        foreach (string folder in Directory.GetDirectories(curDir))
                        {
                            dirsAndFiles += getFSPathFromAbsolutePath(folder) + "\n";

                            if (Directory.GetFiles(folder).Length != 0)
                            {
                                foreach (string file in Directory.GetFiles(folder))
                                {
                                    dirsAndFiles += Path.GetFileName(file) + "\n";
                                }
                            }
                        }

                        if (Directory.GetFiles(curDir).Length != 0)
                        {
                            foreach (string file in Directory.GetFiles(curDir))
                            {
                                dirsAndFiles += Path.GetFileName(file) + "\n";
                            }
                        }
                        return dirsAndFiles;
                    }

                    return "This folder is empty.";

                case "rmdir":
                    if (Directory.Exists(curDir + "\\" + cmdAndPar[1]))
                    {
                        Directory.Delete(curDir + "\\" + cmdAndPar[1], true);
                        return $"Folder { cmdAndPar[1] } was deleted successfully.";
                    }

                    return $"Folder with name { cmdAndPar[1] } wasn't found in this directory.";

                case "del":
                    if (Directory.GetFiles(curDir).Length != 0)
                    {
                        foreach (string file in Directory.GetFiles(curDir))
                        {
                            if (File.Exists(curDir + "\\" + cmdAndPar[1]))
                            {
                                File.Delete(curDir + "\\" + cmdAndPar[1]);
                                return $"File { cmdAndPar[1] } was deleted successfully.";
                            }
                        }
                    }

                    return $"File with name { cmdAndPar[1] } wasn't found in this directory.";

                case "copy":
                    if (Directory.Exists(curDir + "\\" + cmdAndPar[1]))
                    {
                        if (Directory.Exists(Constants.ROOTPATH + "\\disk" + cmdAndPar[2]))
                        {
                            WorkWithFolders.copyFolder(curDir + "\\" + cmdAndPar[1], Constants.ROOTPATH + "\\disk" + cmdAndPar[2]);
                            Directory.Delete(curDir + "\\" + cmdAndPar[1]);
                            return $"Folder { cmdAndPar[1] } was copied into { cmdAndPar[2] }";
                        }

                        if (Directory.Exists(curDir + "\\" + cmdAndPar[2]))
                        {
                            WorkWithFolders.copyFolder(curDir + "\\" + cmdAndPar[1], curDir + "\\" + cmdAndPar[2]);
                            Directory.Delete(curDir + "\\" + cmdAndPar[1]);
                            return $"Folder { cmdAndPar[1] } was copied into { cmdAndPar[2] }";
                        }
                    }

                    if (Directory.Exists(Constants.ROOTPATH + "\\disk" + cmdAndPar[1]))
                    {
                        if (Directory.Exists(Constants.ROOTPATH + "\\disk" + cmdAndPar[2]))
                        {
                            WorkWithFolders.copyFolder(Constants.ROOTPATH + "\\disk" + cmdAndPar[1], Constants.ROOTPATH + "\\disk" + cmdAndPar[2]);
                            Directory.Delete(Constants.ROOTPATH + "\\disk" + cmdAndPar[1]);
                            return $"Folder { cmdAndPar[1] } was copied into { cmdAndPar[2] }";
                        }

                        if (Directory.Exists(curDir + "\\" + cmdAndPar[2]))
                        {
                            WorkWithFolders.copyFolder(Constants.ROOTPATH + "\\disk" + cmdAndPar[1], curDir + "\\" + cmdAndPar[2]);
                            Directory.Delete(Constants.ROOTPATH + "\\disk" + cmdAndPar[1]);
                            return $"Folder { cmdAndPar[1] } was copied into { cmdAndPar[2] }";
                        }
                    }

                        return "Source path are not exists.";

                case "md":
                case "mkdir":
                    if (!Directory.Exists(curDir + "\\" + cmdAndPar[1]))
                    {
                        Directory.CreateDirectory(curDir + "\\" + cmdAndPar[1]);
                        return $"Folder { cmdAndPar[1] } was created successfully.";
                    }

                    if (!Directory.Exists(cmdAndPar[1]))
                    {
                        Directory.CreateDirectory(cmdAndPar[1]);
                        return $"Folder { cmdAndPar[1].Split('\\')[cmdAndPar[1].Split('\\').Length - 1] } was created successfully.";
                    }

                    return $"Folder { cmdAndPar[1] } already exists.";

                case "move":
                    if (Directory.Exists(curDir + "\\" + cmdAndPar[1]))
                    {
                        if (Directory.Exists(Constants.ROOTPATH + "\\disk" + cmdAndPar[2]))
                        {
                            WorkWithFolders.copyFolder(curDir + "\\" + cmdAndPar[1], Constants.ROOTPATH + "\\disk" + cmdAndPar[2]);
                            Directory.Delete(curDir + "\\" + cmdAndPar[1]);
                            return $"Folder { cmdAndPar[1] } was moved into { cmdAndPar[2] }";
                        }

                        if (Directory.Exists(curDir + "\\" + cmdAndPar[2]))
                        {
                            WorkWithFolders.copyFolder(curDir + "\\" + cmdAndPar[1], curDir + "\\" + cmdAndPar[2]);
                            Directory.Delete(curDir + "\\" + cmdAndPar[1]);
                            return $"Folder { cmdAndPar[1] } was moved into { cmdAndPar[2] }";
                        }
                    }

                    if (Directory.Exists(Constants.ROOTPATH + "\\disk" + cmdAndPar[1]))
                    {
                        if (Directory.Exists(Constants.ROOTPATH + "\\disk" + cmdAndPar[2]))
                        {
                            WorkWithFolders.copyFolder(Constants.ROOTPATH + "\\disk" + cmdAndPar[1], Constants.ROOTPATH + "\\disk" + cmdAndPar[2]);
                            Directory.Delete(Constants.ROOTPATH + "\\disk" + cmdAndPar[1]);
                            return $"Folder { cmdAndPar[1] } was moved into { cmdAndPar[2] }";
                        }

                        if (Directory.Exists(curDir + "\\" + cmdAndPar[2]))
                        {
                            WorkWithFolders.copyFolder(Constants.ROOTPATH + "\\disk" + cmdAndPar[1], curDir + "\\" + cmdAndPar[2]);
                            Directory.Delete(Constants.ROOTPATH + "\\disk" + cmdAndPar[1]);
                            return $"Folder { cmdAndPar[1] } was moved into { cmdAndPar[2] }";
                        }
                    }

                    return "Source path are not exists.";

                case "mf":
                case "mkfile":
                    if (!File.Exists(curDir + "\\" + cmdAndPar[1]))
                    {
                        File.Create(curDir + "\\" + cmdAndPar[1]);
                        return $"File { cmdAndPar[1] } was created successfully.";
                    }

                    if (!File.Exists(cmdAndPar[1]))
                    {
                        File.Create(cmdAndPar[1]);
                        return $"File { cmdAndPar[1].Split('\\')[cmdAndPar[1].Split('\\').Length - 1] } was created successfully.";
                    }

                    return $"File { cmdAndPar[1] } already exists.";

                case "cd":
                    if (cmdAndPar.Length < 2)
                    {
                        return "";
                    }
                    string resultCD = Interpreter.cd(curDir, cmdAndPar[1]);
                    if (resultCD == "disk")
                    {
                        curDir = Constants.ROOTPATH + "\\disk" + cmdAndPar[1];
                        curDirLabel.Text = getFSPathFromAbsolutePath(curDir);
                        resultCD = $"You are now in { getFSPathFromAbsolutePath(curDir) } disk.";
                    }
                    else if (resultCD == "folder in dir")
                    {
                        curDir += "\\" + cmdAndPar[1];
                        curDirLabel.Text = getFSPathFromAbsolutePath(curDir);
                        resultCD = $"You are now in { getFSPathFromAbsolutePath(curDir) } directory.";
                    }
                    else if (resultCD == "dir")
                    {
                        curDir = cmdAndPar[1];
                        curDirLabel.Text = getFSPathFromAbsolutePath(curDir);
                        resultCD = $"You are now in { getFSPathFromAbsolutePath(curDir) } directory.";
                    }
                    else if (resultCD == "doesn't exists")
                    {
                        resultCD = $"Directory { cmdAndPar[1] } doesn't exists.";
                    }

                    int tWidth = (int)getContentSize(curDirLabel.Text).Width + 5;
                    curTextBoxX = tWidth + 40;
                    curDirLabel.Width = tWidth;

                    return resultCD;

                case "exit":
                    this.Close();
                    return "";

                case "help":
                    return "dir — all folders and files in current directory.\n" +
                        "rmdir — delete folder in current directory.\n" +
                        "del — delete file in current directory.\n" +
                        "copy — copy file from one directory to another.\n" +
                        "md (mkdir) — create folder in current directory or in writed one.\n" +
                        "move — move file from one direcrory to another.\n" +
                        "mf (mkfile) — create folder in current directory or in writed one.\n" +
                        "cd — change current directory.\n" +
                        "exit — close command line.";

                default:
                    return "command not found " + cmd + "\nType \"help\" for help.";
            }
        }

        private static string getFSPathFromAbsolutePath(string absolutePath)
        {
            return absolutePath.Replace(Constants.ROOTPATH + "\\disk", "") + " ";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
