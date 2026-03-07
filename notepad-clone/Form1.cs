using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notepad {
  public partial class Form1:Form {
    private bool _isModified = false;
    private string _currentFilePath = "";

    public Form1() {
      InitializeComponent();

      fontDialog1.ShowColor = true;
      this.KeyPreview = true;

      Notatnik.TextChanged += Notatnik_TextChanged;
      Notatnik.KeyDown += Notatnik_KeyDown;
      Notatnik.KeyUp += Notatnik_KeyUp;
      Notatnik.MouseUp += Notatnik_MouseUp;
      this.FormClosing += Form1_FormClosing;

      UpdateTitle();
      UpdateStatusBar();
      }

    private void Form1_Load(object sender,EventArgs e) {
      }

    private void UpdateTitle() {
      string fileName = string.IsNullOrEmpty(_currentFilePath)
          ? "Untitled"
          : Path.GetFileName(_currentFilePath);

      if(_isModified)
        fileName = "*" + fileName;

      this.Text = fileName + " - Notepad Clone";
      }

    private void UpdateStatusBar() {
      if(statusStrip1 == null || !statusStrip1.Visible)
        return;

      int index = Notatnik.SelectionStart;
      int line = Notatnik.GetLineFromCharIndex(index);
      int col = index - Notatnik.GetFirstCharIndexFromLine(line);

      toolStripStatusLabelPos.Text = $"Ln {line + 1}, Col {col + 1}";

      int chars = Notatnik.Text.Length;
      int lines = Notatnik.Lines.Length;

      toolStripStatusLabelCount.Text = $"Lines: {lines} | Chars: {chars}";
      }

    private void Notatnik_TextChanged(object sender,EventArgs e) {
      _isModified = true;
      UpdateTitle();
      UpdateStatusBar();
      }


    private void Notatnik_KeyDown(object sender,KeyEventArgs e) {
      if(e.Control && e.KeyCode == Keys.A) {
        Notatnik.SelectAll();
        e.SuppressKeyPress = true;
        }
      }

    private bool SaveAs() {
      try {
        saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        saveFileDialog1.DefaultExt = "txt";
        saveFileDialog1.AddExtension = true;

        if(!string.IsNullOrWhiteSpace(_currentFilePath))
          saveFileDialog1.FileName = _currentFilePath;

        if(saveFileDialog1.ShowDialog() != DialogResult.OK)
          return false;

        string path = saveFileDialog1.FileName;
        File.WriteAllText(path,Notatnik.Text);

        _currentFilePath = path;
        _isModified = false;
        UpdateTitle();
        UpdateStatusBar();
        return true;
        } catch(Exception ex) {
        MessageBox.Show("File save error: " + ex.Message);
        return false;
        }
      }

    private bool SaveFile() {
      try {
        if(string.IsNullOrEmpty(_currentFilePath))
          return SaveAs();

        File.WriteAllText(_currentFilePath,Notatnik.Text);
        _isModified = false;
        UpdateTitle();
        UpdateStatusBar();
        return true;
        } catch(Exception ex) {
        MessageBox.Show("File save error: " + ex.Message);
        return false;
        }
      }

    private bool ConfirmSaveChanges() {
      if(!_isModified)
        return true;

      DialogResult result = MessageBox.Show(
          "Do you want to save changes?",
          "Notepad Clone",
          MessageBoxButtons.YesNoCancel,
          MessageBoxIcon.Warning);

      if(result == DialogResult.Yes) {
        return SaveFile();
        } else if(result == DialogResult.No) {
        return true;
        } else {
        return false;
        }
      }

    private void newToolStripMenuItem_Click(object sender,EventArgs e) {
      if(!ConfirmSaveChanges())
        return;

      Notatnik.Clear();
      _currentFilePath = "";
      _isModified = false;
      UpdateTitle();
      UpdateStatusBar();
      }

    private void openToolStripMenuItem_Click(object sender,EventArgs e) {
      if(!ConfirmSaveChanges())
        return;

      try {
        openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

        if(openFileDialog1.ShowDialog() == DialogResult.OK) {
          Notatnik.Text = File.ReadAllText(openFileDialog1.FileName);
          _currentFilePath = openFileDialog1.FileName;
          _isModified = false;
          UpdateTitle();
          UpdateStatusBar();
          }
        } catch(Exception ex) {
        MessageBox.Show("File read error: " + ex.Message);
        }
      }

    private void saveToolStripMenuItem_Click(object sender,EventArgs e) {
      SaveFile();
      }

    private void zamknijToolStripMenuItem_Click(object sender,EventArgs e) {
      Close();
      }

    private void Form1_FormClosing(object sender,FormClosingEventArgs e) {
      if(!ConfirmSaveChanges()) {
        e.Cancel = true;
        }
      }

    private void cofnijToolStripMenuItem_Click(object sender,EventArgs e) {
      if(Notatnik.CanUndo)
        Notatnik.Undo();
      }

    private void wytnijToolStripMenuItem_Click(object sender,EventArgs e) {
      Notatnik.Cut();
      }

    private void kopiujToolStripMenuItem_Click(object sender,EventArgs e) {
      Notatnik.Copy();
      }

    private void wklejToolStripMenuItem_Click(object sender,EventArgs e) {
      Notatnik.Paste();
      }

    private void usunToolStripMenuItem_Click(object sender,EventArgs e) {
      Notatnik.SelectedText = "";
      }

    private void zaznaczWszystkoToolStripMenuItem_Click(object sender,EventArgs e) {
      Notatnik.SelectAll();
      }

    private void czcionkaToolStripMenuItem_Click(object sender,EventArgs e) {
      fontDialog1.Font = Notatnik.Font;
      fontDialog1.Color = Notatnik.ForeColor;

      if(fontDialog1.ShowDialog() == DialogResult.OK) {
        Notatnik.Font = fontDialog1.Font;
        Notatnik.ForeColor = fontDialog1.Color;
        }
      }

    private void tłoToolStripMenuItem_Click(object sender,EventArgs e) {
      if(colorDialog1.ShowDialog() == DialogResult.OK) {
        Notatnik.BackColor = colorDialog1.Color;
        }
      }

    private void pasekstanuToolStripMenuItem_Click(object sender,EventArgs e) {
      statusStrip1.Visible = pasekstanuToolStripMenuItem.Checked;
      UpdateStatusBar();
      }

    private void Notatnik_KeyUp(object sender,KeyEventArgs e) {
      UpdateStatusBar();
      }

    private void Notatnik_MouseUp(object sender,MouseEventArgs e) {
      UpdateStatusBar();
      }

    private void otworzToolStripMenuItem_Click(object sender,EventArgs e) {
      openToolStripMenuItem_Click(sender,e);
      }

    private void zapiszJakoToolStripMenuItem_Click(object sender,EventArgs e) {
      saveToolStripMenuItem_Click(sender,e);
      }

    private void saveAsToolStripMenuItem_Click(object sender,EventArgs e) {
      SaveAs();
      }
    }


    
  }
