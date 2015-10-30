using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace LIB
{
    public partial class RegisterRentalForm : DevExpress.XtraEditors.XtraForm
    {
        private MainForm _mainForm;
        private static Feature _feature;
        private List<RentalDTO> _listRental;
        private readonly Thread _threadRefresh;
        private readonly Refresher _refresher;

        public RegisterRentalForm(Feature feature, MainForm mainForm)
        {
            InitializeComponent();
            cboRentalStatus.Text = "Tất cả";
            cboRequestStatus.Text = "Tất cả";
            _feature = feature;
            _mainForm = mainForm;
            InitializeData();

            // new thread
            _refresher = new Refresher(_feature, this);
            _refresher.LastUpdateTime = DateTime.Now;
            _threadRefresh = new Thread(_refresher.GetNewRegister);
            _threadRefresh.Start();
        }

        private void InitializeData()
        {
            //_listRegister = _feature.GetAllRegister();
            //grdRegister.DataSource = _listRegister;
            //_listRental = _feature.GetAllRental();
            //grdRental.DataSource = _listRental;
            
            dteRequestFrom.Value = DateTime.Now.AddMonths(-1);
            dteRentalFrom.Value = DateTime.Now.AddMonths(-1);
            if (_refresher != null)
            {
                _refresher.LastUpdateTime = DateTime.Now;
            }

            ResetListRequest();
            ResetListRental();
        }

        public void ReloadDatabase()
        {
            //InitializeData();
            if (tabControl.SelectedTabPage == tabRegister)
            {
                ResetListRequest();
            }
            if (tabControl.SelectedTabPage == tabRental)
            {
                ResetListRental();
            }
            //Refresh();
        }

        public void ApproveRequest()
        {
            var selectedRequest = GetSelectedRequest();

            if (selectedRequest == null)
            {
                MessageBox.Show(this, Constants.REQUEST_SELECT, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (selectedRequest.Status != BookRegisterStatus.NEW)
            {
                MessageBox.Show(this, Constants.REQUEST_LOCK, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                return;
            }

            if (MessageBox.Show(this, Constants.REQUEST_APPROVE,
                                Constants.SYSTEM_INFO,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            string msg = _feature.ApproveRequest(selectedRequest);
            if (msg != null)
            {
                MessageBox.Show(this, msg, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            ReloadDatabase();
        }

        public void RejectRequest()
        {
            var selectedRequest = GetSelectedRequest();

            if (selectedRequest == null)
            {
                MessageBox.Show(this, Constants.REQUEST_SELECT, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (selectedRequest.Status != BookRegisterStatus.NEW)
            {
                MessageBox.Show(this, Constants.REQUEST_LOCK, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(this, Constants.REQUEST_REJECT,
                                    Constants.SYSTEM_INFO,
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            if (!_feature.RejectRequest(selectedRequest))
            {
                MessageBox.Show(this, Constants.SYSTEM_ERROR, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            ReloadDatabase();
        }

        public void AddNewRental()
        {
            var newRentalForm = new NewRentalForm(_feature, _listRental);
            newRentalForm.ShowDialog();
            ReloadDatabase();
        }

        public void ExpandRental()
        {
            var selectedRental = GetSelectedRental();

            if (selectedRental == null)
            {
                MessageBox.Show(this, Constants.RENTAL_SELECT, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (selectedRental.Status != RentalStatus.NEW)
            {
                MessageBox.Show(this, Constants.RENTAL_LOCK, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (selectedRental.ExpandCount >= selectedRental.ExpandLimit)
            {
                MessageBox.Show(this, Constants.RENTAL_EXPAND_LIMIT, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            var expandRentalForm = new ExpandRentalForm(_feature, selectedRental);
            expandRentalForm.ShowDialog();
            ReloadDatabase();
        }

        public void ReturnBook()
        {
            var selectedRental = GetSelectedRental();

            if (selectedRental == null)
            {
                MessageBox.Show(this, Constants.RENTAL_SELECT, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (selectedRental.Status != RentalStatus.NEW)
            {
                MessageBox.Show(this, Constants.RENTAL_LOCK, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var returnBookForm = new ReturnBookForm(_feature, selectedRental);
            returnBookForm.ShowDialog();
            ReloadDatabase();
        }

        private BookRegisterDTO GetSelectedRequest()
        {
            var grdView = grdRegister.FocusedView as GridView;

            if (grdView != null)
            {
                return grdView.GetFocusedRow() as BookRegisterDTO;
            }

            return null;
        }

        private RentalDTO GetSelectedRental()
        {
            var grdView = grdRental.FocusedView as GridView;

            if (grdView != null)
            {
                return grdView.GetFocusedRow() as RentalDTO;
            }

            return null;
        }

        private void RegisterRentalFormFormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose(true);
            _listRental = null;
            _threadRefresh.Abort();
            ((MainForm)MdiParent ?? _mainForm).ChildSelected("");
        }

        private void BtnRegisterSearchClick(object sender, EventArgs e)
        {
            SearchRequestDTO rDto = new SearchRequestDTO();
            rDto.UserName = txtRequestUser.Text;
            rDto.Title = txtRequestTitle.Text;
            rDto.Status = cboRequestStatus.SelectedIndex;
            rDto.FromDate = dteRequestFrom.Text;
            rDto.ToDate = dteRequestTo.Text;
            rDto.PageNumber = 1;
            SearchRequestBUS rBus = new SearchRequestBUS();
            grdRegister.DataSource = rBus.SearchRequests(rDto);
        }

        private void BtnRentalSearchClick(object sender, EventArgs e)
        {
            SearchRentalDTO rentalDto = new SearchRentalDTO();
            rentalDto.Title = txtRentalTitle.Text;
            rentalDto.UserName = txtRentalUser.Text;
            rentalDto.Status = cboRentalStatus.SelectedIndex;
            rentalDto.FromDate = dteRentalFrom.Text;
            rentalDto.ToDate = dteRentalTo.Text;
            rentalDto.PageNumber = 1;
            SearchRentalBUS rentalBus = new SearchRentalBUS();
            grdRental.DataSource = rentalBus.SearchRentals(rentalDto);
        }

        public void Import()
        {
            var importForm = new RegisterImportForm(_feature);
            importForm.ShowDialog();
            //var openFileDialog = new OpenFileDialog();
            //openFileDialog.ShowDialog();
            //var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);

            //if (_feature.ImportRegister(fileStream))
            //{
            //    MessageBox.Show(this, Constants.REQUEST_IMPORT, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
            //                    MessageBoxIcon.Information);
            //} else
            //{
            //    MessageBox.Show(this, Constants.REQUEST_IMPORT, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
            //                    MessageBoxIcon.Error);
            //}
        }

        private void RegisterRentalFormActivated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).ChildSelected("Rental");
        }

        public delegate void AlertDelegate(string message);

        private void ShowAlert(string message)
        {
            //var bm = new Bitmap(Properties.Resources.request);
            var alertInfo = new AlertInfo(Constants.REQUEST_NEW, message);
            alertControl1.Show(this, alertInfo);
            InitializeData();
        }

        public void Alert(string message)
        {
            Invoke(new AlertDelegate(ShowAlert), message);
        }

        private void ResetListRequest()
        {
            //_listRegister = _feature.GetAllRegister();
            //grdRegister.DataSource = _listRegister;
            var rDto = new SearchRequestDTO();
            rDto.Status = (int) BookRegisterStatus.NEW;
            rDto.FromDate = dteRequestFrom.Value.ToShortDateString();
            rDto.ToDate = dteRequestTo.Value.ToShortDateString();
            rDto.PageNumber = 1;
            var rBus = new SearchRequestBUS();
            grdRegister.DataSource = rBus.SearchRequests(rDto);
        }

        private void ResetListRental()
        {
            //_listRental = _feature.GetAllRental();
            //grdRental.DataSource = _listRental;
            var rentalDto = new SearchRentalDTO();
            rentalDto.Status = (int) RentalStatus.NEW;
            rentalDto.FromDate = dteRentalFrom.Text;
            rentalDto.ToDate = dteRentalTo.Text;
            rentalDto.PageNumber = 1;
            var rentalBus = new SearchRentalBUS();
            grdRental.DataSource = rentalBus.SearchRentals(rentalDto);
        }

        private void BtnResetRequestClick(object sender, EventArgs e)
        {
            ResetListRequest();
            txtRequestUser.Text = "";
            txtRequestTitle.Text = "";
            cboRequestStatus.SelectedIndex = 0;
            dteRequestFrom.Value = DateTime.Now.AddMonths(-1);
            dteRequestTo.Value = DateTime.Now;
        }

        private void BtnResetRentalClick(object sender, EventArgs e)
        {
            ResetListRental();
            txtRentalUser.Text = "";
            txtRentalTitle.Text = "";
            cboRentalStatus.SelectedIndex = 0;
            dteRentalFrom.Value = DateTime.Now.AddMonths(-1);
            dteRentalTo.Value = DateTime.Now;
        }

        private void TabControlSelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == tabRegister)
            {
                ResetListRequest();
            }
            else if (e.Page == tabRental)
            {
                ResetListRental();
            }
        }
    }
}