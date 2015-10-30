using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LIB.Common
{
    public static class ConnectionManager
    {
        private static SqlConnection _con;

        public static SqlConnection Con
        {
            get
            {
                if (_con == null)
                {
                    _con = new SqlConnection(GetConnectionString());
                    _con.Open();
                    return _con;
                }
                if (_con.State == ConnectionState.Open)
                {
                    var ccon = new SqlConnection(GetConnectionString());
                    ccon.Open();
                    return ccon;
                    
                }
                if (_con.State == ConnectionState.Broken)
                {
                    _con.Close();
                }
                if (_con.State == ConnectionState.Closed)
                {
                    _con.Open();
                }
                return _con;
            }
        }

        public static string GetConnectionString()
        {
            if (!Options.Init)
            {
                Options.LoadConfigurationOptions();
            }

            string conStr = "Data Source=" + Options.DataSource +
                            ";Database=" + Options.Database +
                            ";User Id=" + Options.UserId +
                            ";Password=" + Options.Password +
                            "; Connection Timeout=30; Min Pool Size=20; Max Pool Size=100000;";
            return conStr;
        }

        /// <summary>
        /// Return a Sql Command with detailed information of SP and Parameters
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="parameters"></param>
        /// <param name="values"></param>
        /// <returns>Sql Command associated with SP</returns>
        public static SqlCommand GetCommand(string spName, Dictionary<string, SqlDbType> parameters, List<object> values)
        {
            return GetCommand(spName, parameters, values, null);
        }

        /// <summary>
        /// Return a Sql Command with detailed information of SP and Parameters
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="parameters"></param>
        /// <param name="values"></param>
        /// <returns>Sql Command associated with SP</returns>
        public static SqlCommand GetCommand(string spName, Dictionary<string, SqlDbType> parameters, List<object> values, SqlTransaction trans)
        {
            SqlCommand cmd = trans == null ? ConnectionManager.Con.CreateCommand() : trans.Connection.CreateCommand();
            cmd.CommandText = spName;
            cmd.Transaction = trans;

            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < parameters.Count; i++)
            {
                string parameterName = parameters.Keys.ElementAt(i);
                cmd.Parameters.Add(parameterName, parameters[parameterName]).Value = values[i];
            }

            return cmd;
        }
    }
}
