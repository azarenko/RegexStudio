
namespace RegexStudio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._filename = new System.Windows.Forms.ToolStripStatusLabel();
            this._matchCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._input = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._output = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Extract = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._extractExecute = new System.Windows.Forms.Button();
            this._extracktHighlight = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._extractPattern = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._extractFormatter = new System.Windows.Forms.TextBox();
            this.Replace = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._regExGlobalOptions = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this._replaceExecute = new System.Windows.Forms.Button();
            this._replaceHighlight = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this._replacePattern = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this._replaceFormatter = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Extract.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Replace.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._filename,
            this._matchCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _filename
            // 
            this._filename.Name = "_filename";
            this._filename.Size = new System.Drawing.Size(0, 17);
            // 
            // _matchCount
            // 
            this._matchCount.Name = "_matchCount";
            this._matchCount.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 599);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(671, 593);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._input);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 589);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // _input
            // 
            this._input.AcceptsTab = true;
            this._input.Dock = System.Windows.Forms.DockStyle.Fill;
            this._input.Location = new System.Drawing.Point(3, 16);
            this._input.Name = "_input";
            this._input.Size = new System.Drawing.Size(316, 570);
            this._input.TabIndex = 0;
            this._input.Text = "";
            this._input.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._output);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 589);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // _output
            // 
            this._output.AcceptsTab = true;
            this._output.Dock = System.Windows.Forms.DockStyle.Fill;
            this._output.Location = new System.Drawing.Point(3, 16);
            this._output.Name = "_output";
            this._output.Size = new System.Drawing.Size(331, 570);
            this._output.TabIndex = 0;
            this._output.Text = "";
            this._output.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(680, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 593);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Extract);
            this.tabControl1.Controls.Add(this.Replace);
            this.tabControl1.Location = new System.Drawing.Point(6, 181);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 407);
            this.tabControl1.TabIndex = 1;
            // 
            // Extract
            // 
            this.Extract.Controls.Add(this.tableLayoutPanel2);
            this.Extract.Location = new System.Drawing.Point(4, 22);
            this.Extract.Name = "Extract";
            this.Extract.Padding = new System.Windows.Forms.Padding(3);
            this.Extract.Size = new System.Drawing.Size(300, 381);
            this.Extract.TabIndex = 0;
            this.Extract.Text = "Extract";
            this.Extract.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 375);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._extractExecute);
            this.panel2.Controls.Add(this._extracktHighlight);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 25);
            this.panel2.TabIndex = 0;
            // 
            // _extractExecute
            // 
            this._extractExecute.Location = new System.Drawing.Point(127, -1);
            this._extractExecute.Name = "_extractExecute";
            this._extractExecute.Size = new System.Drawing.Size(118, 23);
            this._extractExecute.TabIndex = 1;
            this._extractExecute.Text = "Execute";
            this._extractExecute.UseVisualStyleBackColor = true;
            this._extractExecute.Click += new System.EventHandler(this._extractExecute_Click);
            // 
            // _extracktHighlight
            // 
            this._extracktHighlight.Location = new System.Drawing.Point(3, -1);
            this._extracktHighlight.Name = "_extracktHighlight";
            this._extracktHighlight.Size = new System.Drawing.Size(118, 23);
            this._extracktHighlight.TabIndex = 0;
            this._extracktHighlight.Text = "Highlight";
            this._extracktHighlight.UseVisualStyleBackColor = true;
            this._extracktHighlight.Click += new System.EventHandler(this._extracktHighlight_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._extractPattern);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 166);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pattern";
            // 
            // _extractPattern
            // 
            this._extractPattern.AcceptsTab = true;
            this._extractPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this._extractPattern.Location = new System.Drawing.Point(3, 16);
            this._extractPattern.Multiline = true;
            this._extractPattern.Name = "_extractPattern";
            this._extractPattern.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._extractPattern.Size = new System.Drawing.Size(282, 147);
            this._extractPattern.TabIndex = 0;
            this._extractPattern.WordWrap = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._extractFormatter);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 175);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 166);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Formatter";
            // 
            // _extractFormatter
            // 
            this._extractFormatter.AcceptsTab = true;
            this._extractFormatter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._extractFormatter.Location = new System.Drawing.Point(3, 16);
            this._extractFormatter.Multiline = true;
            this._extractFormatter.Name = "_extractFormatter";
            this._extractFormatter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._extractFormatter.Size = new System.Drawing.Size(282, 147);
            this._extractFormatter.TabIndex = 0;
            this._extractFormatter.WordWrap = false;
            // 
            // Replace
            // 
            this.Replace.Controls.Add(this.tableLayoutPanel3);
            this.Replace.Location = new System.Drawing.Point(4, 22);
            this.Replace.Name = "Replace";
            this.Replace.Padding = new System.Windows.Forms.Padding(3);
            this.Replace.Size = new System.Drawing.Size(300, 381);
            this.Replace.TabIndex = 1;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._regExGlobalOptions);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 172);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General settings";
            // 
            // _regExGlobalOptions
            // 
            this._regExGlobalOptions.CheckOnClick = true;
            this._regExGlobalOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this._regExGlobalOptions.FormattingEnabled = true;
            this._regExGlobalOptions.Location = new System.Drawing.Point(3, 16);
            this._regExGlobalOptions.Name = "_regExGlobalOptions";
            this._regExGlobalOptions.Size = new System.Drawing.Size(305, 153);
            this._regExGlobalOptions.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox7, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(294, 375);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._replaceExecute);
            this.panel3.Controls.Add(this._replaceHighlight);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 25);
            this.panel3.TabIndex = 0;
            // 
            // _replaceExecute
            // 
            this._replaceExecute.Location = new System.Drawing.Point(127, -1);
            this._replaceExecute.Name = "_replaceExecute";
            this._replaceExecute.Size = new System.Drawing.Size(118, 23);
            this._replaceExecute.TabIndex = 1;
            this._replaceExecute.Text = "Execute";
            this._replaceExecute.UseVisualStyleBackColor = true;
            this._replaceExecute.Click += new System.EventHandler(this._replaceExecute_Click);
            // 
            // _replaceHighlight
            // 
            this._replaceHighlight.Location = new System.Drawing.Point(3, -1);
            this._replaceHighlight.Name = "_replaceHighlight";
            this._replaceHighlight.Size = new System.Drawing.Size(118, 23);
            this._replaceHighlight.TabIndex = 0;
            this._replaceHighlight.Text = "Highlight";
            this._replaceHighlight.UseVisualStyleBackColor = true;
            this._replaceHighlight.Click += new System.EventHandler(this._replaceHighlight_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this._replacePattern);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(288, 166);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pattern";
            // 
            // _replacePattern
            // 
            this._replacePattern.AcceptsTab = true;
            this._replacePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this._replacePattern.Location = new System.Drawing.Point(3, 16);
            this._replacePattern.Multiline = true;
            this._replacePattern.Name = "_replacePattern";
            this._replacePattern.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._replacePattern.Size = new System.Drawing.Size(282, 147);
            this._replacePattern.TabIndex = 0;
            this._replacePattern.WordWrap = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this._replaceFormatter);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 175);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(288, 166);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Formatter";
            // 
            // _replaceFormatter
            // 
            this._replaceFormatter.AcceptsTab = true;
            this._replaceFormatter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._replaceFormatter.Location = new System.Drawing.Point(3, 16);
            this._replaceFormatter.Multiline = true;
            this._replaceFormatter.Name = "_replaceFormatter";
            this._replaceFormatter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._replaceFormatter.Size = new System.Drawing.Size(282, 147);
            this._replaceFormatter.TabIndex = 0;
            this._replaceFormatter.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 645);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Regex Studio created by Azarenko S.A.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Extract.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Replace.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox _input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox _output;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel _filename;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox _regExGlobalOptions;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Extract;
        private System.Windows.Forms.TabPage Replace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox _extractPattern;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox _extractFormatter;
        private System.Windows.Forms.Button _extractExecute;
        private System.Windows.Forms.Button _extracktHighlight;
        private System.Windows.Forms.ToolStripStatusLabel _matchCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button _replaceExecute;
        private System.Windows.Forms.Button _replaceHighlight;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox _replacePattern;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox _replaceFormatter;
    }
}

