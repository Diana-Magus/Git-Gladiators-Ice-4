using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Import System.IO for StreamWriter
using System.Windows.Forms; // Import System.Windows.Forms for Form

namespace BobsShop
{
    public partial class MainForm : Form
    {
        RegistrationStack<User> registrationStack = new RegistrationStack<User>();

        public MainForm()
        {
            InitializeComponent();
            FileReader.GenerateTxtFile();
        }

        private void btnWelcome_Click(object sender, MouseEventArgs e)
        {
            WelcomePanel.Visible = false;
            LoginPanel.Visible = true;
            
        }

        private void btnSignup_Click(object sender, MouseEventArgs e)
        {
            LoginPanel.Visible = false;
            RegisterPanel.Visible = true;
        }

        private void btnSubmit_Click(object sender, MouseEventArgs e) //Login credential validation
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            User tempUser = RegisterLogin.CreateTempUser(userName, password);

            bool valid = RegisterLogin.checkUserDetailsLogin(tempUser);

            if (valid)
            {
                //if bool true proceed to welcome
                this.Hide();
                WelcomeForm welcomeForm = new WelcomeForm(tempUser);
                welcomeForm.Show();
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                //if bool false display 'userpassword combination not valid
                MessageBox.Show("Username/password combination not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmitNew_Click(object sender, MouseEventArgs e)
        {
            string userName = txtUsernameNew.Text;
            string password = txtPasswordNew.Text;
            User tempUser = RegisterLogin.CreateTempUser(userName, password); //temp user is created to compare user values to db

            bool available = RegisterLogin.checkUserDetailsRegister(tempUser); //checks to see is user name is available

            if (available)  //registers user is username is available and password meets requiments
            {
                //if available display 'user account successfully created', proceed to welcome
                // registrationStack.AddCredentials(tempUser);
                // Write username, password and to file
                FileWriter.TxtWrite(userName, tempUser.UserPassword, tempUser.Salt); 
                
                txtUsername.Clear();
                txtPassword.Clear();
                this.Hide();

                WelcomeForm welcomeForm = new WelcomeForm(tempUser);
                welcomeForm.Show();

                
            }
            else
            {
                //if invalid display 'user name not available, please enter a different one'
                MessageBox.Show("Username not available, please enter a different one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, MouseEventArgs e)
        {
            RegisterPanel.Visible = false;
            LoginPanel.Visible = true;
        }
    }
}

