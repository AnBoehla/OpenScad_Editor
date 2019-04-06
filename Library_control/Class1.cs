using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fctb_control;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.IO;
using System.Data;
using System.Xml;

namespace Library_control
{
    public class Library_control_class
    {
        private static List<Fctb_data> functions;
        private static List<Library_functions> librarys_functions = new List<Library_functions>();
        library_control.Function_editor editor = new library_control.Function_editor(librarys_functions, functions);

        public Library_control_class(List<Fctb_data> Functions)
        {
            functions = Functions;

            load_librarys();
            update_functions();
        }

        public static void load_librarys()
        {
            librarys_functions.Clear();
            StreamReader reader_librarys = new StreamReader(@"init\librarys.txt");
            string line = reader_librarys.ReadLine();
            string[] split;
            while (line != null)
            {
                split = line.Split(';');
                load_functions(split[0], split[1]);
                line = reader_librarys.ReadLine();
            }
            reader_librarys.Close();
        }

        public static void load_functions(string name, string filename)
        {
            Library_functions data = null;
            XmlTextReader reader = null;
            Fctb_data fctb_data;

            try
            {
                for (int i = 0; i < librarys_functions.Count; i++)
                {
                    if (librarys_functions[i].pfad== filename)
                    {
                        data = librarys_functions[i];
                        librarys_functions[i].functions.Clear();
                    }
                }

                if (data == null)
                    data = new Library_functions(name, filename);

                reader = new XmlTextReader(filename);

                while (reader.Read())
                {
                    if (reader.Depth == 2)
                    {
                        fctb_data = new Fctb_data(new Guid());
                        do
                        {
                            if (reader.Name == "name")
                            {
                                fctb_data.name = reader.ReadElementContentAsString();
                            }
                            if (reader.Name == "snippet")
                            {
                                fctb_data.snippet = reader.ReadElementContentAsString();
                            }
                            if (reader.Name == "tooltip")
                            {
                                fctb_data.tooltip = reader.ReadElementContentAsString();
                            }
                            if (reader.Name == "code")
                            {
                                fctb_data.code = reader.ReadElementContentAsString();
                            }
                            reader.Read();
                        }
                        while (reader.Depth > 1);
                        fctb_data.kind = "function";
                        data.functions.Add(fctb_data);
                    }
                }
                librarys_functions.Add(data);
            }
            catch (Exception e)
            {
                if (reader != null)
                MessageBox.Show("Library" + name + "could not be loaded\r" + e.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        public static void update_functions()
        {
            try
            {
            functions.Clear();
            foreach (Library_functions library in librarys_functions)
            {
                foreach (Fctb_data function in library.functions)
                {
                    int start = function.code.IndexOf('\r') + 2;
                    functions.Add(new Fctb_data(function.guid,function.kind,function.name + "_" + library.name, function.tooltip,function.snippet,function.code.Substring(start)));
                }
            }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void call_function_editor()
        {
            var test = librarys_functions;
            var stest = functions;
            library_control.Function_editor editor = new library_control.Function_editor(librarys_functions, functions);
            editor.Show();
        }

        public static void call_library_manager()
        {
            library_control.Library library_manager = new library_control.Library(librarys_functions, functions);
            library_manager.Show();
        }

        public static void Save_librarys()
        {
            StreamWriter writer = new StreamWriter(@"init\librarys.txt");

            for (int i = 0; i < librarys_functions.Count; i++)
            {
                writer.WriteLine(librarys_functions[i].name + ";" + librarys_functions[i].pfad);
            }
            writer.Close();
        }
    }

    public class Library_functions
    {
        public string name;
        public string pfad;
        public List<Fctb_data> functions;

        public Library_functions(string Name, string Pfad)
        {
            name = Name;
            pfad = Pfad;
            functions = new List<Fctb_data>();
        }
    }
}