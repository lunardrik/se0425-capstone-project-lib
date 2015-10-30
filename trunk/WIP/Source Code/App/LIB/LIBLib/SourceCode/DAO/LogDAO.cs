using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using LIB.Common;

namespace LIB
{
    public class LogDAO
    {
        public int InsertLog(String username,String action,String logType)
        {
            try
            {
                ConnectionManager.GetCommand("SP1402Log",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar},
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.NVarChar},
                                                     {"@Param4", SqlDbType.DateTime},
                                                     {"@Param5", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     username,
                                                     action,
                                                     logType,
                                                     DateTime.Now,
                                                     DateTime.Now
                                                 }).ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Log.Logger.Error("Error at LogDAO - InsertLog", e);
                return 0;
            }
            return 1;
        }
    }
}
