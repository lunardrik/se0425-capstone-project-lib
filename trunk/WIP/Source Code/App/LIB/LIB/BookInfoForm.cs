using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace LIB
{
    public partial class BookInfoForm : DevExpress.XtraEditors.XtraForm
    {
        public CatalogueDTO ReturnCatalogue { get; set; }
        public bool Saved { get; set; }
        List<SearchBookResultDTO> lst = new List<SearchBookResultDTO>();
        private SearchBookDTO dto;
        private List<CategoryDTO> _lstCate = new List<CategoryDTO>();

        public BookInfoForm()
        {
            InitializeComponent();

            grcCatalogue.DataSource = lst;

            CategoryBUS bus = new CategoryBUS();
            _lstCate.Add(new CategoryDTO()
            {
                CategoryId = "",
                CategoryName = "--Tất cả danh mục--"
            });
            _lstCate.AddRange(bus.GetAllCatagory());

            foreach (CategoryDTO categoryDTO in _lstCate)
            {
                for (int i = 0; i < categoryDTO.CategoryId.Split('.').Length - 1; i++)
                {
                    categoryDTO.CategoryName = "|--" + categoryDTO.CategoryName;
                }
            }

            cbeDetailCategory.DataSource = _lstCate;

            cboxField1.SelectedIndex = 0;
            cboxField2.SelectedIndex = 0;
            cboxField3.SelectedIndex = 0;
            cboxAno1.SelectedIndex = 0;
            cboxAno2.SelectedIndex = 0;
            cboxType1.SelectedIndex = 0;
            cboxType2.SelectedIndex = 0;
            cboxType3.SelectedIndex = 0;

            SearchBookBUS bbus = new SearchBookBUS();
            int stype = 1;
            dto = new SearchBookDTO();
            dto.Info1 = txtTitle.Text;
            dto.PageNumber = 1;
            dto.SearchType = (SearchType)stype;
            //grcCatalogue.DataSource = bbus.SearchBooks(dto);
            lst.Clear();
            lst.AddRange(bbus.SearchBooks(dto));

            grcCatalogue.RefreshDataSource();

            int NoR = bbus.SearchBooksCount(dto);
            lblResult.Text = NoR.ToString();

            int pages = (int)Math.Ceiling(((double)NoR) / ((double)Options.NumberOfRecord));

            cbePage.Items.Clear();
            cbePage.Text = "";
            for (int i = 1; i <= pages; i++)
            {
                cbePage.Items.Add(i);
            }
            if (pages != 0)
            {
                cbePage.SelectedIndex = 0;
            }
        }

        private void abgCatalogue_DoubleClick(object sender, EventArgs e)
        {
            SearchBookResultDTO catalogueDTO = ((SearchBookResultDTO)abgCatalogue.GetFocusedRow());
            EditCatalogue(catalogueDTO);
        }

        public void EditCatalogue()
        {
            if (abgCatalogue.GetFocusedRow() != null)
            {
                this.Focus();
                abgCatalogue.Focus();
                EditCatalogue((SearchBookResultDTO)abgCatalogue.GetFocusedRow());
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 đầu sách để chỉnh sửa.");
            }
        }

        public void EditCatalogue(SearchBookResultDTO dto)
        {
            Saved = false;
            EditCatalogueForm editCatalogueForm = new EditCatalogueForm(this, dto.ISBN);
            editCatalogueForm.ShowDialog();

            if (Saved)
            {
                dto.ISBN = ReturnCatalogue.ISBN;
                dto.Title = ReturnCatalogue.Title;
                dto.ShortDescription = ReturnCatalogue.ShortDescription;
                dto.AuthorName = ReturnCatalogue.Authors;
                dto.CategoryName = ReturnCatalogue.Category.CategoryName;
                dto.PublisherName = ReturnCatalogue.Publisher.PublisherName;
                dto.Image = ReturnCatalogue.Image;
            }
        }

        public void AddCatalogue()
        {
            Saved = false;
            EditCatalogueForm editCatalogueForm = new EditCatalogueForm(this);
            editCatalogueForm.ShowDialog();

            if (Saved)
            {
                lst.Add(new SearchBookResultDTO()
                            {
                                ISBN = ReturnCatalogue.ISBN,
                                AuthorName = ReturnCatalogue.Authors,
                                CategoryName = ReturnCatalogue.Category.CategoryName,
                                Image = ReturnCatalogue.Image,
                                PublisherName = ReturnCatalogue.Publisher.PublisherName,
                                Title = ReturnCatalogue.Title
                            });
            }
        }

        private void ribeCatalogueAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CatalogueBUS bus = new CatalogueBUS();
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                SearchBookResultDTO dto = (SearchBookResultDTO)abgCatalogue.GetFocusedRow();
                EditCatalogue(dto);
            }
            else if (e.Button.Kind == ButtonPredefines.Delete)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa đầu sách này ko??", "", MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes)
                {
                    SearchBookResultDTO dto = (SearchBookResultDTO)abgCatalogue.GetFocusedRow();
                    CatalogueDTO cdto = bus.GetCatalogueById(dto.ISBN);
                    DeleteCatalogue(cdto);
                }

            }
        }

        public void DeleteCatalogue()
        {
            if (abgCatalogue.GetFocusedRow() != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa đầu sách này ko??", "", MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes)
                {
                    CatalogueBUS bus = new CatalogueBUS();
                    SearchBookResultDTO dto = (SearchBookResultDTO) abgCatalogue.GetFocusedRow();
                    CatalogueDTO cdto = bus.GetCatalogueById(dto.ISBN);
                    DeleteCatalogue(cdto);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 đầu sách để xoá.");
            }
        }

        public void DeleteCatalogue(CatalogueDTO cdto)
        {
            CatalogueBUS catalogueBus = new CatalogueBUS();
            if (catalogueBus.DeleteCatalogue(cdto, null) == 1)
            {
                abgCatalogue.DeleteSelectedRows();
            }
            else
            {
                MessageBox.Show("Không thể xóa được đầu sách này khỏi CSDL =.='");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBookBUS bbus = new SearchBookBUS();
            int stype = xtraTabControl1.SelectedTabPageIndex;
            dto = new SearchBookDTO();
            if (stype == 0)
            {
                dto.Info1 = txtTitle.Text;
                dto.PageNumber = 1;
                dto.SearchType = (SearchType)stype;
            }
            else if (stype == 1)
            {
                dto.Info1 = txtDetailTitle.Text;
                dto.Info2 = ((CategoryDTO)cbeDetailCategory.SelectedValue).CategoryId;
                dto.Info3 = txtShortDesc.Text;
                dto.Info4 = txtAuthorName.Text;
                dto.Cate = ((CategoryDTO)cbeDetailCategory.SelectedValue).CategoryId;
                dto.PageNumber = 1;
                dto.SearchType = (SearchType)stype;
            }
            else if (stype == 2)
            {
                dto.Info1 = txtInfo1.Text;
                dto.Info2 = txtInfo2.Text;
                dto.Info3 = txtInfo3.Text;
                dto.Field1 = cboxField1.SelectedItem.ToString();
                dto.Field2 = cboxField2.SelectedItem.ToString();
                dto.Field3 = cboxField3.SelectedItem.ToString();
                dto.Type1 = cboxType1.SelectedIndex;
                dto.Type2 = cboxType2.SelectedIndex;
                dto.Type3 = cboxType3.SelectedIndex;
                dto.Ano1 = cboxAno1.SelectedItem.ToString();
                dto.Ano2 = cboxAno2.SelectedItem.ToString(); 
                dto.PageNumber = 1;
                dto.SearchType = (SearchType) stype;
            }
            // get number of results
            lst.Clear();
            lst.AddRange(bbus.SearchBooks(dto));

            grcCatalogue.RefreshDataSource();
            // grcCatalogue.DataSource = lst;

            int NoR = bbus.SearchBooksCount(dto);
            lblResult.Text = NoR.ToString();

            int pages = (int)Math.Ceiling(((double)NoR) / ((double)Options.NumberOfRecord));

            cbePage.Items.Clear();
            cbePage.Text = "";
            for (int i = 1; i <= pages; i++)
            {
                cbePage.Items.Add(i);
            }
            if (pages != 0)
            {
                cbePage.SelectedIndex = 0;
            }

        }

        private void cbePage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBookBUS bbus = new SearchBookBUS();
            // get result list
            lst.Clear();
            int tmp;
            dto.PageNumber = int.TryParse(cbePage.Text, out tmp) ? tmp : 1;

            lst.AddRange(bbus.SearchBooks(dto));

            //grcCatalogue.DataSource = lst;
            grcCatalogue.RefreshDataSource();
            //grcCatalogue.CausesValidation = true;
        }

        private void BookInfoForm_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).ChildSelected("Catalogue");
        }

        private void BookInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).ChildSelected("");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtShortDesc.Text = "";
            txtInfo3.Text = "";
            txtInfo2.Text = "";
            txtInfo1.Text = "";
            txtDetailTitle.Text = "";
            txtAuthorName.Text = "";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.TopicId, HelpContextMap.CID_THEM_DAU_SACH_MOI.ToString());
        }

        private void SSHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.TopicId, HelpContextMap.CID_HINH_CHOP.ToString());
        }

        private void DSHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.TopicId, HelpContextMap.CID_HINH_CHOP1.ToString());
        }

        private void ASHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.TopicId, HelpContextMap.CID_HINH_CHOP2.ToString());
        }
    }
}