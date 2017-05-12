using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_БД_ООП.Forms
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            // temporary solution for increasing the comfort of development process
            this.Visible = false;
            var mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == ConfigurationSettings.AppSettings["UserName"])
            {
                if (textBoxPassword.Text == ConfigurationSettings.AppSettings["Password"])
                {
                    this.Visible = false;
                    var mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    userNameErrorLabel.Visible = false;
                    passwordErrorLabel.Visible = true;
                }
            }
            else
            {
                userNameErrorLabel.Visible = true;
                passwordErrorLabel.Visible = false;
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signInButton.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
