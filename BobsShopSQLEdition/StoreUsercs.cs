using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsShop
{
    internal class RegistrationStack<User>
    {
        public Stack<User> credentialsStack;

        public RegistrationStack()
        {
            credentialsStack = new Stack<User>();
        }

        public void AddCredentials(User user)////Schoenrock I. 2019
        {

            credentialsStack.Push(user);

        }

        public string DisplayCredentials()
        {
            string credentialsString = string.Empty;

            foreach (var credential in credentialsStack)
            {
                credentialsString += credential + "\n";
            }

            return credentialsString;
        }
    }

}

//Schoenrock I. 2019. C# Tutorial: Stacks. [Online] Available at: https://www.youtube.com/watch?v=EMm0UB5On3w [Accessed 19 Mar. 2024].