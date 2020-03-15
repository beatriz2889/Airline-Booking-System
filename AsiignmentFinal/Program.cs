using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsiignmentFinal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //Beatriz Morales 101159722
        /// Paul Ikhane 101162941
        /// Collins Mbuton 101175934 
        [STAThread]
        static void Main()
        {
            AirlineCoordinator coordinator = new AirlineCoordinator(100, 50, 5);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(coordinator));
        }
    }
}
