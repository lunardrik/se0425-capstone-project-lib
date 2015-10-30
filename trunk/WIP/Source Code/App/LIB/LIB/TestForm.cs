using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace LIB
{
    public partial class TestForm : DevExpress.XtraEditors.XtraForm
    {
        public TestForm()
        {
            InitializeComponent();
            
            List<TypeACopy> lst = new List<TypeACopy>()
                                      {
                                          new TypeACopy() {TypeName = "Tại thư viện", NoC = 66},
                                          new TypeACopy() {TypeName = "Đã được mượn", NoC = 3},
                                          new TypeACopy() {TypeName = "Đã mất", NoC = 20}
                                      };
            Series serie1 = new Series("Số lượng sách trong thư viện", ViewType.Pie);

            serie1.ArgumentDataMember = "TypeName";
            serie1.ValueDataMembers[0] = "NoC";
            //serie1.LegendPointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
            serie1.LegendPointOptions.PointView = PointView.Argument;
            serie1.PointOptions.ValueNumericOptions.Format = NumericFormat.FixedPoint;
            ((PiePointOptions) serie1.PointOptions).PercentOptions.ValueAsPercent = false;

            ChartControl c = new ChartControl();
            c.Series.Add(serie1);
            c.DataSource = lst;
            c.ExportToImage("D:\\Demo.jpg", ImageFormat.Jpeg);

            GridControl gc = new GridControl();
            DataTable dt = new DataTable();

            SqlDataReader reader =
                LIB.Common.ConnectionManager.GetCommand("ReportOfRentalByUserId", new Dictionary<string, SqlDbType>() { {"@UserId", SqlDbType.NVarChar}},
                                                        new List<object>() {"admin"}).ExecuteReader();
            dt.Load(reader);

            gc.DataSource = dt;
            
            GridView view = new GridView();

            view.GridControl = gc;

            gridControl1.DataSource = dt;

            gridControl1.ExportToPdf("D:\\Demo.pdf");

            //cctlTestChart.Series.Add(serie1);
            //cctlTestChart.DataSource = lst;
        }
    }

    public class TypeACopy
    {
        public string TypeName { get; set; }
        public int NoC { get; set; }
    }
}