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

        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=''");

        MySqlCommand command;

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
            DateTime time = DateTime.Now;
            command = new MySqlCommand("Insert into pos.barang(Kode,Nama,JumlahAwal,HargaHPP,HargaJual,Created_at,Updated_at) values(@Kode,@Nama,@JumlahAwal,@HargaHPP,@HargaJual,@Created_at,@Updated_at);", conn);
            command.Parameters.AddWithValue("@Kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            command.Parameters.AddWithValue("@JumlahAwal", Convert.ToInt32(txtJumlah.Text));
            command.Parameters.AddWithValue("@HargaHPP", Convert.ToDecimal(txtHpp.Text));
            command.Parameters.AddWithValue("@HargaJual", Convert.ToDecimal(txtJual.Text));
            command.Parameters.AddWithValue("@Created_at", time);
            command.Parameters.AddWithValue("@Updated_at", time);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil di Tambahkan!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
