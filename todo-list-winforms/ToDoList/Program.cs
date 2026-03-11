using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList {
  internal static class Program {
    /// <summary>
    /// Główny punkt wejścia dla aplikacji.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      Application.ThreadException += (sender,args) =>
      {
        MessageBox.Show(
            "Unexpected error occurred:\n\n" + args.Exception.Message,
            "ToDoList",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
      };

      Application.Run(new Form1());
      }
    }
  }
