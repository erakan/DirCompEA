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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DirComp {
	public partial class DirCompEA : Form {
		public class FileInfo {
			public string Name;
			public string Cheksum;
			public bool isAdded;
			public string Dir;
			public string FileName;

			public FileInfo(string name, string checksum, string dir) {
				Name = name;
				Cheksum = checksum;
				FileName = name.Remove(0, dir.Length);
				Dir = dir;
				isAdded = false;
			}
		}

		public DirCompEA() {
			InitializeComponent();
		}

		List<FileInfo> GetFileInfos(string dir, ProgressBar pb) {
			string[] arrLeftDirFiles = System.IO.Directory.GetFiles(dir, "*.*", System.IO.SearchOption.TopDirectoryOnly);
			List<FileInfo> lstLeftFiles = new List<FileInfo>(arrLeftDirFiles.Length);
			pb.Minimum = 0;
			pb.Maximum = arrLeftDirFiles.Length;
			pb.Value = 0;
			pb.Step = 1;
			foreach (string s in arrLeftDirFiles) {
				FileInfo fi = new FileInfo(s, DTHasher.GetSHA1Hash(s), dir);
				lstLeftFiles.Add(fi);
				pb.PerformStep();
				Application.DoEvents();
			}
			return lstLeftFiles;
		}

		void FillSubdirs(string dir, ComboBox cmb) {
			string[] arrDirs = System.IO.Directory.GetDirectories(dir, "*.*", System.IO.SearchOption.AllDirectories);
			cmb.Items.Clear();
			cmb.Items.Add("");
			cmb.Items.AddRange(arrDirs);
		}

		enum FileInfoStatus {
			NotExists,
			Identical,
			NotIdentical,
		}

		void CreateLVI(ListView lv, FileInfo fi, FileInfoStatus fis) {
			ListViewItem lvi = new ListViewItem(fi.Name);
			lvi.SubItems.Add(fi.Cheksum);
			DateTime dt = System.IO.File.GetLastWriteTime(fi.Name);
			lvi.SubItems.Add(dt.ToLongDateString() + " " + dt.ToString("hh:mm:ss"));
			switch (fis) {
				case FileInfoStatus.NotExists:
					lvi.ForeColor = Color.Red;
					break;
				case FileInfoStatus.Identical:
					lvi.ForeColor = Color.Green;
					break;
				case FileInfoStatus.NotIdentical:
					lvi.ForeColor = Color.Blue;
					break;
				default:
					break;
			}
			lv.Items.Add(lvi);
		}

		void CompareDirs(string leftdir, string rightdir) {
			List<FileInfo> lstLeftFiles = GetFileInfos(leftdir, prgsLeft);
			List<FileInfo> lstRightFiles = GetFileInfos(rightdir, prgsLeft);
			List<FileInfo> lstMain = lstLeftFiles.Count > lstRightFiles.Count ? lstLeftFiles : lstRightFiles;
			List<FileInfo> lstInner = lstLeftFiles.Count > lstRightFiles.Count ? lstRightFiles : lstLeftFiles;
			ListView lvMain = lstLeftFiles.Count > lstRightFiles.Count ? lvLeftDir : lvRightDir;
			ListView lvInner = lstLeftFiles.Count > lstRightFiles.Count ? lvRightDir : lvLeftDir;
			lvMain.Items.Clear();
			lvInner.Items.Clear();
			prgsLeft.Minimum = 0;
			prgsLeft.Maximum = lstMain.Count;
			prgsLeft.Value = 0;
			prgsLeft.Step = 1;
			for (int i = 0; i < lstMain.Count; i++) {
				FileInfoStatus fis = FileInfoStatus.NotExists;
				FileInfo fi = lstMain[i];
				bool isFind = false;
				foreach (FileInfo fii in lstInner) {
					if (fii.Cheksum == fi.Cheksum) {
						isFind = true;
						fis = FileInfoStatus.Identical;
						CreateLVI(lvInner, fii, fis);
						lstInner.Remove(fii);
						break;
					} else if (fii.FileName == fi.FileName) {
						isFind = true;
						fis = FileInfoStatus.NotIdentical;
						CreateLVI(lvInner, fii, fis);
						lstInner.Remove(fii);
						break;
					}
				}
				if (!isFind) continue;
				CreateLVI(lvMain, fi, fis);
				lstMain.RemoveAt(i--);
				prgsLeft.PerformStep();
				Application.DoEvents();
			}
			foreach (FileInfo fii in lstMain) {
				CreateLVI(lvMain, fii, FileInfoStatus.NotExists);
				prgsLeft.PerformStep();
			}
			foreach (FileInfo fii in lstInner)
				CreateLVI(lvInner, fii, FileInfoStatus.NotExists);

		}

		public sealed class DTHasher {
			private DTHasher() { }

			private static byte[] ConvertStringToByteArray(string data) {
				return (new System.Text.UnicodeEncoding()).GetBytes(data);
			}

			private static System.IO.FileStream GetFileStream(string pathName) {
				return (new System.IO.FileStream(pathName, System.IO.FileMode.Open,
						System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite));
			}

			public static string GetSHA1Hash(string pathName) {
				string strResult = "";
				string strHashData = "";

				byte[] arrbytHashValue;
				System.IO.FileStream oFileStream = null;

				System.Security.Cryptography.SHA1CryptoServiceProvider oSHA1Hasher =
						 new System.Security.Cryptography.SHA1CryptoServiceProvider();

				try {
					oFileStream = GetFileStream(pathName);
					arrbytHashValue = oSHA1Hasher.ComputeHash(oFileStream);
					oFileStream.Close();

					strHashData = System.BitConverter.ToString(arrbytHashValue);
					strHashData = strHashData.Replace("-", "");
					strResult = strHashData;
				} catch (System.Exception ex) {
					System.Windows.Forms.MessageBox.Show(ex.Message, "Error!",
						   System.Windows.Forms.MessageBoxButtons.OK,
						   System.Windows.Forms.MessageBoxIcon.Error,
						   System.Windows.Forms.MessageBoxDefaultButton.Button1);
				}

				return (strResult);
			}

			public static string GetMD5Hash(string pathName) {
				string strResult = "";
				string strHashData = "";

				byte[] arrbytHashValue;
				System.IO.FileStream oFileStream = null;

				System.Security.Cryptography.MD5CryptoServiceProvider oMD5Hasher =
						 new System.Security.Cryptography.MD5CryptoServiceProvider();

				try {
					oFileStream = GetFileStream(pathName);
					arrbytHashValue = oMD5Hasher.ComputeHash(oFileStream);
					oFileStream.Close();

					strHashData = System.BitConverter.ToString(arrbytHashValue);
					strHashData = strHashData.Replace("-", "");
					strResult = strHashData;
				} catch (Exception ex) {
					MessageBox.Show(ex.Message, "Error!",
							 MessageBoxButtons.OK,
							 MessageBoxIcon.Error,
							 MessageBoxDefaultButton.Button1);
				}

				return (strResult);
			}
		}

		bool _TextChanged = true;
		private void btnCompareAgain_Click(object sender, EventArgs e) {
			try {
				btnCompareAgain.Enabled = false;
				if (_TextChanged) {
					FillSubdirs(txtLeftDir.Text, cmbLeftDirs);
					FillSubdirs(txtRightDir.Text, cmbRightDirs);
					CompareDirs(txtLeftDir.Text, txtRightDir.Text);
					_TextChanged = false;
				} else {
					string left = cmbLeftDirs.SelectedItem.ToString();
					string right = cmbRightDirs.SelectedItem.ToString();
					if (left.Length == 0) left = txtLeftDir.Text;
					if (right.Length == 0) right = txtRightDir.Text;
					CompareDirs(left, right);
				}
				UpdateInfos();
				btnCompareAgain.Enabled = true;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error!",
						 MessageBoxButtons.OK,
						 MessageBoxIcon.Error,
						 MessageBoxDefaultButton.Button1);
			}

		}

		void UpdateInfos() {
			lblLeftInfo.Text = String.Format("Subdir Count: {0}, Current Dir File Count: {1}",
				cmbLeftDirs.Items.Count, lvLeftDir.Items.Count);
			lblRightInfo.Text = String.Format("Subdir Count: {0}, Current Dir File Count: {1}",
				cmbRightDirs.Items.Count, lvRightDir.Items.Count);
		}

		void ChooseToThis(ComboBox from, string fromdir, ComboBox to, string todir, string direction) {
			bool Find = false;
			string selpath = from.SelectedItem.ToString();
			if (selpath.Length == 0) return;
			selpath = selpath.Remove(0, fromdir.Length);
			for (int i = 0; i < to.Items.Count; i++) {
				string filepath = to.Items[i].ToString();
				if (filepath.Length == 0) continue;
				filepath = filepath.Remove(0, todir.Length);
				if (filepath == selpath) {
					Find = true;
					to.SelectedIndex = i;
				}
			}
			if (!Find)
				MessageBox.Show(String.Format("This forder is not on the {0} view.", direction));
		}

		private void cmbLeftDirs_SelectedIndexChanged(object sender, EventArgs e) {
			ChooseToThis(cmbLeftDirs, txtLeftDir.Text, cmbRightDirs, txtRightDir.Text, "right");
		}

		private void cmbRightDirs_SelectedIndexChanged(object sender, EventArgs e) {
			ChooseToThis(cmbRightDirs, txtRightDir.Text, cmbLeftDirs, txtLeftDir.Text, "left");
		}

		string SelFolderDlg(string path) {
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.ShowNewFolderButton = false;
			fbd.SelectedPath = path;
			if (fbd.ShowDialog() == DialogResult.OK)
				return fbd.SelectedPath;
			return path;
		}

		private void btnChooseDirLeft_Click(object sender, EventArgs e) {
			txtLeftDir.Text = SelFolderDlg(txtLeftDir.Text);
		}

		private void btnChooseDirRight_Click(object sender, EventArgs e) {
			txtRightDir.Text = SelFolderDlg(txtRightDir.Text);
		}

		private void txtLeftDir_TextChanged(object sender, EventArgs e) {
			_TextChanged = true;
		}

		private void txtRightDir_TextChanged(object sender, EventArgs e) {
			_TextChanged = true;
		}
	}
}