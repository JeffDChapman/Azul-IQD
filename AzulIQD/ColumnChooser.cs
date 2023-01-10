using System;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColumnChooser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
