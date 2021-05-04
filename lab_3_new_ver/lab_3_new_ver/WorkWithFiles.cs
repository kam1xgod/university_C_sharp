using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_3_new_ver
{
    class WorkWithFiles
    {
        public static bool checkIfFileNameCorrect(string fileName)
        {
            char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
            if (fileName == "Write your file name here." || fileName == "")
            {
                return false;
            }
            else
            {
                bool symbolsAreOK = true;
                foreach (char argument in invalidFileNameChars)
                {
                    if (fileName.Contains(argument))
                    {
                        symbolsAreOK = false;
                    }
                }
                return symbolsAreOK;
            }
        }
    }
}
