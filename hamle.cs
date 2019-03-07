using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeOyunu
{
    public class nokta
    {
        public int x { get; private set; }

        public int y { get; private set; }

        public nokta(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class hamle
    {
        public nokta nokta { get; private set; }

        public char kr { get; private set; }

        public hamle(int x, int y, char kr)
        {
            this.nokta = new nokta(x, y);
            this.kr = kr;
        }
    }
}
