using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VideoScreensaver
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

       
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                string firstArgument = args[0].ToLower().Trim();
                string secondArgument = null;

                // Handle cases where arguments are separated by colon. (/c:1)
                if (firstArgument.Length > 2)
                {
                    secondArgument = firstArgument.Substring(3).Trim();
                    firstArgument = firstArgument.Substring(0, 2);
                }
                else if (args.Length > 1)
                    secondArgument = args[1];

                if (firstArgument == "/c")           // Config argument
                {
                    Application.Run(new ConfigForm());
                }
                else if (firstArgument == "/p")      // Preview argument
                {
                    // TODO
                }
                else if (firstArgument == "/s")      // Full-screen argument
                {
                    ShowScreenSaver();
                }
                else    // In case an invalid argument is provided
                {
                    MessageBox.Show("Invalid Argument \"" + firstArgument +
                        "\"", "ScreenSaver",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else    // No arguments - treat like /s
            {
                ShowScreenSaver();
            }

        }
        static void ShowScreenSaver()
        {
            foreach (System.Windows.Forms.Screen screen in System.Windows.Forms.Screen.AllScreens)
            {
                    ScreenSaverForm screensaver = new ScreenSaverForm(screen.Bounds);
                    screensaver.Show();
            }
            Application.Run();
        }
    }

}
