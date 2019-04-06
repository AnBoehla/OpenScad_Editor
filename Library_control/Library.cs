using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_control;
using Fctb_control;
using System.IO;
using System.Xml;

namespace library_control
{
    public partial class Library : Form
    {
        public Library(List<Library_functions> Librarys_functions, List<Fctb_data> Functions)
        {
            InitializeComponent();
            librarys_functions = Librarys_functions;
            update_listview();
        }

        private int index_library = -1;
        private static List<Library_functions> librarys_functions = new List<Library_functions>();

        private void button_add_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == save.ShowDialog())
            {
                XmlTextWriter xml_writer = new XmlTextWriter(save.FileName, null);
                xml_writer.WriteStartElement("scad");
                xml_writer.WriteEndElement();
                xml_writer.Close();

                string name = Path.GetFileNameWithoutExtension(save.FileName);
                Library_control_class.load_functions(name,save.FileName);
            }
            update_listview();
            Library_control_class.Save_librarys();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            bool load = true;
            List<string> alrady_loaded = new List<string>();
            if (DialogResult.OK == open.ShowDialog())
            {
                for (int i_load = 0; i_load < open.FileNames.Length; i_load++)
                {
                    string name = Path.GetFileNameWithoutExtension(open.FileNames[i_load]);
                    for (int i_library = 0; i_library < librarys_functions.Count; i_library++)
                    {
                        if (open.FileNames[i_load] == librarys_functions[i_library].pfad)
                        {
                            alrady_loaded.Add("The file " + open.FileNames[i_load] + " alrady loaded");
                            load = false;
                        }
                        else if (name == librarys_functions[i_library].name)
                        {
                            alrady_loaded.Add("The name " + name + " alrady exist");
                            load = false;
                        }
                    }
                    if (load)
                    {
                        Library_control_class.load_functions(name, open.FileName);
                    }
                    load = true;
                }
            }
            if (0 < alrady_loaded.Count)
            {
                string error = alrady_loaded.Count + " librarys could not be loaded\r";
                for (int i = 0; i < alrady_loaded.Count && i < 5; i++)
                {
                    error += alrady_loaded[i] + "\r";
                }
                if (5 < alrady_loaded.Count)
                {
                    error += ".....";
                }
                MessageBox.Show(error);
            }
            update_listview();
            Library_control_class.Save_librarys();
        }

        private void update_listview()
        {
            listView_librarys.Items.Clear();
            for (int i = 0; i < librarys_functions.Count; i++)
            {
                listView_librarys.Items.Add(librarys_functions[i].name);
                listView_librarys.Items[listView_librarys.Items.Count - 1].SubItems.Add(librarys_functions[i].pfad);
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            librarys_functions.RemoveAt(index_library);
            Library_control_class.Save_librarys();
            update_listview();
        }

        private void listView_librarys_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            index_library = e.ItemIndex;
        }
    }
}