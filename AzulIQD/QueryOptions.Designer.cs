namespace AzulIQD
{
    partial class QueryOptions
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
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnNolock = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnDistinct = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btnTop20 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.btnAlias = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(292, 503);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 37);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.btnNolock);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 101);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Use intention locks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use NOLOCK hints (read Uncommited)";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(21, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnNolock
            // 
            this.btnNolock.AutoSize = true;
            this.btnNolock.Checked = true;
            this.btnNolock.Location = new System.Drawing.Point(24, 25);
            this.btnNolock.Name = "btnNolock";
            this.btnNolock.Size = new System.Drawing.Size(21, 20);
            this.btnNolock.TabIndex = 0;
            this.btnNolock.TabStop = true;
            this.btnNolock.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.btnDistinct);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(32, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 101);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duplicate output rows okay (faster)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Return DISTINCT output rows";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(21, 20);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnDistinct
            // 
            this.btnDistinct.AutoSize = true;
            this.btnDistinct.Checked = true;
            this.btnDistinct.Location = new System.Drawing.Point(24, 25);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(21, 20);
            this.btnDistinct.TabIndex = 0;
            this.btnDistinct.TabStop = true;
            this.btnDistinct.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.btnTop20);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(32, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 101);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Return all query rows";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Select top(20)";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(24, 59);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(21, 20);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // btnTop20
            // 
            this.btnTop20.AutoSize = true;
            this.btnTop20.Checked = true;
            this.btnTop20.Location = new System.Drawing.Point(24, 25);
            this.btnTop20.Name = "btnTop20";
            this.btnTop20.Size = new System.Drawing.Size(21, 20);
            this.btnTop20.TabIndex = 0;
            this.btnTop20.TabStop = true;
            this.btnTop20.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.btnAlias);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(32, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 101);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Use full table names";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Use alias table names (shortens query text)";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(24, 59);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(21, 20);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // btnAlias
            // 
            this.btnAlias.AutoSize = true;
            this.btnAlias.Checked = true;
            this.btnAlias.Location = new System.Drawing.Point(24, 25);
            this.btnAlias.Name = "btnAlias";
            this.btnAlias.Size = new System.Drawing.Size(21, 20);
            this.btnAlias.TabIndex = 0;
            this.btnAlias.TabStop = true;
            this.btnAlias.UseVisualStyleBackColor = true;
            // 
            // QueryOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 568);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QueryOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Query Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton7;
        public System.Windows.Forms.RadioButton btnNolock;
        public System.Windows.Forms.RadioButton btnDistinct;
        public System.Windows.Forms.RadioButton btnTop20;
        public System.Windows.Forms.RadioButton btnAlias;
    }
}