using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LIB.Properties;

namespace LIB
{
    public partial class CategoryManagementForm : DevExpress.XtraEditors.XtraForm
    {
        List<CategoryDTO> lst = new List<CategoryDTO>();
        public CategoryManagementForm()
        {
            InitializeComponent();
            lst.AddRange((new CategoryBUS()).GetAllCatagory());
            grdCategory.DataSource = lst;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CategoryBUS bus = new CategoryBUS();
            string info = txtCate.Text;
            lst.Clear();
            lst.AddRange(bus.SearchCate(info));
            grdCategory.RefreshDataSource();
        }

        private void grvCategory_Click(object sender, EventArgs e)
        {
            CategoryDTO category = (CategoryDTO) grvCategory.GetFocusedRow();
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Text = category.CategoryId;
            txtCategoryName.Text = category.CategoryName;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtCategoryID.ReadOnly = false;
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
            txtCategoryID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CategoryBUS bus = new CategoryBUS();
            if (txtCategoryID.ReadOnly == true)
            {
                if (String.IsNullOrEmpty(txtCategoryName.Text))
                {
                    MessageBox.Show(Resources.ADD_NULL_CATEGORY_NAME);
                    txtCategoryName.Focus();
                }
                else
                {
                    CategoryDTO category = (CategoryDTO) grvCategory.GetFocusedRow();
                    category.CategoryName = txtCategoryName.Text;
                    if (bus.UpdateCategory(category) == 1)
                    {
                        MessageBox.Show(Resources.ADD_CATEGORY_SUCCESS);
                        grdCategory.RefreshDataSource();
                    }
                    else
                    {
                        MessageBox.Show(Resources.ADD_CATEGORY_FAIL);
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtCategoryID.Text))
                {
                    MessageBox.Show(Resources.ADD_NULL_CATEGORY_ID);
                    txtCategoryID.Focus();
                }
                else
                {
                    if(String.IsNullOrEmpty(txtCategoryName.Text))
                    {
                        MessageBox.Show(Resources.ADD_NULL_CATEGORY_NAME);
                        txtCategoryName.Focus();
                    }
                    else
                    {
                        if (bus.GetCategoryById(txtCategoryID.Text) != null)
                        {
                            MessageBox.Show(Resources.ADD_EXISTING_CATEGORY_ID);
                        }
                        else
                        {
                            bool Ok = false;
                            if (txtCategoryID.Text.IndexOf('.') == -1)
                            {
                                Ok = true;
                            }
                            else
                            {
                                if (bus.GetCategoryById(txtCategoryID.Text.Substring(0, txtCategoryID.Text.LastIndexOf('.'))) != null)
                                    Ok = true;
                                else Ok = false;
                            }

                            if (Ok)
                            {
                                CategoryDTO category = new CategoryDTO()
                                {
                                    CategoryId = txtCategoryID.Text,
                                    CategoryName = txtCategoryName.Text,
                                    CreatedDate = DateTime.Now,
                                    UpdatedDate = DateTime.Now
                                };
                                if (bus.InsertCategory(category) == 1)
                                {
                                    MessageBox.Show(Resources.ADD_CATEGORY_SUCCESS);
                                    txtCategoryID.ReadOnly = true;
                                    lst.Add(category);
                                    grdCategory.RefreshDataSource();
                                }
                                else
                                {
                                    MessageBox.Show(Resources.ADD_CATEGORY_FAIL);
                                }
                            }
                            else MessageBox.Show(Resources.ADD_ORPHANAGE_CATEGORY);
                        }
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
            CategoryBUS bus = new CategoryBUS();
            if (txtCategoryID.ReadOnly == false)
            {
                MessageBox.Show(Resources.DELETE_NONE_CATEGORY);
            }
            else
            {
                if (String.IsNullOrEmpty(txtCategoryID.Text))
                {
                    MessageBox.Show(Resources.DELETE_NONE_CATEGORY);
                }
                else
                {


                    if (MessageBox.Show(Resources.DELETE_CATEGORY_CONFIRM, "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        if (!txtCategoryID.Text.Equals("0"))
                        {
                            CategoryDTO category = bus.GetCategoryById(txtCategoryID.Text);
                            if (bus.DeleteCategory(category) == 1)
                            {
                                MessageBox.Show(Resources.DELETE_CATEGORY_SUCCESS);
                                txtCategoryID.Text = "";
                                txtCategoryName.Text = "";
                                lst.Clear();
                                lst.AddRange(bus.GetAllCatagory());
                                grdCategory.RefreshDataSource();
                            }
                            else
                            {
                                MessageBox.Show(Resources.DELETE_CATEGORY_FAIL);
                            }
                        }
                        else
                        {
                            MessageBox.Show(Resources.DELETE_DEFAULT_CATEGORY);
                        }
                    }
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.TopicId, HelpContextMap.CID_THEM_MT_DANH_MOC.ToString());
        }
    }
}