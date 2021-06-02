using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// This program is designed to help grasp basic concepts of the building and designing a UI of C#. This 
/// will run a window with dialogue box, text field, and a check box.
/// </summary>
namespace HW12
{
    //This acts as the launching point of the program
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
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
