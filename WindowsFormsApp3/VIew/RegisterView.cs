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
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.VIew
{
    public partial class RegisterView : Form
    {
        LoginController controller = new LoginController();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = usernametxtBox.Text;
            user.Password = passwordtxtBox.Text;
            controller.AddUser(user);
            MessageBox.Show("The user is succesfully registered!!!");
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            this.Hide();
            loginView.Show();
        }
    }
}
