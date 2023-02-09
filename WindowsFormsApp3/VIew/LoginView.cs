using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Controller;

namespace WindowsFormsApp3.VIew
{
    public partial class LoginView : Form
    {
        LoginController controller = new LoginController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxtBox.Text;
            string password = passwordtxtBox.Text;
            var users = controller.GetAllUsers();
            bool userFound = false;
            foreach  (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    userFound = true;
                }
            }

            if (userFound)
            {
                MainView mainView = new MainView();
                this.Hide();
                mainView.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!!!");
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            this.Hide();
            registerView.Show();
        }

        private void usernametxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordlbl_Click(object sender, EventArgs e)
        {

        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }

        private void passwordtxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
