/**
 * DirCompEA ~ A file comparison tool
 * Copyright (c) 2008 Erdinc AKAN (erakan@gmail.com)
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 *
 **/

namespace DirComp
{
	partial class DirCompEA
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtLeftDir = new System.Windows.Forms.TextBox();
			this.txtRightDir = new System.Windows.Forms.TextBox();
			this.prgsLeft = new System.Windows.Forms.ProgressBar();
			this.lvLeftDir = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvRightDir = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmbLeftDirs = new System.Windows.Forms.ComboBox();
			this.cmbRightDirs = new System.Windows.Forms.ComboBox();
			this.btnCompareAgain = new System.Windows.Forms.Button();
			this.btnChooseDirLeft = new System.Windows.Forms.Button();
			this.btnChooseDirRight = new System.Windows.Forms.Button();
			this.lblLeftInfo = new System.Windows.Forms.Label();
			this.lblRightInfo = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Left Dir:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(476, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Right Dir:";
			// 
			// txtLeftDir
			// 
			this.txtLeftDir.Location = new System.Drawing.Point(15, 21);
			this.txtLeftDir.Name = "txtLeftDir";
			this.txtLeftDir.Size = new System.Drawing.Size(428, 20);
			this.txtLeftDir.TabIndex = 2;
			this.txtLeftDir.TextChanged += new System.EventHandler(this.txtLeftDir_TextChanged);
			// 
			// txtRightDir
			// 
			this.txtRightDir.Location = new System.Drawing.Point(479, 21);
			this.txtRightDir.Name = "txtRightDir";
			this.txtRightDir.Size = new System.Drawing.Size(413, 20);
			this.txtRightDir.TabIndex = 3;
			this.txtRightDir.TextChanged += new System.EventHandler(this.txtRightDir_TextChanged);
			// 
			// prgsLeft
			// 
			this.prgsLeft.Location = new System.Drawing.Point(15, 46);
			this.prgsLeft.Name = "prgsLeft";
			this.prgsLeft.Size = new System.Drawing.Size(907, 23);
			this.prgsLeft.TabIndex = 7;
			// 
			// lvLeftDir
			// 
			this.lvLeftDir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2});
			this.lvLeftDir.Location = new System.Drawing.Point(15, 100);
			this.lvLeftDir.Name = "lvLeftDir";
			this.lvLeftDir.Size = new System.Drawing.Size(458, 379);
			this.lvLeftDir.TabIndex = 8;
			this.lvLeftDir.UseCompatibleStateImageBehavior = false;
			this.lvLeftDir.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "File Name";
			this.columnHeader1.Width = 219;
			// 
			// columnHeader5
			// 
			this.columnHeader5.DisplayIndex = 2;
			this.columnHeader5.Text = "SHA1 Hash";
			this.columnHeader5.Width = 246;
			// 
			// columnHeader2
			// 
			this.columnHeader2.DisplayIndex = 1;
			this.columnHeader2.Text = "Date Modified";
			this.columnHeader2.Width = 139;
			// 
			// lvRightDir
			// 
			this.lvRightDir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4});
			this.lvRightDir.Location = new System.Drawing.Point(479, 100);
			this.lvRightDir.Name = "lvRightDir";
			this.lvRightDir.Size = new System.Drawing.Size(443, 379);
			this.lvRightDir.TabIndex = 9;
			this.lvRightDir.UseCompatibleStateImageBehavior = false;
			this.lvRightDir.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "File Name";
			this.columnHeader3.Width = 236;
			// 
			// columnHeader6
			// 
			this.columnHeader6.DisplayIndex = 2;
			this.columnHeader6.Text = "SHA1 Hash";
			this.columnHeader6.Width = 356;
			// 
			// columnHeader4
			// 
			this.columnHeader4.DisplayIndex = 1;
			this.columnHeader4.Text = "Date Modified";
			this.columnHeader4.Width = 137;
			// 
			// cmbLeftDirs
			// 
			this.cmbLeftDirs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLeftDirs.FormattingEnabled = true;
			this.cmbLeftDirs.Location = new System.Drawing.Point(15, 73);
			this.cmbLeftDirs.Name = "cmbLeftDirs";
			this.cmbLeftDirs.Size = new System.Drawing.Size(458, 21);
			this.cmbLeftDirs.TabIndex = 10;
			this.cmbLeftDirs.SelectedIndexChanged += new System.EventHandler(this.cmbLeftDirs_SelectedIndexChanged);
			// 
			// cmbRightDirs
			// 
			this.cmbRightDirs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRightDirs.FormattingEnabled = true;
			this.cmbRightDirs.Location = new System.Drawing.Point(479, 73);
			this.cmbRightDirs.Name = "cmbRightDirs";
			this.cmbRightDirs.Size = new System.Drawing.Size(443, 21);
			this.cmbRightDirs.TabIndex = 11;
			this.cmbRightDirs.SelectedIndexChanged += new System.EventHandler(this.cmbRightDirs_SelectedIndexChanged);
			// 
			// btnCompareAgain
			// 
			this.btnCompareAgain.Location = new System.Drawing.Point(334, 503);
			this.btnCompareAgain.Name = "btnCompareAgain";
			this.btnCompareAgain.Size = new System.Drawing.Size(275, 37);
			this.btnCompareAgain.TabIndex = 12;
			this.btnCompareAgain.Text = "Compare";
			this.btnCompareAgain.UseVisualStyleBackColor = true;
			this.btnCompareAgain.Click += new System.EventHandler(this.btnCompareAgain_Click);
			// 
			// btnChooseDirLeft
			// 
			this.btnChooseDirLeft.Location = new System.Drawing.Point(449, 19);
			this.btnChooseDirLeft.Name = "btnChooseDirLeft";
			this.btnChooseDirLeft.Size = new System.Drawing.Size(24, 23);
			this.btnChooseDirLeft.TabIndex = 13;
			this.btnChooseDirLeft.Text = "...";
			this.btnChooseDirLeft.UseVisualStyleBackColor = true;
			this.btnChooseDirLeft.Click += new System.EventHandler(this.btnChooseDirLeft_Click);
			// 
			// btnChooseDirRight
			// 
			this.btnChooseDirRight.Location = new System.Drawing.Point(898, 19);
			this.btnChooseDirRight.Name = "btnChooseDirRight";
			this.btnChooseDirRight.Size = new System.Drawing.Size(24, 23);
			this.btnChooseDirRight.TabIndex = 14;
			this.btnChooseDirRight.Text = "...";
			this.btnChooseDirRight.UseVisualStyleBackColor = true;
			this.btnChooseDirRight.Click += new System.EventHandler(this.btnChooseDirRight_Click);
			// 
			// lblLeftInfo
			// 
			this.lblLeftInfo.Location = new System.Drawing.Point(17, 483);
			this.lblLeftInfo.Name = "lblLeftInfo";
			this.lblLeftInfo.Size = new System.Drawing.Size(456, 17);
			this.lblLeftInfo.TabIndex = 15;
			this.lblLeftInfo.Text = "Subdir count: {0}";
			this.lblLeftInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRightInfo
			// 
			this.lblRightInfo.Location = new System.Drawing.Point(479, 482);
			this.lblRightInfo.Name = "lblRightInfo";
			this.lblRightInfo.Size = new System.Drawing.Size(443, 18);
			this.lblRightInfo.TabIndex = 16;
			this.lblRightInfo.Text = "Subdir count: {0}";
			this.lblRightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(20, 503);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(193, 37);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Legend";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(59, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Not Identical";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.ForeColor = System.Drawing.Color.Green;
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Identical";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(132, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Not Exists";
			// 
			// DirCompEA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 552);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblRightInfo);
			this.Controls.Add(this.lblLeftInfo);
			this.Controls.Add(this.btnChooseDirRight);
			this.Controls.Add(this.btnChooseDirLeft);
			this.Controls.Add(this.btnCompareAgain);
			this.Controls.Add(this.cmbRightDirs);
			this.Controls.Add(this.cmbLeftDirs);
			this.Controls.Add(this.lvRightDir);
			this.Controls.Add(this.lvLeftDir);
			this.Controls.Add(this.prgsLeft);
			this.Controls.Add(this.txtRightDir);
			this.Controls.Add(this.txtLeftDir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "DirCompEA";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DirCompEA";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLeftDir;
		private System.Windows.Forms.TextBox txtRightDir;
		private System.Windows.Forms.ProgressBar prgsLeft;
		private System.Windows.Forms.ListView lvLeftDir;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ListView lvRightDir;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ComboBox cmbLeftDirs;
		private System.Windows.Forms.ComboBox cmbRightDirs;
		private System.Windows.Forms.Button btnCompareAgain;
		private System.Windows.Forms.Button btnChooseDirLeft;
		private System.Windows.Forms.Button btnChooseDirRight;
		private System.Windows.Forms.Label lblLeftInfo;
		private System.Windows.Forms.Label lblRightInfo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}

