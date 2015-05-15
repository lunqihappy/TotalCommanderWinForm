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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.porgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            resources.ApplyResources(this.porgramToolStripMenuItem, "porgramToolStripMenuItem");
            this.porgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.porgramToolStripMenuItem.Name = "porgramToolStripMenuItem";
            // 
            // closeToolStripMenuItem
            // 
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porgramToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            resources.ApplyResources(this.operationsToolStripMenuItem, "operationsToolStripMenuItem");
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            // 
            // copyToolStripMenuItem
            // 
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_ClickAsync);
            // 
            // cutToolStripMenuItem
            // 
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_ClickAsync);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_ClickAsync);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polishToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // polishToolStripMenuItem
            // 
            resources.ApplyResources(this.polishToolStripMenuItem, "polishToolStripMenuItem");
            this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            this.polishToolStripMenuItem.Click += new System.EventHandler(this.changeLanguageToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.changeLanguageToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.v_ListView_Right, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.v_ListView_Left, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.v_TextBox_ConsoleOutput, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // v_ListView_Right
            // 
            resources.ApplyResources(this.v_ListView_Right, "v_ListView_Right");
            this.v_ListView_Right.AllowDrop = true;
            this.v_ListView_Right.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.v_ColumnHeader_Right_FileName});
            this.v_ListView_Right.FullRowSelect = true;
            this.v_ListView_Right.GridLines = true;
            this.v_ListView_Right.Name = "v_ListView_Right";
            this.v_ListView_Right.UseCompatibleStateImageBehavior = false;
            this.v_ListView_Right.View = System.Windows.Forms.View.Details;
            this.v_ListView_Right.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.v_ListView_Right_ItemDrag);
            this.v_ListView_Right.SelectedIndexChanged += new System.EventHandler(this.v_ListView_Right_SelectedIndexChanged);
            this.v_ListView_Right.DragDrop += new System.Windows.Forms.DragEventHandler(this.v_ListView_Right_DragDrop_Async);
            this.v_ListView_Right.DragEnter += new System.Windows.Forms.DragEventHandler(this.v_ListView_Right_DragEnter);
            this.v_ListView_Right.DoubleClick += new System.EventHandler(this.v_ListView_Right_DoubleClick);
            // 
            // v_ColumnHeader_Right_FileName
            // 
            resources.ApplyResources(this.v_ColumnHeader_Right_FileName, "v_ColumnHeader_Right_FileName");
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.v_Label_LeftPath);
            this.panel1.Controls.Add(this.v_ButtonChooseLeftPath);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Name = "panel1";
            // 
            // v_Label_LeftPath
            // 
            resources.ApplyResources(this.v_Label_LeftPath, "v_Label_LeftPath");
            this.v_Label_LeftPath.BackColor = System.Drawing.Color.DarkTurquoise;
            this.v_Label_LeftPath.Name = "v_Label_LeftPath";
            // 
            // v_ButtonChooseLeftPath
            // 
            resources.ApplyResources(this.v_ButtonChooseLeftPath, "v_ButtonChooseLeftPath");
            this.v_ButtonChooseLeftPath.Name = "v_ButtonChooseLeftPath";
            this.v_ButtonChooseLeftPath.UseVisualStyleBackColor = true;
            this.v_ButtonChooseLeftPath.Click += new System.EventHandler(this.v_ButtonChooseLeftPath_Click);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.v_Label_RightPath);
            this.panel2.Controls.Add(this.v_ButtonChooseRightPath);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Name = "panel2";
            // 
            // v_Label_RightPath
            // 
            resources.ApplyResources(this.v_Label_RightPath, "v_Label_RightPath");
            this.v_Label_RightPath.BackColor = System.Drawing.Color.DarkTurquoise;
            this.v_Label_RightPath.Name = "v_Label_RightPath";
            // 
            // v_ButtonChooseRightPath
            // 
            resources.ApplyResources(this.v_ButtonChooseRightPath, "v_ButtonChooseRightPath");
            this.v_ButtonChooseRightPath.Name = "v_ButtonChooseRightPath";
            this.v_ButtonChooseRightPath.UseVisualStyleBackColor = true;
            this.v_ButtonChooseRightPath.Click += new System.EventHandler(this.v_ButtonChooseRightPath_Click);
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // v_ListView_Left
            // 
            resources.ApplyResources(this.v_ListView_Left, "v_ListView_Left");
            this.v_ListView_Left.AllowDrop = true;
            this.v_ListView_Left.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.v_ColumnHeader_Left_FileName});
            this.v_ListView_Left.FullRowSelect = true;
            this.v_ListView_Left.GridLines = true;
            this.v_ListView_Left.Name = "v_ListView_Left";
            this.v_ListView_Left.UseCompatibleStateImageBehavior = false;
            this.v_ListView_Left.View = System.Windows.Forms.View.Details;
            this.v_ListView_Left.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.v_ListView_Left_ItemDrag);
            this.v_ListView_Left.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.v_ListView_Left_ItemSelectionChanged);
            this.v_ListView_Left.DragDrop += new System.Windows.Forms.DragEventHandler(this.v_ListView_Left_DragDrop_Async);
            this.v_ListView_Left.DragEnter += new System.Windows.Forms.DragEventHandler(this.v_ListView_Left_DragEnter);
            this.v_ListView_Left.DoubleClick += new System.EventHandler(this.v_ListView_Left_DoubleClick);
            // 
            // v_ColumnHeader_Left_FileName
            // 
            resources.ApplyResources(this.v_ColumnHeader_Left_FileName, "v_ColumnHeader_Left_FileName");
            // 
            // v_TextBox_ConsoleOutput
            // 
            resources.ApplyResources(this.v_TextBox_ConsoleOutput, "v_TextBox_ConsoleOutput");
            this.tableLayoutPanel1.SetColumnSpan(this.v_TextBox_ConsoleOutput, 2);
            this.v_TextBox_ConsoleOutput.Name = "v_TextBox_ConsoleOutput";
            this.v_TextBox_ConsoleOutput.ReadOnly = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
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
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;

    }
}

