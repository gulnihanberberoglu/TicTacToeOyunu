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
    public partial class Form1 : Form
    {
        private oyunTahtasi oyunTahtasi;

        private oyuncu oyuncu1;
        private oyuncu oyuncu2;
        private oyuncu aktifOyuncu;
        private bool turn;
        private int turn_count;

        public Form1()
        {
            InitializeComponent();
        }
        //Form1'in yüklendiği metot
        private void Form1_Load(object sender, EventArgs e)
        {
            //form3 ten seçilen boyut boyut değişkenine verildi
            int boyut = (Convert.ToInt32(Form3.gonderilecek_veri));
            label1.Text = Form3.oyuncu1;
            label3.Text = Form3.oyuncu2;
            //Oyun tahtası boyut bilgisine göre oluşturuldu ve button tıklandı bilgisi tutuluyor
            oyunTahtasi = new oyunTahtasi(boyut, ButtonTiklandi);
            this.Controls.Add(oyunTahtasi.oyunTahtasiniAl());
            if(Form2.gonderilecek_veri_tık == "1-tıklandı")
            {
                oyuncu1 = new oyuncu(oyunTahtasi);
                oyuncu2 = new bilgisayar(oyunTahtasi);
                aktifOyuncu = oyuncu1;
            }
            else if(Form2.gonderilecek_veri_tık == "2-tıklandı")
            {
                oyuncu1 = new oyuncu(oyunTahtasi,'X');
                oyuncu2 = new oyuncu(oyunTahtasi,'O');
                aktifOyuncu = oyuncu1;
                aktifOyuncu = oyuncu2;
               
            }
        }

        private void ButtonTiklandi(nokta nokta)
        {
            //oyuncunun hamlesini oyun tahtasına gönderiyor
            oyunTahtasi.hamleyiYaz(aktifOyuncu.oyuncununHamlesiniAl(nokta.x, nokta.y));
            if (oyunTahtasi.kazanan('X'))
            {

                label5.Text = Form3.oyuncu1;
                MessageBox.Show(Form3.oyuncu1 + " oyuncu kazandı");
                this.Close();
            }
            else if (oyunTahtasi.kazanan('O'))
            {

                label5.Text = Form3.oyuncu2;
                MessageBox.Show(Form3.oyuncu2 + " oyuncu kazandı");
                this.Close();
            }
            else if (oyunTahtasi.beraberlikKontrol())
            {

                label5.Text = "Oyun berabere bitti";
                MessageBox.Show("Oyun berabere bitti");
                this.Close();
            }
            else
            {
                //aktif oyuncu oyuncu1 ise oyuncu2 yapıyor
                //aktif oyuncu oyuncu2 ise oyuncu1 yapıyor
                aktifOyuncu = aktifOyuncu == oyuncu1 ? oyuncu2 : oyuncu1;
                //aktif oyuncu bilgisayarsa bilgisayara hamle yaptırıyor
                if (aktifOyuncu is bilgisayar)
                {
                    ButtonTiklandi(nokta);
                }
            }
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }

            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void puanlarıSıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sevgi Alkan,Gülnihan Berberoğlu", "TicTacToe Hakkında");
        }
        
    }
}
