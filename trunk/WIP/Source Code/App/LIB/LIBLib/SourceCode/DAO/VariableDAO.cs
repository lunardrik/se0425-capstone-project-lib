using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using LIB.Common;

namespace LIB
{
    public class VariableDAO
    {
        public string GetVariableByName(string varName)
        {
            try
            {
                var reader = ConnectionManager.GetCommand("SP1201VarName",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar}
                                                 },
                                             new List<object>()
                                                 {
                                                     varName
                                                 }).ExecuteReader();

                if (reader.Read())
                {
                    return reader["Value"].ToString();
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at VariableDAO - GetVariableByName", e);
                return "";
            }
            return "";
        }

        public int UpdateVariableByName(string varName, string val)
        {
            try
            {
                var reader = ConnectionManager.GetCommand("SP1203VarName",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.NVarChar},
                                                     {"@Param2", SqlDbType.NVarChar}
                                                 },
                                             new List<object>()
                                                 {
                                                     varName,
                                                     val
                                                 }).ExecuteReader();

                return 1;
            }
            catch (Exception e)
            {
                Log.Error("Error at VariableDAO - UpdateVariableByName", e);
                return 0;
            }
        }
    }
}
