namespace LIB
{
    partial class SelectAuthorForm
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
            this.txtAuthorName = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lstAuthorResult = new DevExpress.XtraEditors.ListBoxControl();
            this.authorDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAuthorResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên TG:";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(55, 21);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(149, 20);
            this.txtAuthorName.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(210, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(147, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm TG";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstAuthorResult
            // 
            this.lstAuthorResult.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.authorDTOBindingSource, "AuthorId", true));
            this.lstAuthorResult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorDTOBindingSource, "AuthorName", true));
            this.lstAuthorResult.DisplayMember = "AuthorName";
            this.lstAuthorResult.Location = new System.Drawing.Point(4, 57);
            this.lstAuthorResult.Name = "lstAuthorResult";
            this.lstAuthorResult.Size = new System.Drawing.Size(291, 180);
            this.lstAuthorResult.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lstAuthorResult.TabIndex = 4;
            this.lstAuthorResult.ValueMember = "AuthorId";
            // 
            // authorDTOBindingSource
            // 
            this.authorDTOBindingSource.DataSource = typeof(LIB.AuthorDTO);
            // 
            // SelectAuthorForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 273);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstAuthorResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectAuthorForm";
            this.Text = "Chọn tác giả";
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAuthorResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAuthorName;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.ListBoxControl lstAuthorResult;
        private System.Windows.Forms.BindingSource authorDTOBindingSource;

    }
}