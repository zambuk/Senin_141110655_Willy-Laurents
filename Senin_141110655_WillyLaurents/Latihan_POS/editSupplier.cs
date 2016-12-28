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
    public partial class editSupplier : Form
    {
        private String id;
        private String kode;
        private String nama;
        private String alamat;
        private String telepon;
        private DBController dbController;
        public editSupplier(String id, String kode, String nama, String alamat, String telepon)
        {
            dbController = new DBController();
            InitializeComponent();
            this.id = id;
            txtKode.Text = kode;
            txtNama.Text = nama;
            txtAlamat.Text = alamat;
            txtTelepon.Text = telepon; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbController.updateDataSupplier(id, txtKode, txtNama, txtAlamat, txtTelepon);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dbController.delete(id,"supplier");
        }
    }
}
