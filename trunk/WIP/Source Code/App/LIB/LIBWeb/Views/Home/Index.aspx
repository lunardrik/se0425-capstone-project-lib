<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="LIB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Thư viện sách online
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="TopLeftSideBox" runat="server">
<h2>Thành viên</h2>
<p><%= Html.Action("MemberArea","Shared") %></p>
</asp:Content>

<asp:Content ID="Content6" ContentPlaceHolderID="MiddleLeftSideBox" runat="server">
<%= Html.Action("GetRandomCatalogue","Shared") %>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="TopMainContent" runat="server">
                <h2>
                    Đôi dòng về Thư Viện Sách</h2>
                <p>
                    Sách là kết tinh tri thức của nhân loại, là người thầy vĩ đại của mỗi con người.
                    Tuy nhiên, vì nhiều lý do khác nhau mà người ta dần bỏ quên thói quen đọc sách.
                    Sinh viên với nghĩa vụ học tập của mình cũng vần phải tiếp xúc và khai thác tối
                    đa các mặt tích cực của sách.
                    Thư viện sách OPAC lập nên để mọi SV hoặc thành viên của Thư viện ĐH có thể tham
                    gia vào việc phát triển và khai thác các tiềm năng của sách.</p>
                <div class="cleaner_h20">
                </div>
                <div class="image_fl">
                    <img id="FullContentHolder_ContentHolder_Image1" title="Sách" src="../../Images/images01.jpg"
                        alt="Sách" style="height: 180px; width: 240px;">
                </div>
                <div class="section_w250 float_r">
                    <ul class="list_01">
                        <li>Thư viện đồ sộ với hơn 3.000 tựa sách chuyên ngành và ngoại văn.</li>
                        <li>Tự do mượn sách khi là sinh viên của ĐH.</li>
                        <li>Cập nhật tin tức về đầu sách nhanh.</li>
                        <li>Liên tục cập nhật sách hay, sách mới.</li>
                    </ul>
                </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MiddleMainContent" runat="server">
                <h2>
                    Quy trình mượn sách</h2>
                <table width="100%">
                    <tbody>
                        <tr>
                            <td>
                                <img id="FullContentHolder_ContentHolder_Image2" title="Chọn lựa" src="../../Images/option.png"
                                    alt="Chọn lựa" style="height: 64px; width: 64px;">
                            </td>
                            <td>
                                Bạn lựa chọn mượn sách trên thư viện.
                            </td>
                            <td>
                                <img id="FullContentHolder_ContentHolder_Image3" title="Vận chuyển" src="../../Images/transport.png"
                                    alt="Vận chuyển" style="height: 64px; width: 64px;">
                            </td>
                            <td>
                                Bạn sẽ đến nhận sách tại thư viện sau khi gửi yêu cầu mượn sách và đã được xác nhận.
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <img id="FullContentHolder_ContentHolder_Image4" title="Đọc sách" src="../../Images/read.png"
                                    alt="Đọc sách" style="height: 64px; width: 64px;">
                            </td>
                            <td>
                                Bạn giữ sách để đọc và hoàn trả lại trong thời gian quy định kể từ ngày mượn.
                            </td>
                            <td>
                                <img id="FullContentHolder_ContentHolder_Image5" title="Nhắc nhở" src="../../Images/call.png"
                                    alt="Nhắc nhở" style="height: 64px; width: 64px;">
                            </td>
                            <td>
                                Khi bạn trả sách muộn, chúng tôi sẽ gọi điện nhắc nhở và ghi nhận phạt theo quy định.
                            </td>
                        </tr>
                    </tbody>
                </table>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="BottomMainContent" runat="server">
                <span class="bqstart">“</span>
                <%= (new QuoteBUS()).GetRandomQuote() %>
                <span class="bqend">”</span>
</asp:Content>
