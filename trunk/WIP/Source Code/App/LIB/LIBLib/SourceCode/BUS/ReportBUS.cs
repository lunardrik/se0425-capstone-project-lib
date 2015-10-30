using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LIB
{
    public class ReportBUS
    {
        public List<ReportDTO> ReportOnAvaiableCopies()
        {
            ReportDAO dao = new ReportDAO();
            var dt = dao.ReportOnAvaiableCopies();
            List<ReportDTO> result = new List<ReportDTO>();

            if (dt != null)
            {
                result.Add(new ReportDTO()
                               {
                                   Name = "Sách còn trong thư viện",
                                   Value = int.Parse(dt.DefaultView[0]["NOC"].ToString())
                               });
                result.Add(new ReportDTO()
                               {
                                   Name = "Sách đã được mượn",
                                   Value = int.Parse(dt.DefaultView[1]["NOC"].ToString())
                               });

            }
            return result;
        }

        public List<ReportDTO> ReportOnCategory()
        {
            ReportDAO dao = new ReportDAO();
            var dt = dao.ReportOnCategory();
            List<ReportDTO> result = new List<ReportDTO>();

            if (dt != null)
            {
                foreach (DataRowView row in dt.DefaultView)
                {
                    result.Add(new ReportDTO()
                    {
                        Name = row["CategoryName"].ToString(),
                        Value = int.Parse(row["NOC"].ToString())
                    });
                }
            }
            return result;
        }


        public List<ReportDTO> ReportOnPassDueDateChart()
        {
            ReportDAO dao = new ReportDAO();
            var dt = dao.ReportOnPassDueDateChart();
            List<ReportDTO> result = new List<ReportDTO>();

            if (dt != null)
            {
                result.Add(new ReportDTO()
                {
                    Name = "Sách chưa quá hạn",
                    Value = Math.Abs(int.Parse(dt.DefaultView[0]["NOC"].ToString()) - int.Parse(dt.DefaultView[1]["NOC"].ToString()))
                });
                result.Add(new ReportDTO()
                {
                    Name = "Sách đã quá hạn",
                    Value = int.Parse(dt.DefaultView[0]["NOC"].ToString())
                });
            }
            return result;
        }

        public DataTable ReportOnPassDueDateDetail()
        {
            ReportDAO dao = new ReportDAO();
            return dao.ReportOnPassDueDateDetail();
        }

        public DataTable ReportOfRentalOnISBN(string ISBN)
        {
            ReportDAO dao = new ReportDAO();
            return dao.ReportOfRentalOnISBN(ISBN);
        }

        public DataTable ReportOfRentalOnUserId(string UserId)
        {
            ReportDAO dao = new ReportDAO();
            return dao.ReportOfRentalOnUserId(UserId);
        }
    }
}
