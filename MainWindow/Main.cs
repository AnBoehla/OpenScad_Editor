using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.IO;
using System.Xml;
using System.Globalization;
using Fctb_control;
using Library_control;

namespace MainWindow
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Init();
        }

        Fctb_control_class fctb_control;
        Library_control.Library_control_class library_control;
        List<string> autosave_list = new List<string>();

        private void Init()
        {
            fctb_control = new Fctb_control_class(fctb);
            library_control = new Library_control_class(fctb_control.Functions);
            timer_autosave.Start();
            autosave_listupdate();
            fctb.Height = this.Height - 68;
            fctb.Width = this.Width - 19;
        }

        private void fctb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Space | Keys.Control))
                fctb_control.Autocomplete_Show();

            if (e.KeyData == (Keys.S | Keys.Control))
                fctb_control.Save(fctb.Text);

            if (e.KeyData == Keys.F6)
                fctb_control.Select_draw_lines();

            if (e.KeyData == Keys.F7)
                fctb_control.Deselect_draw_lines();

            if (e.KeyData == Keys.F8)
                fctb_control.Deselect_all_draw_lines();
        }

        private void fctb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (fctb_control != null)
                fctb_control.TextChanged(sender, e);
        }

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library_control.Library_control_class.call_function_editor();
        }

        private void autosave()
        {
            string dateNow = DateTime.Now.ToString("yyyy_MM_dd__HH_mm");
            fctb_control.Save_with_filename(@"autosave\" + dateNow + ".edi");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb_control.Open();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            fctb.Height = this.Height - 66;
            fctb.Width = this.Width - 17;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb_control.Save(fctb.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb_control.Saveas(fctb.Text);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb_control.New_file();
        }

        private void timer_autosave_Tick(object sender, EventArgs e)
        {
            autosave();
            autosave_listupdate();
        }

        private void autosave_listupdate()
        {
            autosave_list.Clear();

            foreach (string s in Directory.GetFiles(@"autosave\", "*.edi").Select(Path.GetFileName))
            {
                char[] split = s.ToCharArray();
                if (split[4] == '_' && split[7] == '_' && split[10] == '_' && split[11] == '_' && split[14] == '_')
                {
                    autosave_list.Add(s);
                }
            }
            autosave_list.Sort((a, b) => -1 * a.CompareTo(b));

            while (autosave_list.Count > 10)
            {
                File.Delete(@"autosave\" + autosave_list[autosave_list.Count - 1]);
                autosave_list.RemoveAt(autosave_list.Count - 1);
            }

            //Set autosavenames in Contextmenu
            try
            {
                toolStripMenuItem_autosave1.Text = autosave_list[0].Substring(0, 17);
            }
            catch
            {
                toolStripMenuItem_autosave1.Text = "---";
            }
            try
            {
                toolStripMenuItem_autosave2.Text = autosave_list[1].Substring(0, 17);
            }
            catch
            {
                toolStripMenuItem_autosave2.Text = "---";
            }
            try
            {
                toolStripMenuItem_autosave3.Text = autosave_list[2].Substring(0, 17);
            }
            catch
            {
                toolStripMenuItem_autosave3.Text = "---";
            }
            try
            {
                toolStripMenuItem_autosave4.Text = autosave_list[3].Substring(0, 17);
            }
            catch
            {
                toolStripMenuItem_autosave4.Text = "---";
            }
            try
            {
                toolStripMenuItem_autosave5.Text = autosave_list[4].Substring(0, 17);
            }
            catch
            {
                toolStripMenuItem_autosave5.Text = "---";
            }
            try
            {
                toolStripMenuItem_autosave6.Text = autosave_list[5].Substring(0, 17);
            }
            catch
            {
                toolStripMenuItem_autosave6.Text = "---";
            }
            try
            {
                toolStripMenuItem_autosave7.Text = autosave_list[6].Substring(0, 17);
            }
            catch
            {
                toolStripMenuItem_autosave7.Text = "---";
            }
            try
            {
                toolStripMenuItem_autosave8.Text = autosave_list[7].Substring(0, 17);
            }
            catch
            {
                toolStripMenuItem_autosave8.Text = "---";
            }
            try
            {
                toolStripMenuItem_autosave9.Text = autosave_list[8].Substring(0, 17);
            }
            catch
            {
                toolStripMenuItem_autosave9.Text = "---";
            }
            try
            {
                toolStripMenuItem_autosave10.Text = autosave_list[9].Substring(0, 17);
            }
            catch
            {
                toolStripMenuItem_autosave10.Text = "---";
            }
        }

        private void toolStripMenuItem_autosave_Click(object sender, EventArgs e)
        {
            string filename = sender.ToString();
            if (filename != "---")
            {
                fctb_control.Open_with_filename(@"autosave\" + filename + ".edi");
            }
        }

        private void fctb_ToolTipNeeded(object sender, ToolTipNeededEventArgs e)
        {
            string line = fctb.Lines[e.Place.iLine];
            char[] chars = new char[] { ' ', ';', '(', ')' };
            string[] split = line.Split(chars);

            bool first_loop = true;
            int index_start = 0;
            int index_end = 0;
            while (e.Place.iChar > index_end && index_end != -1)
            {
                if (index_start == index_end && !first_loop)
                    index_end++;
                first_loop = false;
                index_start = index_end;
                index_end = line.IndexOfAny(chars, index_start);
            }
            if (index_end < 0)
                index_end = line.Length;

            e.ToolTipText = fctb_control.ToolTipNeeded(line.Substring(index_start, index_end - index_start));
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb_control.Refresh();
        }

        private void fctb_PaintLine(object sender, PaintLineEventArgs e)
        {
            fctb_control.PaintLine(sender, e);
        }

        public void settings_saved()
        {
            fctb_control.Load_setting();
            fctb_control.Refresh();
        }
    }
}