using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // resize the controls on the form 
            this.folderList.Width = this.Width - 43;
            this.folderList.Height = this.Height - 73;

            this.lRootFolder.Width = this.Width - 137;
        }

    }
}
