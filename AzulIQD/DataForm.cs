using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AzulIQD
{
    public partial class DataForm : Form
    {
        private new SQLdisplayer ParentForm;
        private IDbConnection DBConnection;
        private bool RemoteConx;
        private IDbConnection myConnection;

        public DataForm()
        {
            InitializeComponent();
        }

        public DataForm(SQLdisplayer myParent)
        {
            InitializeComponent();
            ParentForm = myParent;
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            DBConnection = ParentForm.DBConnection;
            RemoteConx = ParentForm.RemoteConx;
            string connectionString = DBConnection.ConnectionString;
            string selectSql = ParentForm.tbSQLstatement.Text.Replace("\r\n", " ");

            // Create DataSet
            DataSet ds = new DataSet();

            // Create DataAdapter 
            if (RemoteConx)
                { myConnection = new SqlConnection(connectionString); }
            else
                { myConnection = new OleDbConnection(connectionString); }

            if (RemoteConx)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectSql, (SqlConnection)myConnection);
                adapter.Fill(ds, "mySQLData");
            }
            else
            { 
                OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, (OleDbConnection)myConnection);
                adapter.Fill(ds, "mySQLData");
            }

            // Create BindingSource
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            bs.DataMember = "mySQLData";

            // Bind to DataGridView
            myDataGrid.DataSource = bs;
        }
    }
}

