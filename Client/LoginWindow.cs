using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginWindow : Form
    {
        private ClientCtrl ctrl;
        public LoginWindow(ClientCtrl ctrl)
        {
            InitializeComponent();
            this.ctrl = ctrl;
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void loginBttn_Click(object sender, System.EventArgs e)
        {
            string user = this.User.Text;
            string password = this.Pass.Text;
            try
            {
                ctrl.login(user, password);
                Console.WriteLine("Login succesful for " + user);
                MainWindow mainWindow = new MainWindow(ctrl);
                mainWindow.Text = "Main Window for employee " + user;
                mainWindow.Show();
                this.Hide();
            }catch(Exception ex)
            {
                MessageBox.Show(this, "Login error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
