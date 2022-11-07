using LiteDB;
using Payroll.Core.Models;
using Payroll.Core.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Payroll
{
    public static class Program
    {
        private const string _dbName = "payroll.db";
        public static ILiteDatabase Database;
        [STAThread]
        static void Main()
        {
            Database = new LiteDatabase(Path.Combine(Directory.GetCurrentDirectory(), _dbName));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authentication());

            EmployeeManager manager = new EmployeeManager();
            Employee employee = manager.CreateEmployee("d", "d", 22, EmployeeGender.Man, 34444, DateTime.Now);
            
        }
    }
}
