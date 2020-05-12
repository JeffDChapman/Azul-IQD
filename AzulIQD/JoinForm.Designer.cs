namespace AzulIQD
{
    partial class JoinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinForm));
            this.lbUnjoined = new System.Windows.Forms.CheckedListBox();
            this.lbJoined = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLjoin = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnRjoin = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbColsJoin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDoneJoinCs = new System.Windows.Forms.Button();
            this.lblUnjoinedTab = new System.Windows.Forms.Label();
            this.lblJoinedTab = new System.Windows.Forms.Label();
            this.clbRightCols = new System.Windows.Forms.CheckedListBox();
            this.clbLeftCols = new System.Windows.Forms.CheckedListBox();
            this.lbRightJoinCols = new System.Windows.Forms.CheckedListBox();
            this.lbLeftJoinCols = new System.Windows.Forms.CheckedListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbColsJoin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUnjoined
            // 
            this.lbUnjoined.CheckOnClick = true;
            this.lbUnjoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnjoined.FormattingEnabled = true;
            this.lbUnjoined.Location = new System.Drawing.Point(434, 64);
            this.lbUnjoined.Name = "lbUnjoined";
            this.lbUnjoined.Size = new System.Drawing.Size(345, 379);
            this.lbUnjoined.TabIndex = 0;
            this.lbUnjoined.UseCompatibleTextRendering = true;
            this.lbUnjoined.SelectedIndexChanged += new System.EventHandler(this.lbUnjoined_SelectedIndexChanged);
            // 
            // lbJoined
            // 
            this.lbJoined.CheckOnClick = true;
            this.lbJoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJoined.FormattingEnabled = true;
            this.lbJoined.Location = new System.Drawing.Point(40, 64);
            this.lbJoined.Name = "lbJoined";
            this.lbJoined.Size = new System.Drawing.Size(345, 379);
            this.lbJoined.TabIndex = 1;
            this.lbJoined.UseCompatibleTextRendering = true;
            this.lbJoined.SelectedIndexChanged += new System.EventHandler(this.lbJoined_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unjoined Tables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Joined Tables";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select ONE table from each list above, then click a button below:";
            // 
            // btnLjoin
            // 
            this.btnLjoin.Enabled = false;
            this.btnLjoin.Location = new System.Drawing.Point(57, 535);
            this.btnLjoin.Name = "btnLjoin";
            this.btnLjoin.Size = new System.Drawing.Size(137, 37);
            this.btnLjoin.TabIndex = 5;
            this.btnLjoin.Text = "Left Join";
            this.btnLjoin.UseVisualStyleBackColor = true;
            this.btnLjoin.Click += new System.EventHandler(this.btnLjoin_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Enabled = false;
            this.btnJoin.Location = new System.Drawing.Point(229, 535);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(137, 37);
            this.btnJoin.TabIndex = 6;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnRjoin
            // 
            this.btnRjoin.Enabled = false;
            this.btnRjoin.Location = new System.Drawing.Point(401, 535);
            this.btnRjoin.Name = "btnRjoin";
            this.btnRjoin.Size = new System.Drawing.Size(137, 37);
            this.btnRjoin.TabIndex = 7;
            this.btnRjoin.Text = "Right Join";
            this.btnRjoin.UseVisualStyleBackColor = true;
            this.btnRjoin.Click += new System.EventHandler(this.btnRjoin_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(633, 535);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 37);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbColsJoin
            // 
            this.gbColsJoin.Controls.Add(this.label4);
            this.gbColsJoin.Controls.Add(this.btnDoneJoinCs);
            this.gbColsJoin.Controls.Add(this.lblUnjoinedTab);
            this.gbColsJoin.Controls.Add(this.lblJoinedTab);
            this.gbColsJoin.Controls.Add(this.clbRightCols);
            this.gbColsJoin.Controls.Add(this.clbLeftCols);
            this.gbColsJoin.Controls.Add(this.lbRightJoinCols);
            this.gbColsJoin.Controls.Add(this.lbLeftJoinCols);
            this.gbColsJoin.Location = new System.Drawing.Point(12, 18);
            this.gbColsJoin.Name = "gbColsJoin";
            this.gbColsJoin.Size = new System.Drawing.Size(792, 560);
            this.gbColsJoin.TabIndex = 9;
            this.gbColsJoin.TabStop = false;
            this.gbColsJoin.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Click on Joining Columns, then >>>";
            // 
            // btnDoneJoinCs
            // 
            this.btnDoneJoinCs.Enabled = false;
            this.btnDoneJoinCs.Location = new System.Drawing.Point(621, 499);
            this.btnDoneJoinCs.Name = "btnDoneJoinCs";
            this.btnDoneJoinCs.Size = new System.Drawing.Size(137, 37);
            this.btnDoneJoinCs.TabIndex = 9;
            this.btnDoneJoinCs.Text = "Next >>";
            this.btnDoneJoinCs.UseVisualStyleBackColor = true;
            this.btnDoneJoinCs.Click += new System.EventHandler(this.btnDoneJoinCs_Click);
            // 
            // lblUnjoinedTab
            // 
            this.lblUnjoinedTab.AutoSize = true;
            this.lblUnjoinedTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnjoinedTab.Location = new System.Drawing.Point(401, 27);
            this.lblUnjoinedTab.Name = "lblUnjoinedTab";
            this.lblUnjoinedTab.Size = new System.Drawing.Size(223, 25);
            this.lblUnjoinedTab.TabIndex = 3;
            this.lblUnjoinedTab.Text = "UnjoinedTabName Here";
            // 
            // lblJoinedTab
            // 
            this.lblJoinedTab.AutoSize = true;
            this.lblJoinedTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinedTab.Location = new System.Drawing.Point(34, 27);
            this.lblJoinedTab.Name = "lblJoinedTab";
            this.lblJoinedTab.Size = new System.Drawing.Size(205, 25);
            this.lblJoinedTab.TabIndex = 2;
            this.lblJoinedTab.Text = "JoinedTabName Here";
            // 
            // clbRightCols
            // 
            this.clbRightCols.CheckOnClick = true;
            this.clbRightCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbRightCols.FormattingEnabled = true;
            this.clbRightCols.Location = new System.Drawing.Point(406, 70);
            this.clbRightCols.Name = "clbRightCols";
            this.clbRightCols.Size = new System.Drawing.Size(338, 404);
            this.clbRightCols.TabIndex = 1;
            this.clbRightCols.UseCompatibleTextRendering = true;
            this.clbRightCols.SelectedIndexChanged += new System.EventHandler(this.clbRightCols_SelectedIndexChanged);
            // 
            // clbLeftCols
            // 
            this.clbLeftCols.CheckOnClick = true;
            this.clbLeftCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbLeftCols.FormattingEnabled = true;
            this.clbLeftCols.Location = new System.Drawing.Point(39, 70);
            this.clbLeftCols.Name = "clbLeftCols";
            this.clbLeftCols.Size = new System.Drawing.Size(338, 404);
            this.clbLeftCols.TabIndex = 0;
            this.clbLeftCols.UseCompatibleTextRendering = true;
            this.clbLeftCols.SelectedIndexChanged += new System.EventHandler(this.clbLeftCols_SelectedIndexChanged);
            // 
            // lbRightJoinCols
            // 
            this.lbRightJoinCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRightJoinCols.FormattingEnabled = true;
            this.lbRightJoinCols.Location = new System.Drawing.Point(406, 70);
            this.lbRightJoinCols.Name = "lbRightJoinCols";
            this.lbRightJoinCols.Size = new System.Drawing.Size(286, 379);
            this.lbRightJoinCols.TabIndex = 1;
            this.lbRightJoinCols.UseCompatibleTextRendering = true;
            // 
            // lbLeftJoinCols
            // 
            this.lbLeftJoinCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeftJoinCols.FormattingEnabled = true;
            this.lbLeftJoinCols.Location = new System.Drawing.Point(39, 70);
            this.lbLeftJoinCols.Name = "lbLeftJoinCols";
            this.lbLeftJoinCols.Size = new System.Drawing.Size(286, 379);
            this.lbLeftJoinCols.TabIndex = 0;
            this.lbLeftJoinCols.UseCompatibleTextRendering = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(726, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 43);
            this.btnClear.TabIndex = 10;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = global::AzulIQD.Properties.Resources.Pencil;
            this.btnEdit.Location = new System.Drawing.Point(332, 381);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 43);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 590);
            this.Controls.Add(this.gbColsJoin);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRjoin);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnLjoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbJoined);
            this.Controls.Add(this.lbUnjoined);
            this.Name = "JoinForm";
            this.Text = "Join Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JoinForm_FormClosing);
            this.gbColsJoin.ResumeLayout(false);
            this.gbColsJoin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lbUnjoined;
        private System.Windows.Forms.CheckedListBox lbJoined;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLjoin;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnRjoin;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbColsJoin;
        private System.Windows.Forms.Label lblUnjoinedTab;
        private System.Windows.Forms.Label lblJoinedTab;
        private System.Windows.Forms.CheckedListBox lbRightJoinCols;
        private System.Windows.Forms.CheckedListBox lbLeftJoinCols;
        private System.Windows.Forms.Button btnDoneJoinCs;
        private System.Windows.Forms.CheckedListBox clbRightCols;
        private System.Windows.Forms.CheckedListBox clbLeftCols;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;



    }
}