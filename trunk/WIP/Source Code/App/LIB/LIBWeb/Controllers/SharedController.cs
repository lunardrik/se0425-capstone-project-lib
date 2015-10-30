using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LIB;

namespace LIBWeb.Controllers
{
    public class SharedController : Controller
    {
        //
        // GET: /Shared/

        public string MemberArea()
        {
            string rs = "";
            if (Session["USER"] == null)
            {
                rs = "Bạn chưa đăng nhập. <br /> <div style=\"text-align:center; padding-left:20px; padding-top:5px; padding-bottom:5px\"><span class=\"button_01\"><a href=\"/Account/LogOn?returnUrl=" + Request.Url + "\"> Đăng nhập </a></span></div>";
            }
            else
            {
                UserDTO user = (UserDTO) Session["USER"];
                rs = "<b> Tên: </b>" + user.Username + "<br/>" +
                     "<b> Ngày sinh: </b>" + user.Birthday.ToShortDateString() + "<br/>" +
                     "<b> Ngày hết hạn: </b>" + user.ExpiredDate.ToShortDateString() + "<br/><br/>" +
                     "<div style=\"text-align:center; padding-left:20px; padding-top:5px; padding-bottom:5px\"><span class=\"button_01\"><a href=\"/Account/LogOff\"> Đăng xuất </a></span></div>";
            }
            return rs;
        }

        public string RentalService(string isbn)
        {
            string rs = "";
            if (Session["USER"] == null)
            {
                rs = "Nếu muốn mượn sách, bạn phải đăng nhập. <br /> <div style=\"text-align:center; padding-left:20px; padding-top:5px; padding-bottom:5px\"><span class=\"button_01\"><a href=\"/Account/LogOn?returnUrl=" + Request.Url + "\"> Đăng nhập </a></span></div>";
            }
            else
            {
                UserDTO user = (UserDTO)Session["USER"];
                Feature f= new Feature();
                BookRegisterBUS bus = new BookRegisterBUS();
                if (user.ExpiredDate < DateTime.Now)
                    rs = "<div style=\"text-align:center; padding-left:20px; padding-top:5px; padding-bottom:5px\"><span class=\"button_02\"><a href=\"javascript:void(0);\">Thẻ hết hạn</a></span></div>";
                else if (bus.GetBookRegisterByUserId(user.UserId).Find(r => (r.ISBN == isbn) && (r.Status == BookRegisterStatus.NEW)) == null)
                    rs = "<div style=\"text-align:center; padding-left:20px; padding-top:5px; padding-bottom:5px\"><span class=\"button_01\"><a href=\"/Shared/RegisterRental/" + isbn + "\" onclick=\"return confirm('Bạn có chắc muốn đăng ký mượn quyển sách này?');\">Đăng ký mượn</a></span></div>";
                else
                    rs = "<div style=\"text-align:center; padding-left:20px; padding-top:5px; padding-bottom:5px\"><span class=\"button_03\"><a href=\"javascript:void(0);\">Đã đăng ký</a></span></div>";
            }
            return rs;
        }

        public ActionResult RegisterRental(string id)
        {
            CatalogueBUS bus = new CatalogueBUS();
            CatalogueDTO cat = bus.GetCatalogueById(id);
            Feature f = new Feature();
            UserDTO user = (UserDTO) Session["USER"];

            if(f.AddRegister(new BookRegisterDTO()
                              {
                                  BookTitle = cat.Title,
                                  ISBN = id,
                                  Note = "",
                                  Status = BookRegisterStatus.NEW,
                                  UserId = user.UserId,
                                  Username = user.Username,
                                  CreatedDate = DateTime.Now,
                                  UpdatedDate = DateTime.Now,
                                  RegisterDate = DateTime.Now
                              }))
            {
                Log.Info("Create a new Register");
            }
            else
            {
                ViewData["Message"] = "Có lỗi xảy ra lúc đăng ký mượn sách, hãy liên hệ với thư viện!";
                return View("Error");
            }

            return RedirectToAction("BookDetail", "Search", new {id = id});
        }

        public string GetRandomCatalogue()
        {
            CatalogueBUS bus = new CatalogueBUS();
            CatalogueDTO dto = bus.GetRandomCatalogue();
            string rs = "";

            rs = "<h2>Sách ngẫu nhiên</h2>" +
                 "<p align=\"center\">" +
                 "<a href=\"/Search/BookDetail/" + dto.ISBN + "\">" +
                 "<img src=\"../../" + (dto.Image.Equals("") ? Options.ImageFolder + Options.NotAvaiable : Options.ImageFolder + dto.Image) + "\" alt=\"" + dto.Title +
                 "\" style=\"height:150px;width:150px;\">" +
                 "<br>" +
                 Constants.Truncate(dto.Title, 300) + "</a>" +
                 "</p>" +
                 dto.ShortDescription;

            return rs;
        }

