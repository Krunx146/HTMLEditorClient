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
        public bool MarkWords;
        public string filePath;
        public string mainFile;

        public frmMain()
        {
            InitializeComponent();
            ((ToolStripMenuItem)pTool10p).Checked = true;
            ((ToolStripMenuItem)menuMark).Checked = true;
            ((ToolStripMenuItem)menuSynchronise).Enabled = false;
            loadMarkup();
            MarkWords = true;
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
            foreach (string s in MarkupListHTML) CheckWord(s, Color.Blue, 0);
            foreach (string s in MarkupListCSS) CheckWord(s, Color.Green, 0);
        }

        private void inputCode_TextChanged(object sender, EventArgs e)
        {
            outputLineNumber.Text = "Line: " + (inputCode.GetLineFromCharIndex(inputCode.SelectionStart)+1) + " of " + inputCode.Lines.Count().ToString();
            inputCode.ForeColor = Color.Black;
            if (MarkWords == true)
            {
                executeMarkup();
            }
            this.Text = "HTML Editor - " + filePath + "*";
        }
        private void CheckWord(string word, Color color, int startIndex)
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
        //OPEN FILE
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputCode.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to load new file? Current code will be erased.","Warning", MessageBoxButtons.YesNo);
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
            if(MarkWords == true)
            {
                executeMarkup();
            }
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
            if(filePath == null)
            {
                saveFileAs();
            }
            else
            {
                System.IO.File.WriteAllText(filePath, inputCode.Text);
            }
            this.Text = "HTML Editor - " + filePath;
        }

        private void inputCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
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
                e.SuppressKeyPress = true;
            }
        }
    }
}