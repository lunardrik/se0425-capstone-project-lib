namespace LIB
{
    partial class ExpandRentalForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dteDueDateOld = new System.Windows.Forms.DateTimePicker();
            this.dteIssueDate = new System.Windows.Forms.DateTimePicker();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dteDueDateNew = new System.Windows.Forms.DateTimePicker();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 125);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 78;
            this.labelControl1.Text = "Ngày hết hạn cũ";
            // 
            // dteDueDateOld
            // 
            this.dteDueDateOld.Enabled = false;
            this.dteDueDateOld.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDueDateOld.Location = new System.Drawing.Point(102, 119);
            this.dteDueDateOld.Name = "dteDueDateOld";
            this.dteDueDateOld.Size = new System.Drawing.Size(133, 20);
            this.dteDueDateOld.TabIndex = 76;
            // 
            // dteIssueDate
            // 
            this.dteIssueDate.Enabled = false;
            this.dteIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteIssueDate.Location = new System.Drawing.Point(102, 92);
            this.dteIssueDate.Name = "dteIssueDate";
            this.dteIssueDate.Size = new System.Drawing.Size(133, 20);
            this.dteIssueDate.TabIndex = 75;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(102, 66);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(136, 20);
            this.txtUser.TabIndex = 73;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(102, 40);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(136, 20);
            this.txtTitle.TabIndex = 72;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Enabled = false;
            this.txtBarcode.Location = new System.Drawing.Point(102, 14);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(136, 20);
            this.txtBarcode.TabIndex = 71;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 70;
            this.labelControl2.Text = "Barcode";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 68;
            this.labelControl3.Text = "Ngày nhận sách";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(60, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 67;
            this.labelControl4.Text = "Đọc giả";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(52, 47);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(44, 13);
            this.labelControl12.TabIndex = 66;
            this.labelControl12.Text = "Tựa sách";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(141, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Gia hạn";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dteDueDateNew
            // 
            this.dteDueDateNew.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDueDateNew.Location = new System.Drawing.Point(102, 146);
            this.dteDueDateNew.Name = "dteDueDateNew";
            this.dteDueDateNew.Size = new System.Drawing.Size(133, 20);
            this.dteDueDateNew.TabIndex = 77;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(12, 152);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(84, 13);
            this.labelControl13.TabIndex = 79;
            this.labelControl13.Text = "Ngày hết hạn mới";
            // 
            // ExpandRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 208);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dteDueDateNew);
            this.Controls.Add(this.dteDueDateOld);
            this.Controls.Add(this.dteIssueDate);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExpandRentalForm";
            this.Text = "Gia hạn";
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dteDueDateOld;
        private System.Windows.Forms.DateTimePicker dteIssueDate;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dteDueDateNew;
        private DevExpress.XtraEditors.LabelControl labelControl13;
    }
}