using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Latihan_POS
{
    class DBController
    {
        MySqlCommand command;
        MySqlConnection conn;
        DataTable dt;
        MySqlDataAdapter da;
        public DBController()
        {
            connection();
        }

        public void connection()
        {
            conn = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=''");
        }



        public void insertDataBarang(TextBox txtKode, TextBox txtNama, TextBox txtJumlah, TextBox txtHpp, TextBox txtJual)
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

        public void insertDataCostumer(TextBox txt_kode,TextBox txt_nama,TextBox txt_alamat,TextBox txt_telepon)
        {
            command = new MySqlCommand("Insert into pos.costumer(kode,nama,alamat,telepon) values(@kode,@nama,@alamat,@telepon);", conn);
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

        public void insertDataSupplier(TextBox txt_kode, TextBox txt_nama, TextBox txt_alamat, TextBox txt_telepon)
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

        public void updateDateBarang(String id, TextBox txtKode, TextBox txtBarang, TextBox txtJumlahAwal, TextBox txtHPP, TextBox txtJual)
        {
            DateTime time = DateTime.Now;
            command = new MySqlCommand("update barang set Kode = @kode, Nama = @nama, JumlahAwal = @jumlahawal, HargaHPP = @hargahpp, HargaJual = @hargajual, Updated_at = @updated_at where id = "+id, conn);
            command.Parameters.AddWithValue("@kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@nama", txtBarang.Text);
            command.Parameters.AddWithValue("@jumlahawal", txtJumlahAwal.Text);
            command.Parameters.AddWithValue("@hargahpp", txtHPP.Text);
            command.Parameters.AddWithValue("@hargajual", txtJual.Text);
            command.Parameters.AddWithValue("@updated_at", time);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Barang berhasil diedit!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
        }

        public void updateDataCostumer(String id, TextBox txtKode, TextBox txtNama, TextBox txtAlamat, TextBox txtTelepon)
        {
            DateTime time = DateTime.Now;
            command = new MySqlCommand("update costumer set kode = @kode, nama = @nama, alamat = @alamat, telepon = @telepon where id = " + id, conn);
            command.Parameters.AddWithValue("@kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@nama", txtNama.Text);
            command.Parameters.AddWithValue("@alamat", txtAlamat.Text);
            command.Parameters.AddWithValue("@telepon", txtTelepon.Text);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Costumer berhasil diedit!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
        }

        public void updateDataSupplier(String id, TextBox txtKode, TextBox txtNama, TextBox txtAlamat, TextBox txtTelepon)
        {
            DateTime time = DateTime.Now;
            command = new MySqlCommand("update supplier set kode = @kode, nama = @nama, alamat = @alamat, telepon = @telepon where id = " + id, conn);
            command.Parameters.AddWithValue("@kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@nama", txtNama.Text);
            command.Parameters.AddWithValue("@alamat", txtAlamat.Text);
            command.Parameters.AddWithValue("@telepon", txtTelepon.Text);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Costumer berhasil diedit!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
        }

        public void delete(String id, String table)
        {
            DateTime time = DateTime.Now;
            command = new MySqlCommand("delete from "+table+" where id = " + id, conn);
          
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(table+" berhasil dihapus!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
        }
        
        public void setDataGrid(String tableName, DataGridView dataGridView)
        {
            command = new MySqlCommand("select * from "+tableName, conn);
            da = new MySqlDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);

            dataGridView.DataSource = dt;
        }

        public void filterDataGrid(String tableName, DataGridView dataGridView, TextBox txt_nama)
        {
            command = new MySqlCommand("select * from " + tableName + " where nama like concat('%', @Nama '%')", conn);
            command.Parameters.AddWithValue("@Nama", txt_nama.Text);
            da = new MySqlDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }
    }
}
