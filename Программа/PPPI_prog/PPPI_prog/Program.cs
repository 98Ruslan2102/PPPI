using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPI_prog
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения. Это полезное приложение, не пытайтесь спорить
        /// </summary>
		
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
