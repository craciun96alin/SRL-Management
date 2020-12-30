using AppContext = FirmaAPP.Common.AppContext;
using System;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using System.Drawing;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }
        public void ShowMessage(string message)
        {
            tbInfo.AppendText(DateTime.Now.ToString()+": ", Color.Navy);
            string[] messageParts = message.Split(':');
            if (messageParts[0] == AppTranslations.Warning)
            {
                tbInfo.AppendText(messageParts[0] + ": ", Color.DarkOrange);
                tbInfo.AppendText(messageParts[1] + "\n");
            }
            else if (messageParts[0] == AppTranslations.Error)
            {
                tbInfo.AppendText(messageParts[0] +": ", Color.Red);
                tbInfo.AppendText(messageParts[1] + "\n");
            }
            else if (messageParts[0] == AppTranslations.Succes)
            {
                tbInfo.AppendText(messageParts[0] + ": ", Color.Green);
                tbInfo.AppendText(messageParts[1] + "\n");
            }
            else
            {
                tbInfo.AppendText(AppTranslations.ErrorInfoBox, Color.Red);
                tbInfo.AppendText(message + "\n");
            }
        }

        #region Events
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            this.Padding = new Padding(0, 0, 0, 0);
            pnlSubMenuOrders.Height -= pnlSubMenuSellingOrders.Height;
        }

        private void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbInfo.Text = string.Empty;
        }
        private void btnSupplies_Click(object sender, EventArgs e)
        {
            pnlSubMenuSupplies.Visible = !pnlSubMenuSupplies.Visible;
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            pnlSubMenuOrders.Visible = !pnlSubMenuOrders.Visible;
        }

        private void btnTshirt_Click(object sender, EventArgs e)
        {
            frmTshirtsList childForm = new frmTshirtsList();
            TshirtListPresenter tshirtListPresenter = new TshirtListPresenter(childForm);
            childForm.AttachPresenter(tshirtListPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }
        private void btn3D_Click(object sender, EventArgs e)
        {
            pnlSubMenu3D.Visible = !pnlSubMenu3D.Visible;
        }
        // Minimized forms will be visible no matter what
        private void frmMainForm_LayoutChange(object sender, LayoutEventArgs e)
        {
            foreach (Form form in AppContext.ActiveForms)
            {
                if (form.WindowState == FormWindowState.Minimized)
                    form.BringToFront();
            }
        }
        private void btn3DPrint_Click(object sender, EventArgs e)
        {
            frm3DPrintsList childForm = new frm3DPrintsList();
            _3DPrintListPresenter filamentListPresenter = new _3DPrintListPresenter(childForm);
            childForm.AttachPresenter(filamentListPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }
        private void btn3DDesign_Click(object sender, EventArgs e)
        {
            frm3DDesignsList childForm = new frm3DDesignsList();
            _3DDesignListPresenter filamentListPresenter = new _3DDesignListPresenter(childForm);
            childForm.AttachPresenter(filamentListPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }
        private void BtnFilament_Click(object sender, EventArgs e)
        {
                frmFilamentList childForm = new frmFilamentList();
                FilamentListPresenter filamentListPresenter = new FilamentListPresenter(childForm);
                childForm.AttachPresenter(filamentListPresenter);
                childForm.AttachMainForm(this);
                OpenChildForm(childForm);
        }

        private void btnVinyl_Click(object sender, EventArgs e)
        {
            frmVinylList childForm = new frmVinylList();
            VinylListPresenter vinylListPresenter = new VinylListPresenter(childForm);
            childForm.AttachPresenter(vinylListPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }

        private void btnOtherPurchase_Click(object sender, EventArgs e)
        {
            frmOtherPurchaseList childForm = new frmOtherPurchaseList();
            OtherPurchaseListPresenter otherPurchaseListPresenter = new OtherPurchaseListPresenter(childForm);
            childForm.AttachPresenter(otherPurchaseListPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }

        private void btnProvidersCustomers_Click(object sender, EventArgs e)
        {
            pnlSubMenuProvidersCustomers.Visible = !pnlSubMenuProvidersCustomers.Visible;
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            frmProviderList childForm = new frmProviderList();
            ProviderListPresenter providerListPresenter = new ProviderListPresenter(childForm);
            childForm.AttachPresenter(providerListPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomersList childForm = new frmCustomersList();
            CustomerListPresenter providerListPresenter = new CustomerListPresenter(childForm);
            childForm.AttachPresenter(providerListPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }

        private void btnOrderForBuy_Click(object sender, EventArgs e)
        {
            frmOrderAcquisitionsList childForm = new frmOrderAcquisitionsList();
            OrderAcquisitionListPresenter acquisitionsListPresenter = new OrderAcquisitionListPresenter(childForm);
            childForm.AttachPresenter(acquisitionsListPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }

        private void btnOrderForSell_Click(object sender, EventArgs e)
        {
            pnlSubMenuSellingOrders.Visible = !pnlSubMenuSellingOrders.Visible;
            if (pnlSubMenuSellingOrders.Visible)
            {
                pnlSubMenuOrders.Height += pnlSubMenuSellingOrders.Height;
            }
            else
            {
                pnlSubMenuOrders.Height -= pnlSubMenuSellingOrders.Height;
            }
        }
        private void btnSellingTshirtOrders_Click(object sender, EventArgs e)
        {
            frmOrderTshirtsSalesList childForm = new frmOrderTshirtsSalesList();
            OrderTshirtsSalesListPresenter salesListPresenter = new OrderTshirtsSalesListPresenter(childForm);
            childForm.AttachPresenter(salesListPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }
        private void btnSelling3DOrders_Click(object sender, EventArgs e)
        {
            frmOrder3DSalesList childForm = new frmOrder3DSalesList();
            Order3DSalesListPresenter salesListPresenter = new Order3DSalesListPresenter(childForm);
            childForm.AttachPresenter(salesListPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }

        private void panelChildForms_Resize(object sender, EventArgs e)
        {
            foreach (Form form in AppContext.ActiveForms)
            {
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.WindowState = FormWindowState.Minimized;
                }
            }
        }

        #region Settings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings childForm = new frmSettings();
            AppSettingsPresenter AppSettingsPresenter = new AppSettingsPresenter(childForm);
            BusinessDetailsPresenter businessDetailsPresenter = new BusinessDetailsPresenter(childForm);
            childForm.AttachPresenter(AppSettingsPresenter);
            childForm.AttachBusinessDetailsPresenter(businessDetailsPresenter);
            childForm.AttachMainForm(this);
            OpenChildForm(childForm);
        }
        #endregion
        #endregion

        private void OpenChildForm(Form childForm)
        {
            try
            {
                if (!AppContext.ActiveForms.Exists(f => f.Name == childForm.Name))
                {
                    childForm.TopLevel = false;
                    panelChildForms.Controls.Add(childForm);
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.BringToFront();
                    MinimizeOpenedForms();
                    childForm.Show();
                }
                else
                    MessageBox.Show("Nu poți deschide aceeași formă de mai multe ori.", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }

        }

        private void MinimizeOpenedForms()
        {
            foreach( Form form in AppContext.ActiveForms)
            {
                form.WindowState = FormWindowState.Minimized;
                form.BringToFront();
            }
        }
    }
}
