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

namespace Galeri_Otomasyonu_LastVersion
{
    public partial class arabasatış : Form
    {
          last_version galeri_otomasyonu = new last_version(); // burada oluşturduğum last version kısmından yeni nesne türettim
        public arabasatış()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow mmm = dataGridView1.CurrentRow;
            string lll = "delete from car_list  where plaka='" + mmm.Cells["plaka"].Value.ToString() + "'"; // Bunu yaparken plakayı seçtim mesela marka seçsem key olarak ford markalı bir araç sildiğimde bütün ford marka araçları silecek
            SqlCommand komut2 = new SqlCommand();
            galeri_otomasyonu.add(komut2, lll);
            
            string text = "select *from car_list";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri_otomasyonu.make_a_list(kkk2, text);
            MessageBox.Show("TEMUR OTOMOTİV OLARAK HAYIRLI KULLANIMLAR DİLERİZ");
        }

        private void arabasatış_Load(object sender, EventArgs e)
        {
            string text = "select *from car_list";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri_otomasyonu.make_a_list(kkk2, text); //Yukarıda oluşturduğum last version sınıfından nesne türetmiştim burda o sınıftan make_a_list metodunu çağırıyorum
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = "select *from car_list where marka like '%" + textBox1.Text + "%'"; // Eğer arama yaptığımda aradığım yer markada varsa bana listeleyecek 
            SqlDataAdapter kkk3 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri_otomasyonu.make_a_list(kkk3, text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = "select *from car_list where renk like '%" + textBox2.Text + "%'"; 
            SqlDataAdapter kkk4 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri_otomasyonu.make_a_list(kkk4, text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string text = "select *from car_list where yakıt like '%" + textBox3.Text + "%'";
            SqlDataAdapter kkk5 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri_otomasyonu.make_a_list(kkk5, text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string text = "select *from car_list where yıl like '%" + textBox4.Text + "%'";
            SqlDataAdapter kkk6 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri_otomasyonu.make_a_list(kkk6, text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string text = "select *from car_list where durumu like '%" + textBox5.Text + "%'";
            SqlDataAdapter kkk7 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri_otomasyonu.make_a_list(kkk7, text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string text = "select *from car_list where fiyat like '%" + textBox6.Text + "%'";
            SqlDataAdapter kkk8 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri_otomasyonu.make_a_list(kkk8, text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            güncelle update = new güncelle();
            update.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
