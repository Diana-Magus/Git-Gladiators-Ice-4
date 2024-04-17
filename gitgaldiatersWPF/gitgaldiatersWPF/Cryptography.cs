using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BobsShop
{
    public class Cryptography
    { 
        public static string CreateSalt()
        {
            char[] str = new char[4];

            Random rnd = new Random();

            string salt = "";


            for (int i = 0; i < 4; i++)
            {
                str[i] = (char)rnd.Next();
                salt += str[i];
            }
            return salt;

        }

        public static string GenerateHash(string password, string salt)
        {
            string passwordSalt = password + salt;
            var sha = SHA256.Create(); // (BugArray.  6/05/2022.)

            var asBysteArray = Encoding.Default.GetBytes(passwordSalt); // (BugArray.  6/05/2022.)

            var hashedPassword = sha.ComputeHash(asBysteArray); // (BugArray.  6/05/2022.)

            return Convert.ToBase64String(hashedPassword); // (BugArray.  6/05/2022.)

        }
    }

    //BugArray.  6/05/2022. C# (.NET Core 6) - HOW TO HASH PASSWORD - Part 6. [Source Code} https://www.youtube.com/watch?v=2yEiwjUEZ78&list=PL2C7Up52sWPNRlzk5xrdjyyWpuDjNou8x&index=32&t=2s. (Acessed 8 April 20240)
}