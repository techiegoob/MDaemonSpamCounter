using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDaemonSpamCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lRootFolder_DoubleClick(object sender, EventArgs e)
        {
            folderSelect();
        }

        private void lRootFolderLabel_DoubleClick(object sender, EventArgs e)
        {
            folderSelect();
        }

        private void folderSelect()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.lRootFolder.Text = folderBrowserDialog.SelectedPath;
                this.folderList.BeginUpdate();
                DirSearch(folderBrowserDialog.SelectedPath);
                this.folderList.EndUpdate();
            }

            formResize();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            formResize();
        }

        void DirSearch(string rootDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(rootDir))
                {
                    if (d.Contains("Art"))
                    {
                        DirectoryInfo di=new DirectoryInfo(d);
                        Int64 folderSize=0;
                        Int64 fileCount = 0;
                        FileInfo[] fis = di.GetFiles();
                        foreach (FileInfo fi in fis)
                        {
                            folderSize += fi.Length;
                            fileCount++;
                        }

                        ListViewItem lvi = new ListViewItem(di.FullName);
                        lvi.SubItems.Add(folderSize.ToString());
                        lvi.SubItems.Add(fileCount.ToString());
                        this.folderList.Items.Add(lvi);
                    }

                    DirSearch(d);
                }
            }
            catch (Exception ex) { MessageBox.Show(string.Format("Exception: {0}", ex.Message)); }
        }

        void formResize()
        {
            // resize the controls on the form 
            this.folderList.Width = this.Width - 43;
            this.folderList.Height = this.Height - 73;

            // resize the listview columns
            this.folderList.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.folderList.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.folderList.Columns[0].Width = this.folderList.Width - this.folderList.Columns[1].Width - this.folderList.Columns[2].Width - SystemInformation.VerticalScrollBarWidth-5;

            this.lRootFolder.Width = this.Width - 137;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formResize();
        }
    }
}
