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
    public partial class QuickAddCopyForm : DevExpress.XtraEditors.XtraForm
    {
        private CatalogueDTO _catalogue;
        private List<String> _barcodeList;

        public QuickAddCopyForm(CatalogueDTO catalogueDTO)
        {
            InitializeComponent();
            _catalogue = catalogueDTO;
        }

        public QuickAddCopyForm()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            int NoC;
            bool isOK = int.TryParse(txtNumber.Text, out NoC);
            if(isOK && NoC != 0)
            {
                _barcodeList = Feature.GenerateBarcode(_catalogue, NoC);

                grctrlBarcode.DataSource = _barcodeList;
                grctrlBarcode.RefreshDataSource();
            }
        }

        private void txtNumber_EditValueChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                txtNumber.Text = "0";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int NoC;
            bool isOK = int.TryParse(txtNumber.Text, out NoC);
            _barcodeList = Feature.GenerateBarcode(_catalogue, NoC);
            if (isOK && NoC>0)
            {
                foreach (string t in _barcodeList)
                {
                    CopyDTO copyDTO = new CopyDTO
                                          {
                                              Barcode = t,
                                              ISBN = _catalogue.ISBN,
                                              Status = (int) CopyStatus.AVAILABLE,
                                              CreatedDate = DateTime.Now,
                                              UpdatedDate = DateTime.Now
                                          };

                    CopyBUS copyBUS = new CopyBUS();
                    if (copyBUS.InsertCopy(copyDTO) == 0)
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm bản sao !!!");
                    }
                }

                _catalogue.NumberOfCopies += NoC;
                _catalogue.AvailableCopies += NoC;

                CatalogueBUS catalogueBUS = new CatalogueBUS();

                if (catalogueBUS.UpdateCatalogue(_catalogue, null) == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm bản sao !!!");
                }

                Options.CountOfCopy += NoC;
                Options.SaveSystemVariable();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}