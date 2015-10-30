using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIB
{
    public partial class ExpandRentalForm : Form
    {
        private Feature _feature;
        private RentalDTO _rental;

        //public ExpandRentalForm()
        //{
        //    InitializeComponent();
        //}

        public ExpandRentalForm(Feature feature, RentalDTO rentalDto)
        {
            InitializeComponent();
            _feature = feature;
            _rental = rentalDto;
            InitializeData();
        }

        private void InitializeData()
        {
            txtBarcode.Text = _rental.Barcode;
            txtUser.Text = _rental.Username;
            txtTitle.Text = _rental.BookTitle;
            dteIssueDate.Value = _rental.IssueDate;
            dteDueDateOld.Value = _rental.DueDate;
            dteDueDateNew.Value = DateTime.Now.AddDays(_rental.ExpandDateLimit);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = ValidateData();

            if (msg != null)
            {
                MessageBox.Show(this, msg, Constants.SYSTEM_INFO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _rental.DueDate = dteDueDateNew.Value;

            if (_feature.ExpandRental(_rental))
            {
                MessageBox.Show(this, Constants.RENTAL_EXPAND_OK, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, Constants.SYSTEM_ERROR, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string ValidateData()
        {
            if (dteDueDateNew.Value.CompareTo(dteDueDateOld.Value) <= 0)
            {
                return Constants.RENTAL_VALIDATE_EXPAND_DATE;
            }

            return null;
        }
    }
}
