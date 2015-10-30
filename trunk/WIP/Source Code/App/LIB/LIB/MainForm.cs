using System;
using System.Drawing;
using LIB;
using DevExpress.XtraBars;
using System.Windows.Forms;

namespace LIB
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Feature _feature;
        private RegisterRentalForm _registerRentalForm;
        private BookInfoForm _infoForm;
        private static UserManagementForm _userForm;

        public void ChildSelected(string childName)
        {
            switch (childName)
            {
                case "Catalogue":
                    pageCatalogueManagement.Visible = true;
                    pageUser.Visible = false;
                    pageRegisterRental.Visible = false;

                    ribbon.SelectedPage = pageCatalogueManagement;
                    break;
                case "Rental":
                    pageCatalogueManagement.Visible = false;
                    pageUser.Visible = false;
                    pageRegisterRental.Visible = true;

                    ribbon.SelectedPage = pageRegisterRental;
                    break;
                case "User":
                    pageCatalogueManagement.Visible = false;
                    pageUser.Visible = true;
                    pageRegisterRental.Visible = false;

                    ribbon.SelectedPage = pageUser;
                    break;
                case "Report":
                default:
                    pageCatalogueManagement.Visible = false;
                    pageUser.Visible = false;
                    pageRegisterRental.Visible = false;

                    ribbon.SelectedPage = pageMain;
                    break;
            }
        }

        public MainForm()
        {
            _feature = new Feature();

            InitializeComponent();

            pageCatalogueManagement.Visible = false;
            pageUser.Visible = false;
            pageRegisterRental.Visible = false;

            ribbon.SelectedPage = pageMain;

            //Help.ShowHelp(this, "HELP.chm", HelpNavigator.Topic, "14_3.2.IterationobjectivesL9.htm");
        }

        private bool CheckLogin()
        {
            if (Options.User == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();

                // authorization
                if (Options.User != null)
                {
                    rpgSystem.Visible = true;
                    // Admin
                    if (Options.User.RoleId == 1)
                    {
                        barBtnCatalogue.Visibility = BarItemVisibility.Never;
                        barBtnReport.Visibility = BarItemVisibility.Never;
                        barBtnRegisterRental.Visibility = BarItemVisibility.Never;
                        // Librarian
                    }
                    else if (Options.User.RoleId == 3)
                    {
                        barBtnUser.Visibility = BarItemVisibility.Never;
                    }
                }
            }
            if (Options.User == null)
            {
                return false;
            }
            return true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void ribbon_TabIndexChanged(object sender, EventArgs e)
        {
            //clientPanel = new DevExpress.XtraEditors.PanelControl();
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            //clientPanel = new DevExpress.XtraEditors.PanelControl();
        }

        private void barBtnRegisterRental_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CheckLogin())
            {
                if (_registerRentalForm == null || _registerRentalForm.IsDisposed) _registerRentalForm = new RegisterRentalForm(_feature, this);
                else
                {
                    _registerRentalForm.Focus();
                    return;
                }
                _registerRentalForm.MdiParent = this;
                _registerRentalForm.Show();
            }
        }

        private void barBtnCatalogue_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CheckLogin())
            {
                if (_infoForm == null || _infoForm.IsDisposed) _infoForm = new BookInfoForm();
                else
                {
                    _infoForm.Focus();
                    return;
                }
                _infoForm.MdiParent = this;
                _infoForm.Show();
            }
        }

        private void barBtnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CheckLogin())
            {
                if (_userForm == null || _userForm.IsDisposed) _userForm = new UserManagementForm(_feature, this);
                else
                {
                    _userForm.Focus();
                    return;
                }
                _userForm.MdiParent = this;
                _userForm.Show();
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnRefresh.Enabled = false;
            btnRefresh.Refresh();

            if (!FocusRentalPage())
            {
                btnRefresh.Enabled = true;
                return;
            }

            if (_registerRentalForm != null)
            {
                _registerRentalForm.ReloadDatabase();
            }

            btnRefresh.Enabled = true;
        }

        private void btnApprove_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!FocusRentalPage())
            {
                return;
            }

            if (_registerRentalForm != null)
            {
                //if (MessageBox.Show(this, Constants.REQUEST_APPROVE,
                //                    Constants.SYSTEM_INFO,
                //                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                _registerRentalForm.ApproveRequest();
                //}
            }
        }

        private void btnReject_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!FocusRentalPage())
            {
                return;
            }

            if (_registerRentalForm != null)
            {
                //if (MessageBox.Show(this, Constants.REQUEST_REJECT,
                //                    Constants.SYSTEM_INFO,
                //                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                _registerRentalForm.RejectRequest();
                //}
            }
        }

        private void btnAddRental_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!FocusRentalPage())
            {
                return;
            }

            if (_registerRentalForm != null)
            {
                _registerRentalForm.AddNewRental();
            }
        }

        private void btnReturnBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!FocusRentalPage())
            {
                return;
            }

            if (_registerRentalForm != null)
            {
                _registerRentalForm.ReturnBook();
            }
        }

        private void barExpandRental_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!FocusRentalPage())
            {
                return;
            }

            if (_registerRentalForm != null)
            {
                _registerRentalForm.ExpandRental();
            }
        }

        private void btnAddCatalogue_ItemClick(object sender, ItemClickEventArgs e)
        {
            _infoForm.AddCatalogue();
        }

        private void btnEditCatalogue_ItemClick(object sender, ItemClickEventArgs e)
        {
            _infoForm.EditCatalogue();
        }

        private bool FocusRentalPage()
        {
            if (_registerRentalForm != null)
            {
                _registerRentalForm.Focus();
                return true;
            }
            _registerRentalForm = new RegisterRentalForm(_feature, this);
            _registerRentalForm.MdiParent = this;
            _registerRentalForm.Show();

            return false;
        }

        private void barBtnAddUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_userForm != null)
            {
                _userForm.AddUser();
            }
        }

        private void barBtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_userForm != null)
            {
                _userForm.ReloadDatabase();
            }
        }

        private void barBtnEditUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_userForm != null)
            {
                _userForm.EditUser();
            }
        }

        private void barBtnImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_registerRentalForm != null)
            {
                _registerRentalForm.Import();
            }
        }

        private void btnEditAuthor_ItemClick(object sender, ItemClickEventArgs e)
        {
            AuthorManagementForm amf = new AuthorManagementForm();
            amf.StartPosition = FormStartPosition.CenterScreen;
            amf.ShowDialog();
        }

        private void btnEditPublisher_ItemClick(object sender, ItemClickEventArgs e)
        {
            PublisherManagementForm pmf = new PublisherManagementForm();
            pmf.StartPosition = FormStartPosition.CenterScreen;
            pmf.ShowDialog();
        }

        private void btnEditCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            CategoryManagementForm cmf = new CategoryManagementForm();
            cmf.StartPosition = FormStartPosition.CenterScreen;
            cmf.ShowDialog();
        }

        private void btnDeleteCatalogue_ItemClick(object sender, ItemClickEventArgs e)
        {
            _infoForm.DeleteCatalogue();
        }

        private void barBtnReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CheckLogin())
            {
                ReportForm frm = new ReportForm();
                frm.ShowDialog();
            }
        }

        private void barLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc đăng xuất khỏi hệ thống không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_infoForm != null && !_infoForm.IsDisposed)
                {
                    _infoForm.Close();
                }
                if (_registerRentalForm != null && !_registerRentalForm.IsDisposed)
                {
                    _registerRentalForm.Close();
                }
                if (_userForm != null && !_userForm.IsDisposed)
                {
                    _userForm.Close();
                }

                Options.User = null;
                rpgSystem.Visible = false;
                Log.Info("User logged out");
            }
        }
    }
}