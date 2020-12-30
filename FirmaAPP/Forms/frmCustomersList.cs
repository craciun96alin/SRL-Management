using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmCustomersList : Form, ICustomerListView
    {
        #region private members
        private CustomerListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region View

        public List<Customer> Customers
        {
            set
            {
                if (value == null) return;
                var slCustomers = new SortableList<Customer>(value);

                dataGridCustomer.DataSource = slCustomers;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "CustomerID",
                    "Orders"
                };
                if (dataGridCustomer.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridCustomer.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(CustomerListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Constructor
        public frmCustomersList()
        {
            InitializeComponent();
        }
        #endregion
        #region public functions
        public void AttachMainForm(frmMainForm form)
        {
            _mainForm = form;
        }
        #endregion
        #region Events
        private void frmCustomersList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }
        private void frmCustomersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails childForm = new frmCustomerDetails();
            CustomerDetailsPresenter presenter = new CustomerDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Customer = new Customer();
            childForm.ShowDialog();
        }

        private void lbEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                editCustomer((Customer)dataGridCustomer.Rows[dataGridCustomer.SelectedRows[0].Index].DataBoundItem);
            }
            catch(Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            editCustomer((Customer)dataGridCustomer.Rows[dataGridCustomer.SelectedRows[0].Index].DataBoundItem);
        }

        private void lbDeleteCustomer_Click(object sender, EventArgs e)
        {
            deleteCustomer();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            deleteCustomer();
        }
        private void dataGridCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editCustomer((Customer)dataGridCustomer.Rows[e.RowIndex].DataBoundItem);
        }
        #endregion
        #region private functions
        private void editCustomer(Customer customer)
        {
            if (VerifySelectedRowForEditing())
            {
                frmCustomerDetails childForm = new frmCustomerDetails();
                CustomerDetailsPresenter presenter = new CustomerDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                childForm.Customer = customer;
                childForm.ShowDialog();
            }
        }

        private void deleteCustomer()
        {
            try
            {
                List<Customer> customersToDelete = new List<Customer>();
                foreach (DataGridViewRow row in dataGridCustomer.SelectedRows)
                {
                    Customer customer = (Customer)dataGridCustomer.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(
                        AppTranslations.DeleteQuestion +
                        AppTranslations.Customer +
                        customer.LastName + " " + customer.FirstName + "?", 
                        AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                    if (result == DialogResult.Yes)
                    {
                        customersToDelete.Add(customer);
                    }
                }
                if (customersToDelete.Count > 0)
                    _presenter.DeleteCustomers(customersToDelete);
                else
                    throw new Exception(AppTranslations.WarningInfoBox+AppTranslations.SelectAtLeastOneRow);
                Refresh();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                Refresh();
            }
        }


        private bool VerifySelectedRowForEditing()
        {
            if (dataGridCustomer.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox+AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridCustomer.SelectedRows.Count > 1)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtMostOneRow);
                return false;
            }
            return true;
        }
        #endregion
        #region override functions
        public override void Refresh()
        {
            _presenter.Init();
        }
        #endregion
    }
}
