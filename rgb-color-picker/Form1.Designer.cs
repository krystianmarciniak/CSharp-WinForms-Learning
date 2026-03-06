namespace Kolory {
  partial class MainForm {
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
      this.panelPreview = new System.Windows.Forms.Panel();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.trackBar2 = new System.Windows.Forms.TrackBar();
      this.trackBar3 = new System.Windows.Forms.TrackBar();
      this.button1 = new System.Windows.Forms.Button();
      this.lblHex = new System.Windows.Forms.Label();
      this.txtHex = new System.Windows.Forms.TextBox();
      this.btnCopy = new System.Windows.Forms.Button();
      this.lstHistory = new System.Windows.Forms.ListBox();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
      this.SuspendLayout();
      // 
      // panelPreview
      // 
      this.panelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelPreview.Location = new System.Drawing.Point(229, 94);
      this.panelPreview.Name = "panelPreview";
      this.panelPreview.Size = new System.Drawing.Size(518, 133);
      this.panelPreview.TabIndex = 0;
      // 
      // trackBar1
      // 
      this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar1.LargeChange = 1;
      this.trackBar1.Location = new System.Drawing.Point(12, 233);
      this.trackBar1.Maximum = 255;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(776, 56);
      this.trackBar1.TabIndex = 1;
      this.trackBar1.TickFrequency = 5;
      this.trackBar1.ValueChanged += new System.EventHandler(this.trackBarR_ValueChanged);
      // 
      // trackBar2
      // 
      this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar2.LargeChange = 1;
      this.trackBar2.Location = new System.Drawing.Point(12, 295);
      this.trackBar2.Maximum = 255;
      this.trackBar2.Minimum = 1;
      this.trackBar2.Name = "trackBar2";
      this.trackBar2.Size = new System.Drawing.Size(776, 56);
      this.trackBar2.TabIndex = 2;
      this.trackBar2.TickFrequency = 5;
      this.trackBar2.Value = 1;
      this.trackBar2.ValueChanged += new System.EventHandler(this.trackBarG_ValueChanged);
      // 
      // trackBar3
      // 
      this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar3.LargeChange = 1;
      this.trackBar3.Location = new System.Drawing.Point(12, 357);
      this.trackBar3.Maximum = 255;
      this.trackBar3.Minimum = 1;
      this.trackBar3.Name = "trackBar3";
      this.trackBar3.Size = new System.Drawing.Size(776, 56);
      this.trackBar3.TabIndex = 3;
      this.trackBar3.TickFrequency = 5;
      this.trackBar3.Value = 1;
      this.trackBar3.ValueChanged += new System.EventHandler(this.trackBarB_ValueChanged);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(690, 415);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Wyjście";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // lblHex
      // 
      this.lblHex.AutoSize = true;
      this.lblHex.Location = new System.Drawing.Point(12, 18);
      this.lblHex.Name = "lblHex";
      this.lblHex.Size = new System.Drawing.Size(37, 16);
      this.lblHex.TabIndex = 5;
      this.lblHex.Text = "HEX:";
      this.lblHex.Click += new System.EventHandler(this.label1_Click);
      // 
      // txtHex
      // 
      this.txtHex.Location = new System.Drawing.Point(105, 18);
      this.txtHex.MaximumSize = new System.Drawing.Size(120, 0);
      this.txtHex.Name = "txtHex";
      this.txtHex.ReadOnly = true;
      this.txtHex.Size = new System.Drawing.Size(100, 22);
      this.txtHex.TabIndex = 6;
      // 
      // btnCopy
      // 
      this.btnCopy.Location = new System.Drawing.Point(488, 415);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Size = new System.Drawing.Size(75, 23);
      this.btnCopy.TabIndex = 7;
      this.btnCopy.Text = "btnCopy";
      this.btnCopy.UseVisualStyleBackColor = true;
      this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
      // 
      // lstHistory
      // 
      this.lstHistory.FormattingEnabled = true;
      this.lstHistory.ItemHeight = 16;
      this.lstHistory.Location = new System.Drawing.Point(24, 94);
      this.lstHistory.Name = "lstHistory";
      this.lstHistory.Size = new System.Drawing.Size(150, 116);
      this.lstHistory.TabIndex = 8;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lstHistory);
      this.Controls.Add(this.btnCopy);
      this.Controls.Add(this.txtHex);
      this.Controls.Add(this.lblHex);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.trackBar3);
      this.Controls.Add(this.trackBar2);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.panelPreview);
      this.KeyPreview = true;
      this.Name = "MainForm";
      this.Text = "RGB Color Picker";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.Panel panelPreview;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.TrackBar trackBar2;
    private System.Windows.Forms.TrackBar trackBar3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label lblHex;
    private System.Windows.Forms.TextBox txtHex;
    private System.Windows.Forms.Button btnCopy;
    private System.Windows.Forms.ListBox lstHistory;
    }
  }

