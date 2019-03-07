using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeOyunu
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        public static string gonderilecek_veri, gonderilecek_veri_tık;
        private void button1_Click(object sender, EventArgs e)
        {
            gonderilecek_veri_tık = "1-tıklandı";
            Form3 frm = new Form3();
            frm.Show();
            Form2 frm2 = new Form2();
            frm2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gonderilecek_veri_tık = "2-tıklandı";
            Form3 frm = new Form3();
            frm.Show();
            Form2 frm2 = new Form2();
            frm2.Close();
        }
    }
}
