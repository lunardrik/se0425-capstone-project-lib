namespace LIB
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.wizReport = new DevExpress.XtraWizard.WizardControl();
            this.wpWelcome = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.grcctlResult = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.wpSelectReportTemplate = new DevExpress.XtraWizard.WizardPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rdgReportTemplate = new DevExpress.XtraEditors.RadioGroup();
            this.wpComplete = new DevExpress.XtraWizard.CompletionWizardPage();
            this.chkRunReport = new DevExpress.XtraEditors.CheckEdit();
            this.wpSelectReportType = new DevExpress.XtraWizard.WizardPage();
            this.grpcReportType = new DevExpress.XtraEditors.GroupControl();
            this.rdgReportType = new DevExpress.XtraEditors.RadioGroup();
            this.grpcReportParams = new DevExpress.XtraEditors.GroupControl();
            this.llblSearch = new System.Windows.Forms.LinkLabel();
            this.txtParam = new DevExpress.XtraEditors.TextEdit();
            this.lblParam = new System.Windows.Forms.Label();
            this.wpOutput = new DevExpress.XtraWizard.WizardPage();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbxFileType = new System.Windows.Forms.ComboBox();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.psExporter = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.pcLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.pcLinkChart = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.cpLink = new DevExpress.XtraPrintingLinks.CompositeLink(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizReport)).BeginInit();
            this.wizReport.SuspendLayout();
            this.wpWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcctlResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.wpSelectReportTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgReportTemplate.Properties)).BeginInit();
            this.wpComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRunReport.Properties)).BeginInit();
            this.wpSelectReportType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpcReportType)).BeginInit();
            this.grpcReportType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgReportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcReportParams)).BeginInit();
            this.grpcReportParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParam.Properties)).BeginInit();
            this.wpOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psExporter)).BeginInit();
            this.SuspendLayout();
            // 
            // wizReport
            // 
            this.wizReport.Appearance.AeroWizardTitle.Image = global::LIB.Properties.Resources.coco_report_banner;
            this.wizReport.Appearance.AeroWizardTitle.Options.UseImage = true;
            this.wizReport.Appearance.Page.Image = global::LIB.Properties.Resources.coco_report_banner;
            this.wizReport.Appearance.Page.Options.UseImage = true;
            this.wizReport.Appearance.PageTitle.BackColor = System.Drawing.Color.White;
            this.wizReport.Appearance.PageTitle.BackColor2 = System.Drawing.Color.Transparent;
            this.wizReport.Appearance.PageTitle.Options.UseBackColor = true;
            this.wizReport.CancelText = "Huỷ bỏ";
            this.wizReport.Controls.Add(this.wpWelcome);
            this.wizReport.Controls.Add(this.wpSelectReportTemplate);
            this.wizReport.Controls.Add(this.wpComplete);
            this.wizReport.Controls.Add(this.wpSelectReportType);
            this.wizReport.Controls.Add(this.wpOutput);
            this.wizReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizReport.FinishText = "&Hoàn tất";
            this.wizReport.HelpText = "&Giúp đỡ";
            this.wizReport.Image = global::LIB.Properties.Resources.document_chart;
            this.wizReport.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.wizReport.Location = new System.Drawing.Point(0, 0);
            this.wizReport.Name = "wizReport";
            this.wizReport.NextText = "&Tiếp tục >";
            this.wizReport.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wpWelcome,
            this.wpSelectReportTemplate,
            this.wpSelectReportType,
            this.wpOutput,
            this.wpComplete});
            this.wizReport.PreviousText = "< Trở &về";
            this.wizReport.Size = new System.Drawing.Size(675, 498);
            this.wizReport.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizReport_SelectedPageChanged);
            this.wizReport.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizReport_CancelClick);
            this.wizReport.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizReport_FinishClick);
            this.wizReport.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizReport_NextClick);
            // 
            // wpWelcome
            // 
            this.wpWelcome.Controls.Add(this.grcctlResult);
            this.wpWelcome.IntroductionText = resources.GetString("wpWelcome.IntroductionText");
            this.wpWelcome.Name = "wpWelcome";
            this.wpWelcome.ProceedText = "Để tiếp tục, hãy nhấn [Tiếp tục]";
            this.wpWelcome.Size = new System.Drawing.Size(458, 365);
            this.wpWelcome.Text = "Hệ thống trích xuất báo cáo thống kê";
            // 
            // grcctlResult
            // 
            this.grcctlResult.Location = new System.Drawing.Point(445, 352);
            this.grcctlResult.MainView = this.gridView1;
            this.grcctlResult.Name = "grcctlResult";
            this.grcctlResult.Size = new System.Drawing.Size(10, 10);
            this.grcctlResult.TabIndex = 0;
            this.grcctlResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grcctlResult.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grcctlResult;
            this.gridView1.Name = "gridView1";
            // 
            // wpSelectReportTemplate
            // 
            this.wpSelectReportTemplate.Controls.Add(this.labelControl2);
            this.wpSelectReportTemplate.Controls.Add(this.labelControl5);
            this.wpSelectReportTemplate.Controls.Add(this.labelControl4);
            this.wpSelectReportTemplate.Controls.Add(this.labelControl3);
            this.wpSelectReportTemplate.Controls.Add(this.labelControl1);
            this.wpSelectReportTemplate.Controls.Add(this.rdgReportTemplate);
            this.wpSelectReportTemplate.DescriptionText = "Trong bước này, bạn hãy chọn 1 trong những kiểu thống kê đã được định nghĩa sẵn d" +
                "ưới đây để tiếp tục";
            this.wpSelectReportTemplate.Name = "wpSelectReportTemplate";
            this.wpSelectReportTemplate.Size = new System.Drawing.Size(643, 353);
            this.wpSelectReportTemplate.Text = "Bước 1 - Chọn kiểu thống kê";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.Location = new System.Drawing.Point(70, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(547, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Giúp bạn nhanh chóng thống kê lại số lượng bản sao có trong hệ thống trên tiêu ch" +
                "í còn và đã được độc giả mượn.";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl5.Location = new System.Drawing.Point(70, 290);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(398, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Tạo ra các bản thống kê chi tiết cho phân hệ Mượn/Trả theo một độc giả nhất định." +
                "";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl4.Location = new System.Drawing.Point(70, 234);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(407, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Tạo ra các bản thống kê chi tiết cho phân hệ Mượn/Trả theo một đầu sách nhất định" +
                ".";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.Location = new System.Drawing.Point(70, 178);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(373, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Cho bạn các thông kê nhanh về tỉ lệ hoặc chi tiết các bản sao đang bị trễ hạn.";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.Location = new System.Drawing.Point(70, 122);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(493, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Giúp bạn thống kê số lượng đầu sách có trong hệ thống theo các Danh mục gốc có sẵ" +
                "n trong hệ thống.";
            // 
            // rdgReportTemplate
            // 
            this.rdgReportTemplate.Location = new System.Drawing.Point(45, 25);
            this.rdgReportTemplate.Name = "rdgReportTemplate";
            this.rdgReportTemplate.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgReportTemplate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdgReportTemplate.Properties.Appearance.Options.UseBackColor = true;
            this.rdgReportTemplate.Properties.Appearance.Options.UseFont = true;
            this.rdgReportTemplate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdgReportTemplate.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Tỉ lệ sách trong hệ thống."),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tỉ lệ sách theo danh mục gốc."),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Thông tin bản sao và trễ hạn."),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Thông tin chi tiết về Mượn/Trả theo đầu sách."),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Thông tin chi tiết về Mượn/Trả theo độc giả.")});
            this.rdgReportTemplate.Size = new System.Drawing.Size(328, 289);
            this.rdgReportTemplate.TabIndex = 10;
            this.rdgReportTemplate.SelectedIndexChanged += new System.EventHandler(this.rdgReportTemplate_SelectedIndexChanged);
            // 
            // wpComplete
            // 
            this.wpComplete.Controls.Add(this.chkRunReport);
            this.wpComplete.FinishText = "Quá trình trích xuất báo cáo thông kê đã hoàn tất. ";
            this.wpComplete.Name = "wpComplete";
            this.wpComplete.ProceedText = "Để thoát, hãy nhấn [Hoàn tất]";
            this.wpComplete.Size = new System.Drawing.Size(458, 365);
            this.wpComplete.Text = "Quá trình hoàn tất";
            // 
            // chkRunReport
            // 
            this.chkRunReport.Location = new System.Drawing.Point(36, 209);
            this.chkRunReport.Name = "chkRunReport";
            this.chkRunReport.Properties.Caption = "Chạy tập tin báo cáo vừa trích xuất.";
            this.chkRunReport.Size = new System.Drawing.Size(258, 19);
            this.chkRunReport.TabIndex = 0;
            // 
            // wpSelectReportType
            // 
            this.wpSelectReportType.Controls.Add(this.grpcReportType);
            this.wpSelectReportType.Controls.Add(this.grpcReportParams);
            this.wpSelectReportType.DescriptionText = "Trong bước này, bạn hãy chọn 1 trong những cách thức thống kê dưới đây để tiếp tụ" +
                "c";
            this.wpSelectReportType.Name = "wpSelectReportType";
            this.wpSelectReportType.Size = new System.Drawing.Size(643, 353);
            this.wpSelectReportType.Text = "Bước 2 - Chọn cách thức thống kê";
            // 
            // grpcReportType
            // 
            this.grpcReportType.Controls.Add(this.rdgReportType);
            this.grpcReportType.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpcReportType.Location = new System.Drawing.Point(0, 0);
            this.grpcReportType.Name = "grpcReportType";
            this.grpcReportType.Size = new System.Drawing.Size(353, 353);
            this.grpcReportType.TabIndex = 1;
            this.grpcReportType.Text = "Chọn dạng thống kê";
            // 
            // rdgReportType
            // 
            this.rdgReportType.Location = new System.Drawing.Point(33, 25);
            this.rdgReportType.Name = "rdgReportType";
            this.rdgReportType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdgReportType.Properties.Appearance.Options.UseFont = true;
            this.rdgReportType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdgReportType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Tạo biểu đồ thống kê"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tạo chi tiết thống kê")});
            this.rdgReportType.Size = new System.Drawing.Size(191, 153);
            this.rdgReportType.TabIndex = 0;
            this.rdgReportType.SelectedIndexChanged += new System.EventHandler(this.rdgReportType_SelectedIndexChanged);
            // 
            // grpcReportParams
            // 
            this.grpcReportParams.Controls.Add(this.llblSearch);
            this.grpcReportParams.Controls.Add(this.txtParam);
            this.grpcReportParams.Controls.Add(this.lblParam);
            this.grpcReportParams.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpcReportParams.Location = new System.Drawing.Point(352, 0);
            this.grpcReportParams.Name = "grpcReportParams";
            this.grpcReportParams.Size = new System.Drawing.Size(291, 353);
            this.grpcReportParams.TabIndex = 3;
            this.grpcReportParams.Text = "Dữ liệu thống kê";
            // 
            // llblSearch
            // 
            this.llblSearch.AutoSize = true;
            this.llblSearch.Location = new System.Drawing.Point(212, 59);
            this.llblSearch.Name = "llblSearch";
            this.llblSearch.Size = new System.Drawing.Size(35, 13);
            this.llblSearch.TabIndex = 2;
            this.llblSearch.TabStop = true;
            this.llblSearch.Text = "Tìm...";
            this.llblSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSearch_LinkClicked);
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(31, 56);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(174, 20);
            this.txtParam.TabIndex = 1;
            this.txtParam.TextChanged += new System.EventHandler(this.txtParam_TextChanged);
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblParam.Location = new System.Drawing.Point(17, 40);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(33, 13);
            this.lblParam.TabIndex = 0;
            this.lblParam.Text = "ISBN";
            // 
            // wpOutput
            // 
            this.wpOutput.Controls.Add(this.btnBrowse);
            this.wpOutput.Controls.Add(this.txtPath);
            this.wpOutput.Controls.Add(this.labelControl9);
            this.wpOutput.Controls.Add(this.labelControl8);
            this.wpOutput.Controls.Add(this.cbxFileType);
            this.wpOutput.DescriptionText = "Cách thức xuất dữ liệu đầu ra";
            this.wpOutput.Name = "wpOutput";
            this.wpOutput.Size = new System.Drawing.Size(643, 353);
            this.wpOutput.Text = "Bước 3 - Dữ liệu đầu ra";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(463, 100);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Chọn...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(180, 102);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(277, 20);
            this.txtPath.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(65, 78);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(54, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Kiểu tập tin";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(65, 105);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 13);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Tên tập tin";
            // 
            // cbxFileType
            // 
            this.cbxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFileType.FormattingEnabled = true;
            this.cbxFileType.Items.AddRange(new object[] {
            "PDF",
            "XLSX",
            "HTML"});
            this.cbxFileType.Location = new System.Drawing.Point(180, 75);
            this.cbxFileType.Name = "cbxFileType";
            this.cbxFileType.Size = new System.Drawing.Size(121, 21);
            this.cbxFileType.TabIndex = 1;
            this.cbxFileType.SelectedIndexChanged += new System.EventHandler(this.cbxFileType_SelectedIndexChanged);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "pdf";
            this.dlgSaveFile.Filter = "Portable Document Format|*.pdf|Microsoft Excel 2007|*.xlsx|Hyper Text Markup Lang" +
                "uage|*.HTML";
            this.dlgSaveFile.Title = "Chọn nơi lưu tập tin";
            // 
            // psExporter
            // 
            this.psExporter.Links.AddRange(new object[] {
            this.pcLink,
            this.pcLinkChart,
            this.cpLink});
            // 
            // pcLink
            // 
            this.pcLink.Component = this.grcctlResult;
            // 
            // 
            // 
            this.pcLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("pcLink.ImageCollection.ImageStream")));
            this.pcLink.ImageCollection.Images.SetKeyName(0, "logo_fpt_university.jpg");
            this.pcLink.Margins = new System.Drawing.Printing.Margins(100, 100, 99, 100);
            this.pcLink.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                "Hệ thống quản lý thư viện",
                "[Image 0]",
                "FU-HCM"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128))), DevExpress.XtraPrinting.BrickAlignment.Near), new DevExpress.XtraPrinting.PageFooterArea(new string[] {
                "",
                "Trang [Page #]",
                "[Date Printed]"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128))), DevExpress.XtraPrinting.BrickAlignment.Near));
            this.pcLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.pcLink.PrintingSystem = this.psExporter;
            this.pcLink.PrintingSystemBase = this.psExporter;
            this.pcLink.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.pcLink_CreateReportHeaderArea);
            // 
            // pcLinkChart
            // 
            // 
            // 
            // 
            this.pcLinkChart.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("pcLinkChart.ImageCollection.ImageStream")));
            this.pcLinkChart.ImageCollection.Images.SetKeyName(0, "logo_fpt_university.jpg");
            this.pcLinkChart.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                "Hệ thống quản lý thư viện",
                "[Image 0]",
                "FU-HCM"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128))), DevExpress.XtraPrinting.BrickAlignment.Near), new DevExpress.XtraPrinting.PageFooterArea(new string[] {
                "",
                "Trang [Page #]",
                "[Date Printed]"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128))), DevExpress.XtraPrinting.BrickAlignment.Near));
            this.pcLinkChart.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.pcLinkChart.PrintingSystem = this.psExporter;
            this.pcLinkChart.PrintingSystemBase = this.psExporter;
            // 
            // cpLink
            // 
            this.cpLink.BreakSpace = 50;
            // 
            // 
            // 
            this.cpLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("cpLink.ImageCollection.ImageStream")));
            this.cpLink.ImageCollection.Images.SetKeyName(0, "logo_fpt_university.jpg");
            this.cpLink.Links.AddRange(new object[] {
            this.pcLinkChart,
            this.pcLink});
            this.cpLink.Margins = new System.Drawing.Printing.Margins(100, 100, 99, 100);
            this.cpLink.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                "Hệ thống quản lý thư viện",
                "[Image 0]",
                "FU-HCM"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128))), DevExpress.XtraPrinting.BrickAlignment.Center), new DevExpress.XtraPrinting.PageFooterArea(new string[] {
                "",
                "Trang [Page #]",
                "[Date Printed]"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128))), DevExpress.XtraPrinting.BrickAlignment.Center));
            this.cpLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.cpLink.PrintingSystem = this.psExporter;
            this.cpLink.PrintingSystemBase = this.psExporter;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 498);
            this.Controls.Add(this.wizReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "The Asphalt World";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "ReportForm";
            this.Text = "Trích xuất thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.wizReport)).EndInit();
            this.wizReport.ResumeLayout(false);
            this.wpWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcctlResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.wpSelectReportTemplate.ResumeLayout(false);
            this.wpSelectReportTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgReportTemplate.Properties)).EndInit();
            this.wpComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkRunReport.Properties)).EndInit();
            this.wpSelectReportType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpcReportType)).EndInit();
            this.grpcReportType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgReportType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcReportParams)).EndInit();
            this.grpcReportParams.ResumeLayout(false);
            this.grpcReportParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParam.Properties)).EndInit();
            this.wpOutput.ResumeLayout(false);
            this.wpOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psExporter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizReport;
        private DevExpress.XtraWizard.WelcomeWizardPage wpWelcome;
        private DevExpress.XtraWizard.WizardPage wpSelectReportTemplate;
        private DevExpress.XtraWizard.WizardPage wpSelectReportType;
        private DevExpress.XtraWizard.CompletionWizardPage wpComplete;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rdgReportTemplate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl grpcReportType;
        private DevExpress.XtraEditors.RadioGroup rdgReportType;
        private DevExpress.XtraEditors.GroupControl grpcReportParams;
        private DevExpress.XtraWizard.WizardPage wpOutput;
        private System.Windows.Forms.ComboBox cbxFileType;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.LinkLabel llblSearch;
        private DevExpress.XtraEditors.TextEdit txtParam;
        private System.Windows.Forms.Label lblParam;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.TextEdit txtPath;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl grcctlResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraPrinting.PrintingSystem psExporter;
        private DevExpress.XtraPrinting.PrintableComponentLink pcLink;
        private DevExpress.XtraPrinting.PrintableComponentLink pcLinkChart;
        private DevExpress.XtraPrintingLinks.CompositeLink cpLink;
        private DevExpress.XtraEditors.CheckEdit chkRunReport;
    }
}