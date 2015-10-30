using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIB
{
    public static class Options
    {
        public static bool Init = false;

        //WEB or APP
        public static bool IsWeb = false;

        // Database
        public static string DataSource { get; set; }
        public static string Database { get; set; }
        public static string UserId { get; set; }
        public static string Password { get; set; }

        // Image Folder
        public static string ImageFolder { get; set; }
        public static string NotAvaiable { get; set; }

        // Result Paging
        public static int NumberOfRecord { get; set; }

        // System Variable
        public static int CountOfCopy { get; set; }

        // System User
        public static UserDTO User { get; set; }

        // Auto Mail
        public static string MailSubject { get; set; }
        public static string EmailAddress { get; set; }
        public static string SMTPHost { get; set; }
        public static int SMTPPort { get; set; }
        public static string AuthenticationId { get; set; }
        public static string AuthenticationPassword { get; set; }

        public static void LoadConfigurationOptions()
        {
            DataSource = ConfigurationManager.AppSettings["Data Source"];
            Database = ConfigurationManager.AppSettings["Database"];
            UserId = ConfigurationManager.AppSettings["User Id"];
            Password = ConfigurationManager.AppSettings["Password"];

            ImageFolder = ConfigurationManager.AppSettings["ImageFolder"];
            NotAvaiable = ConfigurationManager.AppSettings["NotAvaiable"];
            NumberOfRecord = int.Parse(ConfigurationManager.AppSettings["NumberOfRecord"]);

            // Auto mail
            MailSubject = ConfigurationManager.AppSettings["MailSubject"];
            EmailAddress = ConfigurationManager.AppSettings["EmailAddress"];
            SMTPHost = ConfigurationManager.AppSettings["SMTPHost"];
            SMTPPort = int.Parse(ConfigurationManager.AppSettings["SMTPPort"]);
            AuthenticationId = ConfigurationManager.AppSettings["AuthenticationId"];
            AuthenticationPassword = ConfigurationManager.AppSettings["AuthenticationPassword"];
            
            Init = true;
        }

        public static void LoadSystemVariable()
        {
            VariableBUS bus = new VariableBUS();
        }

        public static void SaveConfigurationOptions()
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            ConfigurationManager.AppSettings["Data Source"] = DataSource;
            ConfigurationManager.AppSettings["Database"] = Database;
            ConfigurationManager.AppSettings["User Id"] = UserId;
            ConfigurationManager.AppSettings["Password"] = Password;
        }

        public static void SaveSystemVariable()
        {
            VariableBUS variableBUS = new VariableBUS();
            variableBUS.UpdateVariableByName("CountOfCopy", Options.CountOfCopy.ToString());
        }
    }
}
