namespace AzulIQD
{
    partial class DBconxGet
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
            this.lblServerOrPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.tbLoginID = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbDBtype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUseAsDefault = new System.Windows.Forms.CheckBox();
            this.cbKBDTypes = new System.Windows.Forms.ComboBox();
            this.btnSelectDB = new System.Windows.Forms.Button();
            this.openDBdialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblServerOrPath
            // 
            this.lblServerOrPath.AutoSize = true;
            this.lblServerOrPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerOrPath.Location = new System.Drawing.Point(45, 82);
            this.lblServerOrPath.Name = "lblServerOrPath";
            this.lblServerOrPath.Size = new System.Drawing.Size(76, 25);
            this.lblServerOrPath.TabIndex = 0;
            this.lblServerOrPath.Text = "Server:";
            this.lblServerOrPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(343, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 49);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Next >>";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbServer
            // 
            this.tbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServer.Location = new System.Drawing.Point(141, 81);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(311, 30);
            this.tbServer.TabIndex = 5;
            this.tbServer.Click += new System.EventHandler(this.tbServer_Click);
            // 
            // tbDatabase
            // 
            this.tbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatabase.Location = new System.Drawing.Point(141, 131);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(280, 30);
            this.tbDatabase.TabIndex = 6;
            this.tbDatabase.Click += new System.EventHandler(this.tbDatabase_Click);
            this.tbDatabase.TextChanged += new System.EventHandler(this.tbDatabase_TextChanged);
            // 
            // tbLoginID
            // 
            this.tbLoginID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginID.Location = new System.Drawing.Point(141, 181);
            this.tbLoginID.Name = "tbLoginID";
            this.tbLoginID.Size = new System.Drawing.Size(311, 30);
            this.tbLoginID.TabIndex = 7;
            this.tbLoginID.Click += new System.EventHandler(this.tbLoginID_Click);
            // 
            // tbPW
            // 
            this.tbPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPW.Location = new System.Drawing.Point(141, 231);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(311, 30);
            this.tbPW.TabIndex = 8;
            // 
            // tbDBtype
            // 
            this.tbDBtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDBtype.Location = new System.Drawing.Point(141, 28);
            this.tbDBtype.Name = "tbDBtype";
            this.tbDBtype.Size = new System.Drawing.Size(311, 30);
            this.tbDBtype.TabIndex = 10;
            this.tbDBtype.Text = "(select a KB source)";
            this.tbDBtype.Click += new System.EventHandler(this.tbDBtype_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "DB Type:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbUseAsDefault
            // 
            this.cbUseAsDefault.AutoSize = true;
            this.cbUseAsDefault.Location = new System.Drawing.Point(141, 302);
            this.cbUseAsDefault.Name = "cbUseAsDefault";
            this.cbUseAsDefault.Size = new System.Drawing.Size(143, 24);
            this.cbUseAsDefault.TabIndex = 12;
            this.cbUseAsDefault.Text = "Use As Default";
            this.cbUseAsDefault.UseVisualStyleBackColor = true;
            // 
            // cbKBDTypes
            // 
            this.cbKBDTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKBDTypes.FormattingEnabled = true;
            this.cbKBDTypes.Items.AddRange(new object[] {
            "(select a KB source)",
            "MS Access",
            "MS SQL Server",
            "MS Azure"});
            this.cbKBDTypes.Location = new System.Drawing.Point(141, 27);
            this.cbKBDTypes.Name = "cbKBDTypes";
            this.cbKBDTypes.Size = new System.Drawing.Size(311, 33);
            this.cbKBDTypes.TabIndex = 13;
            this.cbKBDTypes.Text = "MS Access";
            this.cbKBDTypes.Visible = false;
            this.cbKBDTypes.SelectedValueChanged += new System.EventHandler(this.cbKBDTypes_SelectedValueChanged);
            // 
            // btnSelectDB
            // 
            this.btnSelectDB.Location = new System.Drawing.Point(421, 133);
            this.btnSelectDB.Name = "btnSelectDB";
            this.btnSelectDB.Size = new System.Drawing.Size(36, 34);
            this.btnSelectDB.TabIndex = 14;
            this.btnSelectDB.Text = "...";
            this.btnSelectDB.UseVisualStyleBackColor = true;
            this.btnSelectDB.Click += new System.EventHandler(this.btnSelectDB_Click);
            // 
            // DBconxGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 352);
            this.Controls.Add(this.btnSelectDB);
            this.Controls.Add(this.tbDBtype);
            this.Controls.Add(this.cbKBDTypes);
            this.Controls.Add(this.cbUseAsDefault);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.tbLoginID);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblServerOrPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DBconxGet";
            this.Text = "Connect to a Database";
            this.Activated += new System.EventHandler(this.DBconxGet_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBconxGet_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerOrPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox tbServer;
        public System.Windows.Forms.TextBox tbDatabase;
        public System.Windows.Forms.TextBox tbLoginID;
        public System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbDBtype;
        public System.Windows.Forms.CheckBox cbUseAsDefault;
        private System.Windows.Forms.Button btnSelectDB;
        public System.Windows.Forms.OpenFileDialog openDBdialog;
        public System.Windows.Forms.ComboBox cbKBDTypes;
    }
}