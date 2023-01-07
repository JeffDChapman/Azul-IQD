using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Data.Common;

namespace AzulIQD
{
    public partial class JoinForm : Form
    {
        private struct queryTabInfo 
        {
            public string TableName;
            public string Alias;
            public string JoinType;
            public string JoiningTo;
            public List<string> MyJoinColumns;
            public List<string> ToJoinColumns;
            public List<string> showColumns;
        }

        List<queryTabInfo> queryParms = new List<queryTabInfo>();
        public TableDisplayer frmTabDispParent;
        public List<String> passedJoinedTabs = new List<string>();
        private object TabThatNeedsCols;
        private string getColsSQL;
        private IDbConnection DBConnection;
        private bool RemoteConx;
        private DataTable colListing = new DataTable();
        private int colCounter;
        private ColumnChooser myCC;
        private string LeftSideJoinTab;
        private string RightSideJoinTab;
        private string saveJoinType;
        private SQLdisplayer mySQLform;
        private string builtSQLquery;
        private string bsqSelectClause;
        private string bsqFromClause;
        private string bsqExtrasClause;
        private QueryOptions getQO;
        private int qpIndex;
        
        public JoinForm(TableDisplayer parent) 
        {
            InitializeComponent();
            frmTabDispParent = parent;
            DBConnection = parent.DBConnection;
            RemoteConx = parent.RemoteConx;
        }

        public void JFinitialize()
        {
            frmTabDispParent.Hide();
            this.Top = frmTabDispParent.PlaceForms.topForm;
            this.Left = frmTabDispParent.PlaceForms.LeftForm;

            Application.DoEvents();

            bool firstObj = true;
            foreach (object OneTab in passedJoinedTabs)
            {
                if (firstObj)
                {
                    lbJoined.Items.Add(OneTab);
                    TabThatNeedsCols = OneTab;
                    firstObj = false;
                }
                else { lbUnjoined.Items.Add(OneTab); }
            }

            myCC = GetTheColumns();
           
            Application.DoEvents();
            myCC.ShowDialog();

            if (GetReturnedColumns().Count == 0)
            {
                // what happens if they didn't select any columns the first time?
            }

            var myqTinfo = new queryTabInfo();
            myqTinfo.TableName = TabThatNeedsCols.ToString();
            myqTinfo.showColumns = GetReturnedColumns();

            queryParms.Add(myqTinfo);
            myCC.Close();
         }

        private ColumnChooser GetTheColumns()
        {
            myCC = new ColumnChooser(TabThatNeedsCols.ToString(), this);

            //oldWayToGetCols();

            DbCommand command = (DbCommand)DBConnection.CreateCommand();
            command.CommandText = "select * from " + TabThatNeedsCols.ToString() + " where 1 = 0";
            command.CommandType = CommandType.Text;
            DbDataReader reader = command.ExecuteReader();

            DataTable colListing = reader.GetSchemaTable();
            myCC.lbColumnLister.Items.Clear();
            foreach (DataRow oneCol in colListing.Rows)
                { myCC.lbColumnLister.Items.Add(oneCol.ItemArray[0] + "\t" + oneCol.ItemArray[5] + "\t" + oneCol.ItemArray[2]); }

            return myCC;
        }

        private void oldWayToGetCols()
        {
            getColsSQL = "select column_name, data_type, character_maximum_length ";
            getColsSQL += "from information_schema.columns where (table_name = '";
            getColsSQL += TabThatNeedsCols.ToString() + "')";
            colListing.Clear();
            IDbCommand cmd = DBConnection.CreateCommand();
            cmd.CommandText = getColsSQL;
            cmd.CommandType = CommandType.Text;
            int uc1; int uc2; int uc3;
            if (RemoteConx)
            {
                SqlDataAdapter sda = new SqlDataAdapter((SqlCommand)cmd);
                colCounter = sda.Fill(colListing);
                uc1 = 0; uc2 = 1; uc3 = 2;
            }
            else
            {
                OleDbConnection myOleDB = (OleDbConnection)DBConnection;
                colListing = myOleDB.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                    new Object[] { null, null, TabThatNeedsCols.ToString() });
                uc1 = 3; uc2 = 9; uc3 = 11;
            }

            myCC.lbColumnLister.Items.Clear();
            foreach (DataRow oneCol in colListing.Rows)
            {
                myCC.lbColumnLister.Items.Add(oneCol[uc1] + "\t" + oneCol[uc2] + "\t" + oneCol[uc3]);
            }
        }

        private ColumnChooser GetTheColumns(List<string> checkedColumns)
        {
            GetTheColumns();
            foreach (string oneCol in checkedColumns)
            {
                int Foundloc = myCC.lbColumnLister.FindStringExact(oneCol);
                myCC.lbColumnLister.SetItemChecked(Foundloc, true);
            }
            return myCC;
        }

        public void JFaddMoreTables()
        {
            foreach (object OneTab in passedJoinedTabs)
                { lbUnjoined.Items.Add(OneTab); }
        }

