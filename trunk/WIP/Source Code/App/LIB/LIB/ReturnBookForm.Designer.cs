namespace LIB
{
    partial class ReturnBookForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dteReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dteDueDate = new System.Windows.Forms.DateTimePicker();
            this.dteIssueDate = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtOverDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOverDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(79, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Ghi trả";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFine
            // 
            this.txtFine.Enabled = false;
            this.txtFine.Location = new System.Drawing.Point(103, 198);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(135, 20);
            this.txtFine.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tiền phạt";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(30, 150);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(67, 13);
            this.labelControl13.TabIndex = 59;
            this.labelControl13.Text = "Ngày trả sách";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "Ngày hết hạn";
            // 
            // dteReturnDate
            // 
            this.dteReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteReturnDate.Location = new System.Drawing.Point(103, 144);
            this.dteReturnDate.Name = "dteReturnDate";
            this.dteReturnDate.Size = new System.Drawing.Size(133, 20);
            this.dteReturnDate.TabIndex = 57;
            this.dteReturnDate.ValueChanged += new System.EventHandler(this.dteReturnDate_ValueChanged);
            // 
            // dteDueDate
            // 
            this.dteDueDate.Enabled = false;
            this.dteDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDueDate.Location = new System.Drawing.Point(103, 117);
            this.dteDueDate.Name = "dteDueDate";
            this.dteDueDate.Size = new System.Drawing.Size(133, 20);
            this.dteDueDate.TabIndex = 56;
            // 
            // dteIssueDate
            // 
            this.dteIssueDate.Enabled = false;
            this.dteIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteIssueDate.Location = new System.Drawing.Point(103, 90);
            this.dteIssueDate.Name = "dteIssueDate";
            this.dteIssueDate.Size = new System.Drawing.Size(133, 20);
            this.dteIssueDate.TabIndex = 55;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(103, 224);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(135, 21);
            this.cboStatus.TabIndex = 52;
            this.cboStatus.SelectionChangeCommitted += new System.EventHandler(this.cboStatus_SelectionChangeCommitted);
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(103, 64);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(136, 20);
            this.txtUser.TabIndex = 51;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(103, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(136, 20);
            this.txtTitle.TabIndex = 50;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Enabled = false;
            this.txtBarcode.Location = new System.Drawing.Point(103, 12);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(136, 20);
            this.txtBarcode.TabIndex = 49;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "Barcode";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(49, 227);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 13);
            this.labelControl9.TabIndex = 47;
            this.labelControl9.Text = "Tình trạng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "Ngày nhận sách";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(61, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 45;
            this.labelControl4.Text = "Đọc giả";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(53, 41);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(44, 13);
            this.labelControl12.TabIndex = 44;
            this.labelControl12.Text = "Tựa sách";
            // 
            // txtOverDate
            // 
            this.txtOverDate.Enabled = false;
            this.txtOverDate.Location = new System.Drawing.Point(103, 170);
            this.txtOverDate.Name = "txtOverDate";
            this.txtOverDate.Size = new System.Drawing.Size(136, 20);
            this.txtOverDate.TabIndex = 63;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 173);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 13);
            this.labelControl5.TabIndex = 62;
            this.labelControl5.Text = "Số ngày quá hạn";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 297);
            this.Controls.Add(this.txtOverDate);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dteReturnDate);
            this.Controls.Add(this.dteDueDate);
            this.Controls.Add(this.dteIssueDate);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReturnBookForm";
            this.Text = "Ghi trả";
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOverDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dteReturnDate;
        private System.Windows.Forms.DateTimePicker dteDueDate;
        private System.Windows.Forms.DateTimePicker dteIssueDate;
        private System.Windows.Forms.ComboBox cboStatus;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtOverDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;

    }
}

