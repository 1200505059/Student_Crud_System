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
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0KSRB41\\SQLEXPRESS;Initial Catalog=OgrenciIslem;Integrated Security=True");

        private void list_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciIslemDataSet8.tblogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblogrenciTableAdapter.Fill(this.ogrenciIslemDataSet8.tblogrenci);

        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            SqlCommand komut = new SqlCommand("SELECT * FROM tblogrenci", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
