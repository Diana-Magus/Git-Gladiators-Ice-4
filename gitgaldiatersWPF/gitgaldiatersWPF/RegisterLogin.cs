using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BobsShop
{
    internal static class RegisterLogin
    {

        public static bool checkUserDetailsRegister(User tempUser) //checks if user name exists
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
                            if (tempUser.Name.Equals(username))
                            {
                                MessageBox.Show("Username already exists, please enter a different one");
                                return false;
                            }
                        }
                    }

                    if (!Regex.IsMatch(tempUser.UserPassword, @"[0-9]+") && !Regex.IsMatch(tempUser.UserPassword, @"[A-Z]+") && !Regex.IsMatch(tempUser.UserPassword, @".{8,}")) // Password needs to require a Number, an Upper Character, and cannot be no less than 8 Characters (StackOverflow. 20/01/2016.) (ByteHide. 21/05/2023.)
                    {
                        MessageBox.Show("Password is too weak. It needs to contain at least one number, one uppercase character, and be at least 8 characters long");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
           
            return true;
        }






        public static bool checkUserDetailsLogin(User tempUser)
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

                        string username = parts[0];
                        string password = parts[1];
                        string salt = parts[2];

                        string tempSaltedHashedPassword = Cryptography.GenerateHash(tempUser.UserPassword, salt);

                        if (tempUser.Name.Equals(username) && tempSaltedHashedPassword.Equals(password))
                        {
                            return true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
            return false;
        }

        //Method to add user to credential stack

        // Method to create a User object
        public static User CreateUser(string username, string password) //creates instance of user storing the name, hashed password and salt
        {
            string salt = Cryptography.CreateSalt();

            string hashedSaltedPassword=Cryptography.GenerateHash(password, salt);

            return new User(username, hashedSaltedPassword, salt);
        }

        public static User CreateTempUser(string username, string password) //creates instance of user storing the name, hashed password and salt
        {
            

            return new User(username, password);
        }

    }

    //StackOverflow. 20/01/2016. Validating password using regex C#. [Online] Available at: https://stackoverflow.com/questions/34715501/validating-password-using-regex-c-sharp. (Accessed 10 April 2024)
    //ByteHide. 21/05/2023. Regex in C#. [Online] Available at: https://www.bytehide.com/blog/regex-csharp. (Accessed 10 April 2024)
}
