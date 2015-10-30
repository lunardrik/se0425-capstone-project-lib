using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using BorderSide = DevExpress.XtraEditors.Controls.BorderSide;

namespace LIB
{
    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        private string _lastext = "pdf";
        private string _reportHeader = "";

        public ReportForm()
        {
            InitializeComponent();
            dlgSaveFile.FileName = Application.StartupPath + "\\Reports\\Report_" +
                                   DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
            cbxFileType.Text = "PDF";
        }

        private void wizReport_SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
            wizReport.NextText = e.Page == wpOutput ? "Tạo TK" : "&Tiếp tục >";
            wpComplete.AllowCancel = e.Page != wpComplete;
            wpComplete.AllowBack = e.Page != wpComplete;

            if (e.Page == wpSelectReportTemplate)
            {
                e.Page.AllowNext = rdgReportTemplate.SelectedIndex != -1;
            }
            else if (e.Page == wpSelectReportType)
            {
                rdgReportType.Properties.Items.Clear();
                if (rdgReportTemplate.SelectedIndex == 2)
                {
                    this.rdgReportType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[]
                                                                     {
                                                                         new DevExpress.XtraEditors.Controls.
                                                                             RadioGroupItem(0, "Tạo biểu đồ thống kê"),
                                                                         new DevExpress.XtraEditors.Controls.
                                                                             RadioGroupItem(1, "Tạo chi tiết thống kê"),
                                                                         new DevExpress.XtraEditors.Controls.
                                                                             RadioGroupItem(2, "Tạo báo cáo kết hợp")
                                                                     });
                }
                else
                {
                    this.rdgReportType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[]
                                                                     {
                                                                         new DevExpress.XtraEditors.Controls.
                                                                             RadioGroupItem(0, "Tạo biểu đồ thống kê"),
                                                                         new DevExpress.XtraEditors.Controls.
                                                                             RadioGroupItem(1, "Tạo chi tiết thống kê")
                                                                     });
                }

                switch (rdgReportTemplate.SelectedIndex)
                {
                    case 1:
                    case 0:
                        rdgReportType.Properties.Items[0].Enabled = true;
                        rdgReportType.Properties.Items[1].Enabled = false;
                        txtParam.Text = "#";
                        grpcReportParams.Visible = false;
                        break;
                    case 3:
                    case 4:
                        rdgReportType.Properties.Items[0].Enabled = false;
                        rdgReportType.Properties.Items[1].Enabled = true;
                        if (!String.IsNullOrEmpty(txtParam.Text) && txtParam.Text == "#") 
                            txtParam.Text = "";
                        lblParam.Text = rdgReportTemplate.SelectedIndex == 3 ? "Mã ISBN" : "Mã độc giả";
                        grpcReportParams.Visible = true;
                        break;
                    default:
                        rdgReportType.Properties.Items[0].Enabled = true;
                        rdgReportType.Properties.Items[1].Enabled = true;
                        txtParam.Text = "#";
                        grpcReportParams.Visible = false;
                        break;
                }
                e.Page.AllowNext = (rdgReportType.SelectedIndex != -1 && !String.IsNullOrEmpty(txtParam.Text));
            }
            
        }

        private void rdgReportTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            wpSelectReportTemplate.AllowNext = true;
        }

        private void rdgReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            wpSelectReportType.AllowNext = !String.IsNullOrEmpty(txtParam.Text);
        }

        private void txtParam_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtParam.Text))
            {
                wpSelectReportType.AllowNext = rdgReportType.SelectedIndex != -1;
            }
        }

        private void cbxFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dlgSaveFile.DefaultExt = cbxFileType.Text;
            dlgSaveFile.FileName = dlgSaveFile.FileName.Replace("." + _lastext, "." + cbxFileType.Text);
            _lastext = cbxFileType.Text;
            txtPath.Text = dlgSaveFile.FileName;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dlgSaveFile.FilterIndex = cbxFileType.SelectedIndex + 1;
            dlgSaveFile.ShowDialog();

            txtPath.Text = dlgSaveFile.FileName;
            cbxFileType.SelectedIndex = dlgSaveFile.FilterIndex - 1;

        }

        private void llblSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuickSearchForm qsf = new QuickSearchForm();
            qsf.Type = rdgReportTemplate.SelectedIndex == 3 ? 3 : 1;
            if (qsf.ShowDialog() == DialogResult.OK)
            {
                txtParam.Text = qsf.SearchResult;
            }
        }

        private void wizReport_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            Series serie1;
            ChartControl c = new ChartControl();
            c.Size = new Size(500, 400);

            if (e.Page == wpOutput)
            {
                bool isOk = false;
                try
                {
                    new FileInfo(dlgSaveFile.FileName);
                    isOk = true;
                }
                catch // only catch to see if fileName valid or not
                {}

                if (isOk)
                {
                    var path = Path.GetDirectoryName(dlgSaveFile.FileName) ?? "";
                    var filename = Path.GetFileName(dlgSaveFile.FileName) ?? "";
                    var ext = (Path.GetExtension(dlgSaveFile.FileName) ?? "").ToLower();

                    if (!ext.Equals(".pdf") && !ext.Equals(".xlsx") && !ext.Equals(".html"))
                    {
                        MessageBox.Show("Chương trình không hỗ trợ trích xuất dạng tập tin này: " + ext);
                        e.Handled = true;
                    }
                    else
                    {
                        try
                        {
                            if (!Directory.Exists(path) && MessageBox.Show("Thư mục không tồn tại, bạn có muốn tự tạo thư mục này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Directory.CreateDirectory(path);
                            }

                            if (Directory.Exists(path))
                            {
                                ReportBUS bus = new ReportBUS();

                                switch (rdgReportTemplate.SelectedIndex)
                                {
                                    case 0:
                                        serie1 = new Series("", ViewType.Pie);

                                        serie1.ArgumentDataMember = "Name";
                                        serie1.ValueDataMembers[0] = "Value";
                                        serie1.LegendPointOptions.PointView = PointView.Argument;
                                        serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.General;
                                        ((PiePointOptions)serie1.PointOptions).PercentOptions.ValueAsPercent = false;
                                        c.Titles.Add(new ChartTitle()
                                                         {
                                                             Alignment = StringAlignment.Center,
                                                             Text = "Biểu đồ thống kê theo số lượng bản sao trong thư viện",
                                                             WordWrap = true,
                                                             Antialiasing = true
                                                         });
                                        c.Series.Add(serie1);
                                        c.DataSource = bus.ReportOnAvaiableCopies();
                                        this.pcLinkChart.Component = c;
                                        break;
                                    case 1:
                                        serie1 = new Series("", ViewType.Bar);

                                        serie1.ArgumentDataMember = "Name";
                                        serie1.ValueDataMembers[0] = "Value";
                                        serie1.LegendPointOptions.PointView = PointView.Argument;
                                        serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.General;
                                        //((SimplePointOptions)serie1.PointOptions).PercentOptions.ValueAsPercent = false;
                                        c.Titles.Add(new ChartTitle()
                                                         {
                                                             Alignment = StringAlignment.Center,
                                                             Text = "Biểu đồ thống kê số lượng bản sao theo Danh mục",
                                                             WordWrap = true,
                                                             Antialiasing = true
                                                         });
                                        c.Series.Add(serie1);
                                        c.DataSource = bus.ReportOnCategory();
                                        this.pcLinkChart.Component = c;
                                        break;
                                    case 3:
                                        _reportHeader = "Báo cáo chi tiết theo tựa sách có mã số " + txtParam.Text;
                                        grcctlResult.DataSource = bus.ReportOfRentalOnISBN(txtParam.Text);
                                        break;
                                    case 4:
                                        _reportHeader = "Báo cáo chi tiết theo độc giả có mã số " + txtParam.Text;
                                        grcctlResult.DataSource = bus.ReportOfRentalOnUserId(txtParam.Text);
                                        break;
                                    default:
                                        switch (rdgReportType.SelectedIndex)
                                        {
                                            case 0:
                                                serie1 = new Series("", ViewType.Pie);

                                                serie1.ArgumentDataMember = "Name";
                                                serie1.ValueDataMembers[0] = "Value";
                                                serie1.LegendPointOptions.PointView = PointView.Argument;
                                                serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.General;
                                                ((PiePointOptions)serie1.PointOptions).PercentOptions.ValueAsPercent = false;
                                                c.Titles.Add(new ChartTitle()
                                                                 {
                                                                     Alignment = StringAlignment.Center,
                                                                     Text = "Biểu đồ thống kê tỉ lệ sách quá hạn",
                                                                     WordWrap = true,
                                                                     Antialiasing = true
                                                                 });
                                                c.Series.Add(serie1);
                                                c.DataSource = bus.ReportOnPassDueDateChart();
                                                this.pcLinkChart.Component = c;
                                                break;
                                            case 1:
                                                _reportHeader = "Báo cáo chi tiết sách quá hạn";
                                                grcctlResult.DataSource = bus.ReportOnPassDueDateDetail();
                                                break;
                                            case 2:
                                                serie1 = new Series("", ViewType.Pie);

                                                serie1.ArgumentDataMember = "Name";
                                                serie1.ValueDataMembers[0] = "Value";
                                                serie1.LegendPointOptions.PointView = PointView.Argument;
                                                serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.General;
                                                ((PiePointOptions)serie1.PointOptions).PercentOptions.ValueAsPercent = false;
                                                c.Titles.Add(new ChartTitle()
                                                {
                                                    Alignment = StringAlignment.Center,
                                                    Text = "Biểu đồ thống kê tỉ lệ sách quá hạn",
                                                    WordWrap = true,
                                                    Antialiasing = true
                                                });
                                                c.Series.Add(serie1);
                                                c.DataSource = bus.ReportOnPassDueDateChart();
                                                this.pcLinkChart.Component = c;

                                                _reportHeader = "Báo cáo thống kê sách quá hạn";
                                                grcctlResult.DataSource = bus.ReportOnPassDueDateDetail();
                                                break;
                                        }
                                        break;
                                }
                                switch (ext)
                                {
                                    case ".pdf":
                                        switch (rdgReportTemplate.SelectedIndex)
                                        {
                                            case 0:
                                            case 1:
                                                pcLinkChart.CreateDocument();
                                                pcLinkChart.PrintingSystem.ExportToPdf(dlgSaveFile.FileName);
                                                // process to output chart to pdf);
                                                break;
                                            case 3:
                                            case 4:
                                                pcLink.CreateDocument();    
                                                pcLink.PrintingSystem.ExportToPdf(dlgSaveFile.FileName);
                                                // process to output detail to pdf);
                                                break;
                                            default:
                                                switch (rdgReportType.SelectedIndex)
                                                {
                                                    case 0:
                                                        pcLinkChart.CreateDocument();
                                                        pcLinkChart.PrintingSystem.ExportToPdf(dlgSaveFile.FileName);
                                                        // process to output chart to pdf);
                                                        break;
                                                    case 1:
                                                        pcLink.CreateDocument();
                                                        pcLink.PrintingSystem.ExportToPdf(dlgSaveFile.FileName);
                                                        // process to output detail to pdf);
                                                        break;
                                                    case 2:
                                                        cpLink.CreateDocument();
                                                        cpLink.PrintingSystem.ExportToPdf(dlgSaveFile.FileName);
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                    case ".xlsx":
                                        switch (rdgReportTemplate.SelectedIndex)
                                        {
                                            case 0:
                                            case 1:
                                                pcLinkChart.CreateDocument();
                                                pcLinkChart.PrintingSystem.ExportToXlsx(dlgSaveFile.FileName);
                                                // process to output chart to pdf);
                                                break;
                                            case 3:
                                            case 4:
                                                pcLink.CreateDocument();
                                                pcLink.PrintingSystem.ExportToXlsx(dlgSaveFile.FileName);
                                                // process to output detail to pdf);
                                                break;
                                            default:
                                                switch (rdgReportType.SelectedIndex)
                                                {
                                                    case 0:
                                                        pcLinkChart.CreateDocument();
                                                        pcLinkChart.PrintingSystem.ExportToXlsx(dlgSaveFile.FileName);
                                                        // process to output chart to pdf);
                                                        break;
                                                    case 1:
                                                        pcLink.CreateDocument();
                                                        pcLink.PrintingSystem.ExportToXlsx(dlgSaveFile.FileName);
                                                        // process to output detail to pdf);
                                                        break;
                                                    case 2:
                                                        cpLink.CreateDocument();
                                                        cpLink.PrintingSystem.ExportToXlsx(dlgSaveFile.FileName);
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                    case ".html":
                                        switch (rdgReportTemplate.SelectedIndex)
                                        {
                                            case 0:
                                            case 1:
                                                pcLinkChart.CreateDocument();
                                                pcLinkChart.PrintingSystem.ExportToHtml(dlgSaveFile.FileName);
                                                // process to output chart to pdf);
                                                break;
                                            case 3:
                                            case 4:
                                                pcLink.CreateDocument();
                                                pcLink.PrintingSystem.ExportToHtml(dlgSaveFile.FileName);
                                                // process to output detail to pdf);
                                                break;
                                            default:
                                                switch (rdgReportType.SelectedIndex)
                                                {
                                                    case 0:
                                                        pcLinkChart.CreateDocument();
                                                        pcLinkChart.PrintingSystem.ExportToHtml(dlgSaveFile.FileName);
                                                        // process to output chart to pdf);
                                                        break;
                                                    case 1:
                                                        pcLink.CreateDocument();
                                                        pcLink.PrintingSystem.ExportToHtml(dlgSaveFile.FileName);
                                                        // process to output detail to pdf);
                                                        break;
                                                    case 2:
                                                        cpLink.CreateDocument();
                                                        cpLink.PrintingSystem.ExportToHtml(dlgSaveFile.FileName);
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi xảy ra trong quá trình xử lý!");
                            Log.Error("Error at ReportForm - Report", ex);
                            e.Handled = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Đường dẫn không hợp lệ!");
                    e.Handled = true;
                }
            }
        }

        private void wizReport_CancelClick(object sender, CancelEventArgs e)
        {
            this.Close();
        }

        private void wizReport_FinishClick(object sender, CancelEventArgs e)
        {
            if (chkRunReport.Checked)
            {
                System.Diagnostics.Process.Start(dlgSaveFile.FileName);
            }
            this.Close();
        }

        private void pcLink_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 14, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(_reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None);
        }
    }
}