<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/Site_Full.Master" %>
<%@ Import Namespace="LIB" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent">
Liên Hệ
</asp:Content>
<asp:Content runat="server" ID="HeadScript" ContentPlaceHolderID="HeadScript"></asp:Content>
<asp:Content runat="server" ID="TopMain" ContentPlaceHolderID="TopMainContent">
        <h2>
            Liên hệ</h2>
</asp:Content>
<asp:Content runat="server" ID="MiddleMain" ContentPlaceHolderID="MiddleMainContent">        <b>Thư viện sách FPT University</b>
        <table>
            <tbody><tr>
                <td>
                    <img id="FullContentHolder_ContentHolder_imgAddress" title="Địa chỉ" src="../../Images/address.png" alt="Địa chỉ" style="height:16px;width:16px;">
                </td>
                <td>
                    Toà nhà Innovation, QTSC, Số 1 Tô Ký, Phường Tân Thới Hiệp, Quận 12
                </td>
            </tr>
            <tr>
                <td>
                    <img id="FullContentHolder_ContentHolder_imgPhone" title="Điện thoại" src="../../Images/phone.png" alt="Điện thoại" style="height:16px;width:16px;">
                </td>
                <td>
                    0901234567
                </td>
            </tr>
            <tr>
                <td>
                    <img id="FullContentHolder_ContentHolder_imgEmail" title="Email" src="../../Images/email.png" alt="Email" style="height:16px;width:16px;">
                </td>
                <td>
                    <a href="mailto:fu.thuvien@gmail.com">
                        fu.thuvien@gmail.com</a>
                </td>
            </tr>
        </tbody></table>
        <ul>
            <li><b>Thời gian:</b> 08h - 17h</li>
            <li><b>Hình thức:</b> Liên hệ trực tiếp tại thư viện hoặc qua Yahoo <a href="ymsgr:sendim?quanly.thuvien">quanly</a></li>
        </ul>
        <div class="cleaner">
        </div>
</asp:Content>
<asp:Content runat="server" ID="BottomMain" ContentPlaceHolderID="BottomMainContent">
                <span class="bqstart">“</span>
                <%= (new QuoteBUS()).GetRandomQuote() %>
                <span class="bqend">”</span>
</asp:Content>
