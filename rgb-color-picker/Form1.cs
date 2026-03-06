using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolory {
  public partial class MainForm:Form {
    private List<string> colorHistory = new List<string>();

    public MainForm() {
      InitializeComponent();
      UpdatePreviewColor();
      }

    private void trackBarR_ValueChanged(object sender,EventArgs e) => UpdatePreviewColor();
    private void trackBarG_ValueChanged(object sender,EventArgs e) => UpdatePreviewColor();
    private void trackBarB_ValueChanged(object sender,EventArgs e) => UpdatePreviewColor();

    private void UpdatePreviewColor() {
      int r = trackBar1.Value;
      int g = trackBar2.Value;
      int b = trackBar3.Value;

      Color color = Color.FromArgb(r,g,b);
      panelPreview.BackColor = color;

      Text = $"RGB Color Picker | R={r} G={g} B={b}";

      string hex = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
      txtHex.Text = hex;

      const int MaxHistory = 20;

      if(!colorHistory.Contains(hex)) {
        colorHistory.Insert(0,hex);
        lstHistory.Items.Insert(0,hex);

        if(colorHistory.Count > MaxHistory) {
          colorHistory.RemoveAt(colorHistory.Count - 1);
          lstHistory.Items.RemoveAt(lstHistory.Items.Count - 1);
          }
        }
      }
    private void btnCopy_Click(object sender,EventArgs e) {
      Clipboard.SetText(txtHex.Text);
      MessageBox.Show("Skopiowano kolor HEX do schowka.","RGB Color Picker",
          MessageBoxButtons.OK,MessageBoxIcon.Information);
      }
    private void btnExit_Click(object sender,EventArgs e) => Close();
    private void MainForm_KeyDown(object sender,KeyEventArgs e) {
      if(e.KeyCode == Keys.Escape)
        Close();
      }
    private void MainForm_Load(object sender,EventArgs e) {
      }
    private void label1_Click(object sender,EventArgs e) {
      }
    }
  }