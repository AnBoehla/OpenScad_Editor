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
using Fctb_control;
using Library_control;
using System.Xml;

namespace library_control
{
    public partial class Function_editor : Form
    {
        public Function_editor(List<Library_functions> Librarys_functions, List<Fctb_data> Functions)
        {
            InitializeComponent();
            functions = Functions;
            librarys_functions = Librarys_functions;
            fctb_control = new Fctb_control_class(fctb);
            set_form_style();
            function_saved = true;
            set_combobox_itmes();
            set_list_items();
        }

        private Fctb_control_class fctb_control;
        private static List<Fctb_data> functions;
        private static List<Library_functions> librarys_functions = new List<Library_functions>();
        private int index_function = -1;
        private int index_library = -1;

        bool function_saved;

        private void fctb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Space | Keys.Control))
                fctb_control.Autocomplete_Show();

            if (e.KeyData == (Keys.S | Keys.Control))
                Save_function();

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
            if (index_function >= 0)
                function_saved = false;
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

        private void Function_editor_SizeChanged(object sender, EventArgs e)
        {
            set_form_style();
        }

        private void set_form_style()
        {
            textBox_name.Width = this.Width - 220;
            richTextBox_tooltip.Width = this.Width - 220;
            textBox_test_values.Width = this.Width - 220;
            fctb.Width = this.Width - 220;
            fctb.Height = this.Height - 240;
            listView_functions.Height = this.Height - 50;
            listview_function_column.Width = listView_functions.Width;
        }

        private void set_combobox_itmes()
        {
            button_add.Visible = false;
            index_library = -1;

            comboBox_library.Items.Clear();
            foreach (Library_functions item in librarys_functions)
            {
                comboBox_library.Items.Add(item.name);
                comboBox_library.SelectedIndex = 0;
            }
        }

        private void set_list_items()
        {
            change_visible(false);
            index_function = -1;
            if (0 <= index_library)
            {
                listView_functions.Items.Clear();
                foreach (Library_functions item in librarys_functions)
                {
                    string test = comboBox_library.Items[index_library].ToString();
                    if (comboBox_library.Items[index_library].ToString() == item.name)
                    {
                        foreach (Fctb_data data in item.functions)
                        {
                            listView_functions.Items.Add(data.name);
                        }
                    }
                }
            }
        }

        private void change_visible(bool visible)
        {
            label_name.Visible = visible;
            textBox_name.Visible = visible;
            label_tooltip.Visible = visible;
            richTextBox_tooltip.Visible = visible;
            label_test_values.Visible = visible;
            textBox_test_values.Visible = visible;
            fctb.Visible = visible;
            button_remove.Visible = visible;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            DialogResult result = Save_function();

            if (result == DialogResult.No || result == DialogResult.Yes)
            {
                Fctb_data new_function = new Fctb_data(new Guid(), "function", "new_function", "", "", "");
                librarys_functions[index_library].functions.Insert(0, new_function);
                set_list_items();
                textBox_name.Text = "";
                textBox_name.Focus();
                richTextBox_tooltip.Text = "";
                fctb.Text = "";

                index_function = 0;
                change_visible(true);
                for (int i = 0; i < listView_functions.Items.Count; i++)
                {
                    listView_functions.Items[i].BackColor = Color.Transparent;
                }
                listView_functions.Items[index_function].BackColor = Color.Blue;
            }
        }

        private DialogResult Save_function()
        {
            DialogResult result = DialogResult.Yes;
            if (!function_saved)
            {
                //result = MessageBox.Show("Do you want to save the last change?", "Warning", MessageBoxButtons.YesNoCancel);
            }
            if (result == DialogResult.Yes)
            {
                if (0 <= index_function)
                {
                    librarys_functions[index_library].functions[index_function].name = textBox_name.Text;
                    librarys_functions[index_library].functions[index_function].snippet = textBox_name.Text + "_" + librarys_functions[index_library].name + "(^);";
                    librarys_functions[index_library].functions[index_function].tooltip = richTextBox_tooltip.Text;
                    librarys_functions[index_library].functions[index_function].code = fctb.Text;
                }
                function_saved = true;
                Library_control_class.update_functions();

                int start = fctb.Text.IndexOf('\r');
                if (0 <= start)
                    fctb_control.Save_scad(fctb.Text.Substring(0, start));

                XmlTextWriter xml_writer = new XmlTextWriter(librarys_functions[index_library].pfad, null);
                xml_writer.WriteStartElement("scad");
                xml_writer.WriteString("\r\n");
                foreach (Fctb_data data in librarys_functions[index_library].functions)
                {
                    xml_writer.WriteStartElement("function");
                    xml_writer.WriteString("\r\n");

                    xml_writer.WriteStartElement("name");
                    xml_writer.WriteString(data.name);
                    xml_writer.WriteEndElement();
                    xml_writer.WriteString("\r\n");

                    xml_writer.WriteStartElement("snippet");
                    xml_writer.WriteString(data.snippet);
                    xml_writer.WriteEndElement();
                    xml_writer.WriteString("\r\n");

                    xml_writer.WriteStartElement("tooltip");
                    xml_writer.WriteString(data.tooltip);
                    xml_writer.WriteEndElement();
                    xml_writer.WriteString("\r\n");

                    xml_writer.WriteStartElement("code");
                    xml_writer.WriteString(data.code);
                    xml_writer.WriteEndElement();
                    xml_writer.WriteString("\r\n");

                    xml_writer.WriteEndElement();
                    xml_writer.WriteString("\r\n");
                }
                xml_writer.WriteEndElement();
                xml_writer.Close();
            }
            return result;
        }

        private void richTextBox_tooltip_TextChanged(object sender, EventArgs e)
        {
            if (index_function >= 0)
                function_saved = false;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (index_function >= 0)
                function_saved = false;
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are sure to delet the function " + librarys_functions[index_library].functions[index_function].name + "?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                librarys_functions[index_library].functions.RemoveAt(index_function);

                set_list_items();
                Save_function();
            }
        }

        private void comboBox_library_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_add.Visible = true;
            index_library = comboBox_library.SelectedIndex;
            set_list_items();
        }

        private void listView_functions_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            change_visible(true);
            Save_function();
            index_function = e.ItemIndex;
            for (int i = 0; i < listView_functions.Items.Count; i++)
            {
                listView_functions.Items[i].BackColor = Color.Transparent;
            }
            listView_functions.Items[index_function].BackColor = Color.Blue;

            textBox_name.Text = librarys_functions[index_library].functions[index_function].name;
            richTextBox_tooltip.Text = librarys_functions[index_library].functions[index_function].tooltip;
            fctb.Text = librarys_functions[index_library].functions[index_function].code;
        }

        private void button_library_Click(object sender, EventArgs e)
        {
            Library_control.Library_control_class.call_library_manager();
        }

        private void textBox_name_Leave(object sender, EventArgs e)
        {
            bool name_exist = false;
            if (textBox_name.Text == "")
            {
                MessageBox.Show("A name is needed");
                textBox_name.Focus();
                textBox_name.SelectAll();
                name_exist = true;
            }
            else if (textBox_name.Text != librarys_functions[index_library].functions[index_function].name)
            {
                foreach (Fctb_data function in librarys_functions[index_library].functions)
                {
                    if (function.name == textBox_name.Text)
                    {
                        MessageBox.Show("This name is already in us");
                        textBox_name.Focus();
                        textBox_name.SelectAll();
                        name_exist = true;
                    }
                }
            }
            if (!name_exist)
            {
                if (fctb.Text == "")
                {
                    fctb.Text = textBox_name.Text + "_" + librarys_functions[index_library].name + "();\r" + "module " + textBox_name.Text + "_" + librarys_functions[index_library].name + "(){\r\r}";
                }
                else
                {
                    string text = fctb.Text;
                    fctb.Text = text.Replace(librarys_functions[index_library].functions[index_function].name, textBox_name.Text);
                }
                Save_function();
                fctb_control.Refresh();
                set_list_items();
            }
        }
    }
}