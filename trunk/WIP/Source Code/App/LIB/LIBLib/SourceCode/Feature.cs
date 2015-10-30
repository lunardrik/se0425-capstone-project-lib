using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Web.UI;

namespace LIB
{
    public class Feature
    {
        private static CatalogueBUS catalogeBus = new CatalogueBUS();
        private static CopyBUS copyBus = new CopyBUS();
        private static BookRegisterBUS registerBus = new BookRegisterBUS();
        private static RentalBUS rentalBus = new RentalBUS();
        private static UserBUS userBus = new UserBUS();
        private static RoleBUS _roleBus = new RoleBUS();
        private static Random random = new Random((int)DateTime.Now.Ticks);

        public static Image ResizeImage(Image FullsizeImage, int NewWidth, int MaxHeight, bool OnlyResizeIfWider)
        {
            // Prevent using images internal thumbnail
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

            if (OnlyResizeIfWider)
            {
                if (FullsizeImage.Width <= NewWidth)
                {
                    NewWidth = FullsizeImage.Width;
                }
            }

            int NewHeight = FullsizeImage.Height * NewWidth / FullsizeImage.Width;
            if (NewHeight > MaxHeight)
            {
                // Resize with height instead
                NewWidth = FullsizeImage.Width * MaxHeight / FullsizeImage.Height;
                NewHeight = MaxHeight;
            }

            return FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

        }

        public static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        public static string EncodePassword(string password)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(password);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        public class Email
        {
            public string Recipent { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
        }

        public static void SendMail(object _mail)
        {
            var mail = (Email) _mail;
            Log.Info("START Send email to " + mail.Recipent);

            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.To.Add(mail.Recipent);
                message.Subject = mail.Subject;
                message.From = new System.Net.Mail.MailAddress(Options.EmailAddress);
                message.Body = mail.Body;
                message.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient(Options.SMTPHost, Options.SMTPPort);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(Options.AuthenticationId, Options.AuthenticationPassword);

                smtp.Send(message);
                Log.Error("DONE Send email to " + mail.Recipent);
            }
            catch (Exception e)
            {
                Log.Error("Fail to send mail to " + mail.Recipent, e);
            }
        }

        public void SendSampleMail(string recipent, string subject, string body)
        {
            Email mail = new Email()
                             {
                                 Recipent = recipent,
                                 Body = body,
                                 Subject = subject
                             };

            Thread sendMailThread = new Thread(new ParameterizedThreadStart(SendMail));
            sendMailThread.Start(mail);
        }

        #region User

        public bool Login(string userId, string password)
        {
            try
            {
                return userBus.Login(userId, password);
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - Login", e);
            }
            return false;
        }

        public bool ValidateUser(string userId)
        {
            try
            {
                var userDto = userBus.GetUserById(userId);

                if (userDto.Status != UserStatus.ACTIVE)
                {
                    return false;
                }

                if (userDto.ExpiredDate.CompareTo(DateTime.Now) <= 0)
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - ValidateUser", e);
            }

            return true;
        }

