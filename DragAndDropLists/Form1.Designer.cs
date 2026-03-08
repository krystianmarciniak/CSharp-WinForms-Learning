namespace DragAndDropLists {
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
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.buttonReset = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.listBox1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.buttonReset);
      this.splitContainer1.Panel2.Controls.Add(this.listBox2);
      this.splitContainer1.Size = new System.Drawing.Size(1156, 619);
      this.splitContainer1.SplitterDistance = 572;
      this.splitContainer1.TabIndex = 0;
      // 
      // listBox1
      // 
      this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Items.AddRange(new object[] {
            "Element 1",
            "Element 2",
            "Element 3",
            "Element 4",
            "Element 5",
            "Element 6",
            "Element 7",
            "Element 8",
            "Element 9",
            "Element 10"});
      this.listBox1.Location = new System.Drawing.Point(0, 0);
      this.listBox1.Name = "listBox1";
      this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listBox1.Size = new System.Drawing.Size(572, 619);
      this.listBox1.TabIndex = 0;
      // 
      // listBox2
      // 
      this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBox2.FormattingEnabled = true;
      this.listBox2.ItemHeight = 16;
      this.listBox2.Items.AddRange(new object[] {
            "Pozycja A",
            "Pozycja B",
            "Pozycja C",
            "Pozycja D",
            "Pozycja E",
            "Pozycja F",
            "Pozycja G",
            "Pozycja H",
            "Pozycja I",
            "Pozycja J"});
      this.listBox2.Location = new System.Drawing.Point(0, 0);
      this.listBox2.Name = "listBox2";
      this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listBox2.Size = new System.Drawing.Size(580, 619);
      this.listBox2.TabIndex = 0;
      // 
      // buttonReset
      // 
      this.buttonReset.Location = new System.Drawing.Point(451, 21);
      this.buttonReset.Name = "buttonReset";
      this.buttonReset.Size = new System.Drawing.Size(75, 23);
      this.buttonReset.TabIndex = 1;
      this.buttonReset.Text = "Reset";
      this.buttonReset.UseVisualStyleBackColor = true;
      this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1156, 619);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Projekt Drag & Drop";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.Button buttonReset;
    }
  }

