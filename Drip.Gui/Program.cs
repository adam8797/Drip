using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drip.Gui.Forms;

namespace Drip.Gui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Drip -  Driving Robots over IP");
            Console.WriteLine("(totally not a forced acronym)");
            Console.WriteLine("(c) Adam Schiavone 2015, All rights reserved");
            Console.WriteLine("Written for Illinois Robotics");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());

        }
    }
}
