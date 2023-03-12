using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Toku_ku
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; database=toko-ku";
            string query = "INSERT INTO tbl_produk(kode_produk,nama_produk,harga_produk,stok_produk)VALUES('" + this.KODEPRODUK.Text + "','" + this.NAMAPRODUK.Text + "','" + this.HARGAPRODUK.Text + "','" + this.STOKPRODUK.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data berhasil disimpan");
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; database=toko-ku";
            string query = "UPDATE tbl_produk SET nama_produk='" + this.NAMAPRODUK.Text + "',harga_produk='" + this.HARGAPRODUK.Text + "',stok_produk='" + this.STOKPRODUK.Text + "' WHERE kode_produk='" + this.KODEPRODUK.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data berhasil diubah");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; database=toko-ku";
            string query = "DELETE FROM tbl_produk WHERE kode_produk='" + this.KODEPRODUK.Text + "'";

            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data berhasil dihapus");
            conn.Close();
        }

   

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void KODEPRODUK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