        private void lbJoined_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustJoinButtons();
        }

        private void lbUnjoined_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustJoinButtons();
        }

        private void btnLjoin_Click(object sender, EventArgs e)
        {
            JoinButtonLogic("Left Join");
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            JoinButtonLogic("Inner Join");
        }

        private void btnRjoin_Click(object sender, EventArgs e)
        {
            JoinButtonLogic("Right Join");
        }

        private void JoinButtonLogic(string JoinType)
        { 
            // fill the column textboxes with column info

            saveJoinType = JoinType;
            LeftSideJoinTab = lbJoined.CheckedItems[0].ToString();
            RightSideJoinTab = lbUnjoined.CheckedItems[0].ToString();
            queryTabInfo LeftTabInfo = getQTinfoFor(LeftSideJoinTab);
            List<string> LeftTabCols = LeftTabInfo.showColumns;
            lblJoinedTab.Text = LeftSideJoinTab;
            lblUnjoinedTab.Text = RightSideJoinTab;

            clbLeftCols.Items.Clear();
            foreach (string OneCol in LeftTabCols)
                 { clbLeftCols.Items.Add(OneCol); }

            TabThatNeedsCols = lbUnjoined.CheckedItems[0];
            myCC = GetTheColumns();
            clbRightCols.Items.Clear();
            foreach (object OneCol in myCC.lbColumnLister.Items)
                { clbRightCols.Items.Add(OneCol); }

            // auto check columns with same names

            this.gbColsJoin.Visible = true;
            this.Refresh();
            Application.DoEvents();
        }

        private void btnDoneJoinCs_Click(object sender, EventArgs e)
        {
            this.gbColsJoin.Visible = false;
            if (!GetColsToShowRight(myCC)) { return;  }
            Application.DoEvents();

            // store info to internal struct list

            var myqTinfo = new queryTabInfo();
            myqTinfo.TableName = TabThatNeedsCols.ToString();
            myqTinfo.showColumns = GetReturnedColumns();

            myqTinfo.JoinType = saveJoinType;
            myqTinfo.JoiningTo = lbJoined.CheckedItems[0].ToString();
            myqTinfo.MyJoinColumns = new List<string>();
            myqTinfo.ToJoinColumns = new List<string>();
            foreach (object OneCol in clbLeftCols.CheckedItems)
                { myqTinfo.MyJoinColumns.Add(OneCol.ToString()); }
            foreach (object OneCol in clbRightCols.CheckedItems)
                { myqTinfo.ToJoinColumns.Add(OneCol.ToString()); }

            queryParms.Add(myqTinfo);
            
            // move table over from unjoined to joined list and clear checkboxes

            lbUnjoined.Items.Remove(lbUnjoined.CheckedItems[0]);
            lbJoined.Items.Add(TabThatNeedsCols.ToString());
            lbJoined.ClearSelected();
            lbUnjoined.ClearSelected();
            while (lbJoined.CheckedIndices.Count > 0)
                { lbJoined.SetItemChecked(lbJoined.CheckedIndices[0], false); }

            AdjustJoinButtons();
            this.Show();
        }       
        
        private bool GetColsToShowRight(ColumnChooser myCC)
        {
            this.Hide();
            Application.DoEvents();
            myCC.ShowDialog();

            if (GetReturnedColumns().Count == 0)
            {
                UndoTheJoin();
                myCC.Close();
                return false;
            }

            var myqTinfo = new queryTabInfo();
            myqTinfo.TableName = TabThatNeedsCols.ToString();
            myqTinfo.showColumns = GetReturnedColumns();

            myCC.Close();
            return true;
        }

        private void UndoTheJoin()
        {
            lbJoined.ClearSelected();
            lbUnjoined.ClearSelected();
            while (lbJoined.CheckedIndices.Count > 0)
                { lbJoined.SetItemChecked(lbJoined.CheckedIndices[0], false); }
            while (lbUnjoined.CheckedIndices.Count > 0)
                { lbUnjoined.SetItemChecked(lbUnjoined.CheckedIndices[0], false); }
            AdjustJoinButtons();
        }

        private queryTabInfo getQTinfoFor(string TableToLookup)
        {
            qpIndex = 0;
            foreach (queryTabInfo QTinfo in queryParms)
            {
                if (QTinfo.TableName == TableToLookup) { return QTinfo; }
                qpIndex++;
            }
            return new queryTabInfo();
        }

        public List<string> GetReturnedColumns() 
        {
            List<string> ListofSelCols = new List<string>();
            foreach (object OneColumn in myCC.lbColumnLister.CheckedItems)
                { ListofSelCols.Add(OneColumn.ToString()); }
            return ListofSelCols;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            getQO = new QueryOptions();
            getQO.ShowDialog();
            BuildSQLstring();
            mySQLform = new SQLdisplayer(this);
            mySQLform.tbSQLstatement.Text = builtSQLquery;
            this.Hide();
            mySQLform.ShowDialog();
            Application.DoEvents();
            this.Show();
        }

        private void BuildSQLstring()
        {
            builtSQLquery = "";
            bsqSelectClause = "SELECT ";
            bsqFromClause = "\r\nFROM ";
            bsqExtrasClause = "\r\nWHERE (<add your criteria here>)\r\n-- ORDER BY <optionally add sort fields>";
            if (getQO.btnAlias.Checked) { BuildTableAliases();}

            if (getQO.btnDistinct.Checked) { bsqSelectClause += "DISTINCT "; }
            if (getQO.btnTop20.Checked) { bsqSelectClause += "TOP(20) "; }

            foreach(queryTabInfo oneTabInfo in queryParms)
            {
                foreach (string OneField in oneTabInfo.showColumns)
                    { bsqSelectClause += GetFieldName(oneTabInfo.TableName, oneTabInfo.Alias, OneField) + ", "; }
                if (oneTabInfo.JoinType != null) { bsqFromClause += oneTabInfo.JoinType.ToUpper() + " "; }
                bsqFromClause += oneTabInfo.TableName + " ";
                if (oneTabInfo.Alias != "") {bsqFromClause += "AS " + oneTabInfo.Alias + " ";}
                if (getQO.btnNolock.Checked) { bsqFromClause += "WITH(NOLOCK) "; }

                if (oneTabInfo.JoinType != null)
                {
                    bsqFromClause += "ON ";
                    for (int i = 0; i < oneTabInfo.MyJoinColumns.Count; i++)
                    {
                        bsqFromClause += GetFieldName(oneTabInfo.TableName, oneTabInfo.Alias, oneTabInfo.MyJoinColumns[i]);
                        bsqFromClause += " = ";
                        queryTabInfo ToTabInfo = getQTinfoFor(oneTabInfo.JoiningTo);
                        string toJoinAlias = ToTabInfo.Alias;
                        bsqFromClause += GetFieldName(oneTabInfo.JoiningTo, toJoinAlias, oneTabInfo.ToJoinColumns[i]) + " AND ";
                    }
                    bsqFromClause = bsqFromClause.Substring(0, bsqFromClause.Length - 4);
                }
            }

            bsqSelectClause = bsqSelectClause.Substring(0, bsqSelectClause.Length - 2);
            builtSQLquery = bsqSelectClause + bsqFromClause + bsqExtrasClause;
        }

        private string GetFieldName(string tabName, string Alias, string OneField)
        {
            string FieldName = OneField.Substring(0, OneField.IndexOf("\t"));
            if (Alias == "") { return tabName + "." + FieldName; }
                else { return Alias + "." + FieldName; }
        }

        private void BuildTableAliases()
        {
            InputName myLogicClass = new InputName();
            for (int i = 0; i < queryParms.Count; i++) 
            {
                queryTabInfo oneTabInfo = queryParms[i];
                string thisAlias = myLogicClass.SuggestAlias(oneTabInfo.TableName);
                if (thisAlias.Length == 1) { thisAlias = thisAlias.ToUpper(); }
                    else { thisAlias = thisAlias.ToLower(); }
                oneTabInfo.Alias = thisAlias;
                queryParms[i] = oneTabInfo;
            }
        }

        private void AdjustJoinButtons()
        {
            if ((lbJoined.CheckedItems.Count == 1) && (lbUnjoined.CheckedItems.Count == 1))
            {
                this.btnJoin.Enabled = true;
                this.btnLjoin.Enabled = true;
                this.btnRjoin.Enabled = true;
            }
            else
            {
                this.btnJoin.Enabled = false;
                this.btnLjoin.Enabled = false;
                this.btnRjoin.Enabled = false;
            }
            if (lbUnjoined.Items.Count == 0) { btnNext.Enabled = true; }
                else { btnNext.Enabled = false; }
            if (lbJoined.CheckedItems.Count == 1) { btnEdit.Enabled = true; }
                else { btnEdit.Enabled = false; }
        }

        private void clbLeftCols_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkColCounts();
        }

        private void clbRightCols_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkColCounts();
        }        
        
        private void checkColCounts()
        {
            int leftcount = clbLeftCols.CheckedItems.Count;
            int rightcount = clbRightCols.CheckedItems.Count;
            if ((leftcount == rightcount) && (leftcount > 0))
                {btnDoneJoinCs.Enabled = true;}
            else { btnDoneJoinCs.Enabled = false; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbUnjoined.Items.Clear();
            AdjustJoinButtons();
            this.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TabThatNeedsCols = lbJoined.CheckedItems[0];
            queryTabInfo myTabInfo = getQTinfoFor(TabThatNeedsCols.ToString());
            List<string> alreadyChecked = myTabInfo.showColumns;
            myCC = GetTheColumns(alreadyChecked);
            Application.DoEvents();
            myCC.ShowDialog();

            if (GetReturnedColumns().Count == 0)
            {
                // what happens if they deselect all the columns?
            }

            myTabInfo.showColumns = GetReturnedColumns();
            queryParms[qpIndex] = myTabInfo;
            myCC.Close();
        }

        private void JoinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.gbColsJoin.Visible)
            {
                this.gbColsJoin.Visible = false;
                UndoTheJoin();
                e.Cancel = true;
                return;
            }
            this.Hide();
            try { frmTabDispParent.Show(); }
                catch { }
            e.Cancel = true;
        }

    }
}
