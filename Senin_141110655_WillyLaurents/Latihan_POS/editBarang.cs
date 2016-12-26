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
    public partial class editBarang : Form
    {
        DBController dbController;
        public editBarang()
        {
            dbController = new DBController();
            InitializeComponent();
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {

        }

    }
}
