using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_3_new_ver
{
    public class WorkWithDIsks
    {
        public static void createNewDisk(string name)
        {
            Directory.CreateDirectory(Constants.ROOTPATH + "\\" + name);
        }

        public static void scanForDisks(List<string> ts)
        {
            foreach (string disk in Directory.GetDirectories(Constants.ROOTPATH))   //creating a list with disks names and 
                                                                                    //adding all directories in list.
            {
                ts.Add(disk);
                
            }
        }

        //if user inserts name of disk that already exits create window 
        //which will ask delete existing disk or rename it or rename not created yet.

        public static void removeDisk(string name)
        {
            Directory.Delete(Constants.ROOTPATH + name);
        }

        public static void renameDisk(string oldname, string newname)
        {
            Directory.Move(Constants.ROOTPATH + oldname, Constants.ROOTPATH + newname);
        }

        public static string getDiskNameFromPath(string path)
        {
            return WorkWithFolders.getFolderNameFromPath(path).Replace("disk", "");
        }
    }
}
