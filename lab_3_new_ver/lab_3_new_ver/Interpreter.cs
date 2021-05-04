using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_3_new_ver
{
    class Interpreter
    {
        public static bool isDirContainsFolder(string curDir, string folderName)
        {
            bool contains = true;
            foreach (string folder in Directory.GetDirectories(curDir))
            {
                if (!(WorkWithFolders.getFolderNameFromPath(folder) == folderName))
                {
                    contains = false;
                }
            }
            return contains;
        }

        public static bool isPathDisk(string param, List<char> allDisks)
        {
            if (!allDisks.Contains(Convert.ToChar(param)))
            {
                return false;
            }
            return true;
        }

        public static string cd(string curDir, string dir)
        {
            string result = "";
            if (Directory.Exists(Constants.ROOTPATH + "\\disk" + dir))
            {
                string[] filesOnDisk = Directory.GetFiles(Constants.ROOTPATH + "\\disk" + dir, "*.*", SearchOption.AllDirectories);
                long temp = 0;
                foreach (string file in filesOnDisk)
                {
                    var info = new FileInfo(file);
                    temp += info.Length;
                }
                if (temp >= Constants.VOLUMELIMIT)
                {
                    return "You can't choose this disk.";
                }
                result = "disk";
                return result;
            }

            foreach (string folder in Directory.GetDirectories(curDir))
            {
                if (dir == WorkWithFolders.getFolderNameFromPath(folder))
                {
                    result = "folder in dir";
                    return result;
                }
            }

            if (Directory.Exists(curDir + "\\" + dir) == true)
            {
                result = "dir";
                return result;
            }
            
            result = "doesn't exists";
            return result;
            
        }

    }
}

