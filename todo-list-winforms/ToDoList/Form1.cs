using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ToDoList {
  public partial class Form1:Form {
    private BindingList<ToDoEntry> _entries = new BindingList<ToDoEntry>();
    private BindingSource _entriesSource = new BindingSource();

    private bool _isModified = false;
    private string _currentFilePath = "";
    private bool _isUpdatingControls = false;
    public Form1() {
      InitializeComponent();

      _entriesSource.DataSource = _entries;
      _entries.ListChanged += Entries_ListChanged;

      entriesListView.FullRowSelect = true;
      entriesListView.MultiSelect = false;
      entriesListView.HideSelection = false;
      entriesListView.View = View.Details;
      entriesListView.KeyDown += EntriesListView_KeyDown;
      entriesListView.GridLines = true;

      this.FormClosing += Form1_FormClosing;
      this.Load += Form1_Load;
      this.KeyPreview = true;

      RefreshEntriesListView();
      UpdateTitle();

      if(Properties.Settings.Default.WindowWidth > 0) {
        this.Width = Properties.Settings.Default.WindowWidth;
        this.Height = Properties.Settings.Default.WindowHeight;
        this.Left = Properties.Settings.Default.WindowX;
        this.Top = Properties.Settings.Default.WindowY;
        }
      }
    private void RefreshEntriesListView() {
      entriesListView.Items.Clear();

      foreach(ToDoEntry entry in _entries) {
        ListViewItem item = new ListViewItem(entry.Title);
        item.SubItems.Add(entry.DueDate.ToShortDateString());
        item.Tag = entry;

        entriesListView.Items.Add(item);
        }
      UpdateStatusBar();
      entriesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
      entriesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
      }
    private void UpdateTitle() {
      string fileName = string.IsNullOrEmpty(_currentFilePath)
          ? "Nowy plik"
          : System.IO.Path.GetFileName(_currentFilePath);

      string modifiedMark = _isModified ? " *" : "";

      this.Text = $"ToDo List - {fileName}{modifiedMark}";
      }
    private void MarkAsModified() {
      _isModified = true;
      UpdateTitle();
      }
    private void ClearEditor() {
      _isUpdatingControls = true;

      titleTextBox.Text = "";
      dueDatePicker.Value = DateTime.Now;
      descriptionTextBox.Text = "";

      _isUpdatingControls = false;
      }
    private void DisplayEntry(ToDoEntry entry) {
      if(entry == null) {
        ClearEditor();
        return;
        }

      _isUpdatingControls = true;

      titleTextBox.Text = entry.Title;
      dueDatePicker.Value = entry.DueDate;
      descriptionTextBox.Text = entry.Description;

      _isUpdatingControls = false;
      }
    private ToDoEntry GetSelectedEntry() {
      if(entriesListView.SelectedItems.Count == 0)
        return null;

      return entriesListView.SelectedItems[0].Tag as ToDoEntry;
      }
    private void Entries_ListChanged(object sender,ListChangedEventArgs e) {
      RefreshEntriesListView();
      UpdateTitle();
      }
    private void newButton_Click(object sender,EventArgs e) {
      ToDoEntry newEntry = new ToDoEntry {
        Title = "Nowe zadanie",
        DueDate = DateTime.Now,
        Description = ""
        };

      _entries.Add(newEntry);
      MarkAsModified();

      foreach(ListViewItem item in entriesListView.Items) {
        if(item.Tag == newEntry) {
          item.Selected = true;
          item.Focused = true;
          item.EnsureVisible();
          break;
          }
        }

      titleTextBox.Focus();
      titleTextBox.SelectAll();
      }
    private void deleteButton_Click(object sender,EventArgs e) {
      ToDoEntry selectedEntry = GetSelectedEntry();

      if(selectedEntry == null) {
        MessageBox.Show(
            "Najpierw wybierz zadanie do usunięcia.",
            "Brak zaznaczenia",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        return;
        }

      DialogResult result = MessageBox.Show(
          "Czy na pewno chcesz usunąć wybrane zadanie?",
          "Potwierdzenie usunięcia",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

      if(result == DialogResult.Yes) {

        int index = entriesListView.SelectedIndices[0];
        _entries.Remove(selectedEntry);
        MarkAsModified();

        if(entriesListView.Items.Count > 0) {
          if(index >= entriesListView.Items.Count)
            index = entriesListView.Items.Count - 1;

          entriesListView.Items[index].Selected = true;
          } else {
          ClearEditor();
          }
        }

      }
    private void entriesListView_SelectedIndexChanged(object sender,EventArgs e) {
      ToDoEntry selectedEntry = GetSelectedEntry();
      DisplayEntry(selectedEntry);
      }
    private void titleTextBox_TextChanged(object sender,EventArgs e) {
      if(_isUpdatingControls)
        return;

      ToDoEntry selectedEntry = GetSelectedEntry();
      if(selectedEntry == null)
        return;

      selectedEntry.Title = titleTextBox.Text;
      MarkAsModified();
      RefreshEntriesListView();
      RestoreSelection(selectedEntry);
      }
    private void dueDatePicker_ValueChanged(object sender,EventArgs e) {
      if(_isUpdatingControls)
        return;

      ToDoEntry selectedEntry = GetSelectedEntry();
      if(selectedEntry == null)
        return;

      selectedEntry.DueDate = dueDatePicker.Value;
      MarkAsModified();
      RefreshEntriesListView();
      RestoreSelection(selectedEntry);
      }
    private void descriptionTextBox_TextChanged(object sender,EventArgs e) {
      if(_isUpdatingControls)
        return;

      ToDoEntry selectedEntry = GetSelectedEntry();
      if(selectedEntry == null)
        return;

      selectedEntry.Description = descriptionTextBox.Text;
      MarkAsModified();
      }
    private void RestoreSelection(ToDoEntry entry) {
      if(entry == null)
        return;

      foreach(ListViewItem item in entriesListView.Items) {
        if(item.Tag == entry) {
          item.Selected = true;
          item.Focused = true;
          item.EnsureVisible();
          break;
          }
        }
      }
    private void exitToolStripMenuItem_Click(object sender,EventArgs e) {
      this.Close();
      }
    private void newToolStripMenuItem_Click(object sender,EventArgs e) {
      DialogResult result = MessageBox.Show(
          "Czy chcesz utworzyć nową listę? Niezapisane zmiany zostaną utracone.",
          "Nowa lista",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

      if(result == DialogResult.Yes) {
        _entries.Clear();
        _currentFilePath = "";
        _isModified = false;
        ClearEditor();
        RefreshEntriesListView();
        UpdateTitle();
        }
      }
    private void Form1_FormClosing(object sender,FormClosingEventArgs e) {
      if(!_isModified)
        return;

      if(!string.IsNullOrEmpty(_currentFilePath)) {
        SaveToFile(_currentFilePath);
        } else {
        DialogResult result = MessageBox.Show(
            "Masz niezapisane zmiany. Czy na pewno chcesz zamknąć program?",
            "Niezapisane zmiany",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if(result == DialogResult.No) {
          e.Cancel = true;
          return;
          }
        }
      Properties.Settings.Default.WindowWidth = this.Width;
      Properties.Settings.Default.WindowHeight = this.Height;
      Properties.Settings.Default.WindowX = this.Left;
      Properties.Settings.Default.WindowY = this.Top;

      Properties.Settings.Default.Save();
      }
    private void SaveToFile(string filePath) {
      try {
        string json = JsonConvert.SerializeObject(_entries,Formatting.Indented);

        File.WriteAllText(filePath,json);

        _currentFilePath = filePath;
        _isModified = false;
        UpdateTitle();
        } catch(Exception ex) {
        MessageBox.Show(
            "Błąd podczas zapisu pliku:\n" + ex.Message,
            "Błąd zapisu",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }
      }
    private void LoadFromFile(string filePath) {
      try {
        string json = File.ReadAllText(filePath);
        List<ToDoEntry> loadedEntries = JsonConvert.DeserializeObject<List<ToDoEntry>>(json);
        _entries.Clear();

        if(loadedEntries != null) {
          foreach(ToDoEntry entry in loadedEntries) {
            _entries.Add(entry);
            }
          }
        _currentFilePath = filePath;
        _isModified = false;
        this.Text = "ToDo List - " + Path.GetFileName(_currentFilePath);
        RefreshEntriesListView();
        ClearEditor();
        UpdateTitle();

        } catch(Exception ex) {
        MessageBox.Show(
            "Błąd podczas wczytywania pliku:\n" + ex.Message,
            "Błąd wczytywania",
            MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
      }
    private void saveToolStripMenuItem_Click(object sender,EventArgs e) {
      if(string.IsNullOrEmpty(_currentFilePath)) {
        SaveFileDialog dialog = new SaveFileDialog();
        dialog.Filter = "JSON files (*.json)|*.json";
        dialog.Title = "Zapisz listę zadań";
        dialog.FileName = "tasks.json";

        if(dialog.ShowDialog() == DialogResult.OK) {
          SaveToFile(dialog.FileName);
          }
        } else {
        SaveToFile(_currentFilePath);
        }
      }
    private void loadToolStripMenuItem_Click(object sender,EventArgs e) {
      OpenFileDialog dialog = new OpenFileDialog();
      dialog.Filter = "JSON files (*.json)|*.json";
      dialog.Title = "Wczytaj listę zadań";

      if(dialog.ShowDialog() == DialogResult.OK) {
        LoadFromFile(dialog.FileName);
        _currentFilePath = dialog.FileName;
        }
      }
    private void Form1_Load(object sender,EventArgs e) {
      titleTextBox.Focus();
      titleTextBox.SelectAll();
      }
    private void UpdateStatusBar() {
      statusLabel.Text = $"Tasks: {_entries.Count}";
      }
    private void EntriesListView_KeyDown(object sender,KeyEventArgs e) {
      if(e.KeyCode == Keys.Delete) {
        DeleteSelectedEntry();
        }
      }
    private void DeleteSelectedEntry() {
      if(entriesListView.SelectedIndices.Count == 0)
        return;

      int index = entriesListView.SelectedIndices[0];
      _entries.RemoveAt(index);
      RefreshEntriesListView();
      _isModified = true;
      }
    }
  }
