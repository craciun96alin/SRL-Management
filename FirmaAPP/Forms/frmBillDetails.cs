using System;
using AppContext = FirmaAPP.Common.AppContext;
using System.Collections.Generic;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using System.Drawing;
using System.IO;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmBillDetails : Form , IBillDetailsView
    {
        #region PrivateMembers
        private BillDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        #endregion
        #region Constructor
        public frmBillDetails()
        {
            InitializeComponent();
        }
        #endregion
        #region IBillDetailsViewMembers
        public int BillID { get; set; }
        public int OrderID { get; set; }
        private Bill _Bill;
        private byte[] _file;
        public Bill Bill
        {
            get
            {
                _Bill = new Bill
                {
                    BillID = this.BillID,
                    BillStatus = Enums.ParseEnum<Enums.BillStatus>(cbBillStatus.SelectedValue.ToString()),
                    BillName = tbName.Text,
                    Description = tbDescription.Text,
                    FileName = tbFile.Text,
                    BillDate = dateTimeBill.Value,
                    File = _file != null ? (tbFile.Text != string.Empty) ? _file : File.ReadAllBytes(tbFile.Text) : null
            };
                return _Bill;
            }
            set
            {
                BillID = value.BillID;
                cbBillStatus.SelectedIndex = (short)Enums.ParseEnum<Enums.BillStatus>(value.BillStatus.ToString());
                tbName.Text = value.BillName;
                tbDescription.Text = value.Description;
                tbFile.Text = value.FileName;
                dateTimeBill.Value = value.BillDate < dateTimeBill.MinDate ? DateTime.Now.Date : value.BillDate;
                _file = value.File;
            }
        }
        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public void AttachPresenter(BillDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Events
        private void frmBillDetails_Load(object sender, EventArgs e)
        {
            try
            {
                AppContext.ActiveForms.Add(this);
                //_presenter.Init();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            DialogResult resultFile = openFile.ShowDialog();
            if(resultFile == DialogResult.OK)
            {
                tbFile.Text = openFile.FileName;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.AddUpdateBill(Bill);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
                this.Close();
            }
        }
        #endregion
        #region public functions
        public void Init()
        {
            cbBillStatus.DataSource = Enum.GetNames(typeof(Common.Enums.BillStatus));
        }

        public void AttachMainForm(frmMainForm form)
        {
            _mainForm = form;
        }

        public void AttachParentForm(Form form)
        {
            _parentForm = form;
        }
        #endregion

        private void cbBillStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBillStatus.SelectedIndex == 1)
            {
                tbName.Text = "Fără factură";
                tbName.Enabled = false;
                btnAddBill.Enabled = false;
                tbFile.Text = "";
                tbDescription.Enabled = false;
            }
            else
            {
                tbName.Enabled = true;
                btnAddBill.Enabled = true;
                tbDescription.Enabled = true;
            }
        }

        private void tbFile_TextChanged(object sender, EventArgs e)
        {
            cbBillStatus.SelectedIndex = (short)Enums.ParseEnum<Enums.BillStatus>(Enums.BillStatus.Emisă.ToString()); ;
        }
    }
}
