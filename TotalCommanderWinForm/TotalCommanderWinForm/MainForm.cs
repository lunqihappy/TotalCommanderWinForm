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

namespace TotalCommanderWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeComboboxes();
        }

        private void InitializeComboboxes()
        {
            comboBox1.Items.AddRange(DriveInfo.GetDrives().Select(d => d.Name).ToArray());
            comboBox2.Items.AddRange(DriveInfo.GetDrives().Select(d => d.Name).ToArray());
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void v_ButtonChooseLeftPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.RootFolder = Environment.SpecialFolder.MyComputer;

            if (string.IsNullOrEmpty(v_Label_LeftPath.Text))
            {
                fbd.SelectedPath = comboBox1.SelectedItem.ToString();
            }
            else
            {
                fbd.SelectedPath = v_Label_LeftPath.Text;
            }

            var result = fbd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                v_Label_LeftPath.Text = fbd.SelectedPath;
                PrintToConsoleOutput("Slected left path: {0}", fbd.SelectedPath);
                UpdateLeftListView(fbd.SelectedPath);
            }
        }

        private void v_ButtonChooseRightPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.RootFolder = Environment.SpecialFolder.MyComputer;

            if (string.IsNullOrEmpty(v_Label_RightPath.Text))
            {
                fbd.SelectedPath = comboBox2.SelectedItem.ToString();
            }
            else
            {
                fbd.SelectedPath = v_Label_RightPath.Text;
            }

            var result = fbd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                v_Label_RightPath.Text = fbd.SelectedPath;
                PrintToConsoleOutput("Slected right path: {0}", fbd.SelectedPath);
                UpdateRightListView(fbd.SelectedPath);
            }
        }

        private void PrintToConsoleOutput(string text, params object[] args)
        {
            var outputText = (Environment.NewLine + string.Format(text, args));
            v_TextBox_ConsoleOutput.AppendText(outputText);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            v_Label_LeftPath.Text = string.Empty;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            v_Label_RightPath.Text = string.Empty;
        }

        private void UpdateLeftListView(string path)
        {
            v_ListView_Left.Items.Clear();

            Directory.GetFiles(path).ForEach((i) =>
            {
                v_ListView_Left.Items.Add(i);
            });
        }

        private void UpdateRightListView(string path)
        {
            v_ListView_Right.Items.Clear();

            Directory.GetFiles(path).ForEach((i) =>
            {
                v_ListView_Right.Items.Add(i);
            });
        }

        private void v_ListView_Left_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void v_ListView_Right_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void v_ListView_Left_DragDrop(object sender, DragEventArgs e)
        {
            var items = (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(System.Windows.Forms.ListView.SelectedListViewItemCollection));

            foreach (ListViewItem item in items)
            {
                var fileName = item.Text;
                PrintToConsoleOutput("Left drop: {0}", fileName);
            }
        }

        private void v_ListView_Right_DragDrop(object sender, DragEventArgs e)
        {
            var items = (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(System.Windows.Forms.ListView.SelectedListViewItemCollection));

            foreach (ListViewItem item in items)
            {
                var fileName = item.Text;
                PrintToConsoleOutput("Right drop: {0}", fileName);
            }
        }

        private void v_ListView_Left_ItemDrag(object sender, ItemDragEventArgs e)
        {
            v_ListView_Left.DoDragDrop(v_ListView_Left.SelectedItems, DragDropEffects.Copy);
        }

        private void v_ListView_Right_ItemDrag(object sender, ItemDragEventArgs e)
        {
            v_ListView_Right.DoDragDrop(v_ListView_Right.SelectedItems, DragDropEffects.Copy);
        }

    }
}
