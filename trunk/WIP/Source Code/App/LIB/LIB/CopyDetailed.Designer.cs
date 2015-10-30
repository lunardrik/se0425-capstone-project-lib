namespace LIB
{
    partial class CopyDetailedForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtISBN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFilterBarcode = new DevExpress.XtraEditors.TextEdit();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.grdDetailedCopy = new DevExpress.XtraGrid.GridControl();
            this.copyDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvCopyDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeAction = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddBook = new DevExpress.XtraEditors.SimpleButton();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtISBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetailedCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCopyDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(45, 9);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtISBN.Properties.Appearance.Options.UseFont = true;
            this.txtISBN.Properties.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(159, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 355);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Lọc theo số ĐKCB:";
            // 
            // txtFilterBarcode
            // 
            this.txtFilterBarcode.Location = new System.Drawing.Point(117, 352);
            this.txtFilterBarcode.Name = "txtFilterBarcode";
            this.txtFilterBarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtFilterBarcode.Properties.Appearance.Options.UseFont = true;
            this.txtFilterBarcode.Size = new System.Drawing.Size(174, 20);
            this.txtFilterBarcode.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(307, 349);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(81, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // grdDetailedCopy
            // 
            this.grdDetailedCopy.DataSource = this.copyDTOBindingSource;
            this.grdDetailedCopy.Location = new System.Drawing.Point(11, 60);
            this.grdDetailedCopy.MainView = this.grvCopyDetail;
            this.grdDetailedCopy.Name = "grdDetailedCopy";
            this.grdDetailedCopy.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribeAction});
            this.grdDetailedCopy.Size = new System.Drawing.Size(377, 273);
            this.grdDetailedCopy.TabIndex = 5;
            this.grdDetailedCopy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCopyDetail});
            // 
            // copyDTOBindingSource
            // 
            this.copyDTOBindingSource.DataSource = typeof(LIB.CopyDTO);
            // 
            // grvCopyDetail
            // 
            this.grvCopyDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarcode,
            this.colStatusString,
            this.grcAction});
            this.grvCopyDetail.GridControl = this.grdDetailedCopy;
            this.grvCopyDetail.Name = "grvCopyDetail";
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "Số ĐKCB";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.OptionsColumn.AllowEdit = false;
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 0;
            // 
            // colStatusString
            // 
            this.colStatusString.Caption = "Trạng thái";
            this.colStatusString.FieldName = "StatusString";
            this.colStatusString.Name = "colStatusString";
            this.colStatusString.OptionsColumn.AllowEdit = false;
            this.colStatusString.Visible = true;
            this.colStatusString.VisibleIndex = 1;
            // 
            // grcAction
            // 
            this.grcAction.Caption = "Thao tác";
            this.grcAction.ColumnEdit = this.ribeAction;
            this.grcAction.Name = "grcAction";
            this.grcAction.Visible = true;
            this.grcAction.VisibleIndex = 2;
            // 
            // ribeAction
            // 
            this.ribeAction.AutoHeight = false;
            this.ribeAction.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.ribeAction.Name = "ribeAction";
            this.ribeAction.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeAction.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribeAction_ButtonClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Danh sách bản sao chi tiết:";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.Appearance.Options.UseFont = true;
            this.btnAddBook.Location = new System.Drawing.Point(263, 6);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(81, 48);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Thêm sách";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = global::LIB.Properties.Resources.question1;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(361, 26);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(27, 28);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // CopyDetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.grdDetailedCopy);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilterBarcode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CopyDetailedForm";
            this.Text = "Danh sách bản sao chi tiết";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CopyDetailedForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtISBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetailedCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCopyDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtISBN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFilterBarcode;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraGrid.GridControl grdDetailedCopy;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCopyDetail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAddBook;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn grcAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeAction;
        private System.Windows.Forms.BindingSource copyDTOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusString;
        private System.Windows.Forms.PictureBox btnHelp;
    }
}