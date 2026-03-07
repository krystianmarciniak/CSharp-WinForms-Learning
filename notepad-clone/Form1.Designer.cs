namespace Notepad {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.Notatnik = new System.Windows.Forms.TextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.otwórzToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.zapiszJakoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasekstanuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.fontDialog1 = new System.Windows.Forms.FontDialog();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelPos = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Notatnik
      // 
      this.Notatnik.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Notatnik.Location = new System.Drawing.Point(0, 30);
      this.Notatnik.Multiline = true;
      this.Notatnik.Name = "Notatnik";
      this.Notatnik.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.Notatnik.Size = new System.Drawing.Size(800, 420);
      this.Notatnik.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.widokToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 30);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // otwórzToolStripMenuItem
      // 
      this.otwórzToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
      this.otwórzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.otwórzToolStripMenuItem1,
            this.zapiszJakoToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zamknijToolStripMenuItem});
      this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
      this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
      this.otwórzToolStripMenuItem.Text = "File";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
      this.newToolStripMenuItem.Text = "New ";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
      // 
      // otwórzToolStripMenuItem1
      // 
      this.otwórzToolStripMenuItem1.Name = "otwórzToolStripMenuItem1";
      this.otwórzToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.otwórzToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
      this.otwórzToolStripMenuItem1.Text = "Open...";
      this.otwórzToolStripMenuItem1.Click += new System.EventHandler(this.otworzToolStripMenuItem_Click);
      // 
      // zapiszJakoToolStripMenuItem1
      // 
      this.zapiszJakoToolStripMenuItem1.Name = "zapiszJakoToolStripMenuItem1";
      this.zapiszJakoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.zapiszJakoToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
      this.zapiszJakoToolStripMenuItem1.Text = "&Save";
      this.zapiszJakoToolStripMenuItem1.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
      this.saveAsToolStripMenuItem.Text = "Save As...";
      this.saveAsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
      // 
      // zamknijToolStripMenuItem
      // 
      this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
      this.zamknijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
      this.zamknijToolStripMenuItem.Text = "Exit";
      this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
      // 
      // zapiszJakoToolStripMenuItem
      // 
      this.zapiszJakoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.toolStripMenuItem2,
            this.wytnijToolStripMenuItem,
            this.kopiujToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.zaznaczWszystkoToolStripMenuItem});
      this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
      this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
      this.zapiszJakoToolStripMenuItem.Text = "Edit";
      // 
      // cofnijToolStripMenuItem
      // 
      this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
      this.cofnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
      this.cofnijToolStripMenuItem.Text = "Undo ";
      this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 6);
      // 
      // wytnijToolStripMenuItem
      // 
      this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
      this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
      this.wytnijToolStripMenuItem.Text = "Cut";
      this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
      // 
      // kopiujToolStripMenuItem
      // 
      this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
      this.kopiujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
      this.kopiujToolStripMenuItem.Text = "Copy";
      this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
      // 
      // wklejToolStripMenuItem
      // 
      this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
      this.wklejToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.wklejToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
      this.wklejToolStripMenuItem.Text = "Paste";
      this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
      // 
      // usuńToolStripMenuItem
      // 
      this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
      this.usuńToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
      this.usuńToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
      this.usuńToolStripMenuItem.Text = "Delete";
      // 
      // zaznaczWszystkoToolStripMenuItem
      // 
      this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
      this.zaznaczWszystkoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
      this.zaznaczWszystkoToolStripMenuItem.Text = "Select all";
      this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
      // 
      // widokToolStripMenuItem
      // 
      this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czcionkaToolStripMenuItem,
            this.tłoToolStripMenuItem,
            this.pasekstanuToolStripMenuItem});
      this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
      this.widokToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
      this.widokToolStripMenuItem.Text = "View";
      // 
      // czcionkaToolStripMenuItem
      // 
      this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
      this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
      this.czcionkaToolStripMenuItem.Text = "&Font";
      this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
      // 
      // tłoToolStripMenuItem
      // 
      this.tłoToolStripMenuItem.Name = "tłoToolStripMenuItem";
      this.tłoToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
      this.tłoToolStripMenuItem.Text = "&Background";
      this.tłoToolStripMenuItem.Click += new System.EventHandler(this.tłoToolStripMenuItem_Click);
      // 
      // pasekstanuToolStripMenuItem
      // 
      this.pasekstanuToolStripMenuItem.CheckOnClick = true;
      this.pasekstanuToolStripMenuItem.Name = "pasekstanuToolStripMenuItem";
      this.pasekstanuToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
      this.pasekstanuToolStripMenuItem.Text = "Status &bar";
      this.pasekstanuToolStripMenuItem.Click += new System.EventHandler(this.pasekstanuToolStripMenuItem_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.DefaultExt = "txt";
      this.openFileDialog1.FileName = "wyczyść";
      this.openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Pliki INI (*.ini)|*.ini|Pliki źródłowe (*.cs)|*.cs|W" +
    "szystkie pliki (*.*)|*.*";
      this.openFileDialog1.InitialDirectory = ".";
      this.openFileDialog1.Title = "Wczytaj plik";
      // 
      // saveFileDialog1
      // 
      this.saveFileDialog1.DefaultExt = "txt";
      this.saveFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Pliki INI (*.ini)|*.ini|Pliki źródłowe (*.cs)|*.cs|W" +
    "szystkie pliki (*.*)|*.*";
      this.saveFileDialog1.InitialDirectory = ".";
      this.saveFileDialog1.Title = "Zapisz do pliku";
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPos,
            this.toolStripStatusLabelCount});
      this.statusStrip1.Location = new System.Drawing.Point(0, 424);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(800, 26);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabelPos
      // 
      this.toolStripStatusLabelPos.Name = "toolStripStatusLabelPos";
      this.toolStripStatusLabelPos.Size = new System.Drawing.Size(667, 20);
      this.toolStripStatusLabelPos.Spring = true;
      this.toolStripStatusLabelPos.Text = "Ln 1, Col 1";
      // 
      // toolStripStatusLabelCount
      // 
      this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
      this.toolStripStatusLabelCount.Size = new System.Drawing.Size(118, 20);
      this.toolStripStatusLabelCount.Text = "Linie: 1 | Znaki: 0";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.Notatnik);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Untitled - Notepad Clone";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.TextBox Notatnik;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tłoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasekstanuToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.FontDialog fontDialog1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPos;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
    }
  }

