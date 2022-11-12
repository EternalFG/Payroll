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

        public Dashboard()
        {
            InitializeComponent();
            hz.Hide();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height = buttonDashboard.Height;
            panelNav.Top = buttonDashboard.Top;
            panelNav.Left = buttonDashboard.Left;
            buttonDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelNav.Height = buttonDashboard.Height;
            panelNav.Top = buttonDashboard.Top;
            panelNav.Left = buttonDashboard.Left;
            buttonDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void calculateSalary_Click(object sender, EventArgs e)
        {
            panelNav.Height = calculateSalary.Height;
            panelNav.Top = calculateSalary.Top;
            calculateSalary.BackColor = Color.FromArgb(46, 51, 73); 
        }

        private void viewSubordinates_Click(object sender, EventArgs e)
        {
            panelNav.Height = viewSubordinates.Height;
            panelNav.Top = viewSubordinates.Top;
            viewSubordinates.BackColor = Color.FromArgb(46, 51, 73);
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
    }
}
