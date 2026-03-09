namespace ToDoList {
  partial class Form1 {
    /// <summary>
    /// Wymagana zmienna projektanta.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Wyczyść wszystkie używane zasoby.
    /// </summary>
    /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
        }
      base.Dispose(disposing);
      }

    #region Kod generowany przez Projektanta formularzy systemu Windows

    /// <summary>
    /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
    /// jej zawartości w edytorze kodu.
    /// </summary>
    private void InitializeComponent() {
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.entriesListView = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteButton = new System.Windows.Forms.Button();
      this.newButton = new System.Windows.Forms.Button();
      this.descriptionTextBox = new System.Windows.Forms.TextBox();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.dueDateLabel = new System.Windows.Forms.Label();
      this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
      this.titleTextBox = new System.Windows.Forms.TextBox();
      this.titleLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.entriesListView);
      this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.deleteButton);
      this.splitContainer1.Panel2.Controls.Add(this.newButton);
      this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
      this.splitContainer1.Panel2.Controls.Add(this.descriptionLabel);
      this.splitContainer1.Panel2.Controls.Add(this.dueDateLabel);
      this.splitContainer1.Panel2.Controls.Add(this.dueDatePicker);
      this.splitContainer1.Panel2.Controls.Add(this.titleTextBox);
      this.splitContainer1.Panel2.Controls.Add(this.titleLabel);
      this.splitContainer1.Size = new System.Drawing.Size(882, 553);
      this.splitContainer1.SplitterDistance = 277;
      this.splitContainer1.TabIndex = 0;
      // 
      // entriesListView
      // 
      this.entriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
      this.entriesListView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.entriesListView.FullRowSelect = true;
      this.entriesListView.GridLines = true;
      this.entriesListView.HideSelection = false;
      this.entriesListView.Location = new System.Drawing.Point(0, 28);
      this.entriesListView.MultiSelect = false;
      this.entriesListView.Name = "entriesListView";
      this.entriesListView.Size = new System.Drawing.Size(882, 249);
      this.entriesListView.TabIndex = 1;
      this.entriesListView.UseCompatibleStateImageBehavior = false;
      this.entriesListView.View = System.Windows.Forms.View.Details;
      this.entriesListView.Click += new System.EventHandler(this.entriesListView_SelectedIndexChanged);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Tytuł";
      this.columnHeader1.Width = 300;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Do dnia";
      this.columnHeader2.Width = 150;
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(882, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "ToDo List";
      // 
      // plikToolStripMenuItem
      // 
      this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
      this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
      this.plikToolStripMenuItem.Text = "Plik";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.newToolStripMenuItem.Text = "Nowy";
      // 
      // loadToolStripMenuItem
      // 
      this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.loadToolStripMenuItem.Text = "Wczytaj";
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.saveToolStripMenuItem.Text = "Zapisz";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.exitToolStripMenuItem.Text = "Zakończ";
      // 
      // deleteButton
      // 
      this.deleteButton.Location = new System.Drawing.Point(500, 60);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(75, 23);
      this.deleteButton.TabIndex = 9;
      this.deleteButton.Text = "Usuń";
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // newButton
      // 
      this.newButton.Location = new System.Drawing.Point(500, 20);
      this.newButton.Name = "newButton";
      this.newButton.Size = new System.Drawing.Size(75, 23);
      this.newButton.TabIndex = 8;
      this.newButton.Text = "Nowe";
      this.newButton.UseVisualStyleBackColor = true;
      this.newButton.Click += new System.EventHandler(this.newButton_Click);
      // 
      // descriptionTextBox
      // 
      this.descriptionTextBox.AcceptsReturn = true;
      this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.descriptionTextBox.Location = new System.Drawing.Point(100, 88);
      this.descriptionTextBox.Multiline = true;
      this.descriptionTextBox.Name = "descriptionTextBox";
      this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.descriptionTextBox.Size = new System.Drawing.Size(438, 100);
      this.descriptionTextBox.TabIndex = 7;
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.Location = new System.Drawing.Point(20, 90);
      this.descriptionLabel.Name = "descriptionLabel";
      this.descriptionLabel.Size = new System.Drawing.Size(38, 16);
      this.descriptionLabel.TabIndex = 6;
      this.descriptionLabel.Text = "Opis:";
      // 
      // dueDateLabel
      // 
      this.dueDateLabel.AutoSize = true;
      this.dueDateLabel.Location = new System.Drawing.Point(20, 55);
      this.dueDateLabel.Name = "dueDateLabel";
      this.dueDateLabel.Size = new System.Drawing.Size(57, 16);
      this.dueDateLabel.TabIndex = 5;
      this.dueDateLabel.Text = "Do dnia:";
      // 
      // dueDatePicker
      // 
      this.dueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dueDatePicker.Location = new System.Drawing.Point(100, 55);
      this.dueDatePicker.Name = "dueDatePicker";
      this.dueDatePicker.Size = new System.Drawing.Size(200, 22);
      this.dueDatePicker.TabIndex = 3;
      // 
      // titleTextBox
      // 
      this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.titleTextBox.Location = new System.Drawing.Point(100, 20);
      this.titleTextBox.Name = "titleTextBox";
      this.titleTextBox.Size = new System.Drawing.Size(250, 22);
      this.titleTextBox.TabIndex = 1;
      // 
      // titleLabel
      // 
      this.titleLabel.AutoSize = true;
      this.titleLabel.Location = new System.Drawing.Point(20, 20);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(42, 16);
      this.titleLabel.TabIndex = 0;
      this.titleLabel.Text = "Tytuł:\r\n";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(882, 553);
      this.Controls.Add(this.splitContainer1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ToDo List";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ListView entriesListView;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.TextBox titleTextBox;
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.DateTimePicker dueDatePicker;
    private System.Windows.Forms.Label dueDateLabel;
    private System.Windows.Forms.Label descriptionLabel;
    private System.Windows.Forms.TextBox descriptionTextBox;
    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Button newButton;
    }
  }

