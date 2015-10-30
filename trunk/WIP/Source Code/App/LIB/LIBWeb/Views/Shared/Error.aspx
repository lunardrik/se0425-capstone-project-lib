<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site_Full.master" Inherits="System.Web.Mvc.ViewPage<System.Web.Mvc.HandleErrorInfo>" %>

<asp:Content ID="errorTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Có lỗi xảy ra
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="TopMainContent" runat="server">
    Có lỗi xảy ra
</asp:Content>

<asp:Content ID="errorContent" ContentPlaceHolderID="MiddleMainContent" runat="server">
    <span style="color:red"><%= ViewData["Message"] %></span>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BottomMainContent" runat="server">
    <a href="<%=Request.UrlReferrer %>">Nhấn vào đây để quay về trang trước đó.</a>
</asp:Content>
