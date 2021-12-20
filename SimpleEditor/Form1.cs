using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }
        private string m_sfileName = ""; 
      
        private void frmMain_Resize(object sender, EventArgs e)
        {
            rtfMain.Size = this.ClientSize;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.clearFormText();
            rtfMain.WordWrap = false;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {   //Exist the application but ask the user if the text in the box has changed
            if (rtfMain.Modified == true)
            {
                if (MessageBox.Show("Text has changed - do you want to exit?", "Confirm exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void clearFormText()
        {
            this.Text = "Simple Editor - [unnamed]";
        } 

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {           //open a file that already exist
                        bool bDoOpen = true;
                    if (rtfMain.Modified==true ) {
                    if (MessageBox.Show("Text has changed - really open another document?",
                    "Confirm file open", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)==DialogResult.No)
                    bDoOpen=false;
                    }
                    if (bDoOpen == true)
                    {
                        dlgOpen.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                        dlgOpen.FilterIndex = 1;
                        if (dlgOpen.ShowDialog() == DialogResult.OK && dlgOpen.FileName.Length > 0)
                        {
                            rtfMain.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.PlainText);
                            rtfMain.Modified = false;
                            m_sfileName = dlgOpen.FileName;
                             setFormText(m_sfileName);


                        }
                    }
        }
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            if (rtfMain.Modified == true)
            {
                if (MessageBox.Show("Do you want to create a new document?", "Create new document",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtfMain.Clear();
                    m_sfileName = "";
                    clearFormText();
                }
            }
            else
            {
                rtfMain.Clear();
                m_sfileName = "";
                clearFormText();
            }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if (m_sfileName != "")
                rtfMain.SaveFile(m_sfileName, RichTextBoxStreamType.PlainText);
            else
                mnuFileSaveAs_Click(sender, e); 
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            if (m_sfileName != "")
                dlgSave.FileName = m_sfileName;
            else
                dlgSave.FileName = "SimpleEd1";
            dlgSave.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.DefaultExt = "txt";
            if (dlgSave.ShowDialog() == DialogResult.OK && dlgSave.FileName.Length > 0)
            {
                rtfMain.SaveFile(dlgSave.FileName,
                RichTextBoxStreamType.PlainText);
                rtfMain.Modified = false;
                m_sfileName = dlgSave.FileName;
                setFormText(m_sfileName);
            } 
        }
        private void setFormText(string sFile)
        {
            System.IO.FileInfo fInfo;
            fInfo = new System.IO.FileInfo(sFile);
            this.Text = "Simple Editor - [" + fInfo.Name + "]";
        }

   
        private void mnuEditCut_Click(object sender, EventArgs e)
        {
            rtfMain.Cut();
        }

        private void mnuEditCopy_Click(object sender, EventArgs e)
        {
            rtfMain.Copy();
        }

        private void mnuEditPaste_Click(object sender, EventArgs e)
        {
            rtfMain.Paste(); 
        }


        private void mnuEdit_Select(object sender, System.EventArgs e)
        {
            if (rtfMain.SelectionLength == 0)
            {
                mnuEditCut.Enabled = false;
                mnuEditCopy.Enabled = false;
            }
            else
            {
                mnuEditCut.Enabled = true;
                mnuEditCopy.Enabled = true;
            }

            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text) == true)
                mnuEditPaste.Enabled = true;
            else
                mnuEditPaste.Enabled = false;

            if (rtfMain.CanUndo)
                mnuEditUndo.Enabled = true;
            else
                mnuEditUndo.Enabled = false;
            if (rtfMain.CanRedo)
                mnuEditRedo.Enabled = true;
            else
                mnuEditRedo.Enabled = false;

        }

        private void mnuEditUndo_Click(object sender, EventArgs e)
        {
            rtfMain.Undo(); 
        }

        private void mnuEditRedo_Click(object sender, EventArgs e)
        {
            rtfMain.Redo(); 
        }

        private void mnuEditSelectAll_Click(object sender, EventArgs e)
        {
            rtfMain.SelectAll(); 
        }

        private void mnuEditClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete all the text?",
            "Confirm text to delete", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                            rtfMain.Clear(); 
        }

        private void mnuEditFont_Click(object sender, EventArgs e)
        {
            dlgFont.Font = rtfMain.Font;
            if (dlgFont.ShowDialog() == DialogResult.OK)
                rtfMain.Font = dlgFont.Font; 
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {

        }

        private void rtfMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {

        }

        private void dlgFont_Apply(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new About().Show();
            this.Hide();
        }

      

    
     

      

  
    }
}
