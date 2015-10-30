using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace LIB
{
    public partial class EditCatalogueForm : DevExpress.XtraEditors.XtraForm
    {
        private BookInfoForm _parents;
        private CatalogueDTO _catalogue;
        private List<AuthorDTO> _author = new List<AuthorDTO>();
        private List<AuthorDTO> _selectedAuthor = new List<AuthorDTO>();
        private List<PublisherDTO> _publisher = new List<PublisherDTO>();
        private List<CategoryDTO> _category = new List<CategoryDTO>();
        private List<CategoryDTO> _disCategory = new List<CategoryDTO>();
        public AuthorDTO ReturnAuthor;
        private string _oldFileName = "";
        private bool _isEdit = false;

        public EditCatalogueForm(BookInfoForm parent)
        {
            InitializeComponent();

            this.Text = "Thêm đầu sách mới";
            // set Parent
            _parents = parent;

            // Allow Edit on Create new Catalogue
            txtISBN.Properties.ReadOnly = false;
            txtNumberOfCopy.Properties.ReadOnly = false;
            llbDetailedCopy.Enabled = false;

            // Move to config
            //pedCatalogueImage.Image = Image.FromFile(Options.ImageFolder + Options.NotAvaiable);
            txtNumberOfCopy.Text = "0";
            txtAvailableCopy.Text = "0";
            txtLanguage.Text="Tiếng Việt";

            // Load All Data
            LoadAllAuthor();
            LoadAllCategory();
            LoadAllPublisher();

        }

        public EditCatalogueForm(BookInfoForm parent, String isbn)
        {
            InitializeComponent();

            this.Text = "Chỉnh sửa đầu sách [" + isbn + "]";
            _parents = parent;
            CatalogueBUS catalogueBus = new CatalogueBUS();
            _catalogue = catalogueBus.GetCatalogueById(isbn);
            LoadAllAuthor();
            LoadAllCategory();
            LoadAllPublisher();
            LoadInfo(_catalogue);
            _isEdit = true;

            if (_catalogue.NumberOfCopies == -1)
            {
                SetReadOnly(true);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string _tmp = dlgImage.FileName;
            dlgImage.ShowDialog();

            if (dlgImage.FileName.Equals(""))
            {
                dlgImage.FileName = _tmp;
            }
            else
            {
                if (!dlgImage.FileName.Equals(_oldFileName))
                {
                    pedCatalogueImage.Image = Image.FromFile(dlgImage.FileName);
                }
            }
        }

        private void LoadInfo(CatalogueDTO catalogueDto)
        {
            txtISBN.Text = catalogueDto.ISBN;
            txtTitle.Text = catalogueDto.Title;
            //txtPublisher.Text = catalogueDto.Publisher.PublisherName;
            txtYear.Text = catalogueDto.Year.ToString();
            txtPrice.Text = catalogueDto.Price.ToString();
            txtLanguage.Text = catalogueDto.Language;
            txtNumberOfCopy.Text = catalogueDto.NumberOfCopies.ToString();
            txtAvailableCopy.Text = catalogueDto.AvailableCopies.ToString();
            txtExpandLimit.Text = catalogueDto.ExpandLimit.ToString();
            txtExpandDateLimit.Text = catalogueDto.ExpandDateLimit.ToString();
            rtfShortDescription.Text = catalogueDto.ShortDescription;
            /*Thieu select tac gia*/
            pedCatalogueImage.Image = catalogueDto.Img;
            dlgImage.FileName = catalogueDto.Image;
            _oldFileName = catalogueDto.Image;

            //Category
            for (int i = 0; i < cbbCategory.Items.Count; i++)
            {
                if (((CategoryDTO)cbbCategory.Items[i]).CategoryId == _catalogue.Category.CategoryId)
                {
                    cbbCategory.SelectedIndex = i;
                    break;
                }
            }

            //Publisher
            for (int i = 0; i < cbbPublisher.Items.Count; i++)
            {
                if (((PublisherDTO)cbbPublisher.Items[i]).PublisherId == _catalogue.Publisher.PublisherId)
                {
                    cbbPublisher.SelectedIndex = i;
                    break;
                }
            }

        }

        private void SetReadOnly(bool state)
        {
            txtAvailableCopy.ReadOnly = state;
            txtExpandDateLimit.Properties.ReadOnly = state;
            txtExpandLimit.Properties.ReadOnly = state;
            //txtISBN.Properties.ReadOnly = state;
            txtLanguage.Enabled = state;
            txtNumberOfCopy.Properties.ReadOnly = state;
            txtPrice.Properties.ReadOnly = state;
            txtTitle.Properties.ReadOnly = state;
            txtYear.Properties.ReadOnly = state;
            lstAuthor.Enabled = !state;
            btnAddAuthor.Enabled = !state;
            btnRemoveAuthor.Enabled = !state;
            btnBrowse.Enabled = !state;
            if(state == true)
            {
                btnSave.Text = "Kích hoạt lại";
            }
            else
            {
                btnSave.Text = "Lưu lại";
            }
        }

        private void SaveInfo(CatalogueDTO catalogueDTO)
        {
            CatalogueBUS bus = new CatalogueBUS();

            if (_isEdit)
            {
                if (bus.UpdateCatalogue(catalogueDTO, null) == 1)
                {
                    MessageBox.Show("Cập nhật dữ liệu Đầu mục thành công !!!");
                    _parents.Saved = true;
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu Đầu mục thất bại !!!");
                }
            }
            else
            {
                if (bus.InsertCatalogue(catalogueDTO, null) == 1)
                {
                    MessageBox.Show("Thêm Đầu mục thành công !!!");
                    _parents.Saved = true;
                }
                else
                {
                    MessageBox.Show("Thêm Đầu mục thất bại !!!");
                }
            }
        }

        private void LoadAllAuthor()
        {
            AuthorBUS bus = new AuthorBUS();
            _author = bus.GetAllAuthor();

            if (_catalogue != null)
                foreach (AuthorOfBookDTO authorDto in _catalogue.AuthorList)
                {
                    //_selectedAuthor.Add(authorDto.Author);
                    var au = _author.Find(a => a.AuthorId == authorDto.Author.AuthorId);
                    _author.Remove(au);
                    _selectedAuthor.Add(au);
                }

            lstAuthor.DataSource = _selectedAuthor;
        }

        private void LoadAllCategory()
        {
            CategoryBUS bus = new CategoryBUS();
            _category = bus.GetAllCatagory();
            _disCategory = _category.Select(item => (CategoryDTO)item.Clone()).ToList();

            foreach (CategoryDTO categoryDTO in _disCategory)
            {
                for (int i = 0; i < categoryDTO.CategoryId.Split('.').Length - 1; i++)
                {
                    categoryDTO.CategoryName = "|--" + categoryDTO.CategoryName;
                }
            }
            cbbCategory.DataSource = _disCategory;
        }

        private void LoadAllPublisher()
        {
            PublisherBUS bus = new PublisherBUS();
            _publisher = bus.GetAllPublisher();
            cbbPublisher.DataSource = _publisher;
        }

        private void btnRemoveAuthor_Click(object sender, EventArgs e)
        {
            var author = (AuthorDTO) lstAuthor.SelectedItem;

            //lstAuthor.Items.RemoveAt(lstAuthor.SelectedIndex);
            _selectedAuthor.Remove(author);
            _author.Add(author);
            lstAuthor.Refresh();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            ReturnAuthor = null;
            SelectAuthorForm selectAuthorForm = new SelectAuthorForm(this, _author);
            selectAuthorForm.ShowDialog();

            if (ReturnAuthor != null)
            {
                var au = _author.Find(a => a.AuthorId == ReturnAuthor.AuthorId);
                _author.Remove(au);
                _selectedAuthor.Add(au);

                lstAuthor.Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _parents.Saved = false;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Lưu lại")
            {
                if (txtISBN.Text != "")
                {
                    var rs = MessageBox.Show("Bạn có chắc chắn muốn lưu thông tin của đầu sách này không?", "",
                                             MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        List<AuthorOfBookDTO> lst = new List<AuthorOfBookDTO>();
                        foreach (var authorDTO in _selectedAuthor)
                        {
                            lst.Add(new AuthorOfBookDTO()
                                        {
                                            Author = authorDTO,
                                            ISBN = _isEdit ? _catalogue.ISBN : txtISBN.Text,
                                            CreatedDate = DateTime.Now,
                                            UpdatedDate = DateTime.Now
                                        });
                        }
                        CatalogueDTO catalogueDTO = new CatalogueDTO
                                                        {
                                                            ISBN = _isEdit ? _catalogue.ISBN : txtISBN.Text,
                                                            Title = txtTitle.Text,
                                                            Publisher = (PublisherDTO) cbbPublisher.SelectedValue,
                                                            Category = _category[cbbCategory.SelectedIndex],
                                                            Year = int.Parse(txtYear.Text),
                                                            Price = float.Parse(txtPrice.Text),
                                                            Language = txtLanguage.Text,
                                                            ExpandLimit = int.Parse(txtExpandLimit.Text),
                                                            ExpandDateLimit = int.Parse(txtExpandDateLimit.Text),
                                                            AuthorList = lst,
                                                            AvailableCopies =
                                                                _isEdit
                                                                    ? _catalogue.AvailableCopies
                                                                    : int.Parse(txtNumberOfCopy.Text),
                                                            NumberOfCopies =
                                                                _isEdit
                                                                    ? _catalogue.NumberOfCopies
                                                                    : int.Parse(txtNumberOfCopy.Text),
                                                            ShortDescription = rtfShortDescription.Text,
                                                            CreatedDate =
                                                                _isEdit ? _catalogue.CreatedDate : DateTime.Now,
                                                            UpdatedDate = DateTime.Now
                                                        };
                        if (dlgImage.FileName == "")
                        {
                            // Move to config
                            catalogueDTO.Image = "";
                        }
                        else
                        {
                            if (!_oldFileName.Equals(dlgImage.FileName))
                            {
                                string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                                Feature.ResizeImage(pedCatalogueImage.Image, 150, 200, true).Save(Options.ImageFolder + fileName, ImageFormat.Jpeg);
                                catalogueDTO.Image = fileName;
                            }
                            else
                            {
                                catalogueDTO.Image = dlgImage.FileName;
                            }
                        }


                        SaveInfo(catalogueDTO);

                        if (!_isEdit && int.Parse(txtNumberOfCopy.Text) != 0)
                        {
                            CopyBUS bus = new CopyBUS();
                            List<string> barcode = Feature.GenerateBarcode(catalogueDTO, int.Parse(txtNumberOfCopy.Text));

                            for (int i = 0; i < barcode.Count; i++)
                            {
                                CopyDTO dto = new CopyDTO()
                                                  {
                                                      Barcode = barcode[i],
                                                      ISBN = catalogueDTO.ISBN,
                                                      Status = (int) CopyStatus.AVAILABLE,
                                                      CreatedDate = DateTime.Now,
                                                      UpdatedDate = DateTime.Now
                                                  };
                                if (bus.InsertCopy(dto) == 0)
                                {
                                    MessageBox.Show("Quá trình thêm bản sao thất bại !!!");
                                }
                            }
                        }

                        _parents.ReturnCatalogue = catalogueDTO;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập vào số ISBN của đầu sách trước!");
                    txtISBN.Focus();
                }
            }
            else
            {
                SetReadOnly(false);
                CatalogueBUS catalogueBus = new CatalogueBUS();
                CatalogueDTO catalogueDTO = catalogueBus.GetCatalogueById(txtISBN.Text);
                catalogueDTO.AvailableCopies = 0;
                catalogueDTO.NumberOfCopies = 0;
                if (catalogueBus.UpdateCatalogue(catalogueDTO, null) == 1)
                {
                    MessageBox.Show("Cập nhật dữ liệu Đầu mục thành công !!!");
                    txtNumberOfCopy.Text = "0";
                    txtNumberOfCopy.Properties.ReadOnly = true;
                    txtAvailableCopy.Text = "0";
                    txtAvailableCopy.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu Đầu mục thất bại !!!");
                }
            }
        }

        private void txtISBN_Leave(object sender, EventArgs e)
        {
            if (!txtISBN.Properties.ReadOnly && txtISBN.Text != "")
            {
                if (txtISBN.Text.Length == 8 || txtISBN.Text.Length == 13)
                {
                    CatalogueBUS bus = new CatalogueBUS();
                    var catalogue = bus.GetCatalogueById(txtISBN.Text);
                    if (catalogue != null)
                    {
                        var rs =
                            MessageBox.Show(
                                "Số ISBN này đã tồn tại trong CSDL, bạn có muốn chỉnh sửa thông tin đầu sách này không?",
                                "", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {
                            EditCatalogueForm form = new EditCatalogueForm(_parents, txtISBN.Text);
                            form.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            txtISBN.Focus();
                            txtISBN.SelectAll();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số ISBN phải có độ dài 8 hoặc 13 số!");
                    txtISBN.Focus();
                }
            }
        }

        private void llbDetailedCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CopyDetailedForm copyDetailedForm = new CopyDetailedForm(txtISBN.Text);
            copyDetailedForm.ShowDialog();

            CatalogueBUS bus = new CatalogueBUS();
            var _tempCatalogue = bus.GetCatalogueById(txtISBN.Text);

            if (_catalogue != null)
            {
                _catalogue.NumberOfCopies = _tempCatalogue.NumberOfCopies;
                _catalogue.AvailableCopies = _tempCatalogue.AvailableCopies;

                txtAvailableCopy.Text = _catalogue.AvailableCopies.ToString();
                txtNumberOfCopy.Text = _catalogue.NumberOfCopies.ToString();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.TopicId, HelpContextMap.CID_THAY_DOI_THONG_TIN_COA_MT_DAU_SACH.ToString());
        }


    }
}