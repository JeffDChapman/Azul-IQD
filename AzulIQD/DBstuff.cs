using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Reflection;

namespace AzulIQD
{
    public partial class TableDisplayer 
    {
        #region Private Variables
        private string myServerType;
        //private string myServerName;
        //private string myKnowledgeDBname;
        //private string myUserID;
        //private string myPW;
        private bool RemoteConx = false;
        //private string myConxString;
        private IDbConnection myDBconx;
        //private bool dbIsConnected;
        private string activeDBname;
        private bool DBversionIsOk;
        private Version softwareVersion;
        private Version dBversion;
        private DBconxGet GetNewDB;
        private string RLockOption;
        #endregion

        private void setupBuiltinDBsettings()
        {
            myServerType = "MS Access";
            myServerName = ".";
            myKnowledgeDBname = "orGenta.mdb";
            myUserID = "Admin";
            myPW = "";
            DataProvider = "System.Data.OleDb";
            RemoteConx = false;
        }

        private void getDBconnxInfo()
        {
            getDBconnxInfo(false);
        }

        private void getDBconnxInfo(bool newFlag)
        {
            RetrievDBsetupInfo();
            GetNewDB.openDBdialog.CheckFileExists = true;
            GetNewDB.Text = "Connect to KB";
            if (newFlag) 
            {
                GetNewDB.openDBdialog.CheckFileExists = false;
                GetNewDB.tbDatabase.Text = "";
                GetNewDB.Text = "Create New KB";
            }
            
            GetNewDB.ShowDialog();

            myServerType = GetNewDB.tbDBtype.Text;
            myServerName = GetNewDB.tbServer.Text;
            myKnowledgeDBname = GetNewDB.tbDatabase.Text;
            myUserID = GetNewDB.tbLoginID.Text;
            myPW = GetNewDB.tbPW.Text;
            DataProvider = GetNewDB.DataProvider;

            if (GetNewDB.radioButton1.Checked) { RemoteConx = false; }
            else { RemoteConx = true; }

            if (GetNewDB.cbUseAsDefault.Checked)
            {
                RegistryKey ThisUser = Registry.CurrentUser;
                SaveDefaultDBtoRegistry(ThisUser);
            }

        }

        private void RetrievDBsetupInfo()
        {
            //GetNewDB = new DBconxGet();
            //GetNewDB.tbDBtype.Text = myServerType;
            //GetNewDB.tbServer.Text = myServerName;
            //GetNewDB.tbDatabase.Text = myKnowledgeDBname;
            //GetNewDB.tbLoginID.Text = myUserID;
            //GetNewDB.tbPW.Text = myPW;
            //GetNewDB.testing = testing;
            //for (int j = 0; j < GetNewDB.cbKBDTypes.Items.Count; j++)
            //{
            //    if (GetNewDB.cbKBDTypes.Items[j].ToString() == myServerType)
            //    { GetNewDB.cbKBDTypes.SelectedIndex = j; }
            //}

            //if (testing) { GetNewDB.fillDBtypePulldown(); }
            //if (RemoteConx)
            //{
            //    GetNewDB.radioButton1.Checked = false;
            //    GetNewDB.radioButton2.Checked = true;
            //}
            //else
            //{
            //    GetNewDB.radioButton1.Checked = true;
            //    GetNewDB.radioButton2.Checked = false;
            //}
            //GetNewDB.restoredDBinfo = restoredDBinfo;
        }

        private void SaveDefaultDBtoRegistry(RegistryKey ThisUser)
        {
            RegistryKey DBsettings = ThisUser.CreateSubKey("Software\\orGenta\\DBsettings");
            if (RemoteConx)
            {
                DBsettings.SetValue("RemoteConx", "1");
            }
            else
            {
                DBsettings.SetValue("RemoteConx", "0");
            }
            DBsettings.SetValue("ServerType", myServerType);
            DBsettings.SetValue("ServerName", myServerName);
            DBsettings.SetValue("DBname", myKnowledgeDBname);
            DBsettings.SetValue("dbLoginID", myUserID);
            DBsettings.SetValue("dataProv", DataProvider);
        }

        private bool BuildAndValidateDBconx(bool isSilent)
        {
            this.Cursor = Cursors.WaitCursor;
            if (myServerType == "MS Access")
            {
                myConxString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
                //myConxString += myServerName + "\\" + myKnowledgeDBname + ";User Id=Admin;Password=;";
                myConxString += myServerName + "\\" + myKnowledgeDBname + ";User Id=" + myUserID +
                    ";Jet OLEDB:Encrypt Database=True;Jet OLEDB:Database Password=" + myPW + ";";
            }
            else 
                { nonAccessConx(); }

            // Try to connect to the DB 

            if (testing)
            {
                //using (StreamWriter sw = File.AppendText(LogfileName))
                //{ sw.WriteLine("Using Conx String: " + myConxString); }

                //// TODO: also write out client I.P. address if using remote conx
            }

            dbIsConnected = false;
            {
                try
                {
                    DbProviderFactory myProviderFactory = DbProviderFactories.GetFactory(DataProvider);
                    myDBconx = myProviderFactory.CreateConnection();
                    myDBconx.ConnectionString = myConxString;

                    myDBconx.Open();
                    dbIsConnected = true;
                    activeDBname = myDBconx.Database;
                    if (myServerType == "MS Access")
                        { activeDBname = myKnowledgeDBname; }
                    if (RemoteConx)
                        { RLockOption = "WITH (NOLOCK) "; }
                    else
                        { RLockOption = ""; }
                }
                catch (Exception ex)
                {
                    dbIsConnected = false;
                    this.Cursor = Cursors.Arrow;
                    //if (testing) { myErrHandler.LogRTerror("BuildAndValidateDBconx", ex); }
                    if (!isSilent)
                    {
                        //MessageBox.Show("Unable to connect to Database", "Connect Error");
                        //if (optLongErrMessages)
                        //{ myErrHandler.ShowErrDetails("BuildAndValidateDBconx", ex, "DB Connection Error"); }
                    }
                }
            }

            //DBversionIsOk = false;
            //CheckDBversion();
            //if (!DBversionIsOk)
            //{
            //    try { myDBconx.Close(); }
            //    catch { }
            //    dbIsConnected = false;
            //}
            return dbIsConnected;
        }

        private void nonAccessConx()
        {
            myConxString = "Server=";
            if (RemoteConx) { myConxString += "tcp:"; }
            myConxString += myServerName;
            if (RemoteConx) { myConxString += ".database.windows.net,1433"; }

            // TODO: fix this... Azure is remote + /also/ pulldown for Azure DB

            myConxString += ";Initial Catalog=" + myKnowledgeDBname;
            if (myUserID == "")
            { myConxString += ";Integrated Security=true"; }
            else
            {
                myConxString += ";Persist Security Info=False;User ID=";
                myConxString += myUserID + ";Password=" + myPW;
            }
            if (RemoteConx) { myConxString += ";MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False"; }
            myConxString += ";Connection Timeout=20;";
        }

        private void CheckDBversion()
        {
            softwareVersion = Assembly.GetExecutingAssembly().GetName().Version;
            if (testing)
            {
                //using (StreamWriter sw = File.AppendText(LogfileName))
                //{ sw.WriteLine("Software Version: {0}", softwareVersion.ToString()); }
            }
            if (!dbIsConnected) { return; }

            string GetItemCmd = "SELECT ParameterValue FROM Sysvars " + RLockOption +
                "WHERE ParameterName = 'Database Version'";
            IDbCommand cmd = myDBconx.CreateCommand();

            cmd.CommandText = GetItemCmd;
            try
            {
                string SoftwareKeyRetd = cmd.ExecuteScalar().ToString();
                dBversion = new Version(SoftwareKeyRetd);
            }
            catch
            {
                MessageBox.Show(this, "Invalid Database Version for orGenta 2.0");
                return;
            }


            if (testing)
            {
                //using (StreamWriter sw = File.AppendText(LogfileName))
                //{
                //    sw.WriteLine("Database Version: {0}", dBversion.ToString());
                //    sw.WriteLine("Data Provider: {0}", DataProvider);
                //}
            }

            if (softwareVersion.CompareTo(dBversion) < 0)
            {
                string updMsg = "Please upgrade orGenta to " + dBversion.ToString();
                MessageBox.Show(this, updMsg);
                return;
            }
            if (dBversion.Major != softwareVersion.Major)
            {
                MessageBox.Show(this, "Invalid Database Version for orGenta 2.0");
                return;
            }
            DBversionIsOk = true;
        }

    }
}