        public string Paging(int CurrentPage, int NoP, string funcName)
        {
            string rs = "";
            if (String.IsNullOrEmpty(funcName))
            {
                funcName = "setval";
            }
            if (NoP != 0)
            {

                rs += "<p align=\"center\"><ul id=\"pagination\">" +
                      "<li class=\"previous" + (CurrentPage == 1 ? "-off" : "") + "\">" +
                      (CurrentPage == 1 ? "" : "<a href=\"javascript:void(0);\" onclick=\""+funcName+"(1);\">") + "« Đầu" +
                      (CurrentPage == 1 ? "" : "</a>") + "</li>" +
                      "<li class=\"previous" + (CurrentPage == 1 ? "-off" : "") + "\">" +
                      (CurrentPage == 1
                           ? ""
                           : "<a href=\"javascript:void(0);\" onclick=\"" + funcName + "(" + (CurrentPage - 1) + ");\">") +
                      "« Trước" + (CurrentPage == 1 ? "" : "</a>") + "</li>";

                for (int i = (CurrentPage - 2 > 0 ? CurrentPage - 2 : 1); i <= (CurrentPage + 2 <= NoP ? CurrentPage + 2 : NoP); i++)
                {
                    if (i != CurrentPage)
                    {
                        rs += "<li><a href=\"javascript:void(0);\" onclick=\"" + funcName + "(" + i + ");\">" + i + "</a></li>";

                    }
                    else
                    {
                        rs += "<li class=\"active\">" + i + "</li>";
                    }
                }

                rs += "<li class=\"next" + (CurrentPage == NoP ? "-off" : "") + "\">" + (CurrentPage == NoP ? "" : "<a href=\"javascript:void(0);\" onclick=\"" + funcName + "(" + (CurrentPage + 1) + ");\">") + "Kế »" + (CurrentPage == NoP ? "" : "</a>") + "</li>" +
"<li class=\"next" + (CurrentPage == NoP ? "-off" : "") + "\">" + (CurrentPage == NoP ? "" : "<a href=\"javascript:void(0);\" onclick=\"" + funcName + "(" + NoP + ");\">") + "Cuối »" + (CurrentPage == NoP ? "" : "</a>") + "</li>" + "</ul></p>";
  
}
            return rs;
        }

        public string GetRentalByUserIdPaging(int p)
        {
            UserDTO user = (UserDTO)Session["USER"];
            string rs = "";
            int NoP = 0;
            Feature f = new Feature();
            List<RentalDTO> rtd = f.GetRentalByUserIdPaging(user, p, out NoP);
    
            foreach (RentalDTO rental in rtd)
            {
                //if (rental.Status == RentalStatus.NEW)
                {
                    rs += "<tr>";
                    rs += "<td width=\"150px\">" + rental.BookTitle + "</td>";
                    rs += "<td style=\"color:darkgreen\">" + rental.Barcode + "</td>";
                    rs += "<td style=\"color:red\">" + rental.DueDate.ToShortDateString() + "</td>";
                    rs += "<td style=\"color:" + (rental.Status == RentalStatus.NEW ? "red" : "darkblue") + "\">" +
                          EnumHelper.GetDescription(rental.Status) + "</td>";
                    rs += "</tr>";
                }
            }

            rs += "<tr><td colspan=\"4\" align=\"center\">" + Paging(p, NoP, "setvalRental") + "</td></tr>";

            return rs;
        }

        public string GetRegisterByUserIdPaging(int p)
        {
            UserDTO user = (UserDTO) Session["USER"];
            int NoP = 0;
            string rs = "";
            Feature f = new Feature();
            List<BookRegisterDTO> rtd = f.GetRegisterByUserIdPaging(user, p, out NoP);

            foreach (BookRegisterDTO register in rtd)
            {
                rs += "<tr>";
                rs += "<td width=\"150px\">" + register.BookTitle + "</td>";
                rs += "<td style=\"color:red\">" + register.RegisterDate.ToShortDateString() + "</td>";
                rs += "<td style=\"color:darkgreen\">" + EnumHelper.GetDescription(register.Status) + "</td>";
                rs += "<td style=\"color:darkgreen\">" +
                      (register.Status == BookRegisterStatus.NEW
                           ? "<span class=\"button_01\"><a href=\"/Shared/CancelRegister/?ui=" + register.UserId + "&rd=" + register.RegisterDate.Ticks + "&ri=" + register.ISBN + "\" style=\"width:70px\">Huỷ</a></span>"
                           : "") + "</td>";
                rs += "</tr>";
            }

            rs += "<tr><td colspan=\"4\" align=\"center\">" + Paging(p, NoP, "setvalRegister") + "</td></tr>";

            return rs;
        }

        public ActionResult CancelRegister(string ui, string rd, string ri)
        {
            long ticks;
            long.TryParse(rd, out ticks);
            DateTime registerDate = new DateTime(ticks);

            Feature f = new Feature();
            f.DeleteRegister(ui, ri, registerDate);

            return RedirectToAction("Information", "Account");
        }
    }
}
