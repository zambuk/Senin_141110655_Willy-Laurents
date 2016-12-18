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
        public tambahBarang()
        {
            InitializeComponent();
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
            DBController dbController = new DBController();
            dbController.insertDataBarang(txtKode,txtNama,txtJumlah,txtHpp,txtJual);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
