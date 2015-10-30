using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LIB.Common;

namespace LIB
{
    public class ReportDAO
    {
        public DataTable ReportOnAvaiableCopies()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP9901",
                                                                    new Dictionary<string, SqlDbType>() {},
                                                                    new List<object>() {}).ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception e)
            {
                Log.Error("Error at ReportDAO - ReportOnAvaiableCopies", e);
                return null;
            }

            return dt;
        }

        public DataTable ReportOnCategory()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP9902",
                                                                    new Dictionary<string, SqlDbType>() { },
                                                                    new List<object>() { }).ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception e)
            {
                Log.Error("Error at ReportDAO - ReportOnPassDueDate", e);
                return null;
            }

            return dt;
        }

        public DataTable ReportOnPassDueDateChart()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP9903Chart",
                                                                    new Dictionary<string, SqlDbType>() { },
                                                                    new List<object>() { }).ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception e)
            {
                Log.Error("Error at ReportDAO - ReportOnPassDueDate", e);
                return null;
            }

            return dt;
        }

        public DataTable ReportOnPassDueDateDetail()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP9903Detail",
                                                                    new Dictionary<string, SqlDbType>() { },
                                                                    new List<object>() { }).ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception e)
            {
                Log.Error("Error at ReportDAO - ReportOnPassDueDate", e);
                return null;
            }

            return dt;
        }
        
        public DataTable ReportOfRentalOnISBN(string ISBN)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP9904",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {{"@ISBN", SqlDbType.NVarChar}},
                                                                    new List<object>() {ISBN}).ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception e)
            {
                Log.Error("Error at ReportDAO - ReportOfRentalOnISBN", e);
                return null;
            }
            return dt;
        }

        public DataTable ReportOfRentalOnUserId(string UserId)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP9905",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {{"@UserID", SqlDbType.NVarChar}},
                                                                    new List<object>() {UserId}).ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception e)
            {
                Log.Error("Error at ReportDAO - ReportOfRentalOnUserId", e);
                return null;
            }
            return dt;
        }
    }
}
