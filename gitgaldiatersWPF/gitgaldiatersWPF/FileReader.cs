using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace BobsShop
{
    public class FileReader
    {

        public static void GenerateTxtFile()
        {
            string txtUserDetails = "UserDetails.txt";

            if (!File.Exists(txtUserDetails)){
                File.CreateText(txtUserDetails);
            }
        }
        public static void TxtRead()
        {
            const string path = "UserDetails.txt";

            

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ');
                        if (parts.Length == 2)
                        {
                            string username = parts[0];
                            string password = parts[1];
                            string salt = parts[2];

                            MessageBox.Show($"Username: {username}, Password: {password}");
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
