using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsShop
{
    public class User
    {
        
        public string Name { get; set; } //Name getter and setter
        public string UserPassword { get; set; } //password getter and setter

        public string Salt { get; set; }

        public User() //User constructor - empty
        {
        }

        public User(string name, string password, string salt) //User constructor with salt
        {
            Name = name;
            UserPassword = password;
            Salt = salt;
        }

        public User(string name, string password) //User constructor without salt to create temp user
        {
            Name = name;
            UserPassword = password;
            
        }

    }

}
