using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BobsShop
{
    class FileWriter
    {
        public static void TxtWrite(string userName, string password, string salt)
        {
            const string path = "UserDetails.txt";

            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{userName} {password} {salt}");
                }
                MessageBox.Show("Username and password have been written to the file successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
