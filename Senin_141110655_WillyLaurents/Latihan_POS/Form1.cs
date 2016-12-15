using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tambahBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahBarang formTambahBarang = new tambahBarang();
            formTambahBarang.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tambahCostumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahCostumer formTambahCust = new tambahCostumer();
            formTambahCust.Show();
        }

        private void tambahSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahSupplier formTambahSupp = new tambahSupplier();
            formTambahSupp.Show();
        }
    }
}
