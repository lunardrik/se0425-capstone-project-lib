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
    public partial class SelectAuthorForm : DevExpress.XtraEditors.XtraForm
    {
        private EditCatalogueForm _parents;
        private List<AuthorDTO> _authors;
        private List<AuthorDTO> _searchResult = new List<AuthorDTO>();



        public SelectAuthorForm()
        {
            InitializeComponent();
        }

        public SelectAuthorForm(EditCatalogueForm parent, List<AuthorDTO> author)
        {
            InitializeComponent();
            _parents = parent;
            _authors = author;

            _searchResult.AddRange(_authors);

            lstAuthorResult.DataSource = _searchResult;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstAuthorResult.SelectedIndex != -1)
            {
                _parents.ReturnAuthor = (AuthorDTO)lstAuthorResult.SelectedItem;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _searchResult.Clear();

            _searchResult.AddRange(_authors.FindAll(a => a.AuthorName.Contains(txtAuthorName.Text)));
            lstAuthorResult.Refresh();
            lstAuthorResult.SelectedIndex = 0;
        }
    }
}