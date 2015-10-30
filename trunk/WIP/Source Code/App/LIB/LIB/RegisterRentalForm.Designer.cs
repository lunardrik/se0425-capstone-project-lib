namespace LIB
{
    partial class RegisterRentalForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterRentalForm));
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabRegister = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetRequest = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchRequest = new DevExpress.XtraEditors.SimpleButton();
            this.cboRequestStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dteRequestTo = new System.Windows.Forms.DateTimePicker();
            this.dteRequestFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequestTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRequestUser = new System.Windows.Forms.TextBox();
            this.grdRegister = new DevExpress.XtraGrid.GridControl();
            this.bookRegisterDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdViewRegister = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegisterDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabRental = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetRental = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchRental = new DevExpress.XtraEditors.SimpleButton();
            this.txtRentalUser = new System.Windows.Forms.TextBox();
            this.txtRentalTitle = new System.Windows.Forms.TextBox();
            this.dteRentalFrom = new System.Windows.Forms.DateTimePicker();
            this.dteRentalTo = new System.Windows.Forms.DateTimePicker();
            this.cboRentalStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grdRental = new DevExpress.XtraGrid.GridControl();
            this.rentalDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewRental = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReturnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpandCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpandLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookRegisterDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewRegister)).BeginInit();
            this.tabRental.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRental)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.tabRegister;
            this.tabControl.Size = new System.Drawing.Size(865, 397);
            this.tabControl.TabIndex = 6;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabRegister,
            this.tabRental});
            this.tabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControlSelectedPageChanged);
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.splitContainer1);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Size = new System.Drawing.Size(858, 368);
            this.tabRegister.Text = "Yêu Cầu";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdRegister);
            this.splitContainer1.Size = new System.Drawing.Size(858, 368);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetRequest);
            this.groupBox1.Controls.Add(this.btnSearchRequest);
            this.groupBox1.Controls.Add(this.cboRequestStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dteRequestTo);
            this.groupBox1.Controls.Add(this.dteRequestFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRequestTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRequestUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 80);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnResetRequest
            // 
            this.btnResetRequest.Location = new System.Drawing.Point(613, 20);
            this.btnResetRequest.Name = "btnResetRequest";
            this.btnResetRequest.Size = new System.Drawing.Size(75, 23);
            this.btnResetRequest.TabIndex = 19;
            this.btnResetRequest.Text = "Hủy";
            this.btnResetRequest.Click += new System.EventHandler(this.BtnResetRequestClick);
            // 
            // btnSearchRequest
            // 
            this.btnSearchRequest.Location = new System.Drawing.Point(532, 20);
            this.btnSearchRequest.Name = "btnSearchRequest";
            this.btnSearchRequest.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRequest.TabIndex = 18;
            this.btnSearchRequest.Text = "Tìm kiếm";
            this.btnSearchRequest.Click += new System.EventHandler(this.BtnRegisterSearchClick);
            // 
            // cboRequestStatus
            // 
            this.cboRequestStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequestStatus.FormattingEnabled = true;
            this.cboRequestStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Mới",
            "Chấp nhận",
            "Từ chối"});
            this.cboRequestStatus.Location = new System.Drawing.Point(402, 22);
            this.cboRequestStatus.Name = "cboRequestStatus";
            this.cboRequestStatus.Size = new System.Drawing.Size(124, 21);
            this.cboRequestStatus.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đến ngày";
            // 
            // dteRequestTo
            // 
            this.dteRequestTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteRequestTo.Location = new System.Drawing.Point(234, 50);
            this.dteRequestTo.Name = "dteRequestTo";
            this.dteRequestTo.Size = new System.Drawing.Size(99, 21);
            this.dteRequestTo.TabIndex = 15;
            // 
            // dteRequestFrom
            // 
            this.dteRequestFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteRequestFrom.Location = new System.Drawing.Point(65, 50);
            this.dteRequestFrom.Name = "dteRequestFrom";
            this.dteRequestFrom.Size = new System.Drawing.Size(100, 21);
            this.dteRequestFrom.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tình trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tựa sách";
            // 
            // txtRequestTitle
            // 
            this.txtRequestTitle.Location = new System.Drawing.Point(234, 22);
            this.txtRequestTitle.Name = "txtRequestTitle";
            this.txtRequestTitle.Size = new System.Drawing.Size(100, 21);
            this.txtRequestTitle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Độc giả";
            // 
            // txtRequestUser
            // 
            this.txtRequestUser.Location = new System.Drawing.Point(65, 22);
            this.txtRequestUser.Name = "txtRequestUser";
            this.txtRequestUser.Size = new System.Drawing.Size(100, 21);
            this.txtRequestUser.TabIndex = 6;
            // 
            // grdRegister
            // 
            this.grdRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdRegister.DataSource = this.bookRegisterDTOBindingSource;
            this.grdRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRegister.Location = new System.Drawing.Point(0, 0);
            this.grdRegister.MainView = this.grdViewRegister;
            this.grdRegister.Name = "grdRegister";
            this.grdRegister.Size = new System.Drawing.Size(858, 284);
            this.grdRegister.TabIndex = 5;
            this.grdRegister.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewRegister});
            // 
            // bookRegisterDTOBindingSource
            // 
            this.bookRegisterDTOBindingSource.DataSource = typeof(LIB.BookRegisterDTO);
            // 
            // grdViewRegister
            // 
            this.grdViewRegister.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserId,
            this.colISBN,
            this.colRegisterDate,
            this.colNote,
            this.colStatus});
            this.grdViewRegister.GridControl = this.grdRegister;
            this.grdViewRegister.Name = "grdViewRegister";
            // 
            // colUserId
            // 
            this.colUserId.Caption = "Đọc giả";
            this.colUserId.FieldName = "Username";
            this.colUserId.Name = "colUserId";
            this.colUserId.OptionsColumn.AllowEdit = false;
            this.colUserId.Visible = true;
            this.colUserId.VisibleIndex = 0;
            // 
            // colISBN
            // 
            this.colISBN.Caption = "Tựa sách";
            this.colISBN.FieldName = "BookTitle";
            this.colISBN.Name = "colISBN";
            this.colISBN.OptionsColumn.AllowEdit = false;
            this.colISBN.Visible = true;
            this.colISBN.VisibleIndex = 1;
            // 
            // colRegisterDate
            // 
            this.colRegisterDate.Caption = "Ngày đăng ký";
            this.colRegisterDate.FieldName = "RegisterDate";
            this.colRegisterDate.Name = "colRegisterDate";
            this.colRegisterDate.OptionsColumn.AllowEdit = false;
            this.colRegisterDate.Visible = true;
            this.colRegisterDate.VisibleIndex = 2;
            // 
            // colNote
            // 
            this.colNote.Caption = "Ghi chú";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.AllowEdit = false;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 3;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Tình trạng";
            this.colStatus.FieldName = "StatusFriendly";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            // 
            // tabRental
            // 
            this.tabRental.Controls.Add(this.splitContainer2);
            this.tabRental.Name = "tabRental";
            this.tabRental.Size = new System.Drawing.Size(858, 368);
            this.tabRental.Text = "Mượn trả";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grdRental);
            this.splitContainer2.Size = new System.Drawing.Size(858, 368);
            this.splitContainer2.SplitterDistance = 80;
            this.splitContainer2.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetRental);
            this.groupBox2.Controls.Add(this.btnSearchRental);
            this.groupBox2.Controls.Add(this.txtRentalUser);
            this.groupBox2.Controls.Add(this.txtRentalTitle);
            this.groupBox2.Controls.Add(this.dteRentalFrom);
            this.groupBox2.Controls.Add(this.dteRentalTo);
            this.groupBox2.Controls.Add(this.cboRentalStatus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnResetRental
            // 
            this.btnResetRental.Location = new System.Drawing.Point(634, 18);
            this.btnResetRental.Name = "btnResetRental";
            this.btnResetRental.Size = new System.Drawing.Size(75, 23);
            this.btnResetRental.TabIndex = 21;
            this.btnResetRental.Text = "Hủy";
            this.btnResetRental.Click += new System.EventHandler(this.BtnResetRentalClick);
            // 
            // btnSearchRental
            // 
            this.btnSearchRental.Location = new System.Drawing.Point(553, 18);
            this.btnSearchRental.Name = "btnSearchRental";
            this.btnSearchRental.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRental.TabIndex = 20;
            this.btnSearchRental.Text = "Tìm kiếm";
            this.btnSearchRental.Click += new System.EventHandler(this.BtnRentalSearchClick);
            // 
            // txtRentalUser
            // 
            this.txtRentalUser.Location = new System.Drawing.Point(65, 20);
            this.txtRentalUser.Name = "txtRentalUser";
            this.txtRentalUser.Size = new System.Drawing.Size(100, 21);
            this.txtRentalUser.TabIndex = 6;
            // 
            // txtRentalTitle
            // 
            this.txtRentalTitle.Location = new System.Drawing.Point(240, 20);
            this.txtRentalTitle.Name = "txtRentalTitle";
            this.txtRentalTitle.Size = new System.Drawing.Size(100, 21);
            this.txtRentalTitle.TabIndex = 8;
            // 
            // dteRentalFrom
            // 
            this.dteRentalFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteRentalFrom.Location = new System.Drawing.Point(65, 50);
            this.dteRentalFrom.Name = "dteRentalFrom";
            this.dteRentalFrom.Size = new System.Drawing.Size(99, 21);
            this.dteRentalFrom.TabIndex = 14;
            // 
            // dteRentalTo
            // 
            this.dteRentalTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteRentalTo.Location = new System.Drawing.Point(240, 50);
            this.dteRentalTo.Name = "dteRentalTo";
            this.dteRentalTo.Size = new System.Drawing.Size(99, 21);
            this.dteRentalTo.TabIndex = 15;
            // 
            // cboRentalStatus
            // 
            this.cboRentalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRentalStatus.FormattingEnabled = true;
            this.cboRentalStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Đang mượn",
            "Đã trả",
            "Bị mất",
            "Hỏng sách"});
            this.cboRentalStatus.Location = new System.Drawing.Point(423, 20);
            this.cboRentalStatus.Name = "cboRentalStatus";
            this.cboRentalStatus.Size = new System.Drawing.Size(124, 21);
            this.cboRentalStatus.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Đến ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Từ ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tình trạng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tựa sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Độc giả";
            // 
            // grdRental
            // 
            this.grdRental.DataSource = this.rentalDTOBindingSource;
            this.grdRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRental.Location = new System.Drawing.Point(0, 0);
            this.grdRental.MainView = this.gridViewRental;
            this.grdRental.Name = "grdRental";
            this.grdRental.Size = new System.Drawing.Size(858, 284);
            this.grdRental.TabIndex = 6;
            this.grdRental.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRental});
            // 
            // rentalDTOBindingSource
            // 
            this.rentalDTOBindingSource.DataSource = typeof(LIB.RentalDTO);
            // 
            // gridViewRental
            // 
            this.gridViewRental.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserId1,
            this.colBarcode,
            this.colTitle,
            this.colIssueDate,
            this.colDueDate,
            this.colReturnDate,
            this.colFine,
            this.colStatus1,
            this.colExpandCount,
            this.colExpandLimit,
            this.status});
            this.gridViewRental.GridControl = this.grdRental;
            this.gridViewRental.Name = "gridViewRental";
            // 
            // colUserId1
            // 
            this.colUserId1.Caption = "Đọc giả";
            this.colUserId1.FieldName = "Username";
            this.colUserId1.Name = "colUserId1";
            this.colUserId1.OptionsColumn.AllowEdit = false;
            this.colUserId1.Visible = true;
            this.colUserId1.VisibleIndex = 0;
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "ĐKCB";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.OptionsColumn.AllowEdit = false;
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 2;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Tựa sách";
            this.colTitle.FieldName = "BookTitle";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsColumn.AllowEdit = false;
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            // 
            // colIssueDate
            // 
            this.colIssueDate.Caption = "Ngày nhận sách";
            this.colIssueDate.FieldName = "IssueDate";
            this.colIssueDate.Name = "colIssueDate";
            this.colIssueDate.OptionsColumn.AllowEdit = false;
            this.colIssueDate.Visible = true;
            this.colIssueDate.VisibleIndex = 3;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "Ngày hết hạn";
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.OptionsColumn.AllowEdit = false;
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 4;
            // 
            // colReturnDate
            // 
            this.colReturnDate.Caption = "Ngày trả";
            this.colReturnDate.FieldName = "ReturnDate";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.OptionsColumn.AllowEdit = false;
            this.colReturnDate.Visible = true;
            this.colReturnDate.VisibleIndex = 5;
            // 
            // colFine
            // 
            this.colFine.Caption = "Tiền phạt";
            this.colFine.FieldName = "Fine";
            this.colFine.Name = "colFine";
            this.colFine.OptionsColumn.AllowEdit = false;
            this.colFine.Visible = true;
            this.colFine.VisibleIndex = 6;
            // 
            // colStatus1
            // 
            this.colStatus1.Caption = "Tình trạng";
            this.colStatus1.FieldName = "StatusFriendly";
            this.colStatus1.Name = "colStatus1";
            this.colStatus1.OptionsColumn.AllowEdit = false;
            this.colStatus1.Visible = true;
            this.colStatus1.VisibleIndex = 7;
            // 
            // colExpandCount
            // 
            this.colExpandCount.Caption = "Số lần đã gia hạn";
            this.colExpandCount.FieldName = "ExpandCount";
            this.colExpandCount.Name = "colExpandCount";
            this.colExpandCount.OptionsColumn.AllowEdit = false;
            this.colExpandCount.Visible = true;
            this.colExpandCount.VisibleIndex = 8;
            // 
            // colExpandLimit
            // 
            this.colExpandLimit.Caption = "Số lần gia hạn tối đa";
            this.colExpandLimit.FieldName = "ExpandLimit";
            this.colExpandLimit.Name = "colExpandLimit";
            this.colExpandLimit.OptionsColumn.AllowEdit = false;
            this.colExpandLimit.Visible = true;
            this.colExpandLimit.VisibleIndex = 9;
            // 
            // status
            // 
            this.status.Caption = "gridColumn1";
            this.status.FieldName = "Status";
            this.status.Name = "status";
            // 
            // RegisterRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 397);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterRentalForm";
            this.Text = "Quản lý mượn trả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.RegisterRentalFormActivated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterRentalFormFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookRegisterDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewRegister)).EndInit();
            this.tabRental.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRental)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage tabRegister;
        private DevExpress.XtraGrid.GridControl grdRegister;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewRegister;
        private DevExpress.XtraTab.XtraTabPage tabRental;
        private DevExpress.XtraGrid.GridControl grdRental;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRental;
        private System.Windows.Forms.BindingSource bookRegisterDTOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colRegisterDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.Windows.Forms.BindingSource rentalDTOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId1;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReturnDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFine;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn status;
        private System.Windows.Forms.TextBox txtRequestUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequestTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboRequestStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dteRequestTo;
        private System.Windows.Forms.DateTimePicker dteRequestFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboRentalStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dteRentalTo;
        private System.Windows.Forms.DateTimePicker dteRentalFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRentalTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRentalUser;
        private DevExpress.XtraGrid.Columns.GridColumn colExpandCount;
        private DevExpress.XtraGrid.Columns.GridColumn colExpandLimit;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.SimpleButton btnResetRequest;
        private DevExpress.XtraEditors.SimpleButton btnSearchRequest;
        private DevExpress.XtraEditors.SimpleButton btnResetRental;
        private DevExpress.XtraEditors.SimpleButton btnSearchRental;
    }
}