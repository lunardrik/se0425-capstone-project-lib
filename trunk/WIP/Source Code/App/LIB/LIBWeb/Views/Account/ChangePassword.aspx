<%@ Page Title="Title" Language="C#" Inherits="System.Web.Mvc.ViewPage<object>" MasterPageFile="~/Views/Shared/Site_Full.master" %>
<%@ Import Namespace="LIB" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Đổi mật khẩu
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadScript" runat="server">
    <script src="<%= Url.Content("~/Script/checkpass.js")%>" type="text/javascript"></script>
    <script src="<%= Url.Content("~/Script/md5-min.js")%>" type="text/javascript"></script>
    <script type="text/javascript">

        var submitForm = function () {
            if (document.getElementById('txtOldPassword').value == '') { return alert('Xin nhập vào mật khẩu hiện tại'); }
            if (document.getElementById('txtNewPassword').value == '') { return alert('Xin nhập vào mật khẩu mới'); }
            if (document.getElementById('txtNewPasswordA').value == '') { return alert('Xin nhập lại mật khẩu mới'); }
            if (document.getElementById('txtNewPassword').value != document.getElementById('txtNewPasswordA').value) { return alert('Mật khẩu gõ lại không trùng khớp'); }

            if (document.getElementById('txtNewPassword').value == document.getElementById('txtUserId').value) { return alert('Mật khẩu không được trùng với Tên đăng nhập'); }

            document.getElementById('txtOldPassword').value = hex_md5(document.getElementById('txtOldPassword').value);
            document.getElementById('txtNewPassword').value = hex_md5(document.getElementById('txtNewPassword').value);
            document.getElementById('txtNewPasswordA').value = hex_md5(document.getElementById('txtNewPasswordA').value);
            document.forms[0].submit();
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="TopMainContent" runat="server">
    <h2>Đổi mật khẩu</h2>
    <p>
        Nhập mật khẩu cũ và mật khẩu mới mà bạn muốn đổi.
    </p>

</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MiddleMainContent" runat="server">

    <% using (Html.BeginForm()) { %>
        <span style="color:<%= ViewData["RESULT"].ToString().Equals("0") ? "red" : "green" %>"><%= ViewData["RESULT"].ToString().Equals("0") ? "Có lỗi trong quá trình cập nhật thay đổi mật khẩu" : ViewData["RESULT"].ToString().Equals("1") ? "Mật khẩu đã được cập nhật thành công và gửi vào hộp thư của bạn, kiểm tra Spam/Bulk nếu bạn chưa nhận được thư." : "" %></span>
        <% if (!ViewData["RESULT"].ToString().Equals("1"))
{%>
        <div>
            <fieldset>
                <input type="hidden" id="txtUserId" value="<%= ((UserDTO)Session["USER"]).UserId %>"/>
                <legend>Cập nhật mật khẩu</legend>
                
                <div class="editor-label">
                    Mật khẩu hiện tại
                </div>
                <div class="editor-field">
                    <input type="password" id="txtOldPassword" name="txtOldPassword" value=""/>
                </div>
                <br/>
                <br/>

                <div class="editor-label">
                    Mật khẩu mới
                </div>
                <div class="editor-field">
                    <input type="password" id="txtNewPassword" name="txtNewPassword" value=""/>
                </div><div class="editor-label">
                    Nhập lại
                </div>
                <div class="editor-field">
                    <input type="password" id="txtNewPasswordA" name="txtNewPasswordA" value=""/>
                </div>
                <script type="text/javascript">
                    
                        $("#txtNewPassword").passStrength({
                            userid: "#txtUserId" 	//required override
                        });
                    
                </script>
               <%-- <div class="editor-label">
                    <%= Html.CheckBoxFor(m => m.RememberMe) %>
                    <%= Html.LabelFor(m => m.RememberMe) %>
                </div>--%>
                
                <p>
                    <!--<input type="submit" value="Đăng nhập" />-->
                    <span class="button_01"><a href="javascript:void(0);" onclick="submitForm();">Thay đổi mật khẩu</a></span>
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