namespace library_control
{
    partial class Function_editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_editor));
            this.textBox_test_values = new System.Windows.Forms.TextBox();
            this.label_test_values = new System.Windows.Forms.Label();
            this.label_tooltip = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.richTextBox_tooltip = new System.Windows.Forms.RichTextBox();
            this.fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.comboBox_library = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_functions = new System.Windows.Forms.ListView();
            this.listview_function_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_library = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fctb)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_test_values
            // 
            this.textBox_test_values.Location = new System.Drawing.Point(200, 170);
            this.textBox_test_values.Name = "textBox_test_values";
            this.textBox_test_values.Size = new System.Drawing.Size(600, 20);
            this.textBox_test_values.TabIndex = 33;
            // 
            // label_test_values
            // 
            this.label_test_values.AutoSize = true;
            this.label_test_values.Location = new System.Drawing.Point(200, 155);
            this.label_test_values.Name = "label_test_values";
            this.label_test_values.Size = new System.Drawing.Size(63, 13);
            this.label_test_values.TabIndex = 32;
            this.label_test_values.Text = "Test Values";
            // 
            // label_tooltip
            // 
            this.label_tooltip.AutoSize = true;
            this.label_tooltip.Location = new System.Drawing.Point(200, 90);
            this.label_tooltip.Name = "label_tooltip";
            this.label_tooltip.Size = new System.Drawing.Size(39, 13);
            this.label_tooltip.TabIndex = 30;
            this.label_tooltip.Text = "Tooltip";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(200, 50);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 29;
            this.label_name.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(200, 65);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(600, 20);
            this.textBox_name.TabIndex = 28;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            this.textBox_name.Leave += new System.EventHandler(this.textBox_name_Leave);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_remove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove.ForeColor = System.Drawing.Color.White;
            this.button_remove.Location = new System.Drawing.Point(481, 18);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 27;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(401, 18);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 26;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // richTextBox_tooltip
            // 
            this.richTextBox_tooltip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_tooltip.Location = new System.Drawing.Point(203, 106);
            this.richTextBox_tooltip.Name = "richTextBox_tooltip";
            this.richTextBox_tooltip.Size = new System.Drawing.Size(600, 46);
            this.richTextBox_tooltip.TabIndex = 25;
            this.richTextBox_tooltip.Text = "";
            this.richTextBox_tooltip.TextChanged += new System.EventHandler(this.richTextBox_tooltip_TextChanged);
            // 
            // fctb
            // 
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
            this.fctb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctb.CaretColor = System.Drawing.Color.White;
            this.fctb.CharHeight = 14;
            this.fctb.CharWidth = 8;
            this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctb.FoldingIndicatorColor = System.Drawing.Color.White;
            this.fctb.ForeColor = System.Drawing.Color.White;
            this.fctb.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fctb.IsReplaceMode = false;
            this.fctb.LineNumberColor = System.Drawing.SystemColors.HotTrack;
            this.fctb.Location = new System.Drawing.Point(200, 195);
            this.fctb.Name = "fctb";
            this.fctb.Paddings = new System.Windows.Forms.Padding(0, 5, 0, 400);
            this.fctb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctb.ServiceColors")));
            this.fctb.Size = new System.Drawing.Size(600, 230);
            this.fctb.TabIndex = 24;
            this.fctb.Zoom = 100;
            this.fctb.ToolTipNeeded += new System.EventHandler<FastColoredTextBoxNS.ToolTipNeededEventArgs>(this.fctb_ToolTipNeeded);
            this.fctb.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctb_TextChanged);
            this.fctb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctb_KeyDown);
            // 
            // comboBox_library
            // 
            this.comboBox_library.FormattingEnabled = true;
            this.comboBox_library.Location = new System.Drawing.Point(200, 25);
            this.comboBox_library.Name = "comboBox_library";
            this.comboBox_library.Size = new System.Drawing.Size(177, 21);
            this.comboBox_library.TabIndex = 35;
            this.comboBox_library.SelectedIndexChanged += new System.EventHandler(this.comboBox_library_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Library";
            // 
            // listView_functions
            // 
            this.listView_functions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listview_function_column});
            this.listView_functions.FullRowSelect = true;
            this.listView_functions.GridLines = true;
            this.listView_functions.Location = new System.Drawing.Point(5, 5);
            this.listView_functions.MultiSelect = false;
            this.listView_functions.Name = "listView_functions";
            this.listView_functions.Size = new System.Drawing.Size(180, 420);
            this.listView_functions.TabIndex = 37;
            this.listView_functions.UseCompatibleStateImageBehavior = false;
            this.listView_functions.View = System.Windows.Forms.View.Details;
            this.listView_functions.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_functions_ItemSelectionChanged);
            // 
            // listview_function_column
            // 
            this.listview_function_column.Text = "Name";
            this.listview_function_column.Width = 180;
            // 
            // button_library
            // 
            this.button_library.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_library.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_library.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_library.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_library.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_library.ForeColor = System.Drawing.Color.White;
            this.button_library.Location = new System.Drawing.Point(685, 18);
            this.button_library.Name = "button_library";
            this.button_library.Size = new System.Drawing.Size(115, 23);
            this.button_library.TabIndex = 39;
            this.button_library.Text = "Library Manager";
            this.button_library.UseVisualStyleBackColor = false;
            this.button_library.Click += new System.EventHandler(this.button_library_Click);
            // 
            // Function_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 433);
            this.Controls.Add(this.button_library);
            this.Controls.Add(this.listView_functions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_library);
            this.Controls.Add(this.textBox_test_values);
            this.Controls.Add(this.label_test_values);
            this.Controls.Add(this.label_tooltip);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.richTextBox_tooltip);
            this.Controls.Add(this.fctb);
            this.Name = "Function_editor";
            this.Text = "Function_editor";
            this.SizeChanged += new System.EventHandler(this.Function_editor_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.fctb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_test_values;
        private System.Windows.Forms.Label label_test_values;
        private System.Windows.Forms.Label label_tooltip;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.RichTextBox richTextBox_tooltip;
        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.ComboBox comboBox_library;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_functions;
        private System.Windows.Forms.ColumnHeader listview_function_column;
        private System.Windows.Forms.Button button_library;
    }
}