﻿using System;
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
    public partial class ColumnChooser : Form
    {
        JoinForm callingJoinForm;
        public ColumnChooser(string TableToUse, JoinForm parent)
        {
            InitializeComponent();
            callingJoinForm = parent;
            tbTableName.Text = TableToUse;
            this.Top = parent.frmTabDispParent.PlaceForms.topForm;
            this.Left = parent.frmTabDispParent.PlaceForms.LeftForm;
            this.Refresh();
        }

        private void lbColumnLister_Click(object sender, EventArgs e)
        {
            this.btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            callingJoinForm.Show();
        }
    }
}
