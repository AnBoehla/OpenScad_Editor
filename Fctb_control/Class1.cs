using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Linq;


namespace Fctb_control
{
    public class Fctb_control_class
    {
        private FastColoredTextBox fctb;
        private List<int> draw_lines = new List<int>();

        //Autocomplete variable_style
        private AutocompleteMenu popupMenu;
        static private List<Fctb_data> fctb_scad_data = new List<Fctb_data>();
        static private List<Fctb_data> fctb_function_data = new List<Fctb_data>();
        private List<string> variablen = new List<string>();

        //Create style for highlighting
        static private TextStyle comment_style;
        static private TextStyle drawing_style;
        static private TextStyle scad_style;
        static private TextStyle variable_style;

        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        private bool file_saved;

        static private string scad_filename;

        public Fctb_control_class(FastColoredTextBox FastColoredTextBox)
        {
            fctb = FastColoredTextBox;
            Load_setting();
            Load_scad_data();
            Autocomplete_init();
            fctb.AutoIndentChars = false;
        }

        public List<Fctb_data> Functions
        {
            get
            {
                return fctb_function_data;
            }
            set
            {
                fctb_function_data = Functions;
            }
        }

        public void Load_setting()
        {
            StreamReader reader = new StreamReader("init\\setting.txt");
            string line;
            string[] split;
            SolidBrush brush;
            line = reader.ReadLine();
            while (line != null)
            {
                fctb.ClearStylesBuffer();
                split = line.Split('=');
                split[0].Replace(" ", "");
                split[1].Replace(" ", "");

                if (split[0] == "comment_style")
                {
                    split = split[1].Split(';');
                    brush = new SolidBrush(Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2])));
                    comment_style = new TextStyle(brush, null, FontStyle.Regular);
                }
                else if (split[0] == "drawing_style")
                {
                    split = split[1].Split(';');
                    brush = new SolidBrush(Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2])));
                    drawing_style = new TextStyle(brush, null, FontStyle.Regular);
                }
                else if (split[0] == "scad_style")
                {
                    split = split[1].Split(';');
                    brush = new SolidBrush(Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2])));
                    scad_style = new TextStyle(brush, null, FontStyle.Regular);
                }
                else if (split[0] == "variable_style")
                {
                    split = split[1].Split(';');
                    brush = new SolidBrush(Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2])));
                    variable_style = new TextStyle(brush, null, FontStyle.Regular);
                }
                else if (split[0] == "BackColor")
                {
                    split = split[1].Split(';');
                    fctb.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "BookmarkColor")
                {
                    split = split[1].Split(';');
                    fctb.BookmarkColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "CaretColor")
                {
                    split = split[1].Split(';');
                    fctb.CaretColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "ChangedLineColor")
                {
                    split = split[1].Split(';');
                    fctb.ChangedLineColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "CurrentLineColor")
                {
                    split = split[1].Split(';');
                    fctb.CurrentLineColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "DisabledColor")
                {
                    split = split[1].Split(';');
                    fctb.DisabledColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "FoldingIndicatorColor")
                {
                    split = split[1].Split(';');
                    fctb.FoldingIndicatorColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "ForeColor")
                {
                    split = split[1].Split(';');
                    fctb.ForeColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "IndentBackColor")
                {
                    split = split[1].Split(';');
                    fctb.IndentBackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "LineNumberColor")
                {
                    split = split[1].Split(';');
                    fctb.LineNumberColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "PaddingBackColor")
                {
                    split = split[1].Split(';');
                    fctb.PaddingBackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "SelectionColor")
                {
                    split = split[1].Split(';');
                    fctb.SelectionColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "ServiceLinesColor")
                {
                    split = split[1].Split(';');
                    fctb.ServiceLinesColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "TextAreaBorderColor")
                {
                    split = split[1].Split(';');
                    fctb.TextAreaBorderColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "scad_filename")
                {
                    scad_filename = split[1];
                }
                line = reader.ReadLine();
            }
            reader.Close();
            Refresh();
        }

        public void Refresh()
        {
            var selection = fctb.Selection.Clone();
            int scroll_pos_x = Math.Abs(fctb.AutoScrollPosition.X);
            int scroll_pos_y = Math.Abs(fctb.AutoScrollPosition.Y);
            string copy = fctb.Text;
            fctb.Text = "";
            fctb.Text = copy;
            fctb.Selection = selection;
            fctb.AutoScrollPosition = new Point(scroll_pos_x, scroll_pos_y);
        }

        public void Autocomplete_init()
        {
            //create autocomplete popup menu
            if (popupMenu == null)
            {
                popupMenu = new AutocompleteMenu(fctb);
            }
            popupMenu.SearchPattern = @"[\w\.:=!<>]";
            popupMenu.AllowTabKey = true;
            popupMenu.MinFragmentLength = 1;

            List<AutocompleteItem> items = new List<AutocompleteItem>();

            for (int i = 0; i < fctb_scad_data.Count; i++)
            {
                if (fctb_scad_data[i].snippet == null)
                {
                    //go to the next itme when snippet is null
                }
                else if (fctb_scad_data[i].kind == "body")
                {
                    items.Add(new SnippetAutocompleteItem(fctb_scad_data[i].snippet));// { ImageIndex = 0 });
                }
                else if (fctb_scad_data[i].kind == "flat")
                {
                    items.Add(new SnippetAutocompleteItem(fctb_scad_data[i].snippet));// { ImageIndex = 1 });
                }
                else if (fctb_scad_data[i].kind == "transformation")
                {
                    items.Add(new SnippetAutocompleteItem(fctb_scad_data[i].snippet));// { ImageIndex = 2 });
                }
                else
                {
                    items.Add(new SnippetAutocompleteItem(fctb_scad_data[i].snippet));
                }
            }

            for (int i = 0; i < fctb_function_data.Count; i++)
            {
                items.Add(new SnippetAutocompleteItem(fctb_function_data[i].snippet));// { ImageIndex = 0 });
            }
            for (int i = 0; i < variablen.Count; i++)
            {
                items.Add(new SnippetAutocompleteItem(variablen[i] + "^"));
            }

            items.Sort((x, y) => string.Compare(x.Text, y.Text));

            //set as autocomplete source
            popupMenu.Items.SetAutocompleteItems(items);
        }

        public void Autocomplete_Show()
        {
            popupMenu.Show(true);
        }

        public void Select_draw_lines()
        {
            int start = fctb.Selection.FromLine;
            int end = fctb.Selection.ToLine;

            for (int i = start; i <= end; i++)
            {
                draw_lines.Add(i);
            }
            draw_lines.Sort();

            int i1 = 0;
            while (i1 < draw_lines.Count - 1)
            {
                if (draw_lines[i1] == draw_lines[i1 + 1])
                {
                    draw_lines.RemoveAt(i1 + 1);
                }
                else
                {
                    i1++;
                }
            }
            Refresh();
        }

        public void Deselect_draw_lines()
        {
            int start = fctb.Selection.FromLine;
            int end = fctb.Selection.ToLine;

            if (draw_lines.Count != 0)
            {
                draw_lines.Sort();

                int i = start;
                int draw_line_counter = 0;
                while (i <= end)
                {
                    if (draw_lines[draw_line_counter] < i)
                    {
                        draw_line_counter++;
                    }
                    else if (draw_lines[draw_line_counter] == i)
                    {
                        draw_lines.RemoveAt(draw_line_counter);
                    }
                    else
                    {
                        i++;
                    }
                }
                Refresh();
            }
        }

        public void Deselect_all_draw_lines()
        {
            draw_lines.Clear();
            Refresh();
        }


        public void TextChanged(object sender, TextChangedEventArgs e)
        {
            file_saved = false;

            GetVariablen();
            Autocomplete_init();

            //codefolding
            e.ChangedRange.ClearFoldingMarkers();
            e.ChangedRange.SetFoldingMarkers("{", "}");

            string drawing = @"\b(";
            string scad = @"\b(";
            string variable = @"\b(";
            for (int i = 0; i < fctb_scad_data.Count; i++)
            {
                if (fctb_scad_data[i].name == null)
                {
                    //go to next item when name == null
                }
                else if (fctb_scad_data[i].kind == "flat" || fctb_scad_data[i].kind == "body")
                {
                    drawing += fctb_scad_data[i].name + "|";
                }
                else if (fctb_scad_data[i].kind == "transformation" || fctb_scad_data[i].kind == "operation" || fctb_scad_data[i].kind == "logic")
                {
                    scad += fctb_scad_data[i].name + "|";
                }
            }
            for (int i = 0; i < fctb_function_data.Count; i++)
            {
                drawing += fctb_function_data[i].name + "|";
            }
            for (int i = 0; i < variablen.Count; i++)
            {
                variable += variablen[i] + "|";
            }
            drawing += @")\b|#region\b|#endregion\b";
            scad += @")\b|#region\b|#endregion\b";
            variable += @")\b|#region\b|#endregion\b";


            //highlighting
            e.ChangedRange.ClearStyle(comment_style);
            e.ChangedRange.ClearStyle(scad_style);
            e.ChangedRange.ClearStyle(drawing_style);
            e.ChangedRange.ClearStyle(variable_style);
            e.ChangedRange.SetStyle(comment_style, @"//.*$", System.Text.RegularExpressions.RegexOptions.Multiline);
            e.ChangedRange.SetStyle(drawing_style, drawing);
            e.ChangedRange.SetStyle(scad_style, scad);
            e.ChangedRange.SetStyle(variable_style, variable);
        }

        public void Load_scad_data()
        {
            fctb_scad_data.Clear();
            XmlTextReader scad = new XmlTextReader("init\\scad.xml");
            Fctb_data fctb_data;

            try
            {
                while (scad.Read())
                {
                    if (scad.Depth == 2)
                    {
                        fctb_data = new Fctb_data(new Guid());
                        do
                        {
                            if (scad.Name == "name")
                            {
                                fctb_data.name = scad.ReadElementContentAsString();
                            }
                            if (scad.Name == "snippet")
                            {
                                fctb_data.snippet = scad.ReadElementContentAsString();
                            }
                            if (scad.Name == "tooltip")
                            {
                                fctb_data.tooltip = scad.ReadElementContentAsString();
                            }
                            scad.Read();
                        }
                        while (scad.Depth > 1);
                        fctb_data.kind = scad.Name;
                        fctb_scad_data.Add(fctb_data);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Save(string text)
        {
            if (saveFileDialog.FileName == "")
            {
                Saveas(fctb.Text);
            }
            else
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                writer.Write(fctb.Text);
                writer.Close();

                Save_scad(text);
                file_saved = true;
            }
        }

        public void Save_scad(string text)
        {
            if (draw_lines.Count != 0)
            {
                text = text.Replace("\n", "");
                string[] lines = text.Split('\r');
                text = "";
                foreach (int linenumber in draw_lines)
                {
                    text += lines[linenumber] + "\r\n";
                }
            }
            StreamWriter writer = new StreamWriter(scad_filename);
            writer.Write(ConvertToScad(text));
            writer.Close();
        }

        public void Saveas(string text)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Save(text);
            }
        }

        public void Save_with_filename(string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            writer.Write(fctb.Text);
            writer.Close();
        }

        public void Open()
        {
            DialogResult delete = DialogResult.Yes;
            if (!file_saved)
            {
                delete = MessageBox.Show("Do you want to save the last change?", "Warning", MessageBoxButtons.YesNo);
            }
            if (delete == DialogResult.Yes)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(openFileDialog.FileName);
                    fctb.Text = reader.ReadToEnd();
                    reader.Close();
                    saveFileDialog.FileName = openFileDialog.FileName;
                    file_saved = true;
                }
            }
        }

        public void Open_with_filename(string Filename)
        {
            DialogResult delete = DialogResult.Yes;
            if (!file_saved)
            {
                delete = MessageBox.Show("Do you want to save the last change?", "Warning", MessageBoxButtons.YesNo);
            }
            if (delete == DialogResult.Yes)
            {
                StreamReader reader = new StreamReader(Filename);
                fctb.Text = reader.ReadToEnd();
                reader.Close();
                saveFileDialog.FileName = "";
                file_saved = false;
            }
        }

        public void New_file()
        {
            DialogResult delete = DialogResult.Yes;
            if (!file_saved)
            {
                delete = MessageBox.Show("Wollen sie diese verwerfen?", "Die letzten Änderungen wurden noch nicht gespeichert.", MessageBoxButtons.YesNo);
            }
            if (delete == DialogResult.Yes)
            {
                fctb.Text = "";
                file_saved = true;
            }
        }

        public string ToolTipNeeded(string HoveredWord)
        {
            string tooltip = "";
            for (int i = 0; i < fctb_scad_data.Count; i++)
            {
                if (fctb_scad_data[i].name == HoveredWord)
                {
                    tooltip = fctb_scad_data[i].tooltip;
                }
            }
            for (int i = 0; i < fctb_function_data.Count; i++)
            {
                if (fctb_function_data[i].name == HoveredWord)
                {
                    tooltip = fctb_function_data[i].tooltip;
                }
            }
            return tooltip;
        }

        public void GetVariablen()
        {
            variablen.Clear();
            char[] delimiters = { ' ', '=', ';', '\n', '\r' };
            string[] split_programm = fctb.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < split_programm.Length; i++)
            {
                if (split_programm[i] == "var" && i + 1 < split_programm.Length)
                {
                    variablen.Add(split_programm[i + 1]);
                }
            }
        }

        public string ConvertToScad(string text)
        {
            text.Replace("var ", "");

            List<int> index_functions = new List<int>();
            char[] delimiters = { ' ', '(', '\n', '\r' };
            string[] split_programm = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for (int i_function = 0; i_function < Functions.Count; i_function++)
            {
                for (int i_split = 0; i_split < split_programm.Length; i_split++)
                {
                    if (split_programm[i_split] == Functions[i_function].name)
                    {
                        index_functions.Add(i_function);
                    }
                }
            }
            index_functions = index_functions.Distinct().ToList();
            text += "\r\n";
            foreach(int i in index_functions)
            {
                text += Functions[i].code + "\r\n";
            }

            return text;
        }

        public void PaintLine(object sender, PaintLineEventArgs e)
        {
            //draw current line marker
            foreach (int linenumber in draw_lines)
            {
                if (e.LineIndex == linenumber)
                {
                    e.Graphics.FillEllipse(Brushes.Green, 0, e.LineRect.Top, 10, 10);
                }
            }
        }
    }

    public partial class Fctb_data
    {
        public string kind;
        public string name;
        public string tooltip;
        public string snippet;
        public string code;
        public Guid guid;

        public Fctb_data(Guid Function_guid)
        {
            guid = Function_guid;
        }

        public Fctb_data(Guid Function_guid, string Kind, string Name, string Tooltip, string Snippet, string Code)
        {
            guid = Function_guid;
            kind = Kind;
            name = Name;
            tooltip = Tooltip;
            snippet = Snippet;
            code = Code;
        }
    }
 }