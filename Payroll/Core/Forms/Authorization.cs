using Payroll.Core.Models;
using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.Core.Forms
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '•';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Authentication().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textUsername.Text) && !string.IsNullOrWhiteSpace(textPassword.Text))
            {
                var user = Authentication.Collection.FindById(textUsername.Text);
                
                if (user != null)
                {
                    if (textPassword.Text == user.Password)
                    {
                        new Dashboard().Show();
                        this.Hide();
                    }    
                }
                else
                {
                    MessageBox.Show("Invalid login or password.");
                    textUsername.Clear();
                    textPassword.Clear();
                }

            }
        }
    }
}
