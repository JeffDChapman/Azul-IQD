using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AzulIQD
{
    public partial class SQLdisplayer : Form
    {
        private int blinkCounter = 0;
        private JoinForm myJF;
        public IDbConnection DBConnection;
        public bool RemoteConx;

        public SQLdisplayer(JoinForm parent)
        {
            InitializeComponent();
            myJF = parent;
            this.Top = parent.frmTabDispParent.PlaceForms.topForm;
            this.Left = parent.frmTabDispParent.PlaceForms.LeftForm;
            DBConnection = parent.DBConnection;
            RemoteConx = parent.RemoteConx;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            tbSQLstatement.Copy();
            btnExit.Visible = false;
            tmrCopied.Enabled = true;
        }

        private void tmrCopied_Tick(object sender, EventArgs e)
        {
            blinkCounter++;

            if (lblTextCopied.Visible == true)
                { lblTextCopied.Visible = false; }
            else
                { lblTextCopied.Visible = true; }
            this.Refresh();

            if (blinkCounter > 5) 
            { 
                tmrCopied.Enabled = false;
                btnExit.Visible = true;
                blinkCounter = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            myJF.Close();
            myJF.frmTabDispParent.Close();
            this.Close();
            Application.Exit();
        }

        private void btnRunSql_Click(object sender, EventArgs e)
        {
            DataForm myRunData = new DataForm(this);
            myRunData.ShowDialog();
        }
    }
}
