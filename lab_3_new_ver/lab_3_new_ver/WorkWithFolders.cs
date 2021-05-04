using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace lab_3_new_ver
{
    public class WorkWithFolders
    {
        public void scanForFolders(string path, List<string> vs)
        {
            foreach (string folder in Directory.GetDirectories(path))
            {
                vs.Add(folder);
            }
        }

        public void moveFolder(string oldPath, string newPath)
        {
            Directory.Move(oldPath, newPath);
        }

        public static void copyFolder(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public void renameFolder(string oldPathName, string newPathName)
        {
            Directory.Move(oldPathName, newPathName);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName + "\\" + source.Name);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        public static bool checkFolderHaveSubFolders(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] subfolders = directory.GetDirectories();
            if (subfolders.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkFolderExists(string folderName, string path)
        {
            return Directory.Exists(path + "\\" + folderName);
        }

        public static List<string> getSubFolders(string folderPath)
        {
            if (checkFolderHaveSubFolders(folderPath) == true)
            {
                List<string> subfolders = new List<string>();
                foreach (string subfolder in Directory.GetDirectories(folderPath))
                {
                    subfolders.Add(subfolder);
                }
                return subfolders;
            }
            else
            {

                return null;
            }
        }

        public static string getFolderNameFromPath(string path)
        {
            return path.Replace(Path.GetDirectoryName(path) + "\\", "");
        }

        public static List<string> getSubFoldersNamesFromPath(string path, string curDisk)
        {
            //working but... ah, it's cringe, dude.
            List<string> subFoldersNames = new List<string>();
            if (getSubFolders(path) != null)
            {
                foreach (string subfolder in getSubFolders(path))
                {
                    subFoldersNames.Add(subfolder.Replace(Constants.ROOTPATH + "\\disk" + curDisk + "\\", ""));
                    if (getSubFolders(subfolder) != null)
                    {
                        List<string> temp = new List<string>(getSubFoldersNamesFromPath(subfolder, curDisk));
                        foreach (string subSubFolder in temp)
                        {
                            subFoldersNames.Add(subSubFolder);
                        }
                    }
                }
                return subFoldersNames;
            }
            else
            {
                return null;
            }
        }

        public static bool checkIfFolderNameCorrect(string folderName)
        {
            char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
            if (folderName == "Write folder name." || folderName == "")
            {
                return false;
            }
            else
            {
                bool symbolsAreOK = true;
                foreach (char argument in invalidFileNameChars)
                {
                    if (folderName.Contains(argument))
                    {
                        symbolsAreOK = false;
                    }
                }
                return symbolsAreOK;
            }
        }
    }
}
