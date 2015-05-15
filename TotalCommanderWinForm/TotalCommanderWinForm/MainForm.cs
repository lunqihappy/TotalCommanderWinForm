using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
            UpdateLanguage(new CultureInfo("en"));
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
            v_ListView_Left.Items.Clear();

            UpdateLeftListView(comboBox1.SelectedItem as string);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            v_Label_RightPath.Text = string.Empty;
            v_ListView_Right.Items.Clear();

            UpdateRightListView(comboBox2.SelectedItem as string);
        }

        private void RefreshListViews()
        {
            if (!string.IsNullOrEmpty(v_Label_LeftPath.Text))
            {
                UpdateLeftListView(v_Label_LeftPath.Text);
            }

            if (!string.IsNullOrEmpty(v_Label_RightPath.Text))
            {
                UpdateRightListView(v_Label_RightPath.Text);
            }
        }

        private void UpdateLeftListView(string path)
        {
            v_ListView_Left.Items.Clear();

            v_ListView_Left.Items.Add(new ListViewItem()
            {
                Text = "..",
                Tag = Directory.GetParent(path) != null ? Directory.GetParent(path).FullName : comboBox1.SelectedItem as string,
            });

            Directory.GetDirectories(path).ForEach((i) =>
            {
                v_ListView_Left.Items.Add(new ListViewItem()
                {
                    ForeColor = System.Drawing.Color.Red,
                    Text = i.Replace(path, "").Trim('\\'),
                    Tag = i,
                    ToolTipText = i,
                });
            });

            Directory.GetFiles(path).ForEach((i) =>
            {
                v_ListView_Left.Items.Add(new ListViewItem()
                {
                    Text = Path.GetFileName(i),
                    Tag = i,
                    ToolTipText = i,
                });
            });
        }

        private void UpdateRightListView(string path)
        {
            v_ListView_Right.Items.Clear();

            v_ListView_Right.Items.Add(new ListViewItem()
            {
                Text = "..",
                Tag = Directory.GetParent(path) != null ? Directory.GetParent(path).FullName : comboBox2.SelectedItem as string,
            });

            Directory.GetDirectories(path).ForEach((i) =>
            {
                v_ListView_Right.Items.Add(new ListViewItem()
                {
                    ForeColor = System.Drawing.Color.Red,
                    Text = i.Replace(path, "").Trim('\\'),
                    Tag = i,
                    ToolTipText = i,
                });
            });

            Directory.GetFiles(path).ForEach((i) =>
            {
                v_ListView_Right.Items.Add(new ListViewItem()
                {
                    Text = Path.GetFileName(i),
                    Tag = i,
                    ToolTipText = i,
                });
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

        private async void v_ListView_Left_DragDrop_Async(object sender, DragEventArgs e)
        {
            var items = (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(System.Windows.Forms.ListView.SelectedListViewItemCollection));

            List<string> paths = new List<string>();

            foreach (ListViewItem item in items)
            {
                if (item.Text.Equals("..")) 
                    continue;
                var fileName = Path.Combine(v_Label_RightPath.Text, item.Text);
                PrintToConsoleOutput("Left drop: {0}", fileName);
                paths.Add(fileName);
            }

            var progress = new Progress<int>();
            ProgressWindow pw = new ProgressWindow();
            this.Enabled = false;
            pw.Show(this);
            progress.ProgressChanged += new EventHandler<int>(delegate(object sender1, int e1)
            {
                if (pw.Visible)
                {
                    pw.UpdateProgress(e1);
                }
                else
                {
                    PrintToConsoleOutput("Progress: {0}", e1);
                }
            });
            pw.FormClosed += new FormClosedEventHandler(delegate(object sender2, FormClosedEventArgs e2)
            {
                this.Enabled = true;
            });
            CancellationTokenSource source = new CancellationTokenSource();
            pw.Cancel += new ProgressWindow.CancelationPaddingHandler(delegate(object sender2, EventArgs e2)
            {
                source.Cancel();
            });
            await FileManagerHelper.CustomMoveAsync(paths, v_Label_LeftPath.Text, source.Token, progress);
            RefreshListViews();
            pw.Close();
        }

        private async void v_ListView_Right_DragDrop_Async(object sender, DragEventArgs e)
        {
            var items = (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(System.Windows.Forms.ListView.SelectedListViewItemCollection));

            List<string> paths = new List<string>();

            foreach (ListViewItem item in items)
            {
                if (item.Text.Equals(".."))
                    continue;
                var fileName = Path.Combine(v_Label_LeftPath.Text, item.Text);
                PrintToConsoleOutput("Right drop: {0}", fileName);
                paths.Add(fileName);
            }

            var progress = new Progress<int>();
            ProgressWindow pw = new ProgressWindow();
            this.Enabled = false;
            pw.Show(this);
            progress.ProgressChanged += new EventHandler<int>(delegate(object sender1, int e1)
            {
                if (pw.Visible)
                {
                    pw.UpdateProgress(e1);
                }
                else
                {
                    PrintToConsoleOutput("Progress: {0}", e1);
                }
            });
            pw.FormClosed += new FormClosedEventHandler(delegate(object sender2, FormClosedEventArgs e2)
            {
                this.Enabled = true;
            });
            CancellationTokenSource source = new CancellationTokenSource();
            pw.Cancel += new ProgressWindow.CancelationPaddingHandler(delegate(object sender2, EventArgs e2)
            {
                source.Cancel();
            });
            await FileManagerHelper.CustomMoveAsync(paths, v_Label_RightPath.Text, source.Token, progress);
            RefreshListViews();
            pw.Close();
        }

        private void progress_ProgressChanged(object sender, int e)
        {
            PrintToConsoleOutput("Progress: {0}", e);
        }

        private void v_ListView_Left_ItemDrag(object sender, ItemDragEventArgs e)
        {
            v_ListView_Left.DoDragDrop(v_ListView_Left.SelectedItems, DragDropEffects.Copy);
        }

        private void v_ListView_Right_ItemDrag(object sender, ItemDragEventArgs e)
        {
            v_ListView_Right.DoDragDrop(v_ListView_Right.SelectedItems, DragDropEffects.Copy);
        }

        private void v_ListView_Left_DoubleClick(object sender, EventArgs e)
        {
            var item = v_ListView_Left.SelectedItems[0];

            string path = item.Tag as string;
            if (File.GetAttributes(path)
                .HasFlag(FileAttributes.Directory))
            {//is Directory
                v_Label_LeftPath.Text = path;
                PrintToConsoleOutput("Open: {0}", path);
                UpdateLeftListView(path);
            }
            else
            {// is File
                Process.Start(path);
            }
        }

        private void v_ListView_Right_DoubleClick(object sender, EventArgs e)
        {
            var item = v_ListView_Right.SelectedItems[0];

            string path = item.Tag as string;
            if (File.GetAttributes(path)
                .HasFlag(FileAttributes.Directory))
            {//is Directory
                v_Label_RightPath.Text = path;
                PrintToConsoleOutput("Open: {0}", path);
                UpdateRightListView(path);
            }
            else
            {// is File
                Process.Start(path);
            }
        }

        private void changeLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch ((sender as ToolStripMenuItem).Text)
            {
                case "Polski":
                    englishToolStripMenuItem.Checked = false;
                    polishToolStripMenuItem.Checked = true;
                    UpdateLanguage(new CultureInfo("pl-PL"));
                    break;
                case "English":
                    englishToolStripMenuItem.Checked = true;
                    polishToolStripMenuItem.Checked = false;
                    UpdateLanguage(new CultureInfo("en"));
                    break;
                default:
                    englishToolStripMenuItem.Checked = true;
                    polishToolStripMenuItem.Checked = false;
                    UpdateLanguage(new CultureInfo("en"));
                    break;
            }
        }

        private void UpdateLanguage(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));

            resources.ApplyResources(this, "$this", cultureInfo);

            ApplyResources(this, resources, cultureInfo);
        }

        private void ApplyResources(Control control, ComponentResourceManager resourceProvider, CultureInfo culture)
        {
            control.SuspendLayout();
            resourceProvider.ApplyResources(control, control.Name, culture);

            foreach (Control ctrl in control.Controls)
            {
                //toolTip.SetToolTip(ctrl, resourceProvider.GetString(ctrl.Name + ".ToolTip"));
                ApplyResources(ctrl, resourceProvider, culture);
            }

            PropertyInfo property = control.GetType().GetProperty("Items");
            if (property != null)
            {
                try
                {
                    foreach (ToolStripItem item in (IList)property.GetValue(control, null))
                    {
                        ApplyResources(item, resourceProvider, culture);
                    }
                }
                catch { }
            }

            control.ResumeLayout(false);
        }

        private void ApplyResources(ToolStripItem item, ComponentResourceManager resourceProvider, CultureInfo culture)
        {
            resourceProvider.ApplyResources(item, item.Name, culture);

            if (item is ToolStripMenuItem)
            {
                foreach (ToolStripItem it in ((ToolStripMenuItem)item).DropDownItems)
                {
                    ApplyResources(it, resourceProvider, culture);
                }
            }
        }

        private void v_ListView_Left_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            v_ListView_Right.SelectedItems.Clear();

            if (v_ListView_Left.SelectedItems.Count <= 0)
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }

        private void v_ListView_Right_SelectedIndexChanged(object sender, EventArgs e)
        {
            v_ListView_Left.SelectedItems.Clear();

            if (v_ListView_Right.SelectedItems.Count <= 0)
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }

        private async void copyToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            if (v_ListView_Left.SelectedItems.Count > 0)
            {
                var items = (ListView.SelectedListViewItemCollection)v_ListView_Left.SelectedItems;

                List<string> paths = new List<string>();

                foreach (ListViewItem item in items)
                {
                    if (item.Text.Equals(".."))
                        continue;
                    var fileName = Path.Combine(v_Label_LeftPath.Text, item.Text);
                    paths.Add(fileName);
                }

                var progress = new Progress<int>();
                ProgressWindow pw = new ProgressWindow();
                this.Enabled = false;
                pw.Show(this);
                progress.ProgressChanged += new EventHandler<int>(delegate(object sender1, int e1)
                {
                    if (pw.Visible)
                    {
                        pw.UpdateProgress(e1);
                    }
                    else
                    {
                        PrintToConsoleOutput("Progress: {0}", e1);
                    }
                });
                pw.FormClosed += new FormClosedEventHandler(delegate(object sender2, FormClosedEventArgs e2)
                {
                    this.Enabled = true;
                });
                CancellationTokenSource source = new CancellationTokenSource();
                pw.Cancel += new ProgressWindow.CancelationPaddingHandler(delegate(object sender2, EventArgs e2)
                {
                    source.Cancel();
                });
                await FileManagerHelper.CustomCopyAsync(paths, v_Label_RightPath.Text, source.Token, progress);
                RefreshListViews();
                pw.Close();

            }
            else if (v_ListView_Right.SelectedItems.Count > 0)
            {
                var items = (ListView.SelectedListViewItemCollection)v_ListView_Right.SelectedItems;

                List<string> paths = new List<string>();

                foreach (ListViewItem item in items)
                {
                    if (item.Text.Equals(".."))
                        continue;
                    var fileName = Path.Combine(v_Label_RightPath.Text, item.Text);
                    paths.Add(fileName);
                }

                var progress = new Progress<int>();
                ProgressWindow pw = new ProgressWindow();
                this.Enabled = false;
                pw.Show(this);
                progress.ProgressChanged += new EventHandler<int>(delegate(object sender1, int e1)
                {
                    if (pw.Visible)
                    {
                        pw.UpdateProgress(e1);
                    }
                    else
                    {
                        PrintToConsoleOutput("Progress: {0}", e1);
                    }
                });
                pw.FormClosed += new FormClosedEventHandler(delegate(object sender2, FormClosedEventArgs e2)
                {
                    this.Enabled = true;
                });
                CancellationTokenSource source = new CancellationTokenSource();
                pw.Cancel += new ProgressWindow.CancelationPaddingHandler(delegate(object sender2, EventArgs e2)
                {
                    source.Cancel();
                });
                await FileManagerHelper.CustomCopyAsync(paths, v_Label_LeftPath.Text, source.Token, progress);
                RefreshListViews();
                pw.Close();
            }
        }

        private async void cutToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            if (v_ListView_Left.SelectedItems.Count > 0)
            {
                var items = (ListView.SelectedListViewItemCollection)v_ListView_Left.SelectedItems;

                List<string> paths = new List<string>();

                foreach (ListViewItem item in items)
                {
                    if (item.Text.Equals(".."))
                        continue;
                    var fileName = Path.Combine(v_Label_LeftPath.Text, item.Text);
                    paths.Add(fileName);
                }

                var progress = new Progress<int>();
                ProgressWindow pw = new ProgressWindow();
                this.Enabled = false;
                pw.Show(this);
                progress.ProgressChanged += new EventHandler<int>(delegate(object sender1, int e1)
                {
                    if (pw.Visible)
                    {
                        pw.UpdateProgress(e1);
                    }
                    else
                    {
                        PrintToConsoleOutput("Progress: {0}", e1);
                    }
                });
                pw.FormClosed += new FormClosedEventHandler(delegate(object sender2, FormClosedEventArgs e2)
                {
                    this.Enabled = true;
                });
                CancellationTokenSource source = new CancellationTokenSource();
                pw.Cancel += new ProgressWindow.CancelationPaddingHandler(delegate(object sender2, EventArgs e2)
                {
                    source.Cancel();
                });
                await FileManagerHelper.CustomMoveAsync(paths, v_Label_RightPath.Text, source.Token, progress);
                RefreshListViews();
                pw.Close();

            }
            else if (v_ListView_Right.SelectedItems.Count > 0)
            {
                var items = (ListView.SelectedListViewItemCollection)v_ListView_Right.SelectedItems;

                List<string> paths = new List<string>();

                foreach (ListViewItem item in items)
                {
                    if (item.Text.Equals(".."))
                        continue;
                    var fileName = Path.Combine(v_Label_RightPath.Text, item.Text);
                    paths.Add(fileName);
                }

                var progress = new Progress<int>();
                ProgressWindow pw = new ProgressWindow();
                this.Enabled = false;
                pw.Show(this);
                progress.ProgressChanged += new EventHandler<int>(delegate(object sender1, int e1)
                {
                    if (pw.Visible)
                    {
                        pw.UpdateProgress(e1);
                    }
                    else
                    {
                        PrintToConsoleOutput("Progress: {0}", e1);
                    }
                });
                pw.FormClosed += new FormClosedEventHandler(delegate(object sender2, FormClosedEventArgs e2)
                {
                    this.Enabled = true;
                });
                CancellationTokenSource source = new CancellationTokenSource();
                pw.Cancel += new ProgressWindow.CancelationPaddingHandler(delegate(object sender2, EventArgs e2)
                {
                    source.Cancel();
                });
                await FileManagerHelper.CustomMoveAsync(paths, v_Label_LeftPath.Text, source.Token, progress);
                RefreshListViews();
                pw.Close();
            }
        }

        private async void deleteToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (v_ListView_Left.SelectedItems.Count > 0)
                {
                    var items = (ListView.SelectedListViewItemCollection)v_ListView_Left.SelectedItems;

                    List<string> paths = new List<string>();

                    foreach (ListViewItem item in items)
                    {
                        if (item.Text.Equals(".."))
                            continue;
                        var fileName = Path.Combine(v_Label_LeftPath.Text, item.Text);
                        paths.Add(fileName);
                    }

                    var progress = new Progress<int>();
                    ProgressWindow pw = new ProgressWindow();
                    this.Enabled = false;
                    pw.Show(this);
                    progress.ProgressChanged += new EventHandler<int>(delegate(object sender1, int e1)
                    {
                        if (pw.Visible)
                        {
                            pw.UpdateProgress(e1);
                        }
                        else
                        {
                            PrintToConsoleOutput("Progress: {0}", e1);
                        }
                    });
                    pw.FormClosed += new FormClosedEventHandler(delegate(object sender2, FormClosedEventArgs e2)
                    {
                        this.Enabled = true;
                    });
                    CancellationTokenSource source = new CancellationTokenSource();
                    pw.Cancel += new ProgressWindow.CancelationPaddingHandler(delegate(object sender2, EventArgs e2)
                    {
                        source.Cancel();
                    });
                    await FileManagerHelper.CustomDeleteAsync(paths, source.Token, progress);
                    RefreshListViews();
                    pw.Close();

                }
                else if (v_ListView_Right.SelectedItems.Count > 0)
                {
                    var items = (ListView.SelectedListViewItemCollection)v_ListView_Right.SelectedItems;

                    List<string> paths = new List<string>();

                    foreach (ListViewItem item in items)
                    {
                        if (item.Text.Equals(".."))
                            continue;
                        var fileName = Path.Combine(v_Label_RightPath.Text, item.Text);
                        paths.Add(fileName);
                    }

                    var progress = new Progress<int>();
                    ProgressWindow pw = new ProgressWindow();
                    this.Enabled = false;
                    pw.Show(this);
                    progress.ProgressChanged += new EventHandler<int>(delegate(object sender1, int e1)
                    {
                        if (pw.Visible)
                        {
                            pw.UpdateProgress(e1);
                        }
                        else
                        {
                            PrintToConsoleOutput("Progress: {0}", e1);
                        }
                    });
                    pw.FormClosed += new FormClosedEventHandler(delegate(object sender2, FormClosedEventArgs e2)
                    {
                        this.Enabled = true;
                    });
                    CancellationTokenSource source = new CancellationTokenSource();
                    pw.Cancel += new ProgressWindow.CancelationPaddingHandler(delegate(object sender2, EventArgs e2)
                    {
                        source.Cancel();
                    });
                    await FileManagerHelper.CustomDeleteAsync(paths, source.Token, progress);
                    RefreshListViews();
                    pw.Close();
                }
            }
        }
    }
}
