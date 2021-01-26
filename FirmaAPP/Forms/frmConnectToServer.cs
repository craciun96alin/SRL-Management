using FirmaAPP.Common;
using System;
using System.Windows.Forms;
using AppContext = FirmaAPP.Common.AppContext;

namespace FirmaAPP
{
    public partial class frmConnectToServer : Form
    {
        AppHelper.ConnectionString cn = new AppHelper.ConnectionString();

        public frmConnectToServer()
        {
            InitializeComponent();
        }

        private void frmConnectToServer_Load(object sender, EventArgs e)
        {
            txtServer.Text = string.Format(@"{0}\SQLEXPRESS", Environment.MachineName.ToString());

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtServer.Text != string.Empty && txtDatabaseName.Text != string.Empty)
            {



                string connectionString =
          string.Format("Data Source = {0}; Initial Catalog = {1};User ID = {2}; Password = {3}; Trusted_Connection=True;",
          txtServer.Text, txtDatabaseName.Text, txtUserName.Text, txtPassword.Text);
                string testServer =
    string.Format("Data Source = {0}; Initial Catalog = {1};User ID = {2}; Password = {3}; Trusted_Connection=True;",
    txtServer.Text, "", txtUserName.Text, txtPassword.Text);
                try
                {
                    SQLHelper sqlHelper = new SQLHelper(testServer);
                    if (sqlHelper.IsConnected)
                    {
                        cn.Set(connectionString);
                        MessageBox.Show("Succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        frmStartForm startForm = new frmStartForm();
                        startForm.Show();
                        this.Visible = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Me", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            else
            {
                MessageBox.Show("Verificati campurile mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frmConnectToServer_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
            SQLHelper sqlHelper = new SQLHelper(cn.Get());
            try
            {
                if (sqlHelper.IsConnected)
                {
                    frmStartForm startForm = new frmStartForm();
                    startForm.Show();
                }
            }
            catch (Exception ex)
            {
                this.Visible = true;
                MessageBox.Show("Aparent conectarea default nu poate fi accesata, va rugam completati manual datele!", "Me", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}

