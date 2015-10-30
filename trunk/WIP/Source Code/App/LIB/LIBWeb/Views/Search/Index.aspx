<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LIBWeb.Models.SearchResultModels>" %>

<%@ Import Namespace="LIB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Tìm sách
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="HeadScript" runat="server">
    <script type="text/javascript">
        var setval = function (value) {
            $("#txtPageNum").val(value);
            window.document.forms[0].submit();
        }
    </script>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="TopMainContent" runat="server">
    <h2>Tìm sách</h2>
        <% using (Html.BeginForm()) {%>
<table width="100%">
    <tbody><tr>
        <td>
            <b>Từ khóa:</b>
        </td>
        <td>
            <input name="txtKeyword" type="text" id="txtKeyword" autocomplete="off" style="width:350px;" value="<%= Model.KeyWord %>" />
            <input name="txtPageNum" id="txtPageNum" type="hidden" value="1" />
        </td>
        <td>
            <input id="btnSearch" type="submit" value="Kết quả" />
        </td>
    </tr>
    <tr>
        <td>
            <b>Danh mục:</b>
        </td>
        <td>
            <select name="lstCategories" id="lstCategories">
                        <option value="" <%= String.IsNullOrEmpty(Model.CateToSearch) ? "selected" : "" %>>Tất cả</option>
                <% CategoryBUS bus = new CategoryBUS();
                   var cates = bus.GetAllCatagory();
                   
                   foreach (CategoryDTO dto in cates)
{
                %>
                        <option value="<%= dto.CategoryId %>" <%= dto.CategoryId.Equals(Model.CateToSearch) ? "selected" : "" %> ><% for (int i = 0; i < dto.CategoryId.Split('.').Count() - 1; i++) {%> | - <% } %>|--<%= dto.CategoryName %></option>
<% 
}
%>  
                    </select>
                
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <b>Tìm theo:</b>
        </td>
        <td>
            <input id="chkTitle" name="chkTitle" type="checkbox" <%= Model.SearchByTitle ? "checked" : "" %> />
            Tựa sách
            <input id="chkContent" name="chkContent" type="checkbox" <%= Model.SearchByContent ? "checked" : "" %> />
            Mô tả
            <input id="chkAuthor" name="chkAuthor" type="checkbox" <%= Model.SearchByAuthor ? "checked" : "" %> />
            Tên tác giả
        </td>
        <td>
        </td>
    </tr>
<%= (Model.NumberOfResult > 0) ? "<tr></tr><tr><td></td><td>Tìm được <b>" + Model.NumberOfResult + "</b> kết quả.<br/>Hiển thị trang số <b>" + Model.CurrentPage + "</b> trên tổng số <b> " + Model.NoP + "</b></td><td></td></tr>" : "" %>
</tbody></table>    <%
} %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleMainContent" runat="server">
<% if (Model.Results != null)
   {%>
    <%
       foreach (SearchBookResultDTO dto in Model.Results)
       {
%>
    <table width="100%" style="border-bottom: 1px dashed #8A9BA8;">
        <tbody>
            <tr>
                <td width="150">
                        <img title="<%=dto.Title%>" src="../../<%=dto.Image%>"
                            alt="<%=dto.Title%>" style="height: 150px;
                            width: 150px;" />
                </td>
                <td>
                    <%=Html.ActionLink(dto.Title, "BookDetail", "Search", new {id = dto.ISBN}, null)%><br />
                    <b>Tác giả:</b> <%=dto.AuthorName%><br/>
                    <b>Danh mục:</b> <%=dto.CategoryName%>
                    <p>
                        <%= LIB.Constants.Truncate(dto.ShortDescription, 150)%> (<%=Html.ActionLink("đọc thêm", "BookDetail", "Search", new {id = dto.ISBN}, null)%>)</p>
                </td>
            </tr>
        </tbody>
    </table>
    <%
       }
   }
   else
   {
       %>
                <h2>
                    Sách được quan tâm</h2>
                <% SearchBookBUS bus = new SearchBookBUS();
                   List<SearchBookResultDTO> hitlist = bus.SearchBooksHit();
%>
        <script type="text/javascript">
            $(document).ready(function () {
                $('#carousel_FullContentHolder_ContentHolder_AvailBooks').jcarousel();
            });
        </script>
        
                <div class=" jcarousel-skin-tango">
                    <div class="jcarousel-container jcarousel-container-horizontal" style="position: relative; display: block; ">
                        <div class="jcarousel-clip jcarousel-clip-horizontal" style="position: relative; ">
                
                            <ul id="carousel_FullContentHolder_ContentHolder_AvailBooks" class="jcarousel-list jcarousel-list-horizontal" style="overflow-x: hidden; overflow-y: hidden; position: relative; top: 0px; margin-top: 0px; margin-right: 0px; margin-bottom: 0px; margin-left: 0px; padding-top: 0px; padding-right: 0px; padding-bottom: 0px; padding-left: 0px; width: 1450px; left: 0px; ">
                            <% for (int i = 0; i < hitlist.Count; i++)
                                {
                                  %>
                                <li class="jcarousel-item jcarousel-item-horizontal jcarousel-item-<%=i %> jcarousel-item-<%=i %>-horizontal" style="float: left; list-style-type: none; list-style-position: initial; list-style-image: initial; " jcarouselindex="<%=i %>">
                                <a href="<%= Url.Action("BookDetail", "Search", new { id = hitlist[i].ISBN }) %>"><img title="<%= hitlist[i].Title %>" src="<%= hitlist[i].Image %>" alt="<%= hitlist[i].Title %>" style="height:150px;width:150px;" /></a></li>
                                  <%
                                } %>
                                
<%--            
                                <li class="jcarousel-item jcarousel-item-horizontal jcarousel-item-2 jcarousel-item-2-horizontal" style="float: left; list-style-type: none; list-style-position: initial; list-style-image: initial; " jcarouselindex="2"><a href="/sach/15948/mat-ma-da-vinci-an-pham-moi">
                                    <img id="FullContentHolder_ContentHolder_AvailBooks_BookRepeater_imgBook_1" title="Mật Mã Da Vinci (Ấn Phẩm Mới)" src="images/thumbs/15948.jpg" alt="Mật Mã Da Vinci (Ấn Phẩm Mới)" style="height:150px;width:150px;"></a></li>
            
                                <li class="jcarousel-item jcarousel-item-horizontal jcarousel-item-3 jcarousel-item-3-horizontal" style="float: left; list-style-type: none; list-style-position: initial; list-style-image: initial; " jcarouselindex="3"><a href="/sach/18104/luyen-nghe-va-phat-am-tot-tieng-anh-understanding-english-pronounciation-dung-kem-voi-3-dia-cd">
                                    <img id="FullContentHolder_ContentHolder_AvailBooks_BookRepeater_imgBook_2" title="Luyện Nghe Và Phát Âm Tốt Tiếng Anh - Understanding English Pronounciation (Dùng Kèm Với 3 Đĩa CD)" src="images/thumbs/18104.jpg" alt="Luyện Nghe Và Phát Âm Tốt Tiếng Anh - Understanding English Pronounciation (Dùng Kèm Với 3 Đĩa CD)" style="height:150px;width:150px;"></a></li>
            
                                <li class="jcarousel-item jcarousel-item-horizontal jcarousel-item-4 jcarousel-item-4-horizontal" style="float: left; list-style-type: none; list-style-position: initial; list-style-image: initial; " jcarouselindex="4"><a href="/sach/18151/nghe-thuat-lam-do-choi-bang-ong-hut">
                                    <img id="FullContentHolder_ContentHolder_AvailBooks_BookRepeater_imgBook_3" title="Nghệ Thuật Làm Đồ Chơi Bằng Ống Hút" src="images/thumbs/18151.jpg" alt="Nghệ Thuật Làm Đồ Chơi Bằng Ống Hút" style="height:150px;width:150px;"></a></li>
            
                                <li class="jcarousel-item jcarousel-item-horizontal jcarousel-item-5 jcarousel-item-5-horizontal" style="float: left; list-style-type: none; list-style-position: initial; list-style-image: initial; " jcarouselindex="5"><a href="/sach/20243/google-cau-chuyen-than-ky">
                                    <img id="FullContentHolder_ContentHolder_AvailBooks_BookRepeater_imgBook_4" title="Google Câu Chuyện Thần Kỳ" src="images/thumbs/20243.jpg" alt="Google Câu Chuyện Thần Kỳ" style="height:150px;width:150px;"></a></li>
            
                                <li class="jcarousel-item jcarousel-item-horizontal jcarousel-item-6 jcarousel-item-6-horizontal" style="float: left; list-style-type: none; list-style-position: initial; list-style-image: initial; " jcarouselindex="6"><a href="/sach/22060/mui-huong-chuyen-mot-ke-giet-nguoi">
                                    <img id="FullContentHolder_ContentHolder_AvailBooks_BookRepeater_imgBook_5" title="Mùi Hương - Chuyện Một Kẻ Giết Người" src="images/thumbs/22060.jpg" alt="Mùi Hương - Chuyện Một Kẻ Giết Người" style="height:150px;width:150px;"></a></li>
            
                                <li class="jcarousel-item jcarousel-item-horizontal jcarousel-item-7 jcarousel-item-7-horizontal" style="float: left; list-style-type: none; list-style-position: initial; list-style-image: initial; " jcarouselindex="7"><a href="/sach/22068/dan-ong-sao-hoa-dan-ba-sao-kim">
                                    <img id="FullContentHolder_ContentHolder_AvailBooks_BookRepeater_imgBook_6" title="Đàn Ông Sao Hỏa - Đàn Bà Sao Kim" src="images/thumbs/22068.jpg" alt="Đàn Ông Sao Hỏa - Đàn Bà Sao Kim" style="height:150px;width:150px;"></a></li>
            
                                <li class="jcarousel-item jcarousel-item-horizontal jcarousel-item-8 jcarousel-item-8-horizontal" style="float: left; list-style-type: none; list-style-position: initial; list-style-image: initial; " jcarouselindex="8"><a href="/sach/22346/404-essential-tesst-for-ielts-general-training-module-kem-2-dia-cd">
                                    <img id="FullContentHolder_ContentHolder_AvailBooks_BookRepeater_imgBook_7" title="404 Essential Tesst For IELTS General Training Module - Kèm 2 Đĩa CD" src="images/thumbs/22346.jpg" alt="404 Essential Tesst For IELTS General Training Module - Kèm 2 Đĩa CD" style="height:150px;width:150px;"></a></li>
            
                                <li class="jcarousel-item jcarousel-item-horizontal jcarousel-item-9 jcarousel-item-9-horizontal" style="float: left; list-style-type: none; list-style-position: initial; list-style-image: initial; " jcarouselindex="9"><a href="/sach/22350/202-useful-exercises-for-ielts-international-edition-dung-kem-2-dia-cd">
                                    <img id="FullContentHolder_ContentHolder_AvailBooks_BookRepeater_imgBook_8" title="202 Useful Exercises For IELTS International Edition (Dùng Kèm 2 Đĩa CD)" src="images/thumbs/22350.jpg" alt="202 Useful Exercises For IELTS International Edition (Dùng Kèm 2 Đĩa CD)" style="height:150px;width:150px;"></a></li>
--%>            
                            </ul>
                        </div>
                        <div class="jcarousel-prev jcarousel-prev-horizontal jcarousel-prev-disabled jcarousel-prev-disabled-horizontal" style="display: block; " disabled="disabled"></div>
                        <div class="jcarousel-next jcarousel-next-horizontal" style="display: block; "></div>
                    </div>
                </div>
            
                <div class="cleaner">
                </div>
            <%
   }
%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopLeftSideBox" runat="server">
<h2>Thành viên</h2>
<p><%= Html.Action("MemberArea","Shared") %></p>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MiddleLeftSideBox" runat="server">
<h2>Danh Mục</h2>
<br/>
<% CategoryBUS bus = new CategoryBUS();
   CatalogueBUS cbus = new CatalogueBUS();
   List<CategoryDTO> cates = bus.GetLv1Catagory();
   
   foreach (CategoryDTO dto in cates)
    {
        %>
        <div class="news_box">
        <span>  ►  </span><%= Html.ActionLink(dto.CategoryName + "  (" + cbus.CountCatelogueByCategoryId(dto.CategoryId) + ")", "Category", "Search", new {id = dto.CategoryId}, null) %></div>
        <%
    }
%>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="BottomLeftSideBox" runat="server">
<%= Html.Action("GetRandomCatalogue","Shared") %>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="BottomMainContent" runat="server">
<%= Html.Action("Paging","Shared", new {CurrentPage = Model.CurrentPage, NoP = Model.NoP}) %>
<%= Model.NoP == 0 ? "<span class=\"bqstart\">“</span>"+(new QuoteBUS()).GetRandomQuote()+"<span class=\"bqend\">”</span>" : "" %>
</asp:Content>
