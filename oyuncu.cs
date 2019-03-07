using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeOyunu
{
    public class oyuncu
    {
        //readonly sadece cons da ataması yapılabilir
        protected readonly char kr;

        protected readonly oyunTahtasi oyunTahtasi;

        //X değerine göre oyuncu oluşturan cons
        public oyuncu(oyunTahtasi oyunTahtasi)
        {
            this.kr = 'X';
            this.oyunTahtasi = oyunTahtasi;
        }
        //
        public oyuncu(oyunTahtasi oyunTahtasi, char kr)
        {
            this.kr = kr;
            this.oyunTahtasi = oyunTahtasi;
        }

        public char karakteriAl()
        {
            return this.kr;
        }

        public bool oyuncuTurunuAl()
        {
            return false;
        }

        public virtual hamle oyuncununHamlesiniAl(int x, int y)
        {
            return new hamle(x, y, this.kr);
        }
    }

    public class bilgisayar : oyuncu
    {
        public bilgisayar(oyunTahtasi oyunTahtasi)
            : base(oyunTahtasi, 'O')
        {
        }

        public override hamle oyuncununHamlesiniAl(int x, int y)
        {
            var oynTahtasi = this.oyunTahtasi.oyunTahtasiniAl();
            Button btn;
            int satir;
            int kolon;
            var rnd = new Random();
            do
            {
                satir = rnd.Next(oynTahtasi.RowCount);
                kolon = rnd.Next(oynTahtasi.ColumnCount);
                btn = (Button)oynTahtasi.GetControlFromPosition(kolon, satir);
            } while (!btn.Enabled);

            return new hamle(satir, kolon, kr);
        }
    }
}
