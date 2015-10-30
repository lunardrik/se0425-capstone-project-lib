using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Mail;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using log4net;
namespace AutoMail
{
    class Program
    {
        public static ILog Logger;
        private static string _dataSource;
        private static string _database;
        private static string _userId;
        private static string _password;
        private static List<AutoMailDTO> _list;

        static void Main(string[] args)
        {
            LoadConfig();
            try
            {
                MailMessage message = new MailMessage();
                string fMailAdress = ConfigurationManager.AppSettings["EmailAddress"];
                string host = ConfigurationManager.AppSettings["SMTPHost"];
                int port = int.Parse(ConfigurationManager.AppSettings["SMTPPort"]);
                string password = ConfigurationManager.AppSettings["AuthenticationPassword"];
                string subject = ConfigurationManager.AppSettings["Subject"];
                message.From = new MailAddress(fMailAdress);
                message.Subject = subject;

                SmtpClient smtp = new SmtpClient(host, port);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fMailAdress, password);
                _list = GetToMail();
                foreach(AutoMailDTO mailDto in _list)
                {
                    message.To.Add(new MailAddress(mailDto.Email));
                    message.Body = mailDto.Username + " thân mến!\n" +
                                   "Hiện bạn đang mượn cuốn sách: " + mailDto.Title + " có mã số: " + mailDto.Barcode +
                                   " và đã quá hạn. Mong bạn gửi lại thu viện quyển sách này.\nThư viện FU";
                    smtp.Send(message);
                    Console.WriteLine("Mail Sent to: "+mailDto.Username);
                    //Logger.Info("Mail Sent at" + DateTime.Today.ToString());
                }
            }
            catch (Exception e)
            {
                Logger.Error("Cannot send mail: ", e);
            }

        }

        

        private static SqlConnection GetConnection()
        {
            try
            {
                string conStr = "Data Source=" + _dataSource +
                            ";Database=" + _database +
                            ";User Id=" + _userId +
                            ";Password=" + _password +
                            "; Connection Timeout=30; Min Pool Size=20; Max Pool Size=100000;";
                return new SqlConnection(conStr);
            }
            catch (Exception e)
            {
                Logger.Error(e);
                return null;
            }
        }

        public static List<AutoMailDTO> GetToMail()
        {
            List<AutoMailDTO> list = new List<AutoMailDTO>();
            try
            {
                SqlConnection connection = GetConnection();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spMailing";
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoMailDTO uMail;
                while (reader.Read())
                {
                    uMail = new AutoMailDTO();
                    uMail.Username = reader["Username"].ToString();
                    uMail.Email = reader["Email"].ToString();
                    uMail.Barcode = reader["Barcode"].ToString();
                    uMail.Title = reader["Title"].ToString();
                    list.Add(uMail);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                Logger.Error("Mailing's Error: ", e);
                return null;
            }
            return list;
        }

        public static void LoadConfig()
        {
            try
            {
                _dataSource = ConfigurationManager.AppSettings["Data Source"];
                _database = ConfigurationManager.AppSettings["Database"];
                _userId = ConfigurationManager.AppSettings["User Id"];
                _password = ConfigurationManager.AppSettings["Password"];
            }
            catch (Exception e)
            {
                Logger.Error(e);
            }
        }
    }
}
