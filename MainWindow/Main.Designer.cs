namespace MainWindow
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_autosave1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_autosave2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_autosave3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_autosave4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_autosave5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_autosave6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_autosave7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_autosave8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_autosave9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_autosave10 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_autosave = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fctb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fctb
            // 
            this.fctb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctb.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctb.AutoScrollMinSize = new System.Drawing.Size(27, 419);
            this.fctb.BackBrush = null;
            this.fctb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fctb.CaretColor = System.Drawing.Color.White;
            this.fctb.CharHeight = 14;
            this.fctb.CharWidth = 8;
            this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctb.FoldingIndicatorColor = System.Drawing.Color.White;
            this.fctb.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctb.ForeColor = System.Drawing.Color.White;
            this.fctb.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fctb.IsReplaceMode = false;
            this.fctb.LineNumberColor = System.Drawing.SystemColors.HotTrack;
            this.fctb.Location = new System.Drawing.Point(2, 30);
            this.fctb.Name = "fctb";
            this.fctb.Paddings = new System.Windows.Forms.Padding(0, 5, 0, 400);
            this.fctb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctb.ServiceColors")));
            this.fctb.Size = new System.Drawing.Size(800, 422);
            this.fctb.TabIndex = 1;
            this.fctb.Zoom = 100;
            this.fctb.ToolTipNeeded += new System.EventHandler<FastColoredTextBoxNS.ToolTipNeededEventArgs>(this.fctb_ToolTipNeeded);
            this.fctb.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctb_TextChanged);
            this.fctb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctb_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.autosaveToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // autosaveToolStripMenuItem
            // 
            this.autosaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_autosave1,
            this.toolStripMenuItem_autosave2,
            this.toolStripMenuItem_autosave3,
            this.toolStripMenuItem_autosave4,
            this.toolStripMenuItem_autosave5,
            this.toolStripMenuItem_autosave6,
            this.toolStripMenuItem_autosave7,
            this.toolStripMenuItem_autosave8,
            this.toolStripMenuItem_autosave9,
            this.toolStripMenuItem_autosave10});
            this.autosaveToolStripMenuItem.Name = "autosaveToolStripMenuItem";
            this.autosaveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.autosaveToolStripMenuItem.Text = "Autosave";
            // 
            // toolStripMenuItem_autosave1
            // 
            this.toolStripMenuItem_autosave1.Name = "toolStripMenuItem_autosave1";
            this.toolStripMenuItem_autosave1.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem_autosave1.Text = "1";
            this.toolStripMenuItem_autosave1.Click += new System.EventHandler(this.toolStripMenuItem_autosave_Click);
            // 
            // toolStripMenuItem_autosave2
            // 
            this.toolStripMenuItem_autosave2.Name = "toolStripMenuItem_autosave2";
            this.toolStripMenuItem_autosave2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem_autosave2.Text = "2";
            this.toolStripMenuItem_autosave2.Click += new System.EventHandler(this.toolStripMenuItem_autosave_Click);
            // 
            // toolStripMenuItem_autosave3
            // 
            this.toolStripMenuItem_autosave3.Name = "toolStripMenuItem_autosave3";
            this.toolStripMenuItem_autosave3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem_autosave3.Text = "3";
            this.toolStripMenuItem_autosave3.Click += new System.EventHandler(this.toolStripMenuItem_autosave_Click);
            // 
            // toolStripMenuItem_autosave4
            // 
            this.toolStripMenuItem_autosave4.Name = "toolStripMenuItem_autosave4";
            this.toolStripMenuItem_autosave4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem_autosave4.Text = "4";
            this.toolStripMenuItem_autosave4.Click += new System.EventHandler(this.toolStripMenuItem_autosave_Click);
            // 
            // toolStripMenuItem_autosave5
            // 
            this.toolStripMenuItem_autosave5.Name = "toolStripMenuItem_autosave5";
            this.toolStripMenuItem_autosave5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem_autosave5.Text = "5";
            this.toolStripMenuItem_autosave5.Click += new System.EventHandler(this.toolStripMenuItem_autosave_Click);
            // 
            // toolStripMenuItem_autosave6
            // 
            this.toolStripMenuItem_autosave6.Name = "toolStripMenuItem_autosave6";
            this.toolStripMenuItem_autosave6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem_autosave6.Text = "6";
            this.toolStripMenuItem_autosave6.Click += new System.EventHandler(this.toolStripMenuItem_autosave_Click);
            // 
            // toolStripMenuItem_autosave7
            // 
            this.toolStripMenuItem_autosave7.Name = "toolStripMenuItem_autosave7";
            this.toolStripMenuItem_autosave7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem_autosave7.Text = "7";
            this.toolStripMenuItem_autosave7.Click += new System.EventHandler(this.toolStripMenuItem_autosave_Click);
            // 
            // toolStripMenuItem_autosave8
            // 
            this.toolStripMenuItem_autosave8.Name = "toolStripMenuItem_autosave8";
            this.toolStripMenuItem_autosave8.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem_autosave8.Text = "8";
            this.toolStripMenuItem_autosave8.Click += new System.EventHandler(this.toolStripMenuItem_autosave_Click);
            // 
            // toolStripMenuItem_autosave9
            // 
            this.toolStripMenuItem_autosave9.Name = "toolStripMenuItem_autosave9";
            this.toolStripMenuItem_autosave9.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem_autosave9.Text = "9";
            this.toolStripMenuItem_autosave9.Click += new System.EventHandler(this.toolStripMenuItem_autosave_Click);
            // 
            // toolStripMenuItem_autosave10
            // 
            this.toolStripMenuItem_autosave10.Name = "toolStripMenuItem_autosave10";
            this.toolStripMenuItem_autosave10.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem_autosave10.Text = "10";
            this.toolStripMenuItem_autosave10.Click += new System.EventHandler(this.toolStripMenuItem_autosave_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.functionToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.functionToolStripMenuItem.Text = "Function";
            this.functionToolStripMenuItem.Click += new System.EventHandler(this.functionToolStripMenuItem_Click);
            // 
            // timer_autosave
            // 
            this.timer_autosave.Interval = 2000;
            this.timer_autosave.Tick += new System.EventHandler(this.timer_autosave_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fctb);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctb_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fctb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_autosave1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_autosave2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_autosave3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_autosave4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_autosave5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_autosave6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_autosave7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_autosave8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_autosave9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_autosave10;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.Timer timer_autosave;
    }
}

