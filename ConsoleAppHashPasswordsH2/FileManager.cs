using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppHashPasswordsH2
{
    class FileManager
    {
        public void WriteToFile(byte[] hashedPassword)
        {
            using (StreamWriter file = new StreamWriter(@".\PasswordHolder.txt", true))
            {
                file.WriteLine(Convert.ToBase64String(hashedPassword));
            }
        }

        public List<string> ReadFromFile()
        {
            List<string> readText = new List<string>();
            readText = File.ReadAllLines(@".\PasswordHolder.txt").ToList();
            return readText;
        }
    }
}
