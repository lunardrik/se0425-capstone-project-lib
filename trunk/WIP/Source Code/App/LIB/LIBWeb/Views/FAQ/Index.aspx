<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/Site_Full.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent">
Hỏi đáp
</asp:Content>
<asp:Content runat="server" ID="HeadScript" ContentPlaceHolderID="HeadScript"></asp:Content>
<asp:Content runat="server" ID="TopMain" ContentPlaceHolderID="TopMainContent">        
    <script type="text/javascript">
        $(document).ready(function () {
            $('.faq-content .question').click(function () {
                var an = $(this).next('.answer');
                if ($(an).css('display') == 'none')
                    $(an).slideDown();
                else
                    $(an).slideUp();
            });
        });
    </script>

        <h2>
            Giải đáp chung</h2>
        <div class="faq-content">
            <ol>
                <li>
                    <div class="question">
                        OPAC là gì?
                    </div>
                    <div class="answer" style="display: none; ">
                        Hệ thống OPAC là hệ thống quản lý thư viện online, sử dụng cho những cá nhân độc
                        giả muốn tham khảo sách và đăng ký sách mà không cần phải đến thư viện trường.
                    </div>
                </li>
                <li>
                    <div class="question">
                        Tôi có thể đến trực tiếp thư viện hoặc cách nào để liên lạc không?
                    </div>
                    <div class="answer">
                        Bạn có thể thông wa trang <%= Html.ActionLink("Liên hệ", "Index", "Contact") %>.
                        Tại đây bạn có thể tìm thấy thông tin liên lạc với thư viện trường.
                    </div>
                </li>
                <li>
                    <div class="question">
                        Tôi còn các câu hỏi khác, biết hỏi ai?
                    </div>
                    <div class="answer">
                        Nhân viên thủ thư luôn sẵn sàng đón tiếp bạn tại <%= Html.ActionLink("Liên hệ", "Index", "Contact") %>.
                            Bạn có thể gửi mail hoặc liên lạc với chúng tôi để có câu trả lời trực tiếp.
                    </div>
                </li>
            </ol>
        </div>

