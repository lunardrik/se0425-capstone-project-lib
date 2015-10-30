namespace LIB
{
    partial class NewRentalForm
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dteDueDate = new System.Windows.Forms.DateTimePicker();
            this.dteIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lblSearchBarcode = new System.Windows.Forms.Label();
            this.lblSearchUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(48, 109);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 13);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "Hạn trả";
            // 
            // dteDueDate
            // 
            this.dteDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDueDate.Location = new System.Drawing.Point(94, 103);
            this.dteDueDate.Name = "dteDueDate";
            this.dteDueDate.Size = new System.Drawing.Size(131, 20);
            this.dteDueDate.TabIndex = 39;
            // 
            // dteIssuedDate
            // 
            this.dteIssuedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteIssuedDate.Location = new System.Drawing.Point(94, 70);
            this.dteIssuedDate.Name = "dteIssuedDate";
            this.dteIssuedDate.Size = new System.Drawing.Size(131, 20);
            this.dteIssuedDate.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(69, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Ghi mượn";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(94, 18);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(131, 20);
            this.txtUser.TabIndex = 34;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(94, 44);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(131, 20);
            this.txtBarcode.TabIndex = 32;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(45, 47);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 13);
            this.labelControl8.TabIndex = 31;
            this.labelControl8.Text = "Mã sách";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(29, 76);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(55, 13);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "Ngày mượn";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(33, 21);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(51, 13);
            this.labelControl11.TabIndex = 28;
            this.labelControl11.Text = "Mã đọc giả";
            // 
            // lblSearchBarcode
            // 
            this.lblSearchBarcode.AutoSize = true;
            this.lblSearchBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearchBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBarcode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearchBarcode.Location = new System.Drawing.Point(231, 47);
            this.lblSearchBarcode.Name = "lblSearchBarcode";
            this.lblSearchBarcode.Size = new System.Drawing.Size(24, 13);
            this.lblSearchBarcode.TabIndex = 42;
            this.lblSearchBarcode.Text = "Tìm";
            this.lblSearchBarcode.Click += new System.EventHandler(this.LblSearchBarcodeClick);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearchUser.Location = new System.Drawing.Point(231, 21);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(24, 13);
            this.lblSearchUser.TabIndex = 43;
            this.lblSearchUser.Text = "Tìm";
            this.lblSearchUser.Click += new System.EventHandler(this.LblSearchUserClick);
            // 
            // NewRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 180);
            this.Controls.Add(this.lblSearchUser);
            this.Controls.Add(this.lblSearchBarcode);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dteDueDate);
            this.Controls.Add(this.dteIssuedDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewRentalForm";
            this.Text = "Ghi mượn";
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DateTimePicker dteDueDate;
        private System.Windows.Forms.DateTimePicker dteIssuedDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.Label lblSearchBarcode;
        private System.Windows.Forms.Label lblSearchUser;

    }
}

