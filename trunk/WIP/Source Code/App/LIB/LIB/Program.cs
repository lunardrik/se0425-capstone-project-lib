using System;
using System.Threading;
using System.Windows.Forms;
using log4net;
using log4net.Config;


namespace LIB
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                BasicConfigurator.Configure();
                Log.Logger = LogManager.GetLogger(typeof (Program));

                Options.LoadConfigurationOptions();
                Options.LoadSystemVariable();

                TaskSchedulerUtil.CreateTask();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show("Chương trình đã được khởi động.");
            }
        }
    }
}
