using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace LIB
{
    public partial class AuthorManagementForm : DevExpress.XtraEditors.XtraForm
    {
        private List<AuthorDTO> lst = new List<AuthorDTO>();
        public AuthorManagementForm()
        {
            InitializeComponent();
            AuthorBUS bus=new AuthorBUS();
            lst = bus.GetAllAuthor();
            grdAuthor.DataSource = lst;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string authorName = txtInfomation.Text;
            AuthorBUS aBus = new AuthorBUS();
            lst.Clear();
            lst.AddRange(aBus.searchAuthor(authorName));
            grdAuthor.RefreshDataSource();
        }

        private void grvAuthor_Click(object sender, EventArgs e)
        {
            AuthorDTO author = (AuthorDTO) grvAuthor.GetFocusedRow();
            txtAuthorId.Text = author.AuthorId.ToString();
            txtAuthorName.Text = author.AuthorName;
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            txtAuthorId.Text = "";
            txtAuthorName.Text = "";
            txtAuthorName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AuthorBUS authorBus = new AuthorBUS();
            if(String.IsNullOrEmpty(txtAuthorId.Text))
            {
                if (String.IsNullOrEmpty(txtAuthorName.Text))
                {
                    MessageBox.Show("Vui lòng nhập vào tên tác giả !!!");
                    txtAuthorName.Focus();
                }
                else
                {
                    if (authorBus.InsertAuthor(new AuthorDTO(){AuthorName = txtAuthorName.Text,CreatedDate = DateTime.Now,UpdatedDate = DateTime.Now}) == 1)
                    {
                        MessageBox.Show("Tạo mới Tác giả thành công !!!");
                        lst.Clear();
                        lst.AddRange(authorBus.GetAllAuthor());
                        grdAuthor.RefreshDataSource();
                        txtAuthorId.Text = "";
                        txtAuthorName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Tạo mới tác giả thất bại !!!");
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtAuthorName.Text))
                {
                    MessageBox.Show("Vui lòng nhập vào tên tác giả !!!");
                    txtAuthorName.Focus();
                }
                else
                {
                    AuthorDTO author = (AuthorDTO) grvAuthor.GetFocusedRow();
                    author.AuthorName = txtAuthorName.Text;
                    if (authorBus.UpdateAuthor(author) == 1)
                    {
                        MessageBox.Show("Cập nhật thông tin Tác giả thành công !!!");
                        grdAuthor.RefreshDataSource();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin Tác giả thất bại !!!");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa Tác giả này không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AuthorBUS bus = new AuthorBUS();
                if (String.IsNullOrEmpty(txtAuthorId.Text))
                {
                    MessageBox.Show("Hãy chọn một Tác giả để thao tác xóa !!!");
                }
                else
                {
                    AuthorDTO author = (AuthorDTO) grvAuthor.GetFocusedRow();
                    if (bus.DeleteAuthor(author) == 1)
                    {
                        MessageBox.Show("Xóa tác giả thành công !!!");
                        lst.Remove(author);
                        grdAuthor.RefreshDataSource();
                        txtAuthorId.Text = "";
                        txtAuthorName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa tác giả thất bại !!!");
                    }
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.TopicId, HelpContextMap.CID_THEM_TAC_GIA.ToString());
        }
    }
}