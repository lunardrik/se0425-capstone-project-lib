using System;

namespace LIB
{
    partial class EditCatalogueForm
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
            this.dlgImage = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.llbDetailedCopy = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pedCatalogueImage = new DevExpress.XtraEditors.PictureEdit();
            this.txtAvailableCopy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rtfShortDescription = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAuthor = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoveAuthor = new DevExpress.XtraEditors.SimpleButton();
            this.lstAuthor = new DevExpress.XtraEditors.ListBoxControl();
            this.authorDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.categoryDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbPublisher = new System.Windows.Forms.ComboBox();
            this.publisherDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtLanguage = new System.Windows.Forms.ComboBox();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtISBN = new DevExpress.XtraEditors.TextEdit();
            this.txtNumberOfCopy = new DevExpress.XtraEditors.SpinEdit();
            this.txtExpandDateLimit = new DevExpress.XtraEditors.SpinEdit();
            this.txtExpandLimit = new DevExpress.XtraEditors.SpinEdit();
            this.txtPrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtYear = new DevExpress.XtraEditors.SpinEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pedCatalogueImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfCopy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpandDateLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpandLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-1, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng bản sao:";
            // 
            // llbDetailedCopy
            // 
            this.llbDetailedCopy.AutoSize = true;
            this.llbDetailedCopy.Location = new System.Drawing.Point(116, 212);
            this.llbDetailedCopy.Name = "llbDetailedCopy";
            this.llbDetailedCopy.Size = new System.Drawing.Size(133, 13);
            this.llbDetailedCopy.TabIndex = 2;
            this.llbDetailedCopy.TabStop = true;
            this.llbDetailedCopy.Text = "Danh sách bản sao chi tiết";
            this.llbDetailedCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDetailedCopy_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tựa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(261, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tác giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(40, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngôn ngữ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(27, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Năm:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(27, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Thuộc danh mục:";
            // 
            // pedCatalogueImage
            // 
            this.pedCatalogueImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pedCatalogueImage.Location = new System.Drawing.Point(481, 26);
            this.pedCatalogueImage.Name = "pedCatalogueImage";
            this.pedCatalogueImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pedCatalogueImage.Size = new System.Drawing.Size(166, 204);
            this.pedCatalogueImage.TabIndex = 15;
            // 
            // txtAvailableCopy
            // 
            this.txtAvailableCopy.Location = new System.Drawing.Point(210, 188);
            this.txtAvailableCopy.Name = "txtAvailableCopy";
            this.txtAvailableCopy.ReadOnly = true;
            this.txtAvailableCopy.Size = new System.Drawing.Size(39, 21);
            this.txtAvailableCopy.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(148, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Khả dụng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(15, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Số lần gia hạn cho phép:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(216, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Trong vòng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(14, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Miêu tả chi tiết";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(364, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "ngày";
            // 
            // rtfShortDescription
            // 
            this.rtfShortDescription.Location = new System.Drawing.Point(17, 272);
            this.rtfShortDescription.Name = "rtfShortDescription";
            this.rtfShortDescription.Size = new System.Drawing.Size(630, 78);
            this.rtfShortDescription.TabIndex = 29;
            this.rtfShortDescription.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(129, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Giá:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(572, 233);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 32;
            this.btnBrowse.Text = "Tìm hình ảnh";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(317, 164);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthor.TabIndex = 32;
            this.btnAddAuthor.Text = "Thêm TG";
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnRemoveAuthor
            // 
            this.btnRemoveAuthor.Location = new System.Drawing.Point(398, 164);
            this.btnRemoveAuthor.Name = "btnRemoveAuthor";
            this.btnRemoveAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAuthor.TabIndex = 32;
            this.btnRemoveAuthor.Text = "Xóa TG";
            this.btnRemoveAuthor.Click += new System.EventHandler(this.btnRemoveAuthor_Click);
            // 
            // lstAuthor
            // 
            this.lstAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorDTOBindingSource, "AuthorName", true));
            this.lstAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.authorDTOBindingSource, "AuthorId", true));
            this.lstAuthor.Location = new System.Drawing.Point(317, 29);
            this.lstAuthor.Name = "lstAuthor";
            this.lstAuthor.Size = new System.Drawing.Size(158, 129);
            this.lstAuthor.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lstAuthor.TabIndex = 33;
            // 
            // authorDTOBindingSource
            // 
            this.authorDTOBindingSource.DataSource = typeof(LIB.AuthorDTO);
            // 
            // cbbCategory
            // 
            this.cbbCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryDTOBindingSource, "CategoryName", true));
            this.cbbCategory.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.categoryDTOBindingSource, "CategoryId", true));
            this.cbbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryDTOBindingSource, "CategoryId", true));
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(128, 105);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbbCategory.TabIndex = 35;
            // 
            // categoryDTOBindingSource
            // 
            this.categoryDTOBindingSource.DataSource = typeof(LIB.CategoryDTO);
            // 
            // cbbPublisher
            // 
            this.cbbPublisher.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.publisherDTOBindingSource, "PublisherId", true));
            this.cbbPublisher.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherDTOBindingSource, "PublisherName", true));
            this.cbbPublisher.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.publisherDTOBindingSource, "PublisherId", true));
            this.cbbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPublisher.FormattingEnabled = true;
            this.cbbPublisher.Location = new System.Drawing.Point(128, 80);
            this.cbbPublisher.Name = "cbbPublisher";
            this.cbbPublisher.Size = new System.Drawing.Size(121, 21);
            this.cbbPublisher.TabIndex = 36;
            // 
            // publisherDTOBindingSource
            // 
            this.publisherDTOBindingSource.DataSource = typeof(LIB.PublisherDTO);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnHelp);
            this.groupControl1.Controls.Add(this.txtLanguage);
            this.groupControl1.Controls.Add(this.txtTitle);
            this.groupControl1.Controls.Add(this.txtISBN);
            this.groupControl1.Controls.Add(this.txtNumberOfCopy);
            this.groupControl1.Controls.Add(this.txtExpandDateLimit);
            this.groupControl1.Controls.Add(this.txtExpandLimit);
            this.groupControl1.Controls.Add(this.txtPrice);
            this.groupControl1.Controls.Add(this.txtYear);
            this.groupControl1.Controls.Add(this.cbbPublisher);
            this.groupControl1.Controls.Add(this.cbbCategory);
            this.groupControl1.Controls.Add(this.lstAuthor);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnRemoveAuthor);
            this.groupControl1.Controls.Add(this.btnAddAuthor);
            this.groupControl1.Controls.Add(this.btnBrowse);
            this.groupControl1.Controls.Add(this.label13);
            this.groupControl1.Controls.Add(this.rtfShortDescription);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txtAvailableCopy);
            this.groupControl1.Controls.Add(this.pedCatalogueImage);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.llbDetailedCopy);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(659, 389);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin sách";
            // 
            // txtLanguage
            // 
            this.txtLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLanguage.FormattingEnabled = true;
            this.txtLanguage.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Hàn",
            "Tiếng Nga",
            "Tiếng Nhật",
            "Tiếng Pháp",
            "Tiếng TBN",
            "Tiếng Trung",
            "Tiếng Việt",
            "Ngôn ngữ khác"});
            this.txtLanguage.Location = new System.Drawing.Point(128, 159);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(121, 21);
            this.txtLanguage.TabIndex = 42;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(66, 52);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.Mask.EditMask = "N";
            this.txtTitle.Properties.MaxLength = 100;
            this.txtTitle.Size = new System.Drawing.Size(183, 20);
            this.txtTitle.TabIndex = 41;
            this.txtTitle.Leave += new System.EventHandler(this.txtISBN_Leave);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(66, 26);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Properties.Mask.EditMask = "N";
            this.txtISBN.Properties.MaxLength = 13;
            this.txtISBN.Properties.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(183, 20);
            this.txtISBN.TabIndex = 41;
            this.txtISBN.Leave += new System.EventHandler(this.txtISBN_Leave);
            // 
            // txtNumberOfCopy
            // 
            this.txtNumberOfCopy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNumberOfCopy.Location = new System.Drawing.Point(102, 188);
            this.txtNumberOfCopy.Name = "txtNumberOfCopy";
            this.txtNumberOfCopy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtNumberOfCopy.Properties.IsFloatValue = false;
            this.txtNumberOfCopy.Properties.Mask.EditMask = "\\d+";
            this.txtNumberOfCopy.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumberOfCopy.Properties.MaxValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txtNumberOfCopy.Properties.ReadOnly = true;
            this.txtNumberOfCopy.Size = new System.Drawing.Size(46, 20);
            this.txtNumberOfCopy.TabIndex = 39;
            // 
            // txtExpandDateLimit
            // 
            this.txtExpandDateLimit.EditValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txtExpandDateLimit.Location = new System.Drawing.Point(292, 230);
            this.txtExpandDateLimit.Name = "txtExpandDateLimit";
            this.txtExpandDateLimit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtExpandDateLimit.Properties.IsFloatValue = false;
            this.txtExpandDateLimit.Properties.Mask.EditMask = "\\d+";
            this.txtExpandDateLimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtExpandDateLimit.Properties.MaxValue = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.txtExpandDateLimit.Properties.MinValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txtExpandDateLimit.Size = new System.Drawing.Size(66, 20);
            this.txtExpandDateLimit.TabIndex = 40;
            // 
            // txtExpandLimit
            // 
            this.txtExpandLimit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtExpandLimit.Location = new System.Drawing.Point(164, 230);
            this.txtExpandLimit.Name = "txtExpandLimit";
            this.txtExpandLimit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtExpandLimit.Properties.IsFloatValue = false;
            this.txtExpandLimit.Properties.Mask.EditMask = "\\d+";
            this.txtExpandLimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtExpandLimit.Properties.MaxValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txtExpandLimit.Size = new System.Drawing.Size(46, 20);
            this.txtExpandLimit.TabIndex = 39;
            // 
            // txtPrice
            // 
            this.txtPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrice.Location = new System.Drawing.Point(164, 133);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPrice.Properties.Mask.EditMask = "\\d+";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPrice.Size = new System.Drawing.Size(85, 20);
            this.txtPrice.TabIndex = 38;
            // 
            // txtYear
            // 
            this.txtYear.EditValue = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.txtYear.Location = new System.Drawing.Point(60, 134);
            this.txtYear.Name = "txtYear";
            this.txtYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtYear.Properties.IsFloatValue = false;
            this.txtYear.Properties.Mask.EditMask = "\\d+";
            this.txtYear.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtYear.Properties.MaxLength = 4;
            this.txtYear.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtYear.Properties.MinValue = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.txtYear.Size = new System.Drawing.Size(63, 20);
            this.txtYear.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = global::LIB.Properties.Resources.question1;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(620, 351);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(27, 28);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // EditCatalogueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 389);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCatalogueForm";
            this.Text = "Chỉnh sửa đầu mục";
            ((System.ComponentModel.ISupportInitialize)(this.pedCatalogueImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfCopy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpandDateLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpandLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgImage;
        private System.Windows.Forms.BindingSource categoryDTOBindingSource;
        private System.Windows.Forms.BindingSource publisherDTOBindingSource;
        private System.Windows.Forms.BindingSource authorDTOBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbDetailedCopy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.PictureEdit pedCatalogueImage;
        private System.Windows.Forms.TextBox txtAvailableCopy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtfShortDescription;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.SimpleButton btnAddAuthor;
        private DevExpress.XtraEditors.SimpleButton btnRemoveAuthor;
        private DevExpress.XtraEditors.ListBoxControl lstAuthor;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.ComboBox cbbPublisher;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SpinEdit txtExpandDateLimit;
        private DevExpress.XtraEditors.SpinEdit txtExpandLimit;
        private DevExpress.XtraEditors.SpinEdit txtPrice;
        private DevExpress.XtraEditors.SpinEdit txtYear;
        private DevExpress.XtraEditors.TextEdit txtISBN;
        private System.Windows.Forms.ComboBox txtLanguage;
        private DevExpress.XtraEditors.SpinEdit txtNumberOfCopy;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private System.Windows.Forms.PictureBox btnHelp;
    }
}