<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<LIBWeb.Models.SearchResultModels>" MasterPageFile="~/Views/Shared/Site.Master" %>

<%@ Import Namespace="LIB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Tác giả
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
    <input type="hidden" name="txtAuthor" id="txtAuthor" value="<%= Model.Author %>" />
    <input type="hidden" name="txtPageNum" id="txtPageNum" value="1" />
<% AuthorBUS bus = new AuthorBUS();
   AuthorDTO dto = bus.GetAuthorById(Model.Author);%>
   <h2><%= dto.AuthorName %></h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MiddleMainContent" runat="server">
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
        <span style="color:Black"><%= "  ►  " %></span><%= Html.ActionLink(dto.CategoryName + "  (" + cbus.CountCatelogueByCategoryId(dto.CategoryId) + ")", "Category", "Search", new {id = dto.CategoryId}, null) %></div>
        <%
    }
%>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="BottomLeftSideBox" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="BottomMainContent" runat="server">
<%= Html.Action("Paging","Shared", new {CurrentPage = Model.CurrentPage, NoP = Model.NoP, funcName = "setval"}) %>
</asp:Content>
