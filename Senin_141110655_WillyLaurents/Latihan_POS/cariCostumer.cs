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
    public partial class cariCostumer : Form
    {
        private DBController dbController;
        public cariCostumer()
        {
            dbController = new DBController();
            InitializeComponent();
            dbController.setDataGrid("costumer", dataGridView1);
        }

        private void txtBarang_TextChanged(object sender, EventArgs e)
        {
            dbController.filterDataGrid("costumer", dataGridView1, txtBarang);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                String id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                String kode = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                String nama = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                String alamat = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                String telepon = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                editCostumer editCostumer = new editCostumer(id, kode, nama, alamat, telepon);
                editCostumer.Show();
            }
        }
    }
}
