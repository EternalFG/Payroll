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
        public const string DBNAME = "payroll.db";
        public static ILiteDatabase Database;
        [STAThread]
        static void Main()
        {
            using (Database)
            {
                new LiteDatabase(DBNAME);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authentication());
            
        }
    }
}
