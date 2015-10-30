using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace LIB
{
    public partial class CopyDetailedForm : DevExpress.XtraEditors.XtraForm
    {
        private List<CopyDTO> _listCopy;
        private String _isbn;
        private CatalogueDTO _catalogue;
        public List<CopyDTO> _copyResult = new List<CopyDTO>();


        public CopyDetailedForm(String isbn)
        {
            InitializeComponent();
            _listCopy = LoadCopy(isbn);
            _isbn = isbn;

            CatalogueBUS bus = new CatalogueBUS();
            _catalogue = bus.GetCatalogueById(_isbn);

            LoadDataToForm();
        }

        public CopyDetailedForm()
        {
            InitializeComponent();
        }

        public List<CopyDTO> LoadCopy(String isbn)
        {
            CopyBUS copyBus = new CopyBUS();
            return copyBus.GetCopyByISBN(isbn).Where(c => c.Status != 3).ToList();
        }

        public void LoadDataToForm()
        {
            txtISBN.Text = _isbn;
            _copyResult.Clear();
            _copyResult.AddRange(_listCopy);
            grdDetailedCopy.DataSource = _copyResult;
            grdDetailedCopy.RefreshDataSource();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            _copyResult.Clear();
            for (int i = 0; i < _listCopy.Count; i++)
            {
                if (_listCopy[i].Barcode.Contains(txtFilterBarcode.Text))
                {
                    _copyResult.Add(_listCopy[i]);
                }
            }
            grdDetailedCopy.DataSource = _copyResult;
            grdDetailedCopy.RefreshDataSource();
        }

        private void ribeAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                
            }
            else
            {
                if (e.Button.Kind == ButtonPredefines.Delete)
                {
                    CopyBUS copyBus = new CopyBUS();
                    CopyDTO dto = (CopyDTO)grvCopyDetail.GetFocusedRow();
                    if (dto.Status == (int)CopyStatus.AVAILABLE)
                    {
                        if (copyBus.DeleteCopy(dto, null) == 1)
                        {
                            _listCopy.Remove(dto);
                            _copyResult.Remove(dto);
                            grdDetailedCopy.RefreshDataSource();

                            _catalogue.NumberOfCopies--;
                            if (dto.Status == (int) CopyStatus.AVAILABLE)
                            {
                                _catalogue.AvailableCopies--;
                            }

                            CatalogueBUS bus = new CatalogueBUS();
                            if (bus.UpdateCatalogue(_catalogue, null) == 0)
                            {
                                MessageBox.Show("Có lỗi trong quá trình xóa bản sao !!!");
                            }
                            MessageBox.Show("Đã xóa bản sao thành công !!!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa bản sao thất bại !!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá bản sao này vì bản sao đã bị xoá hoặc đang được mượn!");
                    }
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            CatalogueBUS catalogueBUS = new CatalogueBUS();
            QuickAddCopyForm quickAddCopyForm = new QuickAddCopyForm(catalogueBUS.GetCatalogueById(_isbn));
            quickAddCopyForm.ShowDialog();

            CatalogueBUS bus = new CatalogueBUS();
            CatalogueDTO _tempDTO = bus.GetCatalogueById(_isbn);

            _catalogue.NumberOfCopies = _tempDTO.NumberOfCopies;
            _catalogue.AvailableCopies = _tempDTO.AvailableCopies;

            _listCopy = LoadCopy(_isbn);
            LoadDataToForm();
        }

        private void CopyDetailedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CatalogueBUS bus = new CatalogueBUS();
            //bus.UpdateCatalogue(_catalogue);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.TopicId, HelpContextMap.CID_THEM_BAN_SAO.ToString());
        }

    }
}