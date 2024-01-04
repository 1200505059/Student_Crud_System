using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace STUDENTSYSTEM
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0KSRB41\\SQLEXPRESS;Initial Catalog=OgrenciIslem;Integrated Security=True");

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE tblogrenci SET ograd = @p1, ogrsoyad = @p2, ogrno = @p3, ogrsehir = @p4 WHERE Id = @p5;", baglanti);
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                komut.Parameters.AddWithValue("@p3", textBox3.Text);
                komut.Parameters.AddWithValue("@p5", textBox4.Text);
                komut.Parameters.AddWithValue("@p4", comboBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İşlem başarılı");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Bilgiler eksik tekrar deneyin!");
            }
        }

        private void update_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciIslemDataSet7.tblogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblogrenciTableAdapter5.Fill(this.ogrenciIslemDataSet7.tblogrenci);
            // TODO: Bu kod satırı 'ogrenciIslemDataSet6.tblogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblogrenciTableAdapter4.Fill(this.ogrenciIslemDataSet6.tblogrenci);
            // TODO: Bu kod satırı 'ogrenciIslemDataSet5.tblogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblogrenciTableAdapter3.Fill(this.ogrenciIslemDataSet5.tblogrenci);
            // TODO: Bu kod satırı 'ogrenciIslemDataSet4.tblogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblogrenciTableAdapter2.Fill(this.ogrenciIslemDataSet4.tblogrenci);
            // TODO: Bu kod satırı 'ogrenciIslemDataSet3.tblogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblogrenciTableAdapter1.Fill(this.ogrenciIslemDataSet3.tblogrenci);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {     
            SqlCommand komut = new SqlCommand("SELECT * FROM tblogrenci", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;        
            textBox4.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
