using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropLists {
  public partial class Form1:Form {
    private ListBox dragDropSource;

    public Form1() {
      InitializeComponent();

      listBox1.MouseDown+=ListBox_MouseDown;
      listBox2.MouseDown+=ListBox_MouseDown;

      listBox1.AllowDrop=true;
      listBox2.AllowDrop=true;

      listBox1.DragOver+=ListBox_DragOver;
      listBox2.DragOver+=ListBox_DragOver;

      listBox1.DragDrop+=ListBox_DragDrop;
      listBox2.DragDrop+=ListBox_DragDrop;
      }

    private void ListBox_MouseDown(object sender,MouseEventArgs e) {
      ListBox listBox = sender as ListBox;

      if(listBox==null)
        return;

      int index = listBox.IndexFromPoint(e.Location);

      if(index==ListBox.NoMatches)
        return;

      dragDropSource=listBox;
      string item = listBox.Items[index].ToString();

      listBox.DoDragDrop(item,DragDropEffects.Copy|DragDropEffects.Move);
      }

    private void ListBox_DragOver(object sender,DragEventArgs e) {
      ListBox targetListBox = sender as ListBox;

      if(targetListBox==null) {
        e.Effect=DragDropEffects.None;
        return;
        }

      if(dragDropSource==null) {
        e.Effect=DragDropEffects.None;
        return;
        }

      if(targetListBox==dragDropSource) {
        e.Effect=DragDropEffects.None;
        return;
        }

      if(e.Data.GetDataPresent(DataFormats.StringFormat)) {
        if((e.KeyState&8)==8)
          e.Effect=DragDropEffects.Copy;
        else
          e.Effect=DragDropEffects.Move;
        } else {
        e.Effect=DragDropEffects.None;
        }
      }

    private void ListBox_DragDrop(object sender,DragEventArgs e) {
      ListBox targetListBox = sender as ListBox;

      if(targetListBox==null)
        return;

      if(!e.Data.GetDataPresent(DataFormats.StringFormat))
        return;

      string item = (string)e.Data.GetData(DataFormats.StringFormat);

      targetListBox.Items.Add(item);

      if(e.Effect==DragDropEffects.Move&&dragDropSource!=null) {
        dragDropSource.Items.Remove(item);
        }
      }
    }
  }