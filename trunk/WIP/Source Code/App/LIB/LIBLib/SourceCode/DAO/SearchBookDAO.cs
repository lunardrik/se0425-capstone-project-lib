using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using LIB.Common;

namespace LIB
{
    public class SearchBookDAO
    {
        #region Search Basic

        public List<SearchBookResultDTO> SearchBasicBooks(string title, int sRow, int eRow)
        {
            DataTable result;
            List<SearchBookResultDTO> listResult = new List<SearchBookResultDTO>();
            SearchBookResultDTO resultDto;
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0001basic",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@title", SqlDbType.NVarChar},
                                                                            {"@rowStart", SqlDbType.Int},
                                                                            {"@rowEnd", SqlDbType.Int}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            title,
                                                                            sRow,
                                                                            eRow
                                                                        }).
                    ExecuteReader();
                result = new DataTable();
                while (reader.Read())
                {
                    resultDto = new SearchBookResultDTO();
                    resultDto.ISBN = reader["ISBN"].ToString();
                    resultDto.AuthorName = reader["AuthorName"].ToString();
                    resultDto.CategoryName = reader["CategoryName"].ToString();
                    resultDto.Image = reader["Image"].ToString();
                    resultDto.PublisherName = reader["PublisherName"].ToString();
                    resultDto.Title = reader["Title"].ToString();
                    resultDto.ShortDescription = reader["ShortDescription"].ToString();
                    resultDto.No = int.Parse(reader["No"].ToString());
                    listResult.Add(resultDto);
                }


                result.Load(reader);

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at SearchBooksDAO - SearchBasciBooks", e);
                return null;
            }

            return listResult;
        }

        public int SearchBasicBooksCount(string title)
        {
            int rs;
            try
            {
                rs = (int)ConnectionManager.GetCommand("sp0001basicC",
                                                        new Dictionary<string, SqlDbType>()
                                                            {
                                                                {"@title", SqlDbType.NVarChar}
                                                            },
                                                        new List<object>()
                                                            {
                                                                title
                                                            }).
                               ExecuteScalar();
            }
            catch (Exception e)
            {
                Log.Error("Error at SearchBooksDAO - SearchBasciBooksCount", e);
                return -1;
            }

            return rs;
        }

        #endregion

        #region Search Detail

        public List<SearchBookResultDTO> SearchDetailBooks(string title, string categoryId, string shortdesc, string authorname, int sRow, int eRow)
        {
            List<SearchBookResultDTO> listResult = new List<SearchBookResultDTO>();
            SearchBookResultDTO resultDto;
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0001detail",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@title", SqlDbType.NVarChar},
                                                                            {"@categoryId", SqlDbType.NVarChar},
                                                                            {"@shortdescription", SqlDbType.NVarChar},
                                                                            {"@authorname", SqlDbType.NVarChar},
                                                                            {"@rowStart", SqlDbType.Int},
                                                                            {"@rowEnd", SqlDbType.Int}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            title,
                                                                            categoryId,
                                                                            shortdesc,
                                                                            authorname,
                                                                            sRow,
                                                                            eRow
                                                                        }).
                    ExecuteReader();
                while (reader.Read())
                {
                    resultDto = new SearchBookResultDTO();
                    resultDto.ISBN = reader["ISBN"].ToString();
                    resultDto.AuthorName = reader["AuthorName"].ToString();
                    resultDto.CategoryName = reader["CategoryName"].ToString();
                    resultDto.Image = reader["Image"].ToString();
                    resultDto.PublisherName = reader["PublisherName"].ToString();
                    resultDto.Title = reader["Title"].ToString();
                    resultDto.ShortDescription = reader["ShortDescription"].ToString();
                    resultDto.No = int.Parse(reader["No"].ToString());
                    listResult.Add(resultDto);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at SearchBooksDAO - SearchDetailBooks", e);
                return null;
            }

            return listResult;
        }

        public int SearchDetailBooksCount(string title, string categoryId, string shortdesc, string authorname)
        {
            int rs;
            try
            {
                rs = (int)ConnectionManager.GetCommand("sp0001detailC",
                                                        new Dictionary<string, SqlDbType>()
                                                            {
                                                                {"@title", SqlDbType.NVarChar},
                                                                {"@categoryId", SqlDbType.NVarChar},
                                                                {"@shortdescription", SqlDbType.NVarChar},
                                                                {"@authorname", SqlDbType.NVarChar}
                                                            },
                                                        new List<object>()
                                                            {
                                                                title,
                                                                categoryId,
                                                                shortdesc,
                                                                authorname
                                                            }).
                               ExecuteScalar();
            }
            catch (Exception e)
            {
                Log.Error("Error at SearchBooksDAO - SearchDetailBooksCount", e);
                return -1;
            }

            return rs;
        }

        #endregion

        #region Search Advance

        public List<SearchBookResultDTO> SearchAdvanceBooks(SearchBookDTO dto, int sRow, int eRow)
        {
            string param1 = GetParamInfor(dto.Field1, dto.Type1, dto.Info1);
            string param2 = dto.Ano1 + " " + GetParamInfor(dto.Field2, dto.Type2, dto.Info2);
            string param3 = dto.Ano2 + " " + GetParamInfor(dto.Field3, dto.Type3, dto.Info3);

            List<SearchBookResultDTO> listResult = new List<SearchBookResultDTO>();
            SearchBookResultDTO resultDto;
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0001advance",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@param1",SqlDbType.NVarChar},
                                                                            {"@param2",SqlDbType.NVarChar},
                                                                            {"@param3",SqlDbType.NVarChar},
                                                                            {"@sRow",SqlDbType.NVarChar},
                                                                            {"@eRow",SqlDbType.NVarChar}
                                                                        },
                                                                    new List<object>() { param1, param2, param3, sRow.ToString(), eRow.ToString() }).
                    ExecuteReader();
                while(reader.Read())
                {
                    resultDto = new SearchBookResultDTO();
                    resultDto.ISBN = reader["ISBN"].ToString();
                    resultDto.AuthorName = reader["AuthorName"].ToString();
                    resultDto.CategoryName = reader["CategoryName"].ToString();
                    resultDto.Image = reader["Image"].ToString();
                    resultDto.PublisherName = reader["PublisherName"].ToString();
                    resultDto.Title = reader["Title"].ToString();
                    resultDto.ShortDescription = reader["ShortDescription"].ToString();
                    resultDto.No = int.Parse(reader["No"].ToString());
                    listResult.Add(resultDto);
                }
                //int count = result.Rows.Count;
                reader.Close();
            }
            catch (Exception e)
            {
                Log.Logger.Error("Error at SearchBookDAO - SearchAdvanceBooks", e);
                return null;
            }

            return listResult;
        }

        public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            return dTable;
        }

        public string GetParamInfor(string cboxItem1, int cboxItem2, string info)
        {
            List<string> fields = new List<string>();
            string searchParam = "";
            string param = "";

            switch (cboxItem1)
            {
                case "Mọi Trường":
                    fields.Add("Title ");
                    fields.Add("AuthorName ");
                    fields.Add("PublisherName ");
                    fields.Add("CategoryName ");
                    fields.Add("c.ISBN ");
                    fields.Add("Language ");
                    break;
                case "Tựa Sách":
                    fields.Add("Title ");
                    break;
                case "Tác giả":
                    fields.Add("AuthorName ");
                    break;
                case "Nhà Xuất Bản":
                    fields.Add("PublisherName ");
                    break;
                case "Danh Mục":
                    fields.Add("CategoryName ");
                    break;
                case "Ngôn Ngữ":
                    fields.Add("Language ");
                    break;
            }
            switch (cboxItem2)
            {
                case 0:
                    param = "like N'" + info + "%'";
                    break;
                case 1:
                    param = "like N'%" + info + "'";
                    break;
                case 2:
                    param = "like N'%" + info + "%'";
                    break;
                case 3:
                    param = " = N'" + info + "'";
                    break;
            }
            for (int i = 0; i < fields.Count; i++)
            {
                searchParam = searchParam + (i > 0 ? " or " : "") + fields[i] + param;
            }
            searchParam = "(" + searchParam + ")";
            return searchParam;
        }

        public int SearchAdvanceBooksCount(SearchBookDTO dto)
        {
            string param1 = GetParamInfor(dto.Field1, dto.Type1, dto.Info1);
            string param2 = dto.Ano1 + " " + GetParamInfor(dto.Field2, dto.Type2, dto.Info2);
            string param3 = dto.Ano2 + " " + GetParamInfor(dto.Field3, dto.Type3, dto.Info3);
            int result;
            try
            {
                result = (int)ConnectionManager.GetCommand("sp0001advanceC",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@param1",SqlDbType.NVarChar},
                                                                            {"@param2",SqlDbType.NVarChar},
                                                                            {"@param3",SqlDbType.NVarChar}
                                                                        },
                                                                    new List<object>() { param1, param2, param3 }).
                    ExecuteScalar();
            }
            catch (Exception e)
            {
                Log.Logger.Error("Error at SearchBookDAO - SearchAdvanceBooksCount", e);
                return 0;
            }

            return result;
        }

        #endregion

        public DataTable SearchBooksByAuthor(string authorId, int sRow, int eRow)
        {
            DataTable result;
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0001author",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@authorId", SqlDbType.NVarChar},
                                                                            {"@rowStart", SqlDbType.Int},
                                                                            {"@rowEnd", SqlDbType.Int}
                                                                        },
                                                                    new List<object>() { authorId, sRow, eRow }).
                    ExecuteReader();
                result = new DataTable();


                result.Load(reader);

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at SearchBooksDAO - SearchBooksByAuthor", e);
                return null;
            }

            return result;
        }

        public int SearchBooksByAuthorCount(string authorId)
        {
            int rs;
            try
            {
                rs = (int)ConnectionManager.GetCommand("sp0001authorC",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@authorId", SqlDbType.NVarChar}
                                                                        },
                                                                    new List<object>() { authorId }).
                    ExecuteScalar();
            }
            catch (Exception e)
            {
                Log.Error("Error at SearchBooksDAO - SearchBooksByAuthorCount", e);
                return -1;
            }

            return rs;
        }

        public DataTable SearchBooksHit()
        {
            DataTable result;
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0001hit",
                                                                    new Dictionary<string, SqlDbType>() { },
                                                                    new List<object>() { }).
                    ExecuteReader();
                result = new DataTable();


                result.Load(reader);
                //while (reader.Read())
                //{
                //    result.Rows.Add(reader.NextResult());
                //}

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at SearchBooksDAO - SearchBooksHit", e);
                return null;
            }

            return result;
        }

        public class SimpleCopyOfBook
        {
            public string Barcode { get; set; }

            public string Title { get; set; }
        }

        public class SimpleCatalogue
        {
            public string ISBN { get; set; }

            public string Title { get; set; }
        }

        public List<SimpleCopyOfBook> SearchBarcode(SearchBookDTO dto)
        {
            SimpleCopyOfBook scob;
            List<SimpleCopyOfBook> list = new List<SimpleCopyOfBook>();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0001copy",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@title", SqlDbType.NVarChar}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            dto.Info1
                                                                        }).
                    ExecuteReader();
                while (reader.Read())
                {
                    scob = new SimpleCopyOfBook();
                    scob.Barcode = reader["Barcode"].ToString();
                    scob.Title = reader["Title"].ToString();
                    list.Add(scob);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at SearchBooksDAO - SearchBarcode", e);
                return null;
            }

            return list;
        }

        public List<SimpleCatalogue> SearchCatalogue(SearchBookDTO dto)
        {
            SimpleCatalogue scob;
            List<SimpleCatalogue> list = new List<SimpleCatalogue>();
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0001catalogue",
                                                                    new Dictionary<string, SqlDbType>()
                                                                        {
                                                                            {"@title", SqlDbType.NVarChar}
                                                                        },
                                                                    new List<object>()
                                                                        {
                                                                            dto.Info1
                                                                        }).
                    ExecuteReader();
                while (reader.Read())
                {
                    scob = new SimpleCatalogue();
                    scob.ISBN = reader["ISBN"].ToString();
                    scob.Title = reader["Title"].ToString();
                    list.Add(scob);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at SearchBooksDAO - SearchCatalogue", e);
                return null;
            }

            return list;
        }
    }
}