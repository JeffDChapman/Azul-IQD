using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AzulIQD
{
    public partial class TableDisplayer : Form
    {

        #region Private variables 
        private string myConxString;
        private string AzureServer;
        private string myAzureDBName;
        private string myUserID;
        private string myPW;
        private string myDBtype;
        private bool firstTimeThru = true;
        private JoinForm myJF;
        private bool dbIsConnected;
        //private bool AzureConx = false;
        private bool testing = false;
        #endregion
        public IDbConnection DBConnection { get; set; }
        public struct FormLoc
        {
            public int topForm;
            public int LeftForm;
        }
        public FormLoc PlaceForms = new FormLoc();
        public bool RemoteConx = true;
        public TableDisplayer()
        {
            InitializeComponent();
        }

        private void TableDisplayer_Load(object sender, EventArgs e)
        {
            AzureServer = "";
            myAzureDBName = "";
            myUserID = "";
            myPW = "";

            //if (!testing) { lblDBname_Click(this, null); }

            PlaceForms.LeftForm = this.Left;
            PlaceForms.topForm = this.Top;
        }

        private void TableDisplayer_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false) { return; }

            this.Cursor = Cursors.WaitCursor;
            lblStillLoading.Visible = true;
            lbTableListing.Items.Clear();
            this.btnOK.Enabled = false;
            this.Refresh();
            Application.DoEvents();
            if (!dbIsConnected) { lblDBname_Click(this, null); }
            this.tmDisplay.Enabled = true;
        }

        private void tmDisplay_Tick(object sender, EventArgs e)
        {
            this.tmDisplay.Enabled = false;
            LoadTableList();
        }

        private void lblDBname_Click(object sender, EventArgs e)
        {
            DBconxGet GetNewDB = new DBconxGet();
            GetNewDB.tbServer.Text = AzureServer;
            GetNewDB.tbDatabase.Text = myAzureDBName;
            GetNewDB.tbLoginID.Text = myUserID;
            GetNewDB.tbPW.Text = myPW;
            GetNewDB.ShowDialog();

            AzureServer = GetNewDB.tbServer.Text;
            myAzureDBName = GetNewDB.tbDatabase.Text;
            myUserID = GetNewDB.tbLoginID.Text;
            myPW = GetNewDB.tbPW.Text;
            myDBtype = GetNewDB.tbDBtype.Text;
            if (testing)
            {
                string showSets = AzureServer + " " + myAzureDBName + " " +
                myUserID + " " + myPW + " " + myDBtype;
                MessageBox.Show(showSets, "Status");
            }

            if (myDBtype == "MS Access") 
            { 
                //AzureConx = false;
                RemoteConx = false;
            }
                else 
            { 
                //AzureConx = true;
                RemoteConx = true;
            }
            this.lblDBname.Text = "????";
        }

        private void LoadTableList()
        {
            ConnectToDatabase();

            if (!dbIsConnected)
            {
                this.Cursor = Cursors.Arrow;
                return; }

            DataTable t = new DataTable();
            if (RemoteConx)
                { SqlConnection useSQLcx = (SqlConnection)DBConnection;
                t = useSQLcx.GetSchema("Tables");
            }
            else 
                { OleDbConnection useSQLcx = (OleDbConnection)DBConnection;
                t = useSQLcx.GetSchema("Tables");
            }
            
            foreach (DataRow myTabrow in t.Rows)
            {
                string oneTable = myTabrow.ItemArray[2].ToString();
                if (oneTable == "database_firewall_rules") { continue; }
                lbTableListing.Items.Add(oneTable);
            }

            lblStillLoading.Visible = false;
            this.Cursor = Cursors.Arrow;
        }

        private void ConnectToDatabase()
        {
            this.Cursor = Cursors.WaitCursor;
            if (myDBtype == "MS Access")
            {
                myConxString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
                myConxString += AzureServer + "\\" + myAzureDBName + ";User Id=" + myUserID +
                    ";Jet OLEDB:Encrypt Database=True;Jet OLEDB:Database Password=" + myPW + ";";
            }
            else
                { nonAccessConx(); }

            // check if connected to the DB 
            if (DBConnection == null || !checkDBconnected())
            {
                try
                {
                    if (RemoteConx)
                        { DBConnection = new SqlConnection(myConxString); }
                    else 
                        { DBConnection = new OleDbConnection(myConxString); }
                    if (testing) { MessageBox.Show("Attempting DB Open", "Status"); }
                    DBConnection.Open();
                    dbIsConnected = true;
                    if (testing) { MessageBox.Show("DB Open was OK", "Status"); }
                    if (RemoteConx)
                        { this.lblDBname.Text = DBConnection.Database; }
                    else 
                        { this.lblDBname.Text = myAzureDBName; }
                }
                catch (Exception e)
                {
                    dbIsConnected = false;
                    this.Cursor = Cursors.Arrow;
                    MessageBox.Show("Unable to connect to Database", "Connect Error");
                    if (testing)
                    {
                        string innerErr = e.InnerException.Message.ToString();
                        string dbError = e.Message + Environment.NewLine + innerErr;
                        MessageBox.Show(dbError, "Connect Error");
                    }
                }
            }
        }

        private void nonAccessConx()
        {
            myConxString = "Server=";
            if (myDBtype == "MS Azure") { myConxString += "tcp:"; }
            myConxString += AzureServer;
            if (myDBtype == "MS Azure") { myConxString += ".database.windows.net,1433"; }

            myConxString += ";Initial Catalog=" + myAzureDBName;
            if (myUserID == "")
                { myConxString += ";Integrated Security=true"; }
            else
            {
                myConxString += ";Persist Security Info=False;User ID=";
                myConxString += myUserID + ";Password=" + myPW;
            }
            if (myDBtype == "MS Azure") { myConxString += ";MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False"; }
            myConxString += ";Connection Timeout=20;";

        }

        private bool checkDBconnected()
        {
            try
            {
                IDbConnection myTestCnx;
                // TODO: this needs that factory provider stuff...
                if (RemoteConx)
                     { myTestCnx = new SqlConnection(myConxString); }
                else
                     { myTestCnx = new OleDbConnection(myConxString); }
                myTestCnx.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void lbTableListing_Click(object sender, EventArgs e)
        {
            this.btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (firstTimeThru)
            {
                myJF = new JoinForm(this);
                foreach (object item in lbTableListing.CheckedItems)
                    {myJF.passedJoinedTabs.Add(item.ToString());}

                myJF.JFinitialize();
                myJF.Top = PlaceForms.topForm;
                myJF.Left = PlaceForms.LeftForm;     

                firstTimeThru = false;
            }
            else
            {
                myJF.passedJoinedTabs.Clear();
                foreach (object item in lbTableListing.CheckedItems)
                    { myJF.passedJoinedTabs.Add(item.ToString()); }
                myJF.JFaddMoreTables();

                this.Hide();
                myJF.Top = PlaceForms.topForm;
                myJF.Left = PlaceForms.LeftForm;
                Application.DoEvents();
                myJF.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (firstTimeThru)
            {
                this.Close();
                return;
            }
            this.Hide();
            myJF.Show();
        }

        private void TableDisplayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DBConnection.Close();
                DBConnection = null;
            }
            catch { }
            Application.Exit();
        }

        private void TableDisplayer_LocationChanged(object sender, EventArgs e)
        {
            PlaceForms.LeftForm = this.Left;
            PlaceForms.topForm = this.Top;
        }

    }
}
