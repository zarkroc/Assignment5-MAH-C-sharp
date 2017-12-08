using System;
using System.Windows.Forms;

/// <summary>
/// Author: Tomas Perers
/// Date: 2017-11-01
/// </summary>

namespace Assignment5
{
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
            Application.Run(new MainForm());
        }
    }
}
