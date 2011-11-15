namespace MDaemonSpamCounter
{
    partial class Form1
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
            this.lRootFolderLabel = new System.Windows.Forms.Label();
            this.lRootFolder = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderList = new System.Windows.Forms.ListView();
            this.clmFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lRootFolderLabel
            // 
            this.lRootFolderLabel.AutoSize = true;
            this.lRootFolderLabel.Location = new System.Drawing.Point(12, 9);
            this.lRootFolderLabel.Name = "lRootFolderLabel";
            this.lRootFolderLabel.Size = new System.Drawing.Size(91, 14);
            this.lRootFolderLabel.TabIndex = 0;
            this.lRootFolderLabel.Text = "Root User Folder:";
            this.lRootFolderLabel.DoubleClick += new System.EventHandler(this.lRootFolderLabel_DoubleClick);
            // 
            // lRootFolder
            // 
            this.lRootFolder.AutoEllipsis = true;
            this.lRootFolder.Location = new System.Drawing.Point(109, 9);
            this.lRootFolder.Name = "lRootFolder";
            this.lRootFolder.Size = new System.Drawing.Size(163, 13);
            this.lRootFolder.TabIndex = 1;
            this.lRootFolder.Text = "NONE SELECTED";
            this.lRootFolder.DoubleClick += new System.EventHandler(this.lRootFolder_DoubleClick);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select a folder that contains MDaemon email folders";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // folderList
            // 
            this.folderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFolder,
            this.clmCount,
            this.clmSize});
            this.folderList.FullRowSelect = true;
            this.folderList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.folderList.Location = new System.Drawing.Point(15, 25);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(257, 247);
            this.folderList.TabIndex = 2;
            this.folderList.UseCompatibleStateImageBehavior = false;
            this.folderList.View = System.Windows.Forms.View.Details;
            // 
            // clmFolder
            // 
            this.clmFolder.Text = "Folder";
            // 
            // clmSize
            // 
            this.clmSize.DisplayIndex = 1;
            this.clmSize.Text = "Size";
            // 
            // clmCount
            // 
            this.clmCount.DisplayIndex = 2;
            this.clmCount.Text = "# Files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.folderList);
            this.Controls.Add(this.lRootFolder);
            this.Controls.Add(this.lRootFolderLabel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(300, 320);
            this.Name = "Form1";
            this.Text = "MDaemonSpamCounter";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lRootFolderLabel;
        private System.Windows.Forms.Label lRootFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListView folderList;
        private System.Windows.Forms.ColumnHeader clmFolder;
        private System.Windows.Forms.ColumnHeader clmCount;
        private System.Windows.Forms.ColumnHeader clmSize;
    }
}

