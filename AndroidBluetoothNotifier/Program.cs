using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidBluetoothNotifier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(currentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Notification notificationForm = new Notification();
            BluetoothServer server = new BluetoothServer(notificationForm);
            Application.Run();
            server = null;
            notificationForm = null;
        }

        static void currentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string error = "";
            try
            {
                Exception unhandeld = (Exception)e.ExceptionObject;
                error = "++++++++++++++++++++++++++++UNHANDELD EXCEPTION++++++++++++++++++++++++++++++++++++++++++++\r\n";
                error += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss:fff") + "\r\n";
                error += "CLS Terminating = " + e.IsTerminating.ToString() + "\r\n";
                error += "------------------------------------------------------------------------------------------\r\n";
                error += "Exception:\r\n";
                error += "Message: " + unhandeld.Message + "\r\n";
                error += "Source:  " + unhandeld.Source + "\r\n";
                error += "StackTrace:  " + unhandeld.StackTrace + "\r\n";
                error += "==========================================================================================\r\n";
                error += "Innerexception Message: \r\n";
                if (unhandeld.InnerException != null)
                {
                    error += unhandeld.InnerException.Message + "\r\n";
                    error += "Source:  " + unhandeld.InnerException.Source + "\r\n";
                    error += "StackTrace:  " + unhandeld.InnerException.StackTrace + "\r\n";
                }
                error += "==========================================================================================\r\n";
                using (StreamWriter writer = new StreamWriter(@"C:\Users\candoris\Desktop\ABN_unhandled.txt", true))
                {
                    writer.WriteLine(error);
                    writer.Flush();
                }
            }
            catch (Exception more)
            {
                //even more misery
                MessageBox.Show(error + " additional problem: " + more.Message);
            }
            finally
            {
                //cleanup 
                if (e.IsTerminating)
                {
                    MessageBox.Show(error);
                }
            }
        }
    }
}
