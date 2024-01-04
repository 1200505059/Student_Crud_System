using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENTSYSTEM
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0KSRB41\\SQLEXPRESS;Initial Catalog=OgrenciIslem;Integrated Security=True");

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (textId.Text != "")
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from tblogrenci where Id=@p1 ", baglanti);
                    komut.Parameters.AddWithValue("@p1", textId.Text);

                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("İşlem başarılı");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    textId.Text = "";
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }
            }
            else
            {
                MessageBox.Show("Silmek İçin ID girmelisiniz.");
            }

        }

        private void delete_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciIslemDataSet2.tblogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblogrenciTableAdapter.Fill(this.ogrenciIslemDataSet2.tblogrenci);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tblogrenciBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            
        }
    }
}
