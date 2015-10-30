using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using LIB;
using LIB.Common;

namespace LIB
{
    public class QuoteDAO
    {
        public string GetRandomQuote()
        {
            try
            {
                var reader = ConnectionManager.GetCommand("SP1301RAND",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                 },
                                             new List<object>()
                                                 {
                                                 }).ExecuteReader();

                if (reader.Read())
                {
                    return reader["QuoteContent"].ToString();
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at QuoteDAO - GetRandomQuote", e);
                return "";
            }
            return "";
        }
    }
}
