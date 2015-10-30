namespace LIB
{
    partial class AuthorManagementForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtInfomation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAuthor = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdAuthor = new DevExpress.XtraGrid.GridControl();
            this.authorDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvAuthor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAuthorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.txtInfomation);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(792, 79);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(464, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInfomation
            // 
            this.txtInfomation.Location = new System.Drawing.Point(160, 24);
            this.txtInfomation.Name = "txtInfomation";
            this.txtInfomation.Size = new System.Drawing.Size(298, 21);
            this.txtInfomation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tác giả";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnHelp);
            this.panelControl2.Controls.Add(this.btnDelete);
            this.panelControl2.Controls.Add(this.btnAddAuthor);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.txtAuthorId);
            this.panelControl2.Controls.Add(this.txtAuthorName);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(489, 79);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(303, 340);
            this.panelControl2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa tác giả";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(63, 82);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(96, 23);
            this.btnAddAuthor.TabIndex = 7;
            this.btnAddAuthor.Text = "Thêm tác giả mới";
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(63, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(79, 17);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.ReadOnly = true;
            this.txtAuthorId.Size = new System.Drawing.Size(199, 21);
            this.txtAuthorId.TabIndex = 3;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(79, 51);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(199, 21);
            this.txtAuthorName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã tác giả";
            // 
            // grdAuthor
            // 
            this.grdAuthor.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.grdAuthor.DataSource = this.authorDTOBindingSource;
            this.grdAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAuthor.Location = new System.Drawing.Point(0, 79);
            this.grdAuthor.MainView = this.grvAuthor;
            this.grdAuthor.Name = "grdAuthor";
            this.grdAuthor.Size = new System.Drawing.Size(489, 340);
            this.grdAuthor.TabIndex = 2;
            this.grdAuthor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvAuthor});
            // 
            // authorDTOBindingSource
            // 
            this.authorDTOBindingSource.DataSource = typeof(LIB.AuthorDTO);
            // 
            // grvAuthor
            // 
            this.grvAuthor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuthorId,
            this.colAuthorName});
            this.grvAuthor.GridControl = this.grdAuthor;
            this.grvAuthor.Name = "grvAuthor";
            this.grvAuthor.OptionsBehavior.Editable = false;
            this.grvAuthor.OptionsView.ShowGroupPanel = false;
            this.grvAuthor.Click += new System.EventHandler(this.grvAuthor_Click);
            // 
            // colAuthorId
            // 
            this.colAuthorId.Caption = "Mã tác giả";
            this.colAuthorId.FieldName = "AuthorId";
            this.colAuthorId.Name = "colAuthorId";
            this.colAuthorId.Visible = true;
            this.colAuthorId.VisibleIndex = 0;
            // 
            // colAuthorName
            // 
            this.colAuthorName.Caption = "Tên tác giả";
            this.colAuthorName.FieldName = "AuthorName";
            this.colAuthorName.Name = "colAuthorName";
            this.colAuthorName.Visible = true;
            this.colAuthorName.VisibleIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = global::LIB.Properties.Resources.question1;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(264, 300);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(27, 28);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // AuthorManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 419);
            this.Controls.Add(this.grdAuthor);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "AuthorManagementForm";
            this.Text = "Quản lý tác giả";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grdAuthor;
        private DevExpress.XtraGrid.Views.Grid.GridView grvAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.TextBox txtInfomation;
        private DevExpress.XtraEditors.SimpleButton btnAddAuthor;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.TextBox txtAuthorName;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.BindingSource authorDTOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorId;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorName;
        private System.Windows.Forms.PictureBox btnHelp;
    }
}