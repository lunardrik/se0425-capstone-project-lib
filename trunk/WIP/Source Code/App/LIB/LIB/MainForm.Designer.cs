using System.Drawing;

namespace LIB
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAddBooks = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddRental = new DevExpress.XtraBars.BarButtonItem();
            this.btnApprove = new DevExpress.XtraBars.BarButtonItem();
            this.btnReject = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRegisterRental = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCatalogue = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddCatalogue = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditCatalogue = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteCatalogue = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditAuthor = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditPublisher = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem19 = new DevExpress.XtraBars.BarButtonItem();
            this.btnReturnBook = new DevExpress.XtraBars.BarButtonItem();
            this.barExpandRental = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddUser = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditUser = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnImport = new DevExpress.XtraBars.BarButtonItem();
            this.pageMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageCatalogueManagement = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageRegisterRental = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageUser = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.rpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.hlpSystem = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Caption = "Add New Book";
            this.btnAddBooks.Id = 7;
            this.btnAddBooks.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddBooks.LargeGlyph")));
            this.btnAddBooks.Name = "btnAddBooks";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 539);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(868, 25);
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddRental,
            this.btnApprove,
            this.btnReject,
            this.btnRefresh,
            this.barBtnRegisterRental,
            this.barBtnCatalogue,
            this.barBtnReport,
            this.barButtonItem3,
            this.barButtonItem6,
            this.barBtnUser,
            this.btnAddCatalogue,
            this.btnEditCatalogue,
            this.btnDeleteCatalogue,
            this.btnEditCategory,
            this.btnEditAuthor,
            this.btnEditPublisher,
            this.barButtonItem17,
            this.barButtonItem18,
            this.barButtonItem19,
            this.btnReturnBook,
            this.barExpandRental,
            this.barBtnAddUser,
            this.barBtnEditUser,
            this.barBtnRefresh,
            this.barBtnImport,
            this.barLogOut});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 57;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageMain,
            this.pageCatalogueManagement,
            this.pageRegisterRental,
            this.pageUser});
            this.ribbon.SelectedPage = this.pageMain;
            this.ribbon.Size = new System.Drawing.Size(868, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.SelectedPageChanged += new System.EventHandler(this.ribbon_SelectedPageChanged);
            this.ribbon.TabIndexChanged += new System.EventHandler(this.ribbon_TabIndexChanged);
            // 
            // btnAddRental
            // 
            this.btnAddRental.Caption = "Ghi mượn";
            this.btnAddRental.Id = 18;
            this.btnAddRental.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddRental.LargeGlyph")));
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddRental_ItemClick);
            // 
            // btnApprove
            // 
            this.btnApprove.Caption = "Chấp nhận yêu cầu";
            this.btnApprove.Id = 19;
            this.btnApprove.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnApprove.LargeGlyph")));
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnApprove_ItemClick);
            // 
            // btnReject
            // 
            this.btnReject.Caption = "Từ chối yêu cầu";
            this.btnReject.Id = 20;
            this.btnReject.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnReject.LargeGlyph")));
            this.btnReject.Name = "btnReject";
            this.btnReject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReject_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Làm mới lại trang";
            this.btnRefresh.Id = 25;
            this.btnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.LargeGlyph")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // barBtnRegisterRental
            // 
            this.barBtnRegisterRental.Caption = "Quản lý mượn trả";
            this.barBtnRegisterRental.Id = 27;
            this.barBtnRegisterRental.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnRegisterRental.LargeGlyph")));
            this.barBtnRegisterRental.Name = "barBtnRegisterRental";
            this.barBtnRegisterRental.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRegisterRental_ItemClick);
            // 
            // barBtnCatalogue
            // 
            this.barBtnCatalogue.Caption = "Quản lý thông tin sách";
            this.barBtnCatalogue.Id = 28;
            this.barBtnCatalogue.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnCatalogue.LargeGlyph")));
            this.barBtnCatalogue.Name = "barBtnCatalogue";
            this.barBtnCatalogue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCatalogue_ItemClick);
            // 
            // barBtnReport
            // 
            this.barBtnReport.Caption = "Quản lý Báo Cáo";
            this.barBtnReport.Id = 30;
            this.barBtnReport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnReport.LargeGlyph")));
            this.barBtnReport.Name = "barBtnReport";
            this.barBtnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnReport_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tìm cơ bản";
            this.barButtonItem3.Id = 33;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Tìm kiếm chi tiết";
            this.barButtonItem6.Id = 34;
            this.barButtonItem6.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.LargeGlyph")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barBtnUser
            // 
            this.barBtnUser.Caption = "Quản lý người dùng";
            this.barBtnUser.Id = 35;
            this.barBtnUser.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnUser.LargeGlyph")));
            this.barBtnUser.Name = "barBtnUser";
            this.barBtnUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUser_ItemClick);
            // 
            // btnAddCatalogue
            // 
            this.btnAddCatalogue.Caption = "Thêm sách mới";
            this.btnAddCatalogue.Id = 36;
            this.btnAddCatalogue.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddCatalogue.LargeGlyph")));
            this.btnAddCatalogue.Name = "btnAddCatalogue";
            this.btnAddCatalogue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddCatalogue_ItemClick);
            // 
            // btnEditCatalogue
            // 
            this.btnEditCatalogue.Caption = "Sửa sách";
            this.btnEditCatalogue.Id = 37;
            this.btnEditCatalogue.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditCatalogue.LargeGlyph")));
            this.btnEditCatalogue.Name = "btnEditCatalogue";
            this.btnEditCatalogue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditCatalogue_ItemClick);
            // 
            // btnDeleteCatalogue
            // 
            this.btnDeleteCatalogue.Caption = "Xoá sách";
            this.btnDeleteCatalogue.Id = 38;
            this.btnDeleteCatalogue.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteCatalogue.LargeGlyph")));
            this.btnDeleteCatalogue.Name = "btnDeleteCatalogue";
            this.btnDeleteCatalogue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteCatalogue_ItemClick);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Caption = "Thêm mới Chỉnh sửa danh mục";
            this.btnEditCategory.Id = 40;
            this.btnEditCategory.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditCategory.LargeGlyph")));
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditCategory_ItemClick);
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.Caption = "Chỉnh sửa & Thêm tác giả";
            this.btnEditAuthor.Id = 42;
            this.btnEditAuthor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditAuthor.LargeGlyph")));
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditAuthor_ItemClick);
            // 
            // btnEditPublisher
            // 
            this.btnEditPublisher.Caption = "Thêm mới Chỉnh sửa nhà xuất bản";
            this.btnEditPublisher.Id = 44;
            this.btnEditPublisher.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditPublisher.LargeGlyph")));
            this.btnEditPublisher.Name = "btnEditPublisher";
            this.btnEditPublisher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditPublisher_ItemClick);
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "Tìm căn bản";
            this.barButtonItem17.Id = 45;
            this.barButtonItem17.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem17.LargeGlyph")));
            this.barButtonItem17.Name = "barButtonItem17";
            // 
            // barButtonItem18
            // 
            this.barButtonItem18.Caption = "Tìm nâng cao";
            this.barButtonItem18.Id = 46;
            this.barButtonItem18.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem18.LargeGlyph")));
            this.barButtonItem18.Name = "barButtonItem18";
            // 
            // barButtonItem19
            // 
            this.barButtonItem19.Caption = "Tìm chi tiết";
            this.barButtonItem19.Id = 47;
            this.barButtonItem19.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem19.LargeGlyph")));
            this.barButtonItem19.Name = "barButtonItem19";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Caption = "Ghi trả";
            this.btnReturnBook.Id = 48;
            this.btnReturnBook.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnReturnBook.LargeGlyph")));
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReturnBook_ItemClick);
            // 
            // barExpandRental
            // 
            this.barExpandRental.Caption = "Gia hạn";
            this.barExpandRental.Id = 49;
            this.barExpandRental.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barExpandRental.LargeGlyph")));
            this.barExpandRental.Name = "barExpandRental";
            this.barExpandRental.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barExpandRental_ItemClick);
            // 
            // barBtnAddUser
            // 
            this.barBtnAddUser.Caption = "Thêm người dùng";
            this.barBtnAddUser.Id = 51;
            this.barBtnAddUser.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnAddUser.LargeGlyph")));
            this.barBtnAddUser.Name = "barBtnAddUser";
            this.barBtnAddUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddUser_ItemClick);
            // 
            // barBtnEditUser
            // 
            this.barBtnEditUser.Caption = "Chỉnh sửa người dùng";
            this.barBtnEditUser.Id = 53;
            this.barBtnEditUser.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditUser.LargeGlyph")));
            this.barBtnEditUser.Name = "barBtnEditUser";
            this.barBtnEditUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditUser_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Làm mới";
            this.barBtnRefresh.Id = 54;
            this.barBtnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.LargeGlyph")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
            // 
            // barBtnImport
            // 
            this.barBtnImport.Caption = "Nhập liệu từ file";
            this.barBtnImport.Id = 55;
            this.barBtnImport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnImport.LargeGlyph")));
            this.barBtnImport.Name = "barBtnImport";
            this.barBtnImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnImport_ItemClick);
            // 
            // pageMain
            // 
            this.pageMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.rpgSystem});
            this.pageMain.Name = "pageMain";
            this.pageMain.Text = "Trang Chính";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.barBtnCatalogue);
            this.ribbonPageGroup7.ItemLinks.Add(this.barBtnRegisterRental);
            this.ribbonPageGroup7.ItemLinks.Add(this.barBtnReport);
            this.ribbonPageGroup7.ItemLinks.Add(this.barBtnUser);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            this.ribbonPageGroup7.Text = "Các chức năng chính";
            // 
            // pageCatalogueManagement
            // 
            this.pageCatalogueManagement.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12});
            this.pageCatalogueManagement.Name = "pageCatalogueManagement";
            this.pageCatalogueManagement.Text = "Quản lý sách";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.AllowTextClipping = false;
            this.ribbonPageGroup9.ItemLinks.Add(this.btnAddCatalogue);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnEditCatalogue);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnDeleteCatalogue);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.ShowCaptionButton = false;
            this.ribbonPageGroup9.Text = "Thông tin sách";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.AllowTextClipping = false;
            this.ribbonPageGroup10.ItemLinks.Add(this.btnEditCategory);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.ShowCaptionButton = false;
            this.ribbonPageGroup10.Text = "Thông tin danh mục";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.AllowTextClipping = false;
            this.ribbonPageGroup11.ItemLinks.Add(this.btnEditAuthor);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.ShowCaptionButton = false;
            this.ribbonPageGroup11.Text = "Thông tin tác giả";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.AllowTextClipping = false;
            this.ribbonPageGroup12.ItemLinks.Add(this.btnEditPublisher);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.ShowCaptionButton = false;
            this.ribbonPageGroup12.Text = "Thông tin nhà xuất bản";
            // 
            // pageRegisterRental
            // 
            this.pageRegisterRental.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup14,
            this.ribbonPageGroup4});
            this.pageRegisterRental.Name = "pageRegisterRental";
            this.pageRegisterRental.Text = "Quản lý mượn trả";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnApprove);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReject);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnImport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Quản lý yêu cầu";
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.AllowTextClipping = false;
            this.ribbonPageGroup14.ItemLinks.Add(this.btnAddRental);
            this.ribbonPageGroup14.ItemLinks.Add(this.btnReturnBook);
            this.ribbonPageGroup14.ItemLinks.Add(this.barExpandRental);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            this.ribbonPageGroup14.ShowCaptionButton = false;
            this.ribbonPageGroup14.Text = "Quản lý mượn trả sách";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Khác";
            // 
            // pageUser
            // 
            this.pageUser.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup13});
            this.pageUser.Name = "pageUser";
            this.pageUser.Text = "Quản lý người dùng";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.ItemLinks.Add(this.barBtnAddUser);
            this.ribbonPageGroup8.ItemLinks.Add(this.barBtnEditUser);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.ShowCaptionButton = false;
            this.ribbonPageGroup8.Text = "Quản lý người dùng";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.AllowTextClipping = false;
            this.ribbonPageGroup13.ItemLinks.Add(this.barBtnRefresh);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            this.ribbonPageGroup13.ShowCaptionButton = false;
            this.ribbonPageGroup13.Text = "Khác";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Thư Mục Chính";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Books Research";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Book Management";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Book Management";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Users Management";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Chỉnh sửa yêu cầu";
            this.btnEdit.Id = 21;
            this.btnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.LargeGlyph")));
            this.btnEdit.Name = "btnEdit";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Tạm hoãn yêu cầu";
            this.barButtonItem5.Id = 32;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // rpgSystem
            // 
            this.rpgSystem.AllowTextClipping = false;
            this.rpgSystem.ItemLinks.Add(this.barLogOut);
            this.rpgSystem.Name = "rpgSystem";
            this.rpgSystem.ShowCaptionButton = false;
            this.rpgSystem.Text = "Hệ thống";
            this.rpgSystem.Visible = false;
            // 
            // barLogOut
            // 
            this.barLogOut.Caption = "Đăng xuất";
            this.barLogOut.Id = 56;
            this.barLogOut.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barLogOut.LargeGlyph")));
            this.barLogOut.Name = "barLogOut";
            this.barLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLogOut_ItemClick);
            // 
            // hlpSystem
            // 
            this.hlpSystem.HelpNamespace = "help.chm";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 564);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Hệ Thống Quản Lý Thư Viện LIB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnAddBooks;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageRegisterRental;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnAddRental;
        private DevExpress.XtraBars.BarButtonItem btnApprove;
        private DevExpress.XtraBars.BarButtonItem btnReject;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem barBtnRegisterRental;
        private DevExpress.XtraBars.BarButtonItem barBtnCatalogue;
        private DevExpress.XtraBars.BarButtonItem barBtnReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barBtnUser;
        private DevExpress.XtraBars.BarButtonItem btnAddCatalogue;
        private DevExpress.XtraBars.BarButtonItem btnEditCatalogue;
        private DevExpress.XtraBars.BarButtonItem btnDeleteCatalogue;
        private DevExpress.XtraBars.BarButtonItem btnEditCategory;
        private DevExpress.XtraBars.BarButtonItem btnEditAuthor;
        private DevExpress.XtraBars.BarButtonItem btnEditPublisher;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.BarButtonItem barButtonItem18;
        private DevExpress.XtraBars.BarButtonItem barButtonItem19;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageCatalogueManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.BarButtonItem btnReturnBook;
        private DevExpress.XtraBars.BarButtonItem barExpandRental;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barBtnAddUser;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageUser;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem barBtnEditUser;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.BarButtonItem barBtnImport;
        private DevExpress.XtraBars.BarButtonItem barLogOut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystem;
        private System.Windows.Forms.HelpProvider hlpSystem;
        //private DevExpress.XtraBars.BarListItem blstSearchType;
    }
}