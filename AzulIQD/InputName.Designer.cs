﻿namespace AzulIQD
{
    partial class InputName
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.btnAlias = new System.Windows.Forms.Button();
            this.lblAliasOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name:";
            // 
            // tbTableName
            // 
            this.tbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTableName.Location = new System.Drawing.Point(118, 17);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(254, 32);
            this.tbTableName.TabIndex = 1;
            // 
            // btnAlias
            // 
            this.btnAlias.Location = new System.Drawing.Point(20, 75);
            this.btnAlias.Name = "btnAlias";
            this.btnAlias.Size = new System.Drawing.Size(91, 38);
            this.btnAlias.TabIndex = 2;
            this.btnAlias.Text = "Get Alias";
            this.btnAlias.UseVisualStyleBackColor = true;
            this.btnAlias.Click += new System.EventHandler(this.btnAlias_Click);
            // 
            // lblAliasOut
            // 
            this.lblAliasOut.AutoSize = true;
            this.lblAliasOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliasOut.Location = new System.Drawing.Point(163, 81);
            this.lblAliasOut.Name = "lblAliasOut";
            this.lblAliasOut.Size = new System.Drawing.Size(0, 26);
            this.lblAliasOut.TabIndex = 3;
            // 
            // InputName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 136);
            this.Controls.Add(this.lblAliasOut);
            this.Controls.Add(this.btnAlias);
            this.Controls.Add(this.tbTableName);
            this.Controls.Add(this.label1);
            this.Name = "InputName";
            this.Text = "Input Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.Button btnAlias;
        private System.Windows.Forms.Label lblAliasOut;
    }
}

