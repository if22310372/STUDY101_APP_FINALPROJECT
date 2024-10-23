using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace STUDY101_APP_FINALPROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Tampilkan MainMenu saat aplikasi dimulai
            Application.Run(new CALENDER_PAGE());
        }
    }
}
