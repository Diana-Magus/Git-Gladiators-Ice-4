using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobsShop
{
    public partial class WelcomeForm : Form
    {
        public User User;
        public WelcomeForm(User user)
        {
            InitializeComponent();
            User = user;
            labUsername.Text = User.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labUsername_Click(object sender, EventArgs e)
        {
            
        }
    }
}
