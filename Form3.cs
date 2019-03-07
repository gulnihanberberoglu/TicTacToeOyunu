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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            if (Form2.gonderilecek_veri_tık == "1-tıklandı")
            {
                label7.Text = "Bilgisayar";
                textBox1.Text = "Bilgisayar";
            }
            
        }
        public static string gonderilecek_veri, oyuncu1, oyuncu2;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Form3 frm3 = new Form3();
            frm3.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gonderilecek_veri = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gonderilecek_veri = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gonderilecek_veri = radioButton3.Text;
        }
        
        private void oyuncu_1_TextChanged(object sender, EventArgs e)
        {
            oyuncu1 = oyuncu_1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            oyuncu2 = textBox1.Text;
        }
    }
}
