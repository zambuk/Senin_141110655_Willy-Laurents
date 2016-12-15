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
    public partial class tambahSupplier : Form
    {
        public tambahSupplier()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=''");

        MySqlCommand command;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_alamat.Text = "";
            txt_kode.Text = "";
            txt_nama.Text = "";
            txt_telepon.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand("Insert into pos.supplier(kode,nama,alamat,telepon) values(@kode,@nama,@alamat,@telepon);", conn);
            command.Parameters.AddWithValue("@kode", txt_kode.Text.ToUpper());
            command.Parameters.AddWithValue("@nama", txt_nama.Text);
            command.Parameters.AddWithValue("@alamat", txt_alamat.Text);
            command.Parameters.AddWithValue("@telepon", txt_telepon.Text);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Supplier berhasil ditambahkan!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
        }
    }
}
