using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LIB;

namespace LIB
{
    public partial class ReturnBookForm : Form
    {
        private Feature _feature;
        private RentalDTO _rental;

        //public ReturnBookForm()
        //{
        //    InitializeComponent();
        //}

        public ReturnBookForm(Feature feature, RentalDTO selectedRental)
        {
            InitializeComponent();
            _feature = feature;
            _rental = selectedRental;
            InitializeData();
        }

        private void InitializeData()
        {
            txtBarcode.Text = _rental.Barcode;
            txtUser.Text = _rental.Username;
            txtTitle.Text = _rental.BookTitle;
            dteIssueDate.Value = _rental.IssueDate;
            dteDueDate.Value = _rental.DueDate;
            dteReturnDate.Value = DateTime.Now;
            CalculateFine();

            var listStatus = new List<string>();
            foreach (RentalStatus status in Enum.GetValues(typeof(RentalStatus)))
            {
                if (status != RentalStatus.NEW)
                {
                    listStatus.Add(EnumHelper.GetDescription(status));
                }
            }
            cboStatus.DataSource = listStatus;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _rental.ReturnDate = dteReturnDate.Value;
            _rental.Fine = float.Parse(txtFine.Text);
            _rental.Status = (RentalStatus)EnumHelper.Parse(typeof(RentalStatus), cboStatus.Text);
            _feature.ReturnBook(_rental);
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string ValidateData()
        {

            return null;
        }

        private void dteReturnDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateFine();
        }

        private void CalculateFine()
        {
            // calculate overdue fine
            int overDate = dteReturnDate.Value.DayOfYear - dteDueDate.Value.DayOfYear;
            overDate = overDate < 0 ? 0 : overDate;
            txtOverDate.Text = overDate.ToString();
            float overDueFine = overDate * (_rental.BookPrice * 5 / 100);

            // calculate book status fine
            float statusFine = 0;
            try
            {
                _rental.Status = (RentalStatus)EnumHelper.Parse(typeof(RentalStatus), cboStatus.Text);
            }
            catch (Exception)
            {

            }

            if (_rental.Status == RentalStatus.LOST || _rental.Status == RentalStatus.DAMAGED)
            {
                statusFine = _rental.BookPrice;
            }

            txtFine.Text = overDueFine + statusFine + "";
        }

        private void cboStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CalculateFine();
        }
    }
}
