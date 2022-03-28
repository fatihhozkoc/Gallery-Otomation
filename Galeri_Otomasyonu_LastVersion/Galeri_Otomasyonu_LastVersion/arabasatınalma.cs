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
    public partial class arabasatınalma : Form
    {
        last_version galeri_otomasyonu = new last_version();
        public arabasatınalma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "insert into car_list(plaka,marka,seri,yıl,km,renk,motor,yakıt,durumu,fiyat) values(@plaka,@marka,@seri,@yıl,@km,@renk,@motor,@yakıt,@durumu,@fiyat)";
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@plaka", textBox1.Text);
            command.Parameters.AddWithValue("@marka", textBox2.Text);
            command.Parameters.AddWithValue("@seri", textBox3.Text);
            command.Parameters.AddWithValue("@yıl", textBox4.Text);
            command.Parameters.AddWithValue("@km", textBox6.Text);
            command.Parameters.AddWithValue("@renk", textBox7.Text);
            command.Parameters.AddWithValue("@motor", textBox8.Text);
            command.Parameters.AddWithValue("@yakıt", textBox9.Text);
            command.Parameters.AddWithValue("@durumu", textBox5.Text);
            command.Parameters.AddWithValue("@fiyat", textBox10.Text);
            
            galeri_otomasyonu.add(command, text);
            MessageBox.Show("Araba ilanınız başarı ile eklenmiştir..");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
