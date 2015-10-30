<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<LIBWeb.Models.SearchResultModels>"
    MasterPageFile="~/Views/Shared/Site.Master" %>

<%@ Import Namespace="LIB" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent">
    Danh Mục
</asp:Content>
<asp:Content runat="server" ID="HeadScript" ContentPlaceHolderID="HeadScript">
    <script type="text/javascript">
        var setval = function (value) {
            $("#txtPageNum").val(value);
            window.document.forms[0].submit();
        }
    </script>
</asp:Content>
<asp:Content runat="server" ID="TopLeftSideBox" ContentPlaceHolderID="TopLeftSideBox">
    <h2>
        Thành viên</h2>
    <p>
        <%= Html.Action("MemberArea","Shared") %></p>
</asp:Content>
<asp:Content runat="server" ID="MiddleLeftSideBox" ContentPlaceHolderID="MiddleLeftSideBox">
    <h2>
        Danh Mục</h2>
    <br />
    <% CategoryBUS bus = new CategoryBUS();
       CatalogueBUS cbus = new CatalogueBUS();
       List<CategoryDTO> cates = bus.GetSubCategory(Model.ParentCate);
       %>
       <div class="news_box">
                <span>⏎</span>
                <%= Model.ParentCate.IndexOf('.') == -1 ? Html.ActionLink("Tất cả danh mục","Index", "Search") : Html.ActionLink("Về danh mục cha", "Category", "Search", new { id = Model.ParentCate.Substring(0,Model.ParentCate.LastIndexOf('.'))}, null) %>
                </div>
       <%
       if (cates.Count == 0)
       {	
    %>
    <span style="color: Gray">
        <%= "Không có danh mục con nào" %></span>
    <%
}
   foreach (CategoryDTO dto in cates)
   {
    %>
    <div class="news_box">
        <span style="color: Black">
            <span>  ►  </span></span><%= Html.ActionLink(dto.CategoryName + "  (" + cbus.CountCatelogueByCategoryId(dto.CategoryId) + ")", "Category", "Search", new {id = dto.CategoryId}, null) %></div>
    <%
    }
    %>
</asp:Content>
<asp:Content runat="server" ID="BottomLeftSideBox" ContentPlaceHolderID="BottomLeftSideBox">
</asp:Content>
<asp:Content runat="server" ID="TopMain" ContentPlaceHolderID="TopMainContent">
    <% CategoryBUS bus = new CategoryBUS();
       CategoryDTO parentDTO = bus.GetCategoryById(Model.ParentCate);%>
    <h2>
        <%= parentDTO.CategoryName %></h2>
    <% using (Html.BeginForm())
       {%>
    <input type="hidden" name="txtCategoryId" id="txtCategoryId" value="<%= Model.ParentCate %>" />
    <input type="hidden" name="txtPageNum" id="txtPageNum" value="1" />
    <%
   }%>
</asp:Content>
<asp:Content runat="server" ID="MiddleMain" ContentPlaceHolderID="MiddleMainContent">
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
                    <img title="<%=dto.Title%>" src="../../<%=dto.Image%>" alt="<%=dto.Title%>" style="height: 150px;
                        width: 150px;" />
                </td>
                <td>
                    <%=Html.ActionLink(dto.Title, "BookDetail", "Search", new {id = dto.ISBN}, null)%><br />
                    <b>Tác giả:</b>
                    <%=dto.AuthorName%><br/>
                    <b>Danh mục:</b> <%=dto.CategoryName%>
                    <p>
                        <%= LIB.Constants.Truncate(dto.ShortDescription, 150)%>
                        (<%=Html.ActionLink("đọc thêm", "BookDetail", "Search", new {id = dto.ISBN}, null)%>)</p>
                </td>
            </tr>
        </tbody>
    </table>
    <%
       }
   }
    %>
</asp:Content>
<asp:Content runat="server" ID="BottomMain" ContentPlaceHolderID="BottomMainContent">
<%= Html.Action("Paging","Shared", new {CurrentPage = Model.CurrentPage, NoP = Model.NoP, funcName = "setval"}) %>
</asp:Content>
