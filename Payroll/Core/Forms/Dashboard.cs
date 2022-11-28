using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Payroll.Core.Models;
using Payroll.Core.Services;
using System.Data.Common;
using LiteDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Payroll.Core.Forms
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );


        public static User User;
        public Dashboard()
        {
            InitializeComponent();
            hz.Hide();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height = buttonDashboard.Height;
            panelNav.Top = buttonDashboard.Top;
            panelNav.Left = buttonDashboard.Left;
            buttonDashboard.BackColor = Color.FromArgb(46, 51, 73);
            if (User.Employee)
            {
                Visibility(true, false, false, false);
            }
            else
            {
                Visibility(false, false, true, true);
            }
            
            nameUser.Text = User.UserName;
        }

        private void Visibility(bool calculateSalar, bool hzz, bool viewSub, bool dashboard)
        {
            label2.Visible = false;
            label3.Visible = false;
            dataGridViewSubordinates.Visible = false;
            createEmployeeSuccessfuly.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            labelLogin.Visible = false;
            labelPassword.Visible = false;
            hz.Visible = hzz;
            calculateSalary.Visible = calculateSalar;
            viewSubordinates.Visible = viewSub;
            textBoxBaseSalary.Visible = false;
            textBoxCalculateSalary.Visible = false;
            buttonDashboard.Visible = dashboard;
            label1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelNav.Height = buttonDashboard.Height;
            panelNav.Top = buttonDashboard.Top;
            panelNav.Left = buttonDashboard.Left;
            buttonDashboard.BackColor = Color.FromArgb(46, 51, 73);
            label2.Visible = false;
            label3.Visible = false;
            dataGridViewSubordinates.Visible = false;
            createEmployeeSuccessfuly.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            labelLogin.Visible = false;
            labelPassword.Visible = false;
            hz.Visible = false;
            calculateSalary.Visible = false;
            textBoxBaseSalary.Visible = false;
            textBoxCalculateSalary.Visible = false;
            label1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            
        }

        private void calculateSalary_Click(object sender, EventArgs e)
        {
            panelNav.Height = calculateSalary.Height;
            panelNav.Top = calculateSalary.Top;
            calculateSalary.BackColor = Color.FromArgb(46, 51, 73);
            label2.Visible = true;
            label3.Visible = true;
            foreach (var employee in Authentication.Employees.FindAll())
            {
                if (employee.Name == User.UserName)
                {
                    if (employee is Salesman salesman)
                    {
                        textBoxBaseSalary.Text = salesman.Salary.ToString();
                        textBoxCalculateSalary.Text = salesman.CalculateSalary().ToString();
                    }
                    else if (employee is Manager manager)
                    {
                        textBoxBaseSalary.Text = manager.Salary.ToString();
                        textBoxCalculateSalary.Text = manager.CalculateSalary().ToString();
                    }
                    else if (employee is Employee emp)
                    {
                        textBoxBaseSalary.Text = emp.Salary.ToString();
                        MessageBox.Show("Я тут");
                        textBoxCalculateSalary.Text = emp.CalculateSalary().ToString();
                        MessageBox.Show("Вышел");
                    }
                }
            }
        }

        private void viewSubordinates_Click(object sender, EventArgs e)
        {
            panelNav.Height = viewSubordinates.Height;
            panelNav.Top = viewSubordinates.Top;
            viewSubordinates.BackColor = Color.FromArgb(46, 51, 73);
            label2.Visible = false;
            label3.Visible = false;
            dataGridViewSubordinates.Visible = true;
            createEmployeeSuccessfuly.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            labelLogin.Visible = false;
            labelPassword.Visible = false;
            hz.Visible = false;
            calculateSalary.Visible = false;
            textBoxBaseSalary.Visible = false;
            textBoxCalculateSalary.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            //var employees = EmployeeTable.Employees.FindAll();
            for (int i = 0; i < dataGridViewSubordinates.Columns.Count; i++)
            {
                dataGridViewSubordinates.Rows.Add("sex", "Da", 30000, "Man", "Pizda");
            }
            //dataTable.Columns.Add("Name", typeof(string));
            //dataGridViewSubordinates.DataSource = dataAdapter;

        }

        private void buttonDashboard_Leave(object sender, EventArgs e)
        {
            buttonDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void calculateSalary_Leave(object sender, EventArgs e)
        {
            calculateSalary.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void viewSubordinates_Leave(object sender, EventArgs e)
        {
            viewSubordinates.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            new Authorization().Show();
            this.Hide();
        }

        private string getNickname(int nickLenth)
        {
            char[] vowels = "aeuoyi".ToCharArray();
            char[] consonants = "qwrtpsdfghjklzxcvbnm".ToCharArray();

            Random rand = new Random();
            StringBuilder newNick = new StringBuilder();

            while (newNick.Length < nickLenth)
            {
                bool firstVowel = rand.Next(0, 2) == 0 ? true : false;

                if (firstVowel)
                {
                    newNick.Append(vowels[rand.Next(0, vowels.Length)]);
                    newNick.Append(consonants[rand.Next(0, consonants.Length)]);
                }
                else
                {
                    newNick.Append(consonants[rand.Next(0, consonants.Length)]);
                    newNick.Append(vowels[rand.Next(0, vowels.Length)]);
                }
            }

            if (nickLenth % 2 != 0) newNick.Remove(newNick.Length - 1, 1);

            newNick[0] = char.ToUpper(newNick[0]);
            MessageBox.Show(newNick.ToString());
            return newNick.ToString();
            
        }

        private string getPassword()
        {
            int[] arr = new int[8]; 
            Random rnd = new Random();
            string Password = "";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(33, 125);
                Password += (char)arr[i];
            }
            return Password;
        }

        private void showSuccessfuly()
        {
            createEmployeeSuccessfuly.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            labelLogin.Visible = true;
            labelPassword.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text) &&
                !string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                if (decimal.TryParse(textBox5.Text, out decimal salary))
                {
                    EmployeeManager employeeManager = new EmployeeManager();
                    if (comboBox1.Text == "Man")
                    {
                        if (comboBox2.Text == "Employee")
                        {
                            Employee employee = employeeManager.CreateEmployee(textBox3.Text, textBox4.Text, salary, EmployeeGender.Man, DateTime.Now);
                            employee.User.UserName = getNickname(8);
                            employee.User.Password = getPassword();
                            employee.User.Employee = true;
                            Authentication.Employees.Insert(employee);
                            foreach (var emp in Authentication.Employees.FindAll())
                            {
                                MessageBox.Show(emp.Name);
                            }
                            Authentication.Collection.Insert(employee.User);
                            labelLogin.Text = employee.User.UserName;
                            labelPassword.Text = employee.User.Password;
                            showSuccessfuly();
                            
                        }
                        else if (comboBox2.Text == "Manager")
                        {
                            var employee = employeeManager.CreateManager(textBox3.Text, textBox4.Text, salary, EmployeeGender.Man, DateTime.Now);
                            employee.User.UserName = getNickname(8);
                            employee.User.Password = getPassword();
                            Authentication.Employees.Insert(employee);
                            Authentication.Collection.Insert(employee.User);
                            labelLogin.Text = employee.User.UserName;
                            labelPassword.Text = employee.User.Password;
                            showSuccessfuly();
                        }
                        else 
                        {
                            var employee = employeeManager.CreateSalesman(textBox3.Text, textBox4.Text, salary, EmployeeGender.Man, DateTime.Now);
                            employee.User.UserName = getNickname(8);
                            employee.User.Password = getPassword();
                            Authentication.Employees.Insert(employee);
                            Authentication.Collection.Insert(employee.User);
                            labelLogin.Text = employee.User.UserName;
                            labelPassword.Text = employee.User.Password;
                            showSuccessfuly();
                        }
                    }
                    else if (comboBox1.Text == "Woman")
                    {
                        if (comboBox2.Text == "Employee")
                        {
                            var employee = employeeManager.CreateEmployee(textBox3.Text, textBox4.Text, salary, EmployeeGender.Woman, DateTime.Now);
                            employee.User.UserName = getNickname(8);
                            employee.User.Password = getPassword();
                            Authentication.Employees.Insert(employee);
                            Authentication.Collection.Insert(employee.User);
                            labelLogin.Text = employee.User.UserName;
                            labelPassword.Text = employee.User.Password;
                            showSuccessfuly();
                        }
                        else if (comboBox2.Text == "Manager")
                        {
                            var employee = employeeManager.CreateManager(textBox3.Text, textBox4.Text, salary, EmployeeGender.Woman, DateTime.Now);
                            employee.User.UserName = getNickname(8);
                            employee.User.Password = getPassword();
                            Authentication.Employees.Insert(employee);
                            Authentication.Collection.Insert(employee.User);
                            labelLogin.Text = employee.User.UserName;
                            labelPassword.Text = employee.User.Password;
                            showSuccessfuly();
                        }
                        else
                        {
                            var employee = employeeManager.CreateSalesman(textBox3.Text, textBox4.Text, salary, EmployeeGender.Woman, DateTime.Now);
                            employee.User.UserName = getNickname(8);
                            employee.User.Password = getPassword();
                            Authentication.Employees.Insert(employee);
                            Authentication.Collection.Insert(employee.User);
                            labelLogin.Text = employee.User.UserName;
                            labelPassword.Text = employee.User.Password;
                            showSuccessfuly();
                        }
                    }
                }
                     
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;

            if (label != null)
            {
                Clipboard.SetText(label.Text, TextDataFormat.UnicodeText);
            }
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;

            if (label != null)
            {
                Clipboard.SetText(label.Text, TextDataFormat.UnicodeText);
            }
        }
    }
}
