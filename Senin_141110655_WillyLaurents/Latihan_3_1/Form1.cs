using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bold.Font = new Font(bold.Font, FontStyle.Bold);
            italic.Font = new Font(italic.Font, FontStyle.Italic);
            underline.Font = new Font(underline.Font, FontStyle.Underline);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fontfamily
            FontFamily[] fontfam = FontFamily.Families;
            foreach (FontFamily fam in fontfam)
                style.Items.Add(fam.Name);

            //fontcolor
            foreach (KnownColor fontcolor in Enum.GetValues(typeof(KnownColor)))
            {
                color.Items.Add(fontcolor);
            }

            //fontsize
            for (int i = 2; i <= 74; i += 2)
            {
                size.Items.Add(i + " px");
            }
        }

        private void bold_Click(object sender, EventArgs e)
        {
            if (textbox.SelectionFont.Bold)
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style ^ FontStyle.Bold);
                bold.Checked = false;
            }
            else
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style | FontStyle.Bold);
                bold.Checked = true;
            }
        }

        private void italic_Click(object sender, EventArgs e)
        {
            if (textbox.SelectionFont.Italic)
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style ^ FontStyle.Italic);
                italic.Checked = false;
            }
            else
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style | FontStyle.Italic);
                italic.Checked = true;
            }
        }

        private void underline_Click(object sender, EventArgs e)
        {
            if (textbox.SelectionFont.Underline)
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style ^ FontStyle.Underline);
                underline.Checked = false;
            }
            else
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style | FontStyle.Underline);
                underline.Checked = true;
            }
        }

        private void size_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox.SelectionFont = new System.Drawing.Font(textbox.SelectionFont.FontFamily, Convert.ToInt32(size.Text.Split(' ')[0]), textbox.SelectionFont.Style);
        }

        private void style_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox.SelectionFont = new System.Drawing.Font(style.Text, textbox.SelectionFont.Size, textbox.SelectionFont.Style);
        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox.SelectionColor = Color.FromName(color.Text);
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