        public List<UserDTO> GetAllUser()
        {
            var listUser = new List<UserDTO>();
            try
            {
                // get User info
                listUser = userBus.GetUserAll();

                // get Role info
                foreach (var userDto in listUser)
                {
                    var roleDto = _roleBus.GetRoleById(userDto.RoleId);
                    if (roleDto != null)
                    {
                        userDto.RoleDescription = roleDto.RoleDescription;
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - GetAllUser", e);
            }
            return listUser;
        }

        public bool AddUser(UserDTO userDto)
        {
            Log.Info("Add New User " + userDto.UserId);
            var pass = RandomString(8);
            userDto.Password = EncodePassword(pass);
            try
            {
                if (userBus.InsertUser(userDto))
                {
                    SendSampleMail(userDto.Email, Options.MailSubject, "Chào " + userDto.Username + ", <br/><br/>Tài khoản của bạn đã được tạo.<br/>Tên đăng nhập của bạn <b>" + userDto.UserId + "</b><br/>Mật mã của bạn là <b>" + pass + "</b>");
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - AddUser", e);
            }
            return false;
        }

        public bool UpdateUser(UserDTO userDto)
        {
            Log.Info("Update user " + userDto.UserId + " info");
            try
            {
                return userBus.UpdateUser(userDto);
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - UpdateUser", e);
            }
            return false;
        }

        public bool ResetPassword(UserDTO userDto)
        {
            try
            {
                var pass = RandomString(8);
                userDto.Password = EncodePassword(pass);
                if (userBus.UpdateUser(userDto))
                {
                    SendSampleMail(userDto.Email, Options.MailSubject, "Mật mã của bạn đã được thiết lập lại.<br/>Mật mã mới của bạn là <b>" + pass + "</b>");
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - ResetPassword", e);
            }
            return false;
        }

        public bool ChangePassword(UserDTO userDto, string newPassword)
        {
            try
            {
                userDto.Password = newPassword;
                if (userBus.UpdateUser(userDto))
                {
                    SendSampleMail(userDto.Email, Options.MailSubject, "Mật mã của bạn đã được thiết lập lại.<br/>");
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - ResetPassword", e);
            }
            return false;
        }

        #endregion

        #region Role

        public List<RoleDTO> GetAllRole()
        {
            var list = new List<RoleDTO>();
            try
            {
                list = _roleBus.GetAllRole();
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - GetAllRole", e);
            }

            return list;
        }

        #endregion

        #region Book Register

        public List<BookRegisterDTO> GetAllRegister()
        {
            Log.Info("View Register entries");
            var listRegister = new List<BookRegisterDTO>();

            try
            {
                listRegister = registerBus.GetAllBookRegister();

                foreach (var registerDto in listRegister)
                {
                    registerDto.Username = userBus.GetUserById(registerDto.UserId).Username;
                    registerDto.BookTitle = catalogeBus.GetCatalogueById(registerDto.ISBN).Title;
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - GetAllRegister", e);
            }

            return listRegister;
        }

        public List<BookRegisterDTO> GetRegisterByUserId(UserDTO user)
        {
            Log.Info("View Register entries");
            var listRegister = new List<BookRegisterDTO>();

            try
            {
                listRegister = registerBus.GetBookRegisterByUserId(user.UserId);

                foreach (var registerDto in listRegister)
                {
                    registerDto.Username = user.Username;
                    registerDto.BookTitle = catalogeBus.GetCatalogueById(registerDto.ISBN).Title;
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - GetRegisterByUserId", e);
            }

            return listRegister;
        }

        public List<BookRegisterDTO> GetRegisterByUserIdPaging(UserDTO user, int page, out int noP)
        {
            Log.Info("View Register entries");
            var listRegister = new List<BookRegisterDTO>();

            try
            {
                listRegister = registerBus.GetBookRegisterByUserIdPaging(user.UserId, page, out noP);

                foreach (var registerDto in listRegister)
                {
                    registerDto.Username = user.Username;
                    registerDto.BookTitle = catalogeBus.GetCatalogueById(registerDto.ISBN).Title;
                }
            }
            catch (Exception e)
            {
                Log.Error(user, "Error at Feature - GetRegisterByUserId", e);
                noP = 0;
            }

            return listRegister;
        }

        public bool AddRegister(BookRegisterDTO registerDto)
        {
            Log.Info("Add new Register");
            try
            {
                registerDto.Status = BookRegisterStatus.NEW;
                return registerBus.InsertBookRegister(registerDto);
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - AddRegister", e);
            }

            return false;
        }

        public bool DeleteRegister(string userId, string isbn, DateTime registerDate)
        {
            try
            {
                return registerBus.DeleteBookRegister(userId, isbn, registerDate); ;
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - DeleteRegister", e);
            }

            return false;
        }

        public string ApproveRequest(BookRegisterDTO registerDto)
        {
            try
            {
                // Update BookCopy Status
                var listAvailableCopy = GetAvailableCopy(registerDto.ISBN);
                if (listAvailableCopy.Count <= 0)
                {
                    return "Không còn sách khả dụng!";
                }

                // Update Register status
                registerDto.Status = BookRegisterStatus.APPROVED;
                if (!registerBus.UpdateBookRegister(registerDto))
                {
                    return Constants.SYSTEM_ERROR;
                }

                // Add Rental
                var rentalDto = new RentalDTO();
                rentalDto.UserId = registerDto.UserId;
                rentalDto.Barcode = listAvailableCopy[0].Barcode;
                rentalDto.Status = RentalStatus.NEW;
                rentalDto.IssueDate = DateTime.Now;
                rentalDto.DueDate = DateTime.Now.AddDays(7);
                AddRental(rentalDto);

                // Send mail to Reader
                var userDto = userBus.GetUserById(registerDto.UserId);
                if (userDto != null)
                {
                    var writer = new StringWriter();
                    var html = new HtmlTextWriter(writer);
                    html.WriteEncodedText(String.Format("Thân gửi {0}.", userDto.Username));
                    html.WriteEncodedText(" Yều cầu của bạn đã được chấp nhận.");
                    html.WriteEncodedText(String.Format(" Tên sách: {0}", registerDto.BookTitle));
                    html.WriteEncodedText(String.Format(" Ngày đăng ký: {0}", registerDto.RegisterDate.ToShortDateString()));
                    html.WriteEncodedText(String.Format(" Ngày yêu cầu được chấp nhận: {0}", DateTime.Now.ToShortDateString()));
                    html.WriteEncodedText(" Mời bạn đến nhận sách.");
                    SendSampleMail(userDto.Email, Options.MailSubject, writer.ToString());
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - ApproveRequest", e);
            }

            return null;
        }

        public bool RejectRequest(BookRegisterDTO registerDto)
        {
            try
            {
                registerDto.Status = BookRegisterStatus.REJECTED;
                return registerBus.UpdateBookRegister(registerDto);
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - RejectRequest", e);
            }

            return false;
        }

        public string ImportRegister(FileStream fileStream)
        {
            var msg = new StringBuilder();

            // read data from excel file
            List<List<object>> data = null;
            try
            {
                data = ParseExcelUtil.ReadExcelFile(fileStream);
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - ImportRegister - Parse excel", e);
                msg.AppendLine("Có lỗi xảy ra khi đọc dữ liệu!");
                return msg.ToString();
            }

            // Process data
            // set i = 1 to omit the header row
            for (int i = 1; i < data.Count; i++)
            {
                var registerDto = new BookRegisterDTO();
                registerDto.UserId = data[i][0].ToString();
                registerDto.ISBN = data[i][1].ToString();

                try
                {
                    registerDto.RegisterDate = DateTime.Parse(data[i][2].ToString());
                }
                catch (Exception)
                {
                    msg.AppendLine("Có lỗi xảy ra [Dòng thứ " + i + "][RegisterDate không hợp lệ]");
                    continue;
                }
                registerDto.Note = data[i][3].ToString();
                registerDto.Status = BookRegisterStatus.NEW;

                // Validate data
                if (registerBus.GetBookRegisterByPrimaryKey(registerDto.UserId, registerDto.ISBN, registerDto.RegisterDate) != null)
                {
                    msg.AppendLine("Có lỗi xảy ra [Dòng thứ " + i + "] [Dữ liệu đã tồn tại]");
                    continue;
                }
                if (userBus.GetUserById(registerDto.UserId) == null)
                {
                    msg.AppendLine("Có lỗi xảy ra [Dòng thứ " + i + "] [UserID không tồn tại]");
                    continue;
                }

                if (catalogeBus.GetCatalogueById(registerDto.ISBN) == null)
                {
                    msg.AppendLine("Có lỗi xảy ra [Dòng thứ " + i + "] [ISBN không tồn tại]");
                    continue;
                }

                // Insert data to database
                try
                {
                    registerBus.InsertBookRegister(registerDto);
                }
                catch (Exception e)
                {
                    msg.AppendLine("Có lỗi xảy ra [Dòng thứ " + i + "] [Lưu dữ liệu thất bại]");
                    Log.Error("Error at Feature - ImportRegister", e);
                    continue;
                }
            }

            return msg.ToString();
        }

        public List<BookRegisterDTO> GetNewRegister(DateTime lastRefreshTime)
        {
            var listRegister = new List<BookRegisterDTO>();
            try
            {
                listRegister = registerBus.
                    GetBookRegisterByStatusAndCreatedDate(BookRegisterStatus.NEW, lastRefreshTime);
                foreach (var registerDto in listRegister)
                {
                    registerDto.Username = userBus.GetUserById(registerDto.UserId).Username;
                    registerDto.BookTitle = catalogeBus.GetCatalogueById(registerDto.ISBN).Title;
                }
            }
            catch (Exception e)
            {
                Log.Logger.Error("Error at Feature - GetNewRegister", e);
            }
            return listRegister;
        }

        #endregion

        #region Rental

        public List<RentalDTO> GetAllRental()
        {
            var listRental = new List<RentalDTO>();

            try
            {
                // get Rental info
                listRental = rentalBus.GetAllRental();
                foreach (var rentalDto in listRental)
                {
                    // get User info
                    var userDto = userBus.GetUserById(rentalDto.UserId);
                    rentalDto.Username = userDto.Username;

                    // get Catalogue info
                    string isbn = copyBus.GetCopyById(rentalDto.Barcode).ISBN;
                    if (isbn != null)
                    {
                        var catalogeDto = catalogeBus.GetCatalogueById(isbn);
                        if (catalogeDto != null)
                        {
                            rentalDto.BookTitle = catalogeDto.Title;
                            rentalDto.BookPrice = catalogeDto.Price;
                            rentalDto.ExpandLimit = catalogeDto.ExpandLimit;
                            rentalDto.ExpandDateLimit = catalogeDto.ExpandDateLimit;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - GetAllRental", e);
            }

            return listRental;
        }

        public List<RentalDTO> GetRentalByUserId(UserDTO user)
        {
            var listRental = new List<RentalDTO>();

            try
            {
                // get Rental info
                listRental = rentalBus.GetRentalByUserId(user.UserId);
                foreach (var rentalDto in listRental)
                {
                    rentalDto.Username = user.Username;

                    // get Catalogue info
                    string isbn = copyBus.GetCopyById(rentalDto.Barcode).ISBN;
                    if (isbn != null)
                    {
                        var catalogeDto = catalogeBus.GetCatalogueById(isbn);
                        if (catalogeDto != null)
                        {
                            rentalDto.BookTitle = catalogeDto.Title;
                            rentalDto.BookPrice = catalogeDto.Price;
                            rentalDto.ExpandLimit = catalogeDto.ExpandLimit;
                            rentalDto.ExpandDateLimit = catalogeDto.ExpandDateLimit;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - GetRentalByUserId", e);
            }

            return listRental;
        }

        public List<RentalDTO> GetRentalByUserIdPaging(UserDTO user, int page, out int NoP)
        {
            var listRental = new List<RentalDTO>();


            try
            {
                // get Rental info
                listRental = rentalBus.GetRentalByUserIdPaging(user.UserId, page, out NoP);

                foreach (var rentalDto in listRental)
                {
                    rentalDto.Username = user.Username;

                    // get Catalogue info
                    string isbn = copyBus.GetCopyById(rentalDto.Barcode).ISBN;
                    if (isbn != null)
                    {
                        var catalogeDto = catalogeBus.GetCatalogueById(isbn);
                        if (catalogeDto != null)
                        {
                            rentalDto.BookTitle = catalogeDto.Title;
                            rentalDto.BookPrice = catalogeDto.Price;
                            rentalDto.ExpandLimit = catalogeDto.ExpandLimit;
                            rentalDto.ExpandDateLimit = catalogeDto.ExpandDateLimit;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error(user, "Error at Feature - GetRentalByUserId", e);
                NoP = 0;
            }

            return listRental;
        }

        public bool AddRental(RentalDTO rentalDto)
        {
            try
            {
                // insert rental
                rentalDto.Status = RentalStatus.NEW;
                if (!rentalBus.InsertRental(rentalDto))
                {
                    return false;
                }

                // update BookCopy Status
                var copyDto = copyBus.GetCopyById(rentalDto.Barcode);
                if (copyDto != null)
                {
                    copyDto.Status = (int)CopyStatus.NOT_AVAIABLE;
                    copyBus.UpdateCopy(copyDto);

                    // update Catalogue AvailableCopies
                    var catalogeDto = catalogeBus.GetCatalogueById(copyDto.ISBN);
                    if (catalogeDto != null)
                    {
                        catalogeDto.AvailableCopies--;
                        // ++ 2012/04/05 - DiepTN: Add
                        catalogeDto.RentalTime++;
                        // --
                        catalogeBus.UpdateCatalogue(catalogeDto, null);
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - AddRental", e);
            }

            return true;
        }

        public bool ReturnBook(RentalDTO rentalDto)
        {
            try
            {
                // Update Rental Status
                if (!rentalBus.UpdateRental(rentalDto))
                {
                    return false;
                }

                // Update BookCopy Status, Catalogue AvailableCopies
                var copyDto = copyBus.GetCopyById(rentalDto.Barcode);
                if (copyDto != null)
                {
                    var catalogeDto = catalogeBus.GetCatalogueById(copyDto.ISBN);

                    if (catalogeDto != null)
                    {
                        if (rentalDto.Status == RentalStatus.FISNISHED)
                        {
                            // copy status needs to be updated later
                            // ++ DiepTN: 2012/03/12 - Update
                            copyDto.Status = (int)CopyStatus.AVAILABLE;
                            // --
                            catalogeDto.AvailableCopies++;
                        }
                        else if (rentalDto.Status == RentalStatus.DAMAGED)
                        {
                            // copy status needs to be updated later
                            // ++ DiepTN: 2012/03/12 - Update
                            copyDto.Status = (int)CopyStatus.DAMAGED;
                            // --
                            catalogeDto.AvailableCopies++;
                        }
                        else if (rentalDto.Status == RentalStatus.LOST)
                        {
                            // copy status needs to be updated later
                            // ++ DiepTN: 2012/03/12 - Update
                            copyDto.Status = (int)CopyStatus.LOST;
                            // --
                            // availablecopies
                        }

                        copyBus.UpdateCopy(copyDto);
                        catalogeBus.UpdateCatalogue(catalogeDto, null);
                    }
                }


            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - ReturnBook", e);
            }
            return false;
        }

        public bool ExpandRental(RentalDTO rentalDto)
        {
            try
            {
                // check ExpandLimit
                if (rentalDto.ExpandCount >= rentalDto.ExpandLimit)
                {
                    Log.Error("Error at Feature - ExpandRental: Maximum expand time has been reached.");
                    return false;
                }

                // update Rental status
                rentalDto.ExpandCount++;
                return rentalBus.UpdateRental(rentalDto);
            }
            catch (Exception e)
            {
                Log.Error("Error at Feature - ExpandRental", e);
            }
            return false;
        }
        #endregion

        #region Copy

        public static List<string> GenerateBarcode(CatalogueDTO catalogue, int NoC)
        {
            List<string> barcodes = new List<string>();

            string categoryId = int.Parse(catalogue.Category.CategoryId.Split('.')[0]).ToString("00000");

            for (int i = 1; i <= NoC; i++)
            {
                barcodes.Add(categoryId + (Options.CountOfCopy + i).ToString("000000"));
            }

            return barcodes;
        }

        public List<CopyDTO> GetAvailableCopy(string isbn)
        {
            var listCopy = copyBus.GetCopyByISBN(isbn);
            var listAvailableCopy = new List<CopyDTO>();

            if (listCopy != null)
            {
                listAvailableCopy = new List<CopyDTO>();

                foreach (var copyDto in listCopy)
                {
                    if (copyDto.Status == (int)CopyStatus.AVAILABLE)
                    {
                        listAvailableCopy.Add(copyDto);
                    }
                }
            }

            return listAvailableCopy;
        }
        #endregion
    }
}
