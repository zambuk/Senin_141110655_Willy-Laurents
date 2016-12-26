using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class tambahCostumer : Form
    {
        DBController dbController;
        public tambahCostumer()
        {
            dbController = new DBController();
            InitializeComponent();
            dbController.setDataGrid("costumer",dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_alamat.Text = "";
            txt_kode.Text = "";
            txt_nama.Text = "";
            txt_telepon.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_kode.Text.Length == 0)
            {
                MessageBox.Show("Kode Customer belum diisi!");
                return;
            }
            if (txt_nama.Text.Length == 0)
            {
                MessageBox.Show("Nama Customer belum diisi!");
                return;
            }
            if (txt_alamat.Text.Length == 0)
            {
                MessageBox.Show("Alamat Customer belum diisi!");
                return;
            }
            if (txt_telepon.Text.Length == 0)
            {
                MessageBox.Show("Telepon Customer belum diisi!");
                return;
            }

            if (txt_kode.Text.Length > 0 && txt_nama.Text.Length > 0 && txt_alamat.Text.Length > 0 && txt_telepon.Text.Length > 0)
            {
                dbController.insertDataCostumer(txt_kode, txt_nama, txt_alamat, txt_telepon);
            }
        }

        private void txtKode_TextChanged_1(object sender, EventArgs e)
        {
            dbController.filterDataGrid("costumer", dataGridView1, txt_nama);
        }
    }
}
