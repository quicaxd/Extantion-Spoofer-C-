using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spoofer.Tools
{
    internal class İnjector
    {
        public static string ReverseString(string entry)
        {
            char[] chars = entry.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        public static string ExtantionSpoofer(string filePath, string extantion)
        {
            string reversChar = "\u202E"; //read this text https://www.fileformat.info/info/unicode/char/202e/index.htm to this char explanation
            var Spoofer = Path.GetFileNameWithoutExtension(filePath) + reversChar + ReverseString(extantion) + Path.GetExtension(filePath);

            MessageBox.Show($"Changin file name to {Path.GetFileNameWithoutExtension(filePath)}exe{extantion}");
            return Spoofer;
        }
    }
}
