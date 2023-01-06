using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace AzulIQD
{
    public partial class DBconxGet : Form
    {
        public bool restoredDBinfo;
        public bool testing = false;
        public string DataProvider = "System.Data.OleDb";

        public DBconxGet()
        {
            InitializeComponent();
        }

        public void fillDBtypePulldown()
        {
            // only used in testing
            DataTable provTable = DbProviderFactories.GetFactoryClasses();
            cbKBDTypes.Items.Clear();
            foreach (DataRow provider in provTable.Rows)
            {
                cbKBDTypes.Items.Add(provider[2].ToString());
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int dbnLen = tbDatabase.Text.Length;
            if (tbDBtype.Text == "MS Access")
            {
                if ((dbnLen < 4) || (tbDatabase.Text.Substring(dbnLen - 4, 4) != ".mdb"))
                    { tbDatabase.Text += ".mdb"; }
            }

            this.Close();
        }

        private void DBconxGet_Activated(object sender, EventArgs e)
        {
            tbDBtype.Focus();
            if (restoredDBinfo)
            {
                cbUseAsDefault.Visible = false;
                tbPW.Focus();
            }
        }

        private void tbDBtype_Click(object sender, EventArgs e)
        {
            cbUseAsDefault.Visible = true;
            cbKBDTypes.Visible = true;
            cbKBDTypes.DroppedDown = true;
            tbDBtype.Visible = false;
            cbKBDTypes.Focus();
        }

        private void tbServer_Click(object sender, EventArgs e)
        {
            cbUseAsDefault.Visible = true;
        }

        private void tbDatabase_Click(object sender, EventArgs e)
        {
            cbUseAsDefault.Visible = true;
        }

        private void tbLoginID_Click(object sender, EventArgs e)
        {
            cbUseAsDefault.Visible = true;
        }

        private void cbKBDTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            tbDBtype.Text = cbKBDTypes.Text;
            tbDBtype.Visible = true;
            cbKBDTypes.Visible = false;

            switch (tbDBtype.Text)
            {
                case "MS Access":
                    MSAprovider();
                    break;
                case "System.Data.OleDb":
                    MSAprovider();
                    tbDBtype.Text = "MS Access"; 
                    break;
                case "MS SQL Server":
                    MSsqlProvider();
                    break;
                case "System.Data.SqlClient":
                    MSsqlProvider();
                    tbDBtype.Text = "MS SQL Server"; 
                    break;
                case "Azure SQL Server":
                    DataProvider = "System.Data.SqlClient";
                    lblServerOrPath.Text = "Server";
                    break;
                case "Oracle Server":
                    DataProvider = "System.Data.OracleClient";
                    lblServerOrPath.Text = "Server";
                    break;
            }

        }

        private void MSsqlProvider()
        {
            DataProvider = "System.Data.SqlClient";
            lblServerOrPath.Text = "Server";
            if (cbKBDTypes.SelectedText == "MS SQL Server")
            {
                tbServer.Text = Environment.MachineName.ToString() + "\\sqlexpress";
                tbDatabase.Text = "Enter DB Name";
                tbLoginID.Text = "";
            }
        }

        private void MSAprovider()
        {
            DataProvider = "System.Data.OleDb";
            lblServerOrPath.Text = "Path";
            tbServer.Text = ".";
            tbDatabase.Text = "";
            tbLoginID.Text = "Admin";
        }

        private void btnSelectDB_Click(object sender, EventArgs e)
        {
            openDBdialog.Filter = "MS Access (*.mdb)|*.mdb";
                openDBdialog.DefaultExt = "mdb";
                if (openDBdialog.ShowDialog(this) == DialogResult.OK)
                {
                    string dbFullName = openDBdialog.FileName;
                    int lastSlash = 0;
                    for (int i = dbFullName.Length - 1; i > 0;  i--)
                    {
                        if (dbFullName.Substring(i,1) == "\\")
                        {
                            lastSlash = i;
                            break;
                        }
                    }
                    tbServer.Text = dbFullName.Substring(0,lastSlash);
                    tbDatabase.Text = dbFullName.Substring(lastSlash + 1);
                }
        }

        private void tbDatabase_TextChanged(object sender, EventArgs e)
        {
            if (tbDatabase.Text != "") { btnOK.Enabled = true; }
        }

        private void DBconxGet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbDatabase.Text == "") { Application.Exit(); }
        }
    }
}
