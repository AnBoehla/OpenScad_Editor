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

namespace library_control
{
    public partial class Add_Library : Form
    {
        public Add_Library()
        {
            InitializeComponent();
        }

        private static List<Library_functions> librarys_functions = new List<Library_functions>();

        private void Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                textBox_filename.Text = dialog.Description;
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            //System.IO.File.Exists(DialogResult.);
        }
    }
}
