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
            folderBrowserDialog.ShowDialog();
        }

        private void lRootFolderLabel_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
        }
    }
}
