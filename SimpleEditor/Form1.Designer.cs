namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtfMain = new System.Windows.Forms.RichTextBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(571, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.toolStripMenuItem1,
            this.mnuFileSave,
            this.mnuFileOpen,
            this.mnuFileSaveAs,
            this.mnuFileExit});
            this.mnuFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(38, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(124, 22);
            this.mnuFileNew.Text = "-New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(124, 22);
            this.mnuFileSave.Text = "-Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(124, 22);
            this.mnuFileOpen.Text = "-Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(124, 22);
            this.mnuFileSaveAs.Text = "-Save As";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(124, 22);
            this.mnuFileExit.Text = "-Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.mnuEditCopy,
            this.mnuEditPaste,
            this.mnuEditRedo,
            this.mnuEditCut,
            this.mnuEditUndo});
            this.mnuEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(40, 20);
            this.mnuEdit.Text = "&Edit";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 6);
            // 
            // mnuEditCopy
            // 
            this.mnuEditCopy.Name = "mnuEditCopy";
            this.mnuEditCopy.Size = new System.Drawing.Size(111, 22);
            this.mnuEditCopy.Text = "-Copy";
            this.mnuEditCopy.Click += new System.EventHandler(this.mnuEditCopy_Click);
            // 
            // mnuEditPaste
            // 
            this.mnuEditPaste.Name = "mnuEditPaste";
            this.mnuEditPaste.Size = new System.Drawing.Size(111, 22);
            this.mnuEditPaste.Text = "-Paste";
            this.mnuEditPaste.Click += new System.EventHandler(this.mnuEditPaste_Click);
            // 
            // mnuEditRedo
            // 
            this.mnuEditRedo.Name = "mnuEditRedo";
            this.mnuEditRedo.Size = new System.Drawing.Size(111, 22);
            this.mnuEditRedo.Text = "-Redo";
            this.mnuEditRedo.Click += new System.EventHandler(this.mnuEditRedo_Click);
            // 
            // mnuEditCut
            // 
            this.mnuEditCut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuEditCut.Name = "mnuEditCut";
            this.mnuEditCut.Size = new System.Drawing.Size(111, 22);
            this.mnuEditCut.Text = "-Cut";
            this.mnuEditCut.Click += new System.EventHandler(this.mnuEditCut_Click);
            // 
            // mnuEditUndo
            // 
            this.mnuEditUndo.Name = "mnuEditUndo";
            this.mnuEditUndo.Size = new System.Drawing.Size(111, 22);
            this.mnuEditUndo.Text = "-Undo";
            this.mnuEditUndo.Click += new System.EventHandler(this.mnuEditUndo_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rtfMain
            // 
            this.rtfMain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfMain.Location = new System.Drawing.Point(0, 27);
            this.rtfMain.Name = "rtfMain";
            this.rtfMain.Size = new System.Drawing.Size(775, 461);
            this.rtfMain.TabIndex = 2;
            this.rtfMain.Text = "";
            this.rtfMain.TextChanged += new System.EventHandler(this.rtfMain_TextChanged);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "Open File";
            // 
            // dlgFont
            // 
            this.dlgFont.Apply += new System.EventHandler(this.dlgFont_Apply);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 336);
            this.Controls.Add(this.rtfMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCut;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
        private System.Windows.Forms.RichTextBox rtfMain;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStripMenuItem mnuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRedo;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

