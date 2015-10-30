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
    public partial class NewRentalForm : Form
    {
        private Feature _feature;
        private List<RentalDTO> _listRental;
        //public NewRentalForm()
        //{
        //    InitializeComponent();
        //}

        public NewRentalForm(Feature feature, List<RentalDTO> listRental)
        {
            InitializeComponent();
            _feature = feature;
            _listRental = listRental;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            string msg = ValidateData();
            if (msg != null)
            {
                MessageBox.Show(this, msg, Constants.SYSTEM_INFO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var rentalDto = new RentalDTO();
            rentalDto.Barcode = txtBarcode.Text;
            rentalDto.UserId = txtUser.Text;
            rentalDto.Status = RentalStatus.NEW;
            rentalDto.IssueDate = dteIssuedDate.Value;
            rentalDto.DueDate = dteDueDate.Value;

            if (_feature.AddRental(rentalDto))
            {
                MessageBox.Show(this, Constants.RENTAL_INSERT_OK, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                _listRental.Add(rentalDto);
            } else
            {
                MessageBox.Show(this, Constants.SYSTEM_ERROR, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            Dispose();
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            //Dispose();
            Close();
        }

        private string ValidateData()
        {
            if (txtUser.Text == null || txtUser.Text.Equals(""))
            {
                return Constants.RENTAL_VALIDATE_USERID;
            }

            if (txtBarcode.Text == null || txtBarcode.Text.Equals(""))
            {
                return Constants.RENTAL_VALIDATE_BARCODE;
            }

            if (dteIssuedDate.Value.CompareTo(dteDueDate.Value) >= 0)
            {
                return Constants.RENTAL_VALIDATE_DUEDATE;
            }

            return null;
        }

        private void LblSearchUserClick(object sender, EventArgs e)
        {
            QuickSearchForm qsf = new QuickSearchForm();
            qsf.Type = 1;
            if (qsf.ShowDialog() == DialogResult.OK)
            {
                txtUser.Text = qsf.SearchResult;
            }
        }

        private void LblSearchBarcodeClick(object sender, EventArgs e)
        {
            QuickSearchForm qsf = new QuickSearchForm();
            qsf.Type = 2;
            if (qsf.ShowDialog() == DialogResult.OK)
            {
                txtBarcode.Text = qsf.SearchResult;
            }
        }
    }
}
