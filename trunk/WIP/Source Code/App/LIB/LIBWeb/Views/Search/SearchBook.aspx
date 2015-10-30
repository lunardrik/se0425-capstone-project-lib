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
            <input name="txtKeyword" type="text" id="txtKeyword" autocomplete="off" style="width:350px;" />
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
            <select id="lstCategories">
                        <option value="" selected="selected">Tất cả</option>
                <% CategoryBUS bus = new CategoryBUS();
                   var cates = bus.GetAllCatagory();
                   
                   foreach (CategoryDTO dto in cates)
{
                %>
                        <option value="<%= dto.CategoryId %>" ><% for (int i = 0; i < dto.CategoryId.Split('.').Count() - 1; i++) {%> | - <% } %>|--<%= dto.CategoryName %></option>
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
            <input id="chkTitle" type="checkbox" checked="checked">
            Tựa sách
            <input id="chkContent" type="checkbox" checked="checked">
            Mô tả
            <input id="chkAuthor" type="checkbox">
            Tên tác giả
        </td>
        <td>
        </td>
    </tr>
</tbody></table>    <%
} %>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleMainContent" runat="server">
    <% foreach (SearchBookResultDTO dto in Model.Results)
       {
    %>
    <table width="100%">
        <tbody>
            <tr>
                <td width="150">
                        <img title="<%= dto.Title%>" src="../../<%= dto.Image %>"
                            alt="<%= dto.Title%>" style="height: 150px;
                            width: 150px;" />
                </td>
                <td>
                    <%= Html.ActionLink(dto.Title, "BookDetail", "Search", new { dto.ISBN }, null) %><br />
                    <b>Tác giả:</b> <%= dto.AuthorName %>
                    <p>
                        <%= dto.ShortDescription %> (<%= Html.ActionLink("đọc thêm", "BookDetail", "Search", new { dto.ISBN }, null)%>)</p>
<%--                    <div id="FullContentHolder_ContentHolder_lstBooks_BookRepeater_MiniBook1_0_rating_0">
                        <input type="hidden" name="ctl00$ctl00$FullContentHolder$ContentHolder$lstBooks$BookRepeater$ctl00$MiniBook1$rating_RatingExtender_ClientState"
                            id="FullContentHolder_ContentHolder_lstBooks_BookRepeater_MiniBook1_0_rating_RatingExtender_ClientState_0"
                            value="0">
                        <a href="javascript:void(0)" id="FullContentHolder_ContentHolder_lstBooks_BookRepeater_MiniBook1_0_rating_0_A"
                            title="0" style="text-decoration: none"><span id="FullContentHolder_ContentHolder_lstBooks_BookRepeater_MiniBook1_0_rating_0_Star_1"
                                class="ratingStar emptyRatingStar" style="float: left;">&nbsp;</span><span id="FullContentHolder_ContentHolder_lstBooks_BookRepeater_MiniBook1_0_rating_0_Star_2"
                                    class="ratingStar emptyRatingStar" style="float: left;">&nbsp;</span><span id="FullContentHolder_ContentHolder_lstBooks_BookRepeater_MiniBook1_0_rating_0_Star_3"
                                        class="ratingStar emptyRatingStar" style="float: left;">&nbsp;</span><span id="FullContentHolder_ContentHolder_lstBooks_BookRepeater_MiniBook1_0_rating_0_Star_4"
                                            class="ratingStar emptyRatingStar" style="float: left;">&nbsp;</span><span id="FullContentHolder_ContentHolder_lstBooks_BookRepeater_MiniBook1_0_rating_0_Star_5"
                                                class="ratingStar emptyRatingStar" style="float: left;">&nbsp;</span></a>
                    </div>--%>
                </td>
            </tr>
        </tbody>
    </table>
    <%
        }
    %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopLeftSideBox" runat="server">
<h2>Thành viên</h2>
<p><%= Html.Action("MemberArea","Shared") %></p>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MiddleLeftSideBox" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="BottomLeftSideBox" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="BottomMainContent" runat="server">
<% for (int i = 1; i <= Model.NoP; i++)
{
       if (i != Model.CurrentPage)
{	
   %><a href="javascript:void(0);" onclick="setval(<%=i %>);">Trang <%=i %></a> | <%
}
else
{
  %>Trang <%=i %> | <%
}
} %>
</asp:Content>
