using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class LogBUS
    {
        public int InsertLog(String username,String action,String logType)
        {
            LogDAO dao = new LogDAO();
            return dao.InsertLog(username, action, logType);
        }
    }
}
