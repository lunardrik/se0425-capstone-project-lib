using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DemoLib
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            
        }

        private void ribbon_TabIndexChanged(object sender, EventArgs e)
        {
            //clientPanel = new DevExpress.XtraEditors.PanelControl();
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            //clientPanel = new DevExpress.XtraEditors.PanelControl();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            BookRentalManagementForm rental = new BookRentalManagementForm();

            rental.MdiParent = this;

            rental.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            BookInfoForm info = new BookInfoForm();
            info.MdiParent = this;
            info.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserManagementForm user = new UserManagementForm();
            user.MdiParent = this;
            user.Show();
        }        
    }
}