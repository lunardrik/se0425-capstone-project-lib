using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LIB
{
    public partial class UserEditForm : Form
    {
        private Feature _feature;
        private UserDTO _selectedUser;

        public UserEditForm(Feature feature, UserDTO userDto)
        {
            InitializeComponent();
            _feature = feature;
            _selectedUser = userDto;
            InitializeControlStatus();
            InitializeData();
        }

        private void InitializeControlStatus()
        {
            // update mode
            if (_selectedUser != null)
            {
                txtUserID.ReadOnly = true;
                dteIssueDate.Enabled = false;
            }
            else
                btnResetPassword.Visible = false;
        }

        private void InitializeData()
        {
            var listAllRole = _feature.GetAllRole();
            var listRole = new List<RoleDTO>();
            foreach (var roleDto in listAllRole)
            {
                if (roleDto.RoleId != 1)
                {
                    listRole.Add(roleDto);
                }
            }
            cboRole.DataSource = listRole;
            cboRole.DisplayMember = "RoleDescription";
            cboRole.ValueMember = "RoleId";

            var listStatus = new List<string>();
            foreach (UserStatus status in Enum.GetValues(typeof(UserStatus)))
            {
                listStatus.Add(EnumHelper.GetDescription(status));
            }
            cboStatus.DataSource = listStatus;

            // update mode
            if (_selectedUser != null)
            {
                txtUserID.Text = _selectedUser.UserId;
                txtUsername.Text = _selectedUser.Username;
                cboRole.Text = _selectedUser.RoleDescription;
                txtAddress.Text = _selectedUser.Address;
                txtEmail.Text = _selectedUser.Email;
                txtIDSN.Text = _selectedUser.IDSN;
                txtPhone.Text = _selectedUser.Phone;
                dteBirthday.Value = _selectedUser.Birthday;
                dteIssueDate.Value = _selectedUser.IssuedDate;
                dteExpireDate.Value = _selectedUser.ExpiredDate;
                cboStatus.Text = _selectedUser.StatusFriendly;

                // insert mode
            }
            else
            {
                dteIssueDate.Value = DateTime.Now;
                cboRole.SelectedIndex = 0;
                cboStatus.SelectedIndex = 0;
            }
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            string msg = ValidateData();

            if (msg != null)
            {
                MessageBox.Show(this, msg, Constants.SYSTEM_INFO,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool result = false;

            // update
            if (_selectedUser != null)
            {
                _selectedUser.Username = txtUsername.Text;
                _selectedUser.RoleId = (int)cboRole.SelectedValue;
                _selectedUser.IDSN = txtIDSN.Text;
                _selectedUser.Phone = txtPhone.Text;
                _selectedUser.Email = txtEmail.Text;
                _selectedUser.Address = txtAddress.Text;
                _selectedUser.Birthday = dteBirthday.Value;
                _selectedUser.ExpiredDate = dteExpireDate.Value;
                _selectedUser.Status = (UserStatus)EnumHelper.Parse(typeof(UserStatus), cboStatus.Text);
                result = _feature.UpdateUser(_selectedUser);

                if (result)
                {
                    MessageBox.Show(this, Constants.USER_EDIT_OK, Constants.SYSTEM_INFO,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

                // insert
            else
            {
                var userDto = new UserDTO();
                userDto.UserId = txtUserID.Text;
                userDto.Username = txtUsername.Text;
                userDto.Password = txtUserID.Text;
                userDto.RoleId = (int)cboRole.SelectedValue;
                userDto.IDSN = txtIDSN.Text;
                userDto.Phone = txtPhone.Text;
                userDto.Email = txtEmail.Text;
                userDto.Address = txtAddress.Text;
                userDto.Birthday = dteBirthday.Value;
                userDto.IssuedDate = dteIssueDate.Value;
                userDto.ExpiredDate = dteExpireDate.Value;
                userDto.Status = (UserStatus)EnumHelper.Parse(typeof(UserStatus), cboStatus.Text);
                result = _feature.AddUser(userDto);

                if (result)
                {
                    //_feature.SendSampleMail("bangiaolygxcd@gmail.com");
                    MessageBox.Show(this, Constants.USER_INSERT_OK, Constants.SYSTEM_INFO,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (!result)
            {
                MessageBox.Show(this, Constants.SYSTEM_ERROR, Constants.SYSTEM_INFO,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private string ValidateData()
        {
            if (txtUserID.Text.Length == 0)
            {
                return Constants.USER_VALIDATE_USERID;
            }

            if (txtUsername.Text.Length == 0)
            {
                return Constants.USER_VALIDATE_USERNAME;
            }

            if (txtIDSN.Text.Length == 0)
            {
                return Constants.USER_VALIDATE_IDSN;
            }

            if (txtPhone.Text.Length == 0)
            {
                return Constants.USER_VALIDATE_PHONE;
            }

            if (dteIssueDate.Value.CompareTo(dteExpireDate.Value) >= 0)
            {
                return Constants.USER_VALIDATE_EXPIRE_DATE;
            }

            if (txtEmail.Text.Length == 0 || !IsEmail(txtEmail.Text))
            {
                return Constants.USER_VALIDATE_EMAIL;
            }

            if (txtAddress.Text.Length == 0)
            {
                return Constants.USER_VALIDATE_ADDRESS;
            }

            return null;
        }

        public static bool IsEmail(string inputEmail)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            var re = new Regex(strRegex);
            return re.IsMatch(inputEmail);
        }

        private void BtnResetPasswordClick(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                return;
            }
            if (MessageBox.Show(this, Constants.USER_RESET_PASSWORD_CONFIRM, Constants.SYSTEM_INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_feature.ResetPassword(_selectedUser))
                {
                    MessageBox.Show(this, Constants.USER_RESET_PASSWORD_SUCCESS, Constants.SYSTEM_INFO,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, Constants.SYSTEM_ERROR, Constants.SYSTEM_INFO,
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
