using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainWindow
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Init();
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        ColorDialog colorDialog = new ColorDialog();

        private void Init()
        {
            StreamReader reader = new StreamReader("init\\setting.txt");
            string line;
            string[] split;
            line = reader.ReadLine();
            while (line != null)
            {
                split = line.Split('=');
                split[0].Replace(" ", "");
                split[1].Replace(" ", "");

                if (split[0] == "comment_style")
                {
                    split = split[1].Split(';');
                    pictureBox_comment.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "drawing_style")
                {
                    split = split[1].Split(';');
                    pictureBox_drawing.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "scad_style")
                {
                    split = split[1].Split(';');
                    pictureBox_scad.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "variable_style")
                {
                    split = split[1].Split(';');
                    pictureBox_variable.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "BackColor")
                {
                    split = split[1].Split(';');
                    pictureBox_BackColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "BookmarkColor")
                {
                    split = split[1].Split(';');
                    pictureBox_BookmarkColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "CaretColor")
                {
                    split = split[1].Split(';');
                    pictureBox_CaretColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "ChangedLineColor")
                {
                    split = split[1].Split(';');
                    pictureBox_ChangedLineColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "CurrentLineColor")
                {
                    split = split[1].Split(';');
                    pictureBox_CurrentLineColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "DisabledColor")
                {
                    split = split[1].Split(';');
                    pictureBox_DisabledColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "FoldingIndicatorColor")
                {
                    split = split[1].Split(';');
                    pictureBox_FoldingIndicatorColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "ForeColor")
                {
                    split = split[1].Split(';');
                    pictureBox_ForeColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "IndentBackColor")
                {
                    split = split[1].Split(';');
                    pictureBox_IndentBackColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "LineNumberColor")
                {
                    split = split[1].Split(';');
                    pictureBox_LineNumberColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "PaddingBackColor")
                {
                    split = split[1].Split(';');
                    pictureBox_PaddingBackColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "SelectionColor")
                {
                    split = split[1].Split(';');
                    pictureBox_SelectionColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "ServiceLinesColor")
                {
                    split = split[1].Split(';');
                    pictureBox_ServiceLinesColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "TextAreaBorderColor")
                {
                    split = split[1].Split(';');
                    pictureBox_TextAreaBorderColor.BackColor = Color.FromArgb(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split[2]));
                }
                else if (split[0] == "scad_filename")
                {
                    label_scad_filename.Text = split[1];
                }
                line = reader.ReadLine();
            }
            reader.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            colorDialog.Color = picture.BackColor;
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                picture.BackColor = colorDialog.Color;
            }
        }

        private void filename_Click(object sender, EventArgs e)
        {
            Label lable = (Label)sender;
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                lable.Text = openFileDialog.FileName;
            }
        }

        private void save()
        {
            StreamWriter save = new StreamWriter("init\\setting.txt");
            save.WriteLine("comment_style=" + pictureBox_comment.BackColor.R + ";" + pictureBox_comment.BackColor.G + ";" + pictureBox_comment.BackColor.B);
            save.WriteLine("drawing_style=" + pictureBox_drawing.BackColor.R + ";" + pictureBox_drawing.BackColor.G + ";" + pictureBox_drawing.BackColor.B);
            save.WriteLine("scad_style=" + pictureBox_scad.BackColor.R + ";" + pictureBox_scad.BackColor.G + ";" + pictureBox_scad.BackColor.B);
            save.WriteLine("variable_style=" + pictureBox_variable.BackColor.R + ";" + pictureBox_variable.BackColor.G + ";" + pictureBox_variable.BackColor.B);
            save.WriteLine("BackColor=" + pictureBox_BackColor.BackColor.R + ";" + pictureBox_BackColor.BackColor.G + ";" + pictureBox_BackColor.BackColor.B);
            save.WriteLine("BookmarkColor=" + pictureBox_BookmarkColor.BackColor.R + ";" + pictureBox_BookmarkColor.BackColor.G + ";" + pictureBox_BookmarkColor.BackColor.B);
            save.WriteLine("CaretColor=" + pictureBox_CaretColor.BackColor.R + ";" + pictureBox_CaretColor.BackColor.G + ";" + pictureBox_CaretColor.BackColor.B);
            save.WriteLine("ChangedLineColor=" + pictureBox_ChangedLineColor.BackColor.R + ";" + pictureBox_ChangedLineColor.BackColor.G + ";" + pictureBox_ChangedLineColor.BackColor.B);
            save.WriteLine("CurrentLineColor=" + pictureBox_CurrentLineColor.BackColor.R + ";" + pictureBox_CurrentLineColor.BackColor.G + ";" + pictureBox_CurrentLineColor.BackColor.B);
            save.WriteLine("DisabledColor=" + pictureBox_DisabledColor.BackColor.R + ";" + pictureBox_DisabledColor.BackColor.G + ";" + pictureBox_DisabledColor.BackColor.B);
            save.WriteLine("FoldingIndicatorColor=" + pictureBox_FoldingIndicatorColor.BackColor.R + ";" + pictureBox_FoldingIndicatorColor.BackColor.G + ";" + pictureBox_FoldingIndicatorColor.BackColor.B);
            save.WriteLine("ForeColor=" + pictureBox_ForeColor.BackColor.R + ";" + pictureBox_ForeColor.BackColor.G + ";" + pictureBox_ForeColor.BackColor.B);
            save.WriteLine("IndentBackColor=" + pictureBox_IndentBackColor.BackColor.R + ";" + pictureBox_IndentBackColor.BackColor.G + ";" + pictureBox_IndentBackColor.BackColor.B);
            save.WriteLine("LineNumberColor=" + pictureBox_LineNumberColor.BackColor.R + ";" + pictureBox_LineNumberColor.BackColor.G + ";" + pictureBox_LineNumberColor.BackColor.B);
            save.WriteLine("PaddingBackColor=" + pictureBox_PaddingBackColor.BackColor.R + ";" + pictureBox_PaddingBackColor.BackColor.G + ";" + pictureBox_PaddingBackColor.BackColor.B);
            save.WriteLine("SelectionColor=" + pictureBox_SelectionColor.BackColor.R + ";" + pictureBox_SelectionColor.BackColor.G + ";" + pictureBox_SelectionColor.BackColor.B);
            save.WriteLine("ServiceLinesColor=" + pictureBox_ServiceLinesColor.BackColor.R + ";" + pictureBox_ServiceLinesColor.BackColor.G + ";" + pictureBox_ServiceLinesColor.BackColor.B);
            save.WriteLine("TextAreaBorderColor=" + pictureBox_TextAreaBorderColor.BackColor.R + ";" + pictureBox_TextAreaBorderColor.BackColor.G + ";" + pictureBox_TextAreaBorderColor.BackColor.B);
            save.WriteLine("scad_filename=" + label_scad_filename.Text);
            save.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            save();
            var main = Application.OpenForms.OfType<Main>().Single();
            main.settings_saved();
        }
    }
}