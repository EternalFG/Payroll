using LiteDB;
using Payroll.Core.Forms;
using Payroll.Core.Models;
using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Authentication : Form
    {
        public static ILiteDatabase Database = new LiteDatabase("Database.db");

        public static ILiteCollection<User> Collection = Database.GetCollection<User>("Users");
        public static ILiteCollection<IEmployee> Employees = Database.GetCollection<IEmployee>("Emp");
        public Authentication()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Authorization().Show();
            this.Hide();
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

        private void label6_Click(object sender, EventArgs e)
        {
            Database.Dispose();
            Application.Exit();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textUsername.Text) && !string.IsNullOrWhiteSpace(textPassword.Text))
            {
                User user = new User()
                {
                    UserName = textUsername.Text,
                    Password = textPassword.Text,
                    Employee = false,
                };
                if (Collection.FindById(user.UserName) != null)
                {
                    MessageBox.Show("User already exists.");
                    new Authorization().Show();
                    this.Hide();
                }
                else
                {
                    Collection.Insert(user);
                }
                
            }

        }
    }
}
