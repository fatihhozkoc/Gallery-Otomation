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
    public partial class güncelle : Form
    {
        last_version galeri_otomasyonu = new last_version();
        public güncelle()
        {
            InitializeComponent();
        }

        private void güncelle_Load(object sender, EventArgs e)
        {
            string text = "select *from car_list";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri_otomasyonu.make_a_list(kkk2, text); //Yukarıda oluşturduğum last version sınıfından nesne türetmiştim burda
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e) // Databasedeki herhangi bir sıraya 2 kere tıklandığında pşacak olay
        {
           
            DataGridViewRow text2 = dataGridView1.CurrentRow; // işlemi kısaltmak için kullandım bunu
            textBox1.Text = text2.Cells["plaka"].Value.ToString(); 
            textBox2.Text = text2.Cells["marka"].Value.ToString();
            textBox3.Text = text2.Cells["seri"].Value.ToString();
            textBox4.Text = text2.Cells["yıl"].Value.ToString();
            textBox5.Text = text2.Cells["km"].Value.ToString();
            textBox6.Text = text2.Cells["renk"].Value.ToString();
            textBox7.Text = text2.Cells["motor"].Value.ToString();
            textBox8.Text = text2.Cells["yakıt"].Value.ToString();
            textBox9.Text = text2.Cells["durumu"].Value.ToString();
            textBox10.Text = text2.Cells["fiyat"].Value.ToString();              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text3 = "update car_list set marka=@marka,seri=@seri,yıl=@yıl,km=@km,renk=@renk,motor=@motor,yakıt=@yakıt,durumu=@durumu,fiyat=@fiyat where plaka=@plaka";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@plaka", textBox1.Text);
            command2.Parameters.AddWithValue("@marka", textBox2.Text);
            command2.Parameters.AddWithValue("@seri", textBox3.Text);
            command2.Parameters.AddWithValue("@yıl", textBox4.Text);
            command2.Parameters.AddWithValue("@km", textBox5.Text);
            command2.Parameters.AddWithValue("@renk", textBox6.Text);
            command2.Parameters.AddWithValue("@motor", textBox7.Text);
            command2.Parameters.AddWithValue("@yakıt", textBox8.Text);
            command2.Parameters.AddWithValue("@durumu", textBox9.Text);
            command2.Parameters.AddWithValue("@fiyat", textBox10.Text);
           
            galeri_otomasyonu.add(command2, text3);
           
            string text = "select *from car_list";
            SqlDataAdapter kkk2 = new SqlDataAdapter();
            dataGridView1.DataSource = galeri_otomasyonu.make_a_list(kkk2, text);
            MessageBox.Show("İlanınız başarı ile güncellenmiştir..");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
