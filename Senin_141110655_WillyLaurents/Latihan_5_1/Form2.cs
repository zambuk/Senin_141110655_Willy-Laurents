using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class Form2 : Form
    {
        Form1 form1;

        public Form2(Form1 f1)
        {
            InitializeComponent();
            form1 = f1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background Color")
            {
                label1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                button1.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.formcolor = colorDialog1.Color;
            this.Close();
        }
    }
}
