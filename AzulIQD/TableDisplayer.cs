using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzulIQD
{
    public partial class TableDisplayer : Form
    {
        public struct FormLoc
        {
            public int topForm;
            public int LeftForm;
        }
        private string myConxString;
        private string AzureServer;
        private string myAzureDBName;
        private string myUserID;
        private string myPW;
        private bool firstTimeThru = true;
        private JoinForm myJF;
        private bool dbIsConnected;
        private bool AzureConx = false;
        private bool testing = true;
        public SqlConnection DBConnection { get; set; }
        public FormLoc PlaceForms = new FormLoc();

        public TableDisplayer()
        {
            InitializeComponent();
        }

        private void TableDisplayer_Load(object sender, EventArgs e)
        {
            AzureServer = "jeffcultra\\sqlexpress";
            myAzureDBName = "AutomationDB";
            myUserID = "";
            myPW = "";

            if (!testing) { lblDBname_Click(this, null); }

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
            GetNewDB.tbServier.Text = AzureServer;
            GetNewDB.tbDatabase.Text = myAzureDBName;
            GetNewDB.tbLoginID.Text = myUserID;
            GetNewDB.tbPW.Text = myPW;
            GetNewDB.ShowDialog();

            AzureServer = GetNewDB.tbServier.Text;
            myAzureDBName = GetNewDB.tbDatabase.Text;
            myUserID = GetNewDB.tbLoginID.Text;
            myPW = GetNewDB.tbPW.Text;
            if (GetNewDB.radioButton1.Checked) { AzureConx = true;  }
                else { AzureConx = false; }
            this.lblDBname.Text = "????";

            TableDisplayer_VisibleChanged(this, null);
        }        
        
        private void LoadTableList()
        {
            ConnectToAzure();

            if (!dbIsConnected) 
            {
                this.Cursor = Cursors.Arrow;
                return; }

            DataTable t = DBConnection.GetSchema("Tables");
            foreach (DataRow myTabrow in t.Rows)
            {
                string oneTable = myTabrow.ItemArray[2].ToString();
                if (oneTable == "database_firewall_rules") { continue; }
                lbTableListing.Items.Add(oneTable);
            }

            lblStillLoading.Visible = false;
            this.Cursor = Cursors.Arrow;
        }

        private void ConnectToAzure()
        {
            this.Cursor = Cursors.WaitCursor;
            myConxString = "Server=";
            if (AzureConx) { myConxString += "tcp:"; }
            myConxString += AzureServer;
            if (AzureConx) { myConxString += ".database.windows.net,1433"; }
            myConxString += ";Initial Catalog=" + myAzureDBName;
            if (myUserID == "")
                { myConxString += ";Integrated Security=true"; }
            else
            {
            myConxString += ";Persist Security Info=False;User ID=";
            myConxString += myUserID + ";Password=" + myPW;
            }
            if (AzureConx) {myConxString += ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False";}
            myConxString += ";Connection Timeout=3;";

            // TODO: fix this mess. Maybe use a string.replace or add a DB connx object to form
            // also regular SQL connx still doesn't work
           
            // check if connected to the DB 
            if (DBConnection == null || !checkDBconnected())
            {
                try
                {
                    DBConnection = new SqlConnection(myConxString);
                    DBConnection.Open();
                    dbIsConnected = true;
                    this.lblDBname.Text = DBConnection.Database;
                }
                catch
                {
                    dbIsConnected = false;
                    this.Cursor = Cursors.Arrow;
                    MessageBox.Show("Unable to connect to Azure","Connect Error");
                }
            }
        }

        private bool checkDBconnected()
        {
            using (var l_oConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch (SqlException)
                { return false; }
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
