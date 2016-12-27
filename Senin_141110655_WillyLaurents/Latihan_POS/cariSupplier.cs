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
    public partial class cariSupplier : Form
    {
        private DBController dbController;
        public cariSupplier()
        {
            dbController = new DBController();
            InitializeComponent();
            dbController.setDataGrid("supplier", dataGridView1);
        }

        private void txtKode_TextChanged_1(object sender, EventArgs e)
        {
            dbController.filterDataGrid("supplier", dataGridView1, txtBarang);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //String id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //String kode = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                //String nama_barang = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                //String jumlah_awal = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                //String hargaHPP = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //String hargaJual = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                //editBarang editBarang = new editBarang(id, kode, nama_barang, jumlah_awal, hargaHPP, hargaJual);
                //editBarang.Show();
            }
        }
    }
}
