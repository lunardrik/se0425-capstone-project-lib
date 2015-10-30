using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using log4net;
using log4net.Config;


namespace LIB
{
    public class Log
    {
        private static ILog _logger;

        public static ILog Logger
        {
            get
            {
                if (_logger == null)
                {
                    //BasicConfigurator.Configure();
                    //_logger = LogManager.GetLogger(typeof(Program));
                }
                return _logger;
            }
            set
            {
                _logger = value;
            }
        }

        public static void Error(object message, Exception e)
        {
            Error(null, message, e);
        }

        public static void Error(UserDTO user, object message, Exception e)
        {
            // Insert action to db here
            var appType = Options.IsWeb ? "WEB" : "APP";
            user = user ?? (Options.User ?? ((HttpContext.Current == null ? null : HttpContext.Current.Session["USER"]) == null ? new UserDTO() { UserId = "Unknown" } : (UserDTO)HttpContext.Current.Session["USER"]));
            try
            {
                LogBUS bus = new LogBUS();
                bus.InsertLog(user.UserId, message.ToString(), appType + "/" + "ERROR");
            }
            catch (Exception ex)
            {
                Logger.Error("Error at Log - Error", ex);
            }            // Write to log incase of DB fail
            Logger.Error(message, e);

        }

        public static void Info(object message)
        {
            Info(null, message);
        }

        public static void Info(UserDTO user, object message)
        {
            // Insert action to db here
            var appType = Options.IsWeb ? "WEB" : "APP";
            user = user ?? (Options.User ?? ((HttpContext.Current == null ? null : HttpContext.Current.Session["USER"]) == null ? new UserDTO() { UserId = "Unknown" } : (UserDTO)HttpContext.Current.Session["USER"]));
            try
            {
                LogBUS bus = new LogBUS();
                bus.InsertLog(user.UserId, message.ToString(), appType + "/" + "INFO");

            }
            catch (Exception ex)
            {
                Logger.Error("Error at Log - Info", ex);
            }            // Write to log incase of DB fail
            Logger.Info(message);
        }

        public static void Error(string p)
        {
            Error(p, null);
        }
    }
}
