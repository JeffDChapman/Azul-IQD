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
        public SQLdisplayer()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            tbSQLstatement.Copy();
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
            { tmrCopied.Enabled = false;
                blinkCounter = 0;
            }
        }
    }
}
