<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<LIB.UserDTO>" MasterPageFile="~/Views/Shared/Site.Master" %>
<%@ Import Namespace="LIB" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent">
Thông tin chi tiết của thành viên
</asp:Content>
<asp:Content runat="server" ID="HeadScript" ContentPlaceHolderID="HeadScript">
<script type="text/javascript">
    function setvalRental(v) {
        $.ajax({
            url: '/Shared/GetRentalByUserIdPaging/?p=' + v,
            success: function (data) {
                $('#rentalBody').html(data);
            }
        });
    }
    function setvalRegister(v) {
        $.ajax({
            url: '/Shared/GetRegisterByUserIdPaging/?p=' + v,
            success: function (data) {
                $('#registerBody').html(data);
            }
        });
    }
</script>
</asp:Content>
<asp:Content runat="server" ID="TopLeftSideBox" ContentPlaceHolderID="TopLeftSideBox">
<h2>Thành viên</h2>
<p><%= Html.Action("MemberArea","Shared") %></p>
<br/>
<%= Html.ActionLink("Thay đổi mật khẩu đăng nhập","ChangePassword","Account") %>
</asp:Content>
<asp:Content runat="server" ID="MiddleLeftSideBox" ContentPlaceHolderID="MiddleLeftSideBox">
</asp:Content>
<asp:Content runat="server" ID="BottomLeftSideBox" ContentPlaceHolderID="BottomLeftSideBox">
<%= Html.Action("GetRandomCatalogue","Shared") %>
</asp:Content>
<asp:Content runat="server" ID="TopMain" ContentPlaceHolderID="TopMainContent">
<h2><%= Model.Username %></h2>
</asp:Content>
<asp:Content runat="server" ID="MiddleMain" ContentPlaceHolderID="MiddleMainContent">
<h2>Sách bạn đang mượn</h2>
<table class="background-image" summary="Meeting Results">
<thead align="center">
<tr>
<th scope="col">Tựa sách</th>
<th scope="col">Mã số</th>
<th scope="col">Ngày hết hạn</th>
<th scope="col">Trạng thái</th>
</tr>
</thead>
<tfoot>
<tr>
<td colspan="4">Nếu bạn muốn gia hạn thời gian mượn, vui lòng đến gặp Thủ thư của thư viện.</td>
</tr>
</tfoot>
<tbody id="rentalBody">
<%= Html.Action("GetRentalByUserIdPaging","Shared", new {p = 1})%>
</tbody>
</table>
</asp:Content>
<asp:Content runat="server" ID="BottomMain" ContentPlaceHolderID="BottomMainContent">
<h2>Sách bạn đã đăng ký mượn</h2>
<table class="background-image" summary="Meeting Results">
<thead align="center">
<tr>
<th scope="col">Tựa sách</th>
<th scope="col">Ngày đăng ký</th>
<th scope="col">Trạng thái</th>
<th scope="col">Huỷ</th>
</tr>
</thead>
<tfoot>
<tr>
<td colspan="4">Nhấn vào nút <b>[Huỷ]</b> nếu bạn không muốn tiếp tục đăng ký mượn sách nữa.</td>
</tr>
</tfoot>
<tbody id="registerBody">
<%= Html.Action("GetRegisterByUserIdPaging", "Shared", new { p = 1 })%>
</tbody>
</table>
</asp:Content>
