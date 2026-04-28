using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_C_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isAppRunning = true;  // Flag to control the application flow

            while (isAppRunning)
            {
                // Step 1: Show the login form
                using (frmLogin loginForm = new frmLogin())
                {
                    // Show login form as a dialog
                    if (loginForm.ShowDialog() == DialogResult.OK)  // If login is successful
                    {
                        // Step 2: After successful login, retrieve the username (or other parameters)
                        string username = loginForm.GetLoggedInUsername();  // Assume frmLogin has a method to get the username
                        // Step 3: Pass the parameter to frmMain when creating it
                        using (frmMain mainForm = new frmMain(username))  // Pass the username to frmMain
                        {
                            // Show the main form as a dialog
                            if (mainForm.ShowDialog() == DialogResult.Yes)  // If user clicks "Logout"
                            {
                                // Logout was requested, so we go back to the login form
                                continue;  // Loop back to show the login form again
                            }
                            else
                            {
                                // If the main form closes without logging out, exit the app
                                isAppRunning = false;
                            }
                        }
                    }
                    else
                    {
                        // If login form closes (e.g., user cancels), exit the loop
                        isAppRunning = false;
                    }
                }
            }
        }
    }
}
