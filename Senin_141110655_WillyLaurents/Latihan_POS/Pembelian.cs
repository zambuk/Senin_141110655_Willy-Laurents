﻿using System;
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
    public partial class Pembelian : Form
    {
        private DBController dbController;
        private String id_barang;
        private String id_supplier;
        private String stockBarang;
        public Pembelian()
        {
            dbController = new DBController();
            InitializeComponent();
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbController.searchBarangPembelian("barang",dataGridView1,txt_namaBarang);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbController.searchSupplier("supplier", dataGridView2, txt_supplier);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                String id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                String namaBarang = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                String stock = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                String hargaJual = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                stockBarang = stock;
                id_barang = id;
                txt_namaBarang.Text = namaBarang;
                txt_hargaJual.Text = hargaJual;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                String id = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                String namaSupplier = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                String telepon = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();

                id_supplier = id;
                txt_supplier.Text = namaSupplier;
                txt_telepon.Text = telepon;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_namaBarang.Text.Length == 0)
            {
                MessageBox.Show("Nama Barang belum diisi!");
                return;
            }
            if (txt_supplier.Text.Length == 0)
            {
                MessageBox.Show("Nama Supplier belum diisi!");
                return;
            }
            if (txt_telepon.Text.Length == 0)
            {
                MessageBox.Show("Telepon Supplier belum diisi!");
                return;
            }
            if (txt_jumlahBarang.Text.Length == 0)
            {
                MessageBox.Show("Jumlah barang belum diisi!");
                return;
            }
            if (txt_hargaJual.Text.Length == 0)
            {
                MessageBox.Show("Harga jual belum diisi!");
                return;
            }

            if (txt_namaBarang.Text.Length != 0 && txt_supplier.Text.Length != 0 && txt_telepon.Text.Length != 0 && txt_jumlahBarang.Text.Length != 0 && txt_hargaJual.Text.Length != 0)
            {
                dbController.insertPembelian(id_barang, id_supplier, txt_jumlahBarang.Text);
                dbController.updateStock("barang", id_barang, Int32.Parse(stockBarang) + Int32.Parse(txt_jumlahBarang.Text));
                dbController.setDataGrid("barang", dataGridView1);
                dbController.setDataGrid("supplier", dataGridView2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refresh()
        {

        }
    }
}
