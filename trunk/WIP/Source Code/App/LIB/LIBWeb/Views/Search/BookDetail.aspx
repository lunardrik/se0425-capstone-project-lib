<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<LIB.CatalogueDTO>" MasterPageFile="~/Views/Shared/Site.Master" %>
<%@ Import Namespace="System.Globalization" %>
<%@ Import Namespace="LIB" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent">
Chi tiết sách: <%= Model.Title %>
</asp:Content>
<asp:Content runat="server" ID="HeadScript" ContentPlaceHolderID="HeadScript"></asp:Content>
<asp:Content runat="server" ID="TopLeftSideBox" ContentPlaceHolderID="TopLeftSideBox">
<%          NumberFormatInfo nfi = (NumberFormatInfo)
            CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = ".";
%>
        <h2>
            Thông tin</h2>
        <table width="100%">
            <tbody><tr>
                <td colspan="2" align="center">
                    <b>
                        <%= Model.Publisher.PublisherName %></b>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Giá bìa:</b>
                </td>
                <td>
                    <%= Model.Price.ToString("#,##0", nfi) %>đ
                </td>
            </tr>
            <tr>
                <td>
                    <strong>Xuất bản:</strong>
                </td>
                <td>
                    <%= Model.Year %>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Được mượn:</b>
                </td>
                <td>
                    <%= Model.RentalTime %>
                    lần
                </td>
            </tr>
            <tr>
                <td>
                    <b>Được xem:</b>
                </td>
                <td>
                    <%= Model.HitTime %>
                    lần
                </td>
            </tr>
            <tr>
                <td>
                    <b>Tình trạng:</b>
                </td>
                <td>
                    <span style="color:<%= Model.AvailableCopies > 0 ? "Green" : "Red"%>;"><%= Model.AvailableCopies > 0 ? "Vẫn còn sách" : "Đã hết sách"%></span>
                </td>
            </tr>       
            <tr></tr>     
            <tr>
                <td colspan="2">
                    <% if (Model.AvailableCopies > 0)
                       {%>
                        <%=Html.Action("RentalService", "Shared",
                                                         new {isbn = Model.ISBN})%>
                    <%
                       } else
                       { %>
                        <div style="text-align:center; padding-left:20px; padding-top:5px; padding-bottom:5px"><span class="button_02"><a href="javascript:void(0);">Chưa có sách</a></span></div>
                       <% 
                       }%>
                </td>
            </tr>
        </tbody></table>
        <div class="cleaner">
        </div>
</asp:Content>
<asp:Content runat="server" ID="MiddleLeftSideBox" ContentPlaceHolderID="MiddleLeftSideBox">
    <h2>
        Thành viên</h2>
    <p>
        <%= Html.Action("MemberArea","Shared") %></p>
</asp:Content>
<asp:Content runat="server" ID="BottomLeftSideBox" ContentPlaceHolderID="BottomLeftSideBox"></asp:Content>
<asp:Content runat="server" ID="TopMain" ContentPlaceHolderID="TopMainContent">
        <h2><%= Model.Title %></h2>
        <table>
            <tbody>
            <tr>
                <td>
                    <b>Tác giả:</b>
                </td>
                <td>
                    <% for (int i = 0; i < Model.AuthorList.Count; i++ )
                       {
                            %>
                            <%= i >= 1 ? ", " : "" %><%= Html.ActionLink(Model.AuthorList[i].Author.AuthorName, "Author", "Search", new { id = Model.AuthorList[i].Author.AuthorId }, null)%>
                            <%  
                       }
                    %>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Danh mục:</b>
                </td>
                <td>
                    <% string cateID = Model.Category.CategoryId;
                       CategoryBUS bus = new CategoryBUS();
                       string str = "";
                       string[] strs = cateID.Split('.');
                       
                       for (int i = 0; i < strs.Length; i++ )
                       {
                           str += strs[i];
                           var cate = bus.GetCategoryById(str);
                           %>
                           <%= i >= 1 ? "  ⇒  " : ""%><%= Html.ActionLink(cate.CategoryName, "Category", "Search", new { id = cate.CategoryId }, null)%>
                           <%
                           str += '.';
                       }
                       %>

                </td>
            </tr>
        </tbody></table>
        <div class="cleaner_h20">
        </div>
</asp:Content>
<asp:Content runat="server" ID="MiddleMain" ContentPlaceHolderID="MiddleMainContent">
<h2>Thông tin chi tiết</h2>
        <div class="image_fl">
            <img title="<%= Model.Title %>" src="../../<%=Model.Image.Equals("") ? Options.ImageFolder + Options.NotAvaiable : Options.ImageFolder + Model.Image%>" alt="<%= Model.Title %>" style="height:300px;width:300px;"></div>
        <%= Model.ShortDescription %>
        <div class="cleaner">
        </div>
</asp:Content>
<asp:Content runat="server" ID="BottomMain" ContentPlaceHolderID="BottomMainContent"></asp:Content>
