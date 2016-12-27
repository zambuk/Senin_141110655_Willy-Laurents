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
        private String id;
        private String kode;
        private String nama_barang;
        private String jumlah_awal;
        private String hargaHPP;
        private String hargaJual;
        private DBController dbController;
        public editBarang(String id,String kode,String nama_barang,String jumlah_awal,String hargaHPP,String hargaJual)
        {
            dbController = new DBController();
            InitializeComponent();
            this.id = id;
            txtKode.Text = kode;
            txtBarang.Text = nama_barang;
            txtJumlahAwal.Text = jumlah_awal;
            txtHPP.Text = hargaHPP;
            txtJual.Text = hargaJual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbController.updateDateBarang(id, txtKode, txtBarang, txtJumlahAwal, txtHPP, txtJual);
        }
    }
}
