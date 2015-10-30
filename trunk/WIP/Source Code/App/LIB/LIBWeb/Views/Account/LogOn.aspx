<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site_Full.Master" Inherits="System.Web.Mvc.ViewPage<LIBWeb.Models.LogOnModel>" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Đăng nhập
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadScript" runat="server">
    <script src="<%= Url.Content("~/Script/md5-min.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        var submitForm = function () {
            document.getElementById('Password').value = hex_md5(document.getElementById('Password').value);
            document.forms[0].submit();
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="TopMainContent" runat="server">
    <h2>Đăng nhập hệ thống</h2>
    <p>
        Hãy đăng nhập vào hệ thống với tên đăng nhập và mật khẩu của bạn. Nếu bạn muốn đăng ký với Thư viện, xin liên hệ thủ thư để biết thêm chi tiết.
    </p>

</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MiddleMainContent" runat="server">

    <% using (Html.BeginForm()) { %>
        <span style="color:red"><%= ViewData["LogOnError"] ?? "" %></span>
        <div>
            <fieldset>
                <legend>Thông tin đăng nhập</legend>
                
                <div class="editor-label">
                    Tên đăng nhập
                </div>
                <div class="editor-field">
                    <%= Html.TextBoxFor(m => m.UserName) %>
                    <%= Html.ValidationMessageFor(m => m.UserName) %>
                </div>
                
                <div class="editor-label">
                    Mật khẩu
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(m => m.Password) %>
                    <%= Html.ValidationMessageFor(m => m.Password) %>
                </div>
                <%= Html.ActionLink("Quên mật khẩu?","ResetPassword","Account") %>
                <br/>
                <br/>
                <br/>
               <%-- <div class="editor-label">
                    <%= Html.CheckBoxFor(m => m.RememberMe) %>
                    <%= Html.LabelFor(m => m.RememberMe) %>
                </div>--%>
                
                <p>
                    <!--<input type="submit" value="Đăng nhập" />-->
                    <span class="button_01"><a href="javascript:void(0);" onclick="submitForm();">Đăng nhập</a></span>
                </p>
            </fieldset>
        </div>
    <% } %>
</asp:Content>
