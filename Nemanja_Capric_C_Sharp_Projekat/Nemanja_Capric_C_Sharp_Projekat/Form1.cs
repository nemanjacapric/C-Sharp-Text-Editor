using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nemanja_Capric_C_Sharp_Projekat
{
    public partial class Form1 : Form
    {
        string imeFajla;
        string naziv;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void snimi_fajl_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Snimi rtf fajl";
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.Filter = "rtf files|*.rtf|all files|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            string sadrzaj = text_area.Text;

            naziv = saveFileDialog1.FileName;

            snimi(naziv, sadrzaj);
        }
        bool snimi(string ime, string sadrzaj)
        {
            try
            {
                text_area.SaveFile(ime, RichTextBoxStreamType.RichText);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void zavrsi_program_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void otvori_fajl_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Otvori rtf fajl";
            openFileDialog1.Filter = "rtf files|*.rtf|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            imeFajla = openFileDialog1.FileName;

            otvori(imeFajla);
        }
        void otvori(string ime)
        {
            try
            {
                text_area.LoadFile(ime);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pronadji_zameni_Click(object sender, EventArgs e)
        {
            if (text_box1.Text.Trim() == "")
            {
                MessageBox.Show("Unesite tekst koji treba da se nadje");
                text_box1.Focus();
                return;
            }
            if (text_box2.Text.Trim() == "")
            {
                MessageBox.Show("Unesite tekst kojim se menja");
                text_box2.Focus();
                return;
            }

            zamena(text_box1.Text, text_box2.Text);
        }
        void zamena(string nadji, string zameni)
        {
            string sadrzaj = text_area.Text;

            sadrzaj = sadrzaj.Replace(nadji, zameni);
            text_area.Text = sadrzaj;
        }

        private void fontBoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = text_area.SelectionFont;

            text_area.SelectionFont = f.Bold == true ?
            text_area.SelectionFont = new Font(f.FontFamily, f.Size, FontStyle.Regular) :
            text_area.SelectionFont = new Font(f.FontFamily, f.Size, FontStyle.Bold);
        }

        private void fontItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = text_area.SelectionFont;

            text_area.SelectionFont = f.Italic == true ?
            text_area.SelectionFont = new Font(f.FontFamily, f.Size, FontStyle.Regular) :
            text_area.SelectionFont = new Font(f.FontFamily, f.Size, FontStyle.Italic);
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorSelect  = new ColorDialog();
            Color cs = text_area.SelectionColor;
            if (colorSelect.ShowDialog() == DialogResult.Cancel) return;
            Color c = colorSelect.Color;
            text_area.SelectionColor = c;
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontSelect = new FontDialog();
            if (fontSelect.ShowDialog() == DialogResult.Cancel) return;

            Font f = fontSelect.Font;
            text_area.SelectionFont = f;
        }
        
    }
}
