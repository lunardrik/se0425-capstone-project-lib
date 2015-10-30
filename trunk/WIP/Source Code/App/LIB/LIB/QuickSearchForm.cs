using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LIB
{
    public partial class QuickSearchForm : DevExpress.XtraEditors.XtraForm
    {
        public int Type { get; set; }
        public string SearchResult { get; set; }
        public QuickSearchForm()
        {
            InitializeComponent();
            txtInformation.Text = String.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(this.Type==1)
            {
                SearchUserDTO dto=new SearchUserDTO();
                dto.UserName = txtInformation.Text;
                SearchUserBUS bus=new SearchUserBUS();
                grdSimpleInfo.DataSource = bus.SearchSimpleUser(dto);
            }
            else if (this.Type == 2)
            {
                SearchBookDTO dto=new SearchBookDTO();
                dto.Info1 = txtInformation.Text;
                SearchBookBUS bus=new SearchBookBUS();
                grdSimpleInfo.DataSource = bus.SearchBarcode(dto);
            }
            else
            {
                SearchBookDTO dto = new SearchBookDTO();
                dto.Info1 = txtInformation.Text;
                SearchBookBUS bus = new SearchBookBUS();
                grdSimpleInfo.DataSource = bus.SearchCatalogue(dto);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.SearchResult = grdSimpleInfo.SelectedCells[0].Value.ToString();
        }
    }
}