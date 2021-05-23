using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_project.model;


namespace inventory_project
{
    static class Program
    {
        public static int user_id = 0;
        public static List<Permissions> list = new List<Permissions>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new view.login());
        }
    }
}
