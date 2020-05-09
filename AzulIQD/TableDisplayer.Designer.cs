namespace AzulIQD
{
    partial class TableDisplayer
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
            this.lbTableListing = new System.Windows.Forms.CheckedListBox();
            this.lblStillLoading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tmDisplay = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblDBname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTableListing
            // 
            this.lbTableListing.CheckOnClick = true;
            this.lbTableListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableListing.FormattingEnabled = true;
            this.lbTableListing.Location = new System.Drawing.Point(25, 69);
            this.lbTableListing.Name = "lbTableListing";
            this.lbTableListing.Size = new System.Drawing.Size(386, 579);
            this.lbTableListing.TabIndex = 0;
            this.lbTableListing.UseCompatibleTextRendering = true;
            this.lbTableListing.Click += new System.EventHandler(this.lbTableListing_Click);
            // 
            // lblStillLoading
            // 
            this.lblStillLoading.AutoSize = true;
            this.lblStillLoading.BackColor = System.Drawing.SystemColors.Window;
            this.lblStillLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStillLoading.Location = new System.Drawing.Point(108, 338);
            this.lblStillLoading.Name = "lblStillLoading";
            this.lblStillLoading.Size = new System.Drawing.Size(220, 26);
            this.lblStillLoading.TabIndex = 1;
            this.lblStillLoading.Text = "Loading DB Tables ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select tables to add...";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(434, 509);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 49);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Next >>";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(434, 577);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 49);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tmDisplay
            // 
            this.tmDisplay.Tick += new System.EventHandler(this.tmDisplay_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connected to...";
            // 
            // lblDBname
            // 
            this.lblDBname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDBname.Location = new System.Drawing.Point(433, 119);
            this.lblDBname.Name = "lblDBname";
            this.lblDBname.Size = new System.Drawing.Size(117, 20);
            this.lblDBname.TabIndex = 6;
            this.lblDBname.Text = "---";
            this.lblDBname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDBname.Click += new System.EventHandler(this.lblDBname_Click);
            // 
            // TableDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 660);
            this.Controls.Add(this.lblDBname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStillLoading);
            this.Controls.Add(this.lbTableListing);
            this.Name = "TableDisplayer";
            this.Text = " Add Tables";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableDisplayer_FormClosing);
            this.Load += new System.EventHandler(this.TableDisplayer_Load);
            this.VisibleChanged += new System.EventHandler(this.TableDisplayer_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lbTableListing;
        private System.Windows.Forms.Label lblStillLoading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer tmDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDBname;
    }
}