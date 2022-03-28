using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeri_Otomasyonu_LastVersion
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arabasatış sell = new arabasatış();
            sell.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arabasatınalma sell2 = new arabasatınalma();
            sell2.ShowDialog();
        }
    }
}