</asp:Content>
<asp:Content runat="server" ID="MiddleMain" ContentPlaceHolderID="MiddleMainContent">
        <h2>
            Giải đáp về mượn sách
        </h2>
        <div class="faq-content">
            <ol>
                <li>
                    <div class="question">
                        Vì sao cần hệ thống OPAC khi tôi đã có thể mượn sách tại thư viện?
                    </div>
                    <div class="answer">
                        <ul>
                            <li><b>Thứ nhất</b>, bạn không cần phải đến tận nơi, xếp hàng để mượn được sách. Hãy
                                ở nhà và truy vập website thư việc trường OPAC. 
                                Bạn có thể tìm thấy và đăng ký thông tin trước khi đến nhận sách để giảm thiểu việc xếp hàng mượn sách.</li>
                            <li><b>Thứ hai</b>, các thao tác thông qua internet sẽ là lợi thế cho việc bạn đăng ký mượn sách.</li>
                        </ul>
                    </div>
                </li>
                <li>
                    <div class="question">
                        Các bước đặt mượn sách như thế nào?
                    </div>
                    <div class="answer">
                        <ul>
                            <li><b>Bước 1</b>: Ghi danh, đăng ký với thủ thư để confirm về việc sử dụng dịch vụ OPAC.</li>
                            <li><b>Bước 2</b>: Chọn lựa tựa sách yêu thích trên trang <%= Html.ActionLink("Tìm sách", "Index", "Search") %></li>
                            <li><b>Bước 3</b>: Nhấn nút "Đăng ký mượn" và sau đó là đến trường lấy sách vào thời gian bạn cho là thích hợp
                            và <b>không quá 7 ngày</b> sau khi bạn đăng ký mượn</li>
                        </ul>
                    </div>
                </li>
                <li>
                    <div class="question">
                        Vì sao có những tựa không đăng ký mượn được?
                    </div>
                    <div class="answer">
                        Có thể bạn đã đăng ký mượn tựa sách đó rồi. Hoặc hiện tại tựa sách đang trong
                        tình trạng thiếu bản sao. Bạn vui lòng quay trở lại trong thời gian tới khi
                        thư viện đã cập nhận thêm bản sao của sách.
                    </div>
                </li>
                <li>
                    <div class="question">
                        Tôi cần chờ bao lâu để lấy được sách sau khi yêu cầu?
                    </div>
                    <div class="answer">
                        Bạn có thể lấy lên lấy sách trực tiếp ngay sau khi yêu cầu mượn sách.
                        Đồng thời yêu cầu chỉ có giới hạn 7 ngày. Nếu trong vòng 7 ngày bạn không lấy
                        sách, sách sẽ trở về vị trí của nó.
                    </div>
                </li>
                <li>
                    <div class="question">
                        Tôi có thể ghi chú trên sách hay không?
                    </div>
                    <div class="answer">
                        Vì lý do sách cần được bảo quản tốt cho nhiều khoá SV, nên bạn không được ghi
                        chú, tẩy xóa bất kỳ ký hiệu gì lên sách, kể cả khi dùng viết chì.
                    </div>
                </li>
                <li>
                    <div class="question">
                        Tôi muốn hủy mượn một quyển sách đã đăng ký thì cần làm thế nào?</div>
                    <div class="answer">
                        Việc huỷ đăng ký có thể làm khi đăng ký của bạn chưa đc Chấp nhận. 
                        Bạn hãy vào trang <%= Html.ActionLink("Thông tin", "Information", "Account") %>
                        để huỷ đăng ký của mình bằng cách nhấn nút [Huỷ] ở mục "các sách đã đăng ký".

                        Trong trường hợp đăng ký đã được Chấp nhận, bạn hãy liên lạc với thư viện
                        thông qua <%= Html.ActionLink("Liên hệ", "Index", "Contact") %> để thư viện
                        xử lý.
                    </div>
                </li>
                <li>
                    <div class="question">
                        Tôi lỡ làm hư hỏng, làm mất sách hoặc muốn luôn mua sách đang giữ cần
                        làm thế nào?
                    </div>
                    <div class="answer">
                        Bạn có trách nhiệm đền bù số tiền bằng đúng giá bìa của sách.
                    </div>
                </li>
                <li>
                    <div class="question">
                        Các sách được gửi trong tình trạng thế nào?
                    </div>
                    <div class="answer">
                        thư viện cam kết mọi sách bạn mượn đều trong điều kiện mới hoàn toàn hoặc có thể
                        sử dụng được.</div>
                </li>
                <li>
                    <div class="question">
                        Sách có kèm theo các tài liệu bổ sung như CD, băng cassette không?
                    </div>
                    <div class="answer">
                        Có. Thư viện sẽ gửi bạn đủ bộ sách và các tài liệu, ấn phẩm kèm theo. Tuy nhiên,
                        có sách nằm trong chương trình thì các tài liệu kèm theo sẽ tuỳ thuộc vào mức độ
                        ảnh hưởng đến chương trình học mà có được phân phối ra ngoài hay không.
                    </div>
                </li>
                <li>
                    <div class="question">
                        Tôi có thể giữ sách lâu hơn hạn định không?
                    </div>
                    <div class="answer">
                        Bạn có thể đăng ký gia hạn sách, xin mang sách đến với thư viện để được hỗ trợ.
                    </div>
                </li>
            </ol>
        </div>
</asp:Content>
<asp:Content runat="server" ID="BottomMain" ContentPlaceHolderID="BottomMainContent">
        <h2>
            Thông tin về các chương trình của Thư viện
        </h2>
        <div class="faq-content">
            <ol>
                <li>
                    <div class="question">
                        Hiện tại không có chương trình nào.
                    </div>
                </li>
            </ol>
        </div>
</asp:Content>
