using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace LIB
{
    public partial class UserManagementForm : DevExpress.XtraEditors.XtraForm
    {
        private static Feature _feature;
        private MainForm _mainForm;
        private List<UserDTO> _listUser;

        public UserManagementForm(Feature feature, MainForm mainForm)
        {
            InitializeComponent();
            _feature = feature;
            _mainForm = mainForm;
            InitializeData();
        }

        private void InitializeData()
        {
            _listUser = _feature.GetAllUser();
            grdUser.DataSource = _listUser;
            var listStatus = new List<string>();
            foreach (UserStatus status in Enum.GetValues(typeof(UserStatus)))
            {
                listStatus.Add(EnumHelper.GetDescription(status));
            }
            cboxStatus.DataSource = listStatus;
        }

        private UserDTO GetSelectedUser()
        {
            var grdView = grdUser.FocusedView as GridView;

            if (grdView != null)
            {
                return grdView.GetFocusedRow() as UserDTO;
            }

            return null;
        }

        private void UserManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)MdiParent).ChildSelected("");
        }

        private void grdViewUser_DoubleClick(object sender, EventArgs e)
        {
            EditUser();
        }

        public void AddUser()
        {
            Focus();
            var userEditForm = new UserEditForm(_feature, null);
            userEditForm.ShowDialog();
            ReloadDatabase();
        }

        public void EditUser()
        {
            Focus();
            var selectedUser = GetSelectedUser();
            if (selectedUser != null)
            {
                var userEditForm = new UserEditForm(_feature, selectedUser);
                userEditForm.ShowDialog();
                ReloadDatabase();
            }
        }

        public void ReloadDatabase()
        {
            Focus();
            InitializeData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUserDTO searchUserDto=new SearchUserDTO();
            searchUserDto.UserName = txtUsername.Text;
            searchUserDto.Email = txtEmail.Text;
            searchUserDto.Isdn = txtIDSN.Text;
            searchUserDto.Status = (int)EnumHelper.Parse(typeof(UserStatus), cboxStatus.Text);
            searchUserDto.PageNumber = 1;
            SearchUserBUS searchUserBus =new SearchUserBUS();
            grdUser.DataSource = searchUserBus.SearchUsers(searchUserDto);
        }

        private void UserManagementForm_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).ChildSelected("User");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtIDSN.Text = "";
            txtEmail.Text = "";
            cboxStatus.SelectedIndex = 0;
        }
    }
}