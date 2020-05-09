using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzulIQD
{
    public partial class InputName : Form
    {
        private string tableToAlias;

        public InputName()
        {
            InitializeComponent();
        }

        private void btnAlias_Click(object sender, EventArgs e)
        {
            tableToAlias = tbTableName.Text;
            lblAliasOut.Text = SuggestAlias(tableToAlias);
         }

    }
}
