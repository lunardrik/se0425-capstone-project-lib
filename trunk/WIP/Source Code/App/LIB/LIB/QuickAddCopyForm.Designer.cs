namespace LIB
{
    partial class QuickAddCopyForm
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
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnGen = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.grctrlBarcode = new DevExpress.XtraGrid.GridControl();
            this.grvBarcode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrlBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(316, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bạn muốn thêm bao nhiêu cuốn sách vào đầu sách này ?";
            // 
            // txtNumber
            // 
            this.txtNumber.EditValue = "0";
            this.txtNumber.Location = new System.Drawing.Point(12, 48);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.Mask.EditMask = "\\d+";
            this.txtNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumber.Size = new System.Drawing.Size(231, 20);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.EditValueChanged += new System.EventHandler(this.txtNumber_EditValueChanged);
            // 
            // btnGen
            // 
            this.btnGen.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGen.Appearance.Options.UseFont = true;
            this.btnGen.Location = new System.Drawing.Point(249, 45);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(83, 23);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "Tạo ĐKCB";
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(177, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grctrlBarcode
            // 
            this.grctrlBarcode.Location = new System.Drawing.Point(13, 102);
            this.grctrlBarcode.MainView = this.grvBarcode;
            this.grctrlBarcode.Name = "grctrlBarcode";
            this.grctrlBarcode.Size = new System.Drawing.Size(319, 132);
            this.grctrlBarcode.TabIndex = 3;
            this.grctrlBarcode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBarcode});
            // 
            // grvBarcode
            // 
            this.grvBarcode.GridControl = this.grctrlBarcode;
            this.grvBarcode.Name = "grvBarcode";
            this.grvBarcode.OptionsView.ShowColumnHeaders = false;
            this.grvBarcode.OptionsView.ShowGroupPanel = false;
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(88, 240);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Đồng ý";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(178, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Danh sách ĐKCB sẽ được tạo ra:";
            // 
            // QuickAddCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 276);
            this.Controls.Add(this.grctrlBarcode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuickAddCopyForm";
            this.Text = "Thêm bản sao";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrlBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.SimpleButton btnGen;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.GridControl grctrlBarcode;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBarcode;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}