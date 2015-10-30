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
    public partial class PublisherManagementForm : DevExpress.XtraEditors.XtraForm
    {
        List<PublisherDTO> lst = new List<PublisherDTO>();
        public PublisherManagementForm()
        {
            InitializeComponent();
            lst = (new PublisherBUS()).GetAllPublisher();
            grdPublisher.DataSource = lst;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PublisherBUS publisherBus = new PublisherBUS();
            string info = txtPublisher.Text;
            lst.Clear();
            lst.AddRange(publisherBus.SearchPublisher(info));
            grdPublisher.RefreshDataSource();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtPublisherID.Text = "";
            txtPublisherName.Text = "";
            txtPublisherName.Focus();
        }

        private void grvPublisher_Click(object sender, EventArgs e)
        {
            PublisherDTO publisherDTO = (PublisherDTO) grvPublisher.GetFocusedRow();
            txtPublisherID.Text = publisherDTO.PublisherId.ToString();
            txtPublisherName.Text = publisherDTO.PublisherName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resources.DELETE_PUBLISHER_CONFIRM, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PublisherBUS bus = new PublisherBUS();
                if (!txtPublisherID.Text.Equals("0"))
                {
                    if (String.IsNullOrEmpty(txtPublisherID.Text))
                    {
                        MessageBox.Show(Resources.DELETE_NONE_PUBLISHER);
                    }
                    else
                    {
                        PublisherDTO publisherDTO = bus.GetPublisherById(int.Parse(txtPublisherID.Text));
                        if (bus.DeletePublisher(publisherDTO) == 1)
                        {
                            MessageBox.Show(Resources.DELETE_PUBLISHER_SUCCESS);
                            lst.Remove(publisherDTO);
                            grdPublisher.RefreshDataSource();
                            txtPublisherID.Text = "";
                            txtPublisherName.Text = "";
                        }
                        else
                        {
                            MessageBox.Show(Resources.DELETE_PUBLISHER_FAIL);
                        }

                    }
                }
                else
                {
                    MessageBox.Show(Resources.DELETE_DEFAULT_PUBLISHER);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PublisherBUS bus = new PublisherBUS();
            if (String.IsNullOrEmpty(txtPublisherID.Text))
            {
                if (String.IsNullOrEmpty(txtPublisherName.Text))
                {
                    MessageBox.Show(Resources.ADD_NULL_PUBLISHER_NAME);
                }
                else
                {
                    PublisherDTO publisherDTO = new PublisherDTO()
                                                    {
                                                        PublisherName = txtPublisherName.Text,
                                                        CreatedDate = DateTime.Now,
                                                        UpdatedDate = DateTime.Now
                                                    };
                    if (bus.InsertPublisher(publisherDTO) == 1)
                    {
                        MessageBox.Show(Resources.ADD_PUBLISHER_SUCCESS);
                        lst.Add(publisherDTO);
                        grdPublisher.RefreshDataSource();
                    }
                    else
                    {
                        MessageBox.Show(Resources.ADD_PUBLISHER_FAIL);
                    }
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtPublisherName.Text))
                {
                    MessageBox.Show(Resources.ADD_NULL_PUBLISHER_NAME);
                }
                else
                {
                    PublisherDTO publisherDTO = (PublisherDTO)grvPublisher.GetFocusedRow();
                    publisherDTO.PublisherName = txtPublisherName.Text;
                    if (bus.UpdatePublisher(publisherDTO) == 1)
                    {
                        MessageBox.Show(Resources.UPDATE_PUBLISHER_SUCCESS);
                        grdPublisher.RefreshDataSource();
                    }
                    else
                    {
                        MessageBox.Show(Resources.UPDATE_PUBLISHER_FAIL);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}