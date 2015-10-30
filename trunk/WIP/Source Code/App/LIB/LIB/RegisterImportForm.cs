using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIB
{
    public partial class RegisterImportForm : Form
    {
        private Feature _feature;
        public RegisterImportForm(Feature feature)
        {
            InitializeComponent();
            _feature = feature;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XLS|*.xls";
            openFileDialog.ShowDialog();
            txtFile.Text = openFileDialog.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var fileStream = new FileStream(txtFile.Text, FileMode.Open, FileAccess.Read);
            string msg = _feature.ImportRegister(fileStream);
            if (msg.Length > 0)
            {
                MessageBox.Show(this, msg, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, Constants.REQUEST_IMPORT, Constants.SYSTEM_INFO, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
