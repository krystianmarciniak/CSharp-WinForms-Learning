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
    private List<string> dragDropItems = new List<string>();
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

      if(listBox.SelectedItems.Count==0)
        return;

      dragDropSource=listBox;
      dragDropItems=new List<string>();

      foreach(var selectedItem in listBox.SelectedItems) {
        dragDropItems.Add(selectedItem.ToString());
        }

      listBox.DoDragDrop(dragDropItems,DragDropEffects.Copy|DragDropEffects.Move);
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

      if(e.Data.GetDataPresent(typeof(List<string>))) {
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

      if(!e.Data.GetDataPresent(typeof(List<string>)))
        return;

      List<string> items = (List<string>)e.Data.GetData(typeof(List<string>));

      Point point = targetListBox.PointToClient(new Point(e.X,e.Y));
      int index = targetListBox.IndexFromPoint(point);

      if(index==ListBox.NoMatches)
        index=targetListBox.Items.Count;

      foreach(string item in items) {
        targetListBox.Items.Insert(index,item);
        index++;
        }

      if(e.Effect==DragDropEffects.Move&&dragDropSource!=null) {
        foreach(string item in items) {
          dragDropSource.Items.Remove(item);
          }
        }
      }

    private void buttonReset_Click(object sender,EventArgs e) {
      listBox1.Items.Clear();
      listBox2.Items.Clear();

      listBox1.Items.AddRange(new object[] {
    "Element 1",
    "Element 2",
    "Element 3",
    "Element 4",
    "Element 5",
    "Element 6",
    "Element 7",
    "Element 8",
    "Element 9",
    "Element 10"
  });

      listBox2.Items.AddRange(new object[] {
    "Pozycja A",
    "Pozycja B",
    "Pozycja C",
    "Pozycja D",
    "Pozycja E",
    "Pozycja F",
    "Pozycja G",
    "Pozycja H",
    "Pozycja I",
    "Pozycja J"
  });

      dragDropSource=null;
      dragDropItems.Clear();
      }
    }
  }