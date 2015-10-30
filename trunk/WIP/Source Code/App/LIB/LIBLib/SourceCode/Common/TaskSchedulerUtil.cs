using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32.TaskScheduler;

namespace LIB
{
    public class TaskSchedulerUtil
    {
        
        public static void CreateTask()
        {
            try
            {
                const string taskName = "LIB_AutoMail";
                var appName = "AutoMail.exe";
                string accountName = "SYSTEM";
                string password = null;
                var hour = 12;
                var daysInterval = (short)1;

                try
                {
                    appName = ConfigurationManager.AppSettings["MailProgram"];
                }
                catch (Exception e)
                {
                    Log.Error("Error at TaskSchedulerUtil - CreateTask", e);
                }

                try
                {
                    hour = int.Parse(ConfigurationManager.AppSettings["MailTime"]);
                }
                catch (Exception e)
                {
                    Log.Error("Error at TaskSchedulerUtil - CreateTask", e);
                }

                try
                {
                    daysInterval = short.Parse(ConfigurationManager.AppSettings["MailInterval"]);
                }
                catch (Exception e)
                {
                    Log.Error("Error at TaskSchedulerUtil - CreateTask", e);
                }

                try
                {
                    accountName = ConfigurationManager.AppSettings["SchedulerAccount"];
                    password = ConfigurationManager.AppSettings["SchedulerPassword"];
                }
                catch (Exception e)
                {
                    Log.Error("Error at TaskSchedulerUtil - CreateTask", e);
                }

                // Get task service
                var service = new TaskService();

                // Define task
                var taskDefinition = service.NewTask();

                // Define trigger time
                var trigger = new DailyTrigger();
                var startTime = DateTime.Today;
                startTime.AddHours(hour);
                trigger.StartBoundary = startTime;
                trigger.DaysInterval = daysInterval;
                taskDefinition.Triggers.Add(trigger);

                // Define execute program
                taskDefinition.Actions.Add(new ExecAction(appName));

                // Register the task
                service.RootFolder.RegisterTaskDefinition(taskName, taskDefinition, TaskCreation.CreateOrUpdate, accountName, password,
                                                     TaskLogonType.InteractiveTokenOrPassword, null);

            }
            catch (Exception e)
            {
                Log.Error("Error at TaskSchedulerUtil - CreateTask", e);
            }
        }

    }
}
