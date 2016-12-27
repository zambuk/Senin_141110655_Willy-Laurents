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
    }
}
