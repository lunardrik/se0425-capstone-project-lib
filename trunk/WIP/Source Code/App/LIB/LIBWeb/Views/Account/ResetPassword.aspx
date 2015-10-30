<%@ Page Title="Title" Language="C#" Inherits="System.Web.Mvc.ViewPage<object>" MasterPageFile="~/Views/Shared/Site_Full.master" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Quên mật khẩu
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadScript" runat="server">
    <script type="text/javascript">
        var submitForm = function () {
            document.forms[0].submit();
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="TopMainContent" runat="server">
    <h2>Quên mật khẩu</h2>
    <p>
        Hãy dùng ID của bạn để tạo lại mật khẩu đã mất, mật khẩu mới sẽ được chuyển qua hộp thư điện tử của bạn
    </p>

</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MiddleMainContent" runat="server">

    <% using (Html.BeginForm()) { %>
        <span style="color:<%= ViewData["RESULT"].ToString().Equals("0") ? "red" : "green" %>"><%= ViewData["RESULT"].ToString().Equals("0") ? "Tên đăng nhập không tồn tại trong hệ thống" : ViewData["RESULT"].ToString().Equals("1") ? "Mật khẩu đã được gửi vào hộp thư của bạn, kiểm tra Spam/Bulk nếu bạn chưa nhận được thư." : "" %></span>
        <% if (!ViewData["RESULT"].ToString().Equals("1"))
{%>
        <div>
            <fieldset>
                <legend>Lấy lại mật khẩu bằng tên đăng nhập</legend>
                
                <div class="editor-label">
                    Tên đăng nhập
                </div>
                <div class="editor-field">
                    <input type="text" name="txtUserId" value=""/>
                </div>
                
               <%-- <div class="editor-label">
                    <%= Html.CheckBoxFor(m => m.RememberMe) %>
                    <%= Html.LabelFor(m => m.RememberMe) %>
                </div>--%>
                
                <p>
                    <!--<input type="submit" value="Đăng nhập" />-->
                    <span class="button_01"><a href="javascript:void(0);" onclick="submitForm();">Lấy lại mật khẩu</a></span>
                </p>
            </fieldset>
        </div>
           <% 
}
else if (ViewData["RESULT"].ToString().Equals("1"))
{
    %>
    <br />
    <br />
    <%= Html.ActionLink("Nhấn vào đây để đến trang đăng nhập","LogOn","Account") %>
    <%
}%>

    <% } %>
</asp:Content>




