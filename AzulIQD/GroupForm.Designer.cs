namespace AzulIQD
{
    partial class GroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.gvFieldSummaries = new System.Windows.Forms.DataGridView();
            this.colFieldDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFieldOptions = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvFieldSummaries)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(526, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvFieldSummaries
            // 
            this.gvFieldSummaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvFieldSummaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFieldSummaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFieldDesc,
            this.colFieldOptions});
            this.gvFieldSummaries.Location = new System.Drawing.Point(13, 13);
            this.gvFieldSummaries.Name = "gvFieldSummaries";
            this.gvFieldSummaries.RowHeadersWidth = 30;
            this.gvFieldSummaries.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gvFieldSummaries.RowTemplate.Height = 28;
            this.gvFieldSummaries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvFieldSummaries.Size = new System.Drawing.Size(614, 417);
            this.gvFieldSummaries.TabIndex = 1;
            // 
            // colFieldDesc
            // 
            this.colFieldDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFieldDesc.HeaderText = "Field Name";
            this.colFieldDesc.MinimumWidth = 8;
            this.colFieldDesc.Name = "colFieldDesc";
            this.colFieldDesc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colFieldOptions
            // 
            this.colFieldOptions.HeaderText = "Summary";
            this.colFieldOptions.Items.AddRange(new object[] {
            "",
            "Group By",
            "Max",
            "Min",
            "Sum",
            "Count",
            "Avg"});
            this.colFieldOptions.MinimumWidth = 8;
            this.colFieldOptions.Name = "colFieldOptions";
            this.colFieldOptions.Width = 150;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 497);
            this.Controls.Add(this.gvFieldSummaries);
            this.Controls.Add(this.button1);
            this.Name = "GroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Select Groups and Summary Functions";
            ((System.ComponentModel.ISupportInitialize)(this.gvFieldSummaries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView gvFieldSummaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldDesc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colFieldOptions;
    }
}