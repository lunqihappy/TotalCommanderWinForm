namespace TotalCommanderWinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.porgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.v_ListView_Right = new System.Windows.Forms.ListView();
            this.v_ColumnHeader_Right_FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.v_Label_LeftPath = new System.Windows.Forms.Label();
            this.v_ButtonChooseLeftPath = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.v_Label_RightPath = new System.Windows.Forms.Label();
            this.v_ButtonChooseRightPath = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.v_ListView_Left = new System.Windows.Forms.ListView();
            this.v_ColumnHeader_Left_FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.v_TextBox_ConsoleOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // porgramToolStripMenuItem
            // 
            this.porgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.porgramToolStripMenuItem.Name = "porgramToolStripMenuItem";
            this.porgramToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.porgramToolStripMenuItem.Text = "Porgram";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.v_ListView_Right, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.v_ListView_Left, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.v_TextBox_ConsoleOutput, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 443);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // v_ListView_Right
            // 
            this.v_ListView_Right.AllowDrop = true;
            this.v_ListView_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_ListView_Right.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.v_ColumnHeader_Right_FileName});
            this.v_ListView_Right.FullRowSelect = true;
            this.v_ListView_Right.GridLines = true;
            this.v_ListView_Right.Location = new System.Drawing.Point(460, 33);
            this.v_ListView_Right.Name = "v_ListView_Right";
            this.v_ListView_Right.Size = new System.Drawing.Size(452, 281);
            this.v_ListView_Right.TabIndex = 5;
            this.v_ListView_Right.UseCompatibleStateImageBehavior = false;
            this.v_ListView_Right.View = System.Windows.Forms.View.Details;
            this.v_ListView_Right.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.v_ListView_Right_ItemDrag);
            this.v_ListView_Right.DragDrop += new System.Windows.Forms.DragEventHandler(this.v_ListView_Right_DragDrop_Async);
            this.v_ListView_Right.DragEnter += new System.Windows.Forms.DragEventHandler(this.v_ListView_Right_DragEnter);
            this.v_ListView_Right.DoubleClick += new System.EventHandler(this.v_ListView_Right_DoubleClick);
            // 
            // v_ColumnHeader_Right_FileName
            // 
            this.v_ColumnHeader_Right_FileName.Text = "File Name";
            this.v_ColumnHeader_Right_FileName.Width = 400;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.v_Label_LeftPath);
            this.panel1.Controls.Add(this.v_ButtonChooseLeftPath);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 24);
            this.panel1.TabIndex = 2;
            // 
            // v_Label_LeftPath
            // 
            this.v_Label_LeftPath.BackColor = System.Drawing.Color.DarkTurquoise;
            this.v_Label_LeftPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_Label_LeftPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v_Label_LeftPath.Location = new System.Drawing.Point(45, 0);
            this.v_Label_LeftPath.Margin = new System.Windows.Forms.Padding(3);
            this.v_Label_LeftPath.Name = "v_Label_LeftPath";
            this.v_Label_LeftPath.Size = new System.Drawing.Size(383, 24);
            this.v_Label_LeftPath.TabIndex = 2;
            this.v_Label_LeftPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // v_ButtonChooseLeftPath
            // 
            this.v_ButtonChooseLeftPath.AutoSize = true;
            this.v_ButtonChooseLeftPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.v_ButtonChooseLeftPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.v_ButtonChooseLeftPath.Location = new System.Drawing.Point(428, 0);
            this.v_ButtonChooseLeftPath.Name = "v_ButtonChooseLeftPath";
            this.v_ButtonChooseLeftPath.Size = new System.Drawing.Size(23, 24);
            this.v_ButtonChooseLeftPath.TabIndex = 1;
            this.v_ButtonChooseLeftPath.Text = "*";
            this.v_ButtonChooseLeftPath.UseVisualStyleBackColor = true;
            this.v_ButtonChooseLeftPath.Click += new System.EventHandler(this.v_ButtonChooseLeftPath_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(45, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.v_Label_RightPath);
            this.panel2.Controls.Add(this.v_ButtonChooseRightPath);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(460, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 24);
            this.panel2.TabIndex = 3;
            // 
            // v_Label_RightPath
            // 
            this.v_Label_RightPath.BackColor = System.Drawing.Color.DarkTurquoise;
            this.v_Label_RightPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_Label_RightPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.v_Label_RightPath.Location = new System.Drawing.Point(45, 0);
            this.v_Label_RightPath.Name = "v_Label_RightPath";
            this.v_Label_RightPath.Size = new System.Drawing.Size(384, 24);
            this.v_Label_RightPath.TabIndex = 2;
            this.v_Label_RightPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // v_ButtonChooseRightPath
            // 
            this.v_ButtonChooseRightPath.AutoSize = true;
            this.v_ButtonChooseRightPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.v_ButtonChooseRightPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.v_ButtonChooseRightPath.Location = new System.Drawing.Point(429, 0);
            this.v_ButtonChooseRightPath.Name = "v_ButtonChooseRightPath";
            this.v_ButtonChooseRightPath.Size = new System.Drawing.Size(23, 24);
            this.v_ButtonChooseRightPath.TabIndex = 1;
            this.v_ButtonChooseRightPath.Text = "*";
            this.v_ButtonChooseRightPath.UseVisualStyleBackColor = true;
            this.v_ButtonChooseRightPath.Click += new System.EventHandler(this.v_ButtonChooseRightPath_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(0, 0);
            this.comboBox2.MinimumSize = new System.Drawing.Size(45, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(45, 24);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // v_ListView_Left
            // 
            this.v_ListView_Left.AllowDrop = true;
            this.v_ListView_Left.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_ListView_Left.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.v_ColumnHeader_Left_FileName});
            this.v_ListView_Left.FullRowSelect = true;
            this.v_ListView_Left.GridLines = true;
            this.v_ListView_Left.Location = new System.Drawing.Point(3, 33);
            this.v_ListView_Left.Name = "v_ListView_Left";
            this.v_ListView_Left.Size = new System.Drawing.Size(451, 281);
            this.v_ListView_Left.TabIndex = 4;
            this.v_ListView_Left.UseCompatibleStateImageBehavior = false;
            this.v_ListView_Left.View = System.Windows.Forms.View.Details;
            this.v_ListView_Left.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.v_ListView_Left_ItemDrag);
            this.v_ListView_Left.DragDrop += new System.Windows.Forms.DragEventHandler(this.v_ListView_Left_DragDrop_Async);
            this.v_ListView_Left.DragEnter += new System.Windows.Forms.DragEventHandler(this.v_ListView_Left_DragEnter);
            this.v_ListView_Left.DoubleClick += new System.EventHandler(this.v_ListView_Left_DoubleClick);
            // 
            // v_ColumnHeader_Left_FileName
            // 
            this.v_ColumnHeader_Left_FileName.Text = "File Name";
            this.v_ColumnHeader_Left_FileName.Width = 400;
            // 
            // v_TextBox_ConsoleOutput
            // 
            this.v_TextBox_ConsoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.v_TextBox_ConsoleOutput, 2);
            this.v_TextBox_ConsoleOutput.Location = new System.Drawing.Point(3, 320);
            this.v_TextBox_ConsoleOutput.Multiline = true;
            this.v_TextBox_ConsoleOutput.Name = "v_TextBox_ConsoleOutput";
            this.v_TextBox_ConsoleOutput.ReadOnly = true;
            this.v_TextBox_ConsoleOutput.Size = new System.Drawing.Size(909, 120);
            this.v_TextBox_ConsoleOutput.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WinForm - Comander";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem porgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label v_Label_LeftPath;
        private System.Windows.Forms.Button v_ButtonChooseLeftPath;
        private System.Windows.Forms.Label v_Label_RightPath;
        private System.Windows.Forms.Button v_ButtonChooseRightPath;
        private System.Windows.Forms.ListView v_ListView_Right;
        private System.Windows.Forms.ListView v_ListView_Left;
        private System.Windows.Forms.TextBox v_TextBox_ConsoleOutput;
        private System.Windows.Forms.ColumnHeader v_ColumnHeader_Right_FileName;
        private System.Windows.Forms.ColumnHeader v_ColumnHeader_Left_FileName;

    }
}

