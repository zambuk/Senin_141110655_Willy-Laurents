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
    public partial class tambahBarang : Form
    {
        DBController dbController;
        public tambahBarang()
        {
            dbController = new DBController();
            InitializeComponent();
            dbController.setDataGrid("barang",dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKode.Text = "";
            txtNama.Text = "";
            txtJumlah.Text = "";
            txtHpp.Text = "";
            txtJual.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKode.Text.Length == 0)
            {
                MessageBox.Show("Kode Barang belum diisi!");
                return;
            }
            if (txtNama.Text.Length == 0)
            {
                MessageBox.Show("Nama Barang belum diisi!");
                return;
            }
            if (txtJumlah.Text.Length == 0)
            {
                MessageBox.Show("Jumlah Barang belum diisi!");
                return;
            }
            if (txtHpp.Text.Length == 0)
            {
                MessageBox.Show("HPP Barang belum diisi!");
                return;
            }
            if (txtJual.Text.Length == 0)
            {
                MessageBox.Show("Harga Jual Barang belum diisi!");
                return;
            }

            if (txtKode.Text.Length != 0 && txtNama.Text.Length != 0 && txtJumlah.Text.Length != 0 && txtHpp.Text.Length != 0 && txtJual.Text.Length != 0)
            {
                dbController.insertDataBarang(txtKode, txtNama, txtJumlah, txtHpp, txtJual);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtKode_TextChanged_1(object sender, EventArgs e)
        {
            dbController.filterDataGrid("barang", dataGridView1, txtNama);
        }
    }
}
