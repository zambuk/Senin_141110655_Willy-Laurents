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
    public partial class tambahSupplier : Form
    {
        DBController dbController;
        public tambahSupplier()
        {
            dbController = new DBController();
            InitializeComponent();
            dbController.setDataGrid("supplier",dataGridView1);
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
                MessageBox.Show("Kode Supplier belum diisi!");
                return;
            }
            if (txt_nama.Text.Length == 0)
            {
                MessageBox.Show("Nama Supplier belum diisi!");
                return;
            }
            if (txt_alamat.Text.Length == 0)
            {
                MessageBox.Show("Alamat Supplier belum diisi!");
                return;
            }
            if (txt_telepon.Text.Length == 0)
            {
                MessageBox.Show("Telepon Supplier belum diisi!");
                return;
            }

            if (txt_kode.Text.Length > 0 && txt_nama.Text.Length > 0 && txt_alamat.Text.Length > 0 && txt_telepon.Text.Length > 0)
            {
                dbController.insertDataSupplier(txt_kode, txt_nama, txt_alamat, txt_telepon);
                dbController.setDataGrid("supplier", dataGridView1);
            }
        }

        private void txtKode_TextChanged_1(object sender, EventArgs e)
        {
            dbController.filterDataGrid("supplier", dataGridView1, txt_nama);
        }
    }
}
