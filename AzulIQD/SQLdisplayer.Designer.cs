namespace AzulIQD
{
    partial class SQLdisplayer
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
            this.components = new System.ComponentModel.Container();
            this.tbSQLstatement = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblTextCopied = new System.Windows.Forms.Label();
            this.tmrCopied = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbSQLstatement
            // 
            this.tbSQLstatement.AcceptsReturn = true;
            this.tbSQLstatement.AcceptsTab = true;
            this.tbSQLstatement.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSQLstatement.Location = new System.Drawing.Point(25, 34);
            this.tbSQLstatement.Multiline = true;
            this.tbSQLstatement.Name = "tbSQLstatement";
            this.tbSQLstatement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSQLstatement.Size = new System.Drawing.Size(836, 367);
            this.tbSQLstatement.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(727, 423);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(134, 39);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblTextCopied
            // 
            this.lblTextCopied.AutoSize = true;
            this.lblTextCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextCopied.Location = new System.Drawing.Point(268, 428);
            this.lblTextCopied.Name = "lblTextCopied";
            this.lblTextCopied.Size = new System.Drawing.Size(350, 25);
            this.lblTextCopied.TabIndex = 2;
            this.lblTextCopied.Text = "SQL has been copied to your clipboard";
            this.lblTextCopied.Visible = false;
            // 
            // tmrCopied
            // 
            this.tmrCopied.Interval = 300;
            this.tmrCopied.Tick += new System.EventHandler(this.tmrCopied_Tick);
            // 
            // SQLdisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 480);
            this.Controls.Add(this.lblTextCopied);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbSQLstatement);
            this.Name = "SQLdisplayer";
            this.Text = "SQL Statement Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbSQLstatement;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblTextCopied;
        private System.Windows.Forms.Timer tmrCopied;

    }
}