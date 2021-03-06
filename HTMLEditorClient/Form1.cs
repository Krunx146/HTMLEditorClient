﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLEditorClient
{
    public partial class frmMain : Form
    {
        public string[] MarkupListHTML;
        public string[] MarkupListCSS;
        public List<string> SenseWordList = new List<string>();
        public int SenseLength;
        public bool MarkWords;
        public bool SenseVisible;
        public string filePath;
        public string mainFile;
        public ListBox senseList = new ListBox();

        public frmMain()
        {
            InitializeComponent();
            ((ToolStripMenuItem)pTool10p).Checked = true;
            ((ToolStripMenuItem)menuMark).Checked = true;
            ((ToolStripMenuItem)menuSynchronise).Enabled = false;
            this.Controls.Add(senseList);
            loadMarkup();
            MarkWords = true;
            SenseVisible = false;
            filePath = null;
        }
        private void loadMarkup()
        {
            try
            {
                MarkupListHTML = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "MarkupHTML.txt");
                MarkupListCSS = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "MarkupCSS.txt");
            }
            catch
            {
                MessageBox.Show("Cannot read from markup file!");
            }
        }
        private void executeMarkup()
        {
            foreach (string s in MarkupListHTML) CheckAllText(s, Color.Blue, 0);
            foreach (string s in MarkupListCSS) CheckAllText(s, Color.Green, 0);
        }
        private void executeMarkupOnSingleWord()
        {
            foreach (string s in MarkupListHTML)
            {
                int length = s.Length;
                int selectionEnd = inputCode.SelectionStart;
                int selectionStart = 0;
                if (selectionEnd - length <= 0) return;
                else
                {
                    selectionStart = selectionEnd - length;
                    string comp = inputCode.Text.Substring(selectionStart, length);
                    if(comp == s)
                    {
                        this.inputCode.Select(selectionStart, length);
                        this.inputCode.SelectionColor = Color.Blue;
                        this.inputCode.Select(selectionEnd, 0);
                        this.inputCode.SelectionColor = Color.Black;
                    }
                }
                
            }
            foreach (string s in MarkupListCSS)
            {
                int length = s.Length;
                int selectionEnd = inputCode.SelectionStart;
                int selectionStart = 0;
                if (selectionEnd - length <= 0) return;
                else
                {
                    selectionStart = selectionEnd - length;
                    string comp = inputCode.Text.Substring(selectionStart, length);
                    if (comp == s)
                    {
                        this.inputCode.Select(selectionStart, length);
                        this.inputCode.SelectionColor = Color.Green;
                        this.inputCode.Select(selectionEnd, 0);
                        this.inputCode.SelectionColor = Color.Black;
                    }
                }
            }
        }
        private void senseWord()
        {
            SenseWordList.Clear();
            if(inputCode.Text.LastIndexOf('<') > 0 && inputCode.Text[inputCode.SelectionStart - 1] != '>')
            {
                int selectionEnd = inputCode.SelectionStart;
                int selectionStart = inputCode.Text.LastIndexOf('<');
                if (selectionEnd - selectionStart < 1) return;
                string word = inputCode.Text.Substring(selectionStart, selectionEnd - selectionStart);
                SenseLength = selectionEnd - selectionStart;
                foreach (string s in MarkupListHTML)
                {
                    if (s.Contains(word)) SenseWordList.Add(s);
                }
                if (!SenseWordList.Any())
                {
                    senseList.Hide();
                    SenseVisible = false;
                    return;
                }
                senseList.Items.Clear();
                Point senseLoc = inputCode.GetPositionFromCharIndex(inputCode.SelectionStart);
                senseLoc.X += 32;
                senseLoc.Y += 64;
                senseList.Location = senseLoc;
                senseList.BringToFront();
                foreach (string s in SenseWordList)
                {
                    senseList.Items.Add(s);
                }
                senseList.SelectedIndex = 0;
                SenseVisible = true;
                senseList.Show();
            }
            /*
            if (inputCode.Text[inputCode.SelectionStart - 1] == '<')
            {
                senseList.Items.Clear();
                Point senseLoc = inputCode.GetPositionFromCharIndex(inputCode.SelectionStart);
                senseLoc.X += 32;
                senseLoc.Y += 64;
                senseList.Location = senseLoc;
                senseList.BringToFront();
                foreach (string s in SenseWordList)
                {
                    senseList.Items.Add(s);
                }
                senseList.SelectedIndex = 0;
                SenseVisible = true;
                senseList.Show();
            }
            */
            else
            {
                senseList.Hide();
                SenseVisible = false;
            }
        }
        private void inputCode_TextChanged(object sender, EventArgs e)
        {
            outputLineNumber.Text = "Line: " + (inputCode.GetLineFromCharIndex(inputCode.SelectionStart)+1) + " of " + inputCode.Lines.Count().ToString();
            inputCode.ForeColor = Color.Black;
            if (MarkWords == true)
            {
                executeMarkupOnSingleWord();
            }
            this.Text = "HTML Editor - " + filePath + "*";
        }
        private void inputCode_SelectionChanged(object sender, EventArgs e)
        {
            if (inputCode.SelectionStart > 0) senseWord();
            else senseList.Hide();
        }
        private void CheckAllText(string word, Color color, int startIndex)
        {
            if (this.inputCode.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.inputCode.SelectionStart;
                while ((index = this.inputCode.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.inputCode.Select((index + startIndex), word.Length);
                    this.inputCode.SelectionColor = color;
                    this.inputCode.Select(selectStart, 0);
                    this.inputCode.SelectionColor = Color.Black;
                }
            }
        }
        private void CheckString(string word, Color color, int startIndex, int endIndex, string text)
        {
            int selectStart = this.inputCode.SelectionStart;
            if (text.Contains(word))
            {
                this.inputCode.Select(text.IndexOf(word, endIndex-startIndex), word.Length);
                this.inputCode.SelectionColor = color;
                this.inputCode.Select(selectStart, 0);
                this.inputCode.SelectionColor = Color.Black;
            }
        }

        private void inputCode_Click(object sender, EventArgs e)
        {
            outputLineNumber.Text = "Line: " + (inputCode.GetLineFromCharIndex(inputCode.SelectionStart) + 1) + " of " + inputCode.Lines.Count().ToString();
        }

        private void pTool8p_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)pTool8p).Checked = true;
            ((ToolStripMenuItem)pTool10p).Checked = false;
            ((ToolStripMenuItem)pTool12p).Checked = false;
            ((ToolStripMenuItem)pTool16p).Checked = false;
            ((ToolStripMenuItem)pTool20p).Checked = false;
            inputCode.Font = new Font("Arial", 8, FontStyle.Regular);
        }

        private void pTool10p_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)pTool8p).Checked = false;
            ((ToolStripMenuItem)pTool10p).Checked = true;
            ((ToolStripMenuItem)pTool12p).Checked = false;
            ((ToolStripMenuItem)pTool16p).Checked = false;
            ((ToolStripMenuItem)pTool20p).Checked = false;
            inputCode.Font = new Font("Arial", 10, FontStyle.Regular);
        }

        private void pTool12p_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)pTool8p).Checked = false;
            ((ToolStripMenuItem)pTool10p).Checked = false;
            ((ToolStripMenuItem)pTool12p).Checked = true;
            ((ToolStripMenuItem)pTool16p).Checked = false;
            ((ToolStripMenuItem)pTool20p).Checked = false;
            inputCode.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void pTool16p_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)pTool8p).Checked = false;
            ((ToolStripMenuItem)pTool10p).Checked = false;
            ((ToolStripMenuItem)pTool12p).Checked = false;
            ((ToolStripMenuItem)pTool16p).Checked = true;
            ((ToolStripMenuItem)pTool20p).Checked = false;
            inputCode.Font = new Font("Arial", 16, FontStyle.Regular);
        }

        private void pTool20p_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)pTool8p).Checked = false;
            ((ToolStripMenuItem)pTool10p).Checked = false;
            ((ToolStripMenuItem)pTool12p).Checked = false;
            ((ToolStripMenuItem)pTool16p).Checked = false;
            ((ToolStripMenuItem)pTool20p).Checked = true;
            inputCode.Font = new Font("Arial", 20, FontStyle.Regular);
        }

        private void menuMark_Click(object sender, EventArgs e)
        {
            if (MarkWords == true)
            {
                MarkWords = false;
                ((ToolStripMenuItem)menuMark).Checked = false;
                inputCode.SelectAll();
                inputCode.SelectionColor = Color.Black;
                inputCode.DeselectAll();
            }
            else
            {
                MarkWords = true;
                ((ToolStripMenuItem)menuMark).Checked = true;
                inputCode.ForeColor = Color.Black;
                executeMarkup();
            }
        }
        private void openFile()
        {
            if (!string.IsNullOrWhiteSpace(inputCode.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to load new file? Current code will be erased.", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No) return;
            }
            Stream myStream = null;
            OpenFileDialog openLoadDialog = new OpenFileDialog();
            openLoadDialog.InitialDirectory = "c:\\";
            openLoadDialog.Filter = "Html files (*.html)|*.html|Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openLoadDialog.FilterIndex = 1;
            openLoadDialog.RestoreDirectory = true;
            if (openLoadDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openLoadDialog.OpenFile()) != null)
                    {
                        mainFile = System.IO.File.ReadAllText(openLoadDialog.FileName);
                        filePath = openLoadDialog.FileName;
                        this.Text = "HTML Editor - " + filePath;
                        inputCode.Text = mainFile;
                    }
                    myStream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            inputCode.SelectAll();
            inputCode.SelectionColor = Color.Black;
            inputCode.DeselectAll();
            if (MarkWords == true)
            {
                executeMarkup();
            }
        }
        private void saveFile()
        {
            if (filePath == null)
            {
                saveFileAs();
            }
            else
            {
                System.IO.File.WriteAllText(filePath, inputCode.Text);
            }
            this.Text = "HTML Editor - " + filePath;
        }
        private void saveFileAs()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Html file|*.html|Text document|*.txt";
            saveFile.Title = "Save file";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                System.IO.File.WriteAllText(saveFile.FileName,inputCode.Text);
            }
            filePath = saveFile.FileName;
            this.Text = "HTML Editor - " + filePath; 
        }
        private void copyText()
        {
            if (inputCode.SelectedText.Any())
            {
                inputCode.Copy();
            }
        }
        private void pasteText()
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                inputCode.Paste();
            }
            executeMarkup();
        }
        //OPEN FILE
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            saveFileAs();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void inputCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.O)
                {
                    openFile();
                    e.SuppressKeyPress = true;
                }
                if (e.KeyCode == Keys.S)
                {
                    saveFile();
                    e.SuppressKeyPress = true;
                }
                if (e.KeyCode == Keys.V)
                {
                    pasteText();
                    e.SuppressKeyPress = true;
                }
                if (e.KeyCode == Keys.C)
                {
                    copyText();
                    e.SuppressKeyPress = true;
                }
            }
            if (SenseVisible)
            {
                if (e.KeyCode == Keys.Down && senseList.SelectedIndex < senseList.Items.Count-1)
                {
                    senseList.SelectedIndex++;
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Up && senseList.SelectedIndex > 0)
                {
                    senseList.SelectedIndex--;
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    int selectPos = inputCode.SelectionStart - SenseLength;
                    inputCode.Text = inputCode.Text.Remove(selectPos, SenseLength);
                    inputCode.Text = inputCode.Text.Insert(selectPos, SenseWordList[senseList.SelectedIndex]);
                    inputCode.SelectionStart = selectPos + SenseWordList[senseList.SelectedIndex].Length;
                    senseList.Hide();
                    SenseVisible = false;
                    executeMarkupOnSingleWord();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void toolOpen_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void toolSaveAs_Click(object sender, EventArgs e)
        {
            saveFileAs();
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            copyText();
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            pasteText();
        }

        private void contextCopy_Click(object sender, EventArgs e)
        {
            copyText();
        }

        private void contextPaste_Click(object sender, EventArgs e)
        {
            pasteText();
        }
        public void AppendText(string data)
        {
            inputCode.Text = data;
            inputCode.SelectAll();
            inputCode.SelectionColor = Color.Black;
            inputCode.DeselectAll();
            if (MarkWords == true)
            {
                executeMarkup();
            }
        }
        public string GetText()
        {
            return inputCode.Text;
        }
        public int GetTextLength()
        {
            return inputCode.Text.Length;
        }
        private void toolGetFromServer_Click(object sender, EventArgs e)
        {
            frmGetHTML tempForm = new frmGetHTML();
            tempForm.parent = this;
            tempForm.Show();
        }

        private void toolWebPreview_Click(object sender, EventArgs e)
        {
            frmWebPreview tempForm = new frmWebPreview(inputCode.Text);
            tempForm.Show();
        }

        private void toolGetFromServer_Click_1(object sender, EventArgs e)
        {
            frmGetServerData tempForm = new frmGetServerData();
            tempForm.parent = this;
            tempForm.Show();
        }

        private void menuGetFromServer_Click(object sender, EventArgs e)
        {
            frmGetServerData tempForm = new frmGetServerData();
            tempForm.parent = this;
            tempForm.Show();
        }

        private void toolSendToServer_Click(object sender, EventArgs e)
        {
            frmSendToServer tempForm = new frmSendToServer();
            tempForm.parent = this;
            tempForm.Show();
        }
    }
}
