using FirmaAPP.Common;
using System;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frmConnectToServer : Form
    {
        //Strings are not in the AppTranslation because they should not set cultureInfo at this moment!
        private static string ServerAndDataBaseNameMandatory = "Fields that are mark with * are mandatory!";
        private static string VerifyConnection = "You must set the database name for the first login! If the problem persists please check the connection to the server!";
        private static string Warning = "Warning!";
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
                        //MessageBox.Show("Succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        frmStartForm startForm = new frmStartForm();
                        startForm.Show();
                        this.Visible = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(VerifyConnection, Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show(ServerAndDataBaseNameMandatory, Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show(VerifyConnection, Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

