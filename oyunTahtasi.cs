using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeOyunu
{
    public class oyunTahtasi
    {
        private readonly TableLayoutPanel oynTahtasi;

        private readonly Action<nokta> buttonTiklandi;

        public oyunTahtasi(int boyut, Action<nokta> buttonTiklandi)
        {
            this.buttonTiklandi = buttonTiklandi;
            this.oynTahtasi = new TableLayoutPanel
            {
                Dock = DockStyle.Right,
                AutoSize = true,
                RowCount = boyut,
                ColumnCount = boyut
            };
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    var button = new Button()
                    {
                        Text = "",
                        Height = 50,
                        Width = 50
                    };

                    button.Click += Button_Click;
                    this.oynTahtasi.Controls.Add(button, i, j);

                }
            }
        }

        private object AutoScrollOffset(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var tableLayoutPanel = (TableLayoutPanel)button.Parent;
            if (button.Enabled)
            {
                int x = tableLayoutPanel.GetRow(button);
                int y = tableLayoutPanel.GetColumn(button);
                buttonTiklandi(new nokta(x, y));

                button.Enabled = false;
            }
        }

        public TableLayoutPanel oyunTahtasiniAl()
        {
            return this.oynTahtasi;
        }

        public bool hamleyiYaz(hamle hamle)
        {
            var button = (Button)this.oynTahtasi.GetControlFromPosition(hamle.nokta.y, hamle.nokta.x);
            if (button.Enabled)
            {
                button.Text = hamle.kr.ToString();
                button.Enabled = false;

                return true;
            }

            return false;
        }

        public bool kazanan(char oyuncu)
        {
            return kazananYatay(oyuncu) || kazananDikey(oyuncu) || kazananCapraz(oyuncu);
        }

        private bool kazananYatay(char oyuncu)
        {
            for (int i = 0; i < this.oynTahtasi.RowCount; i++)
            {
                for (int j = 0; j < this.oynTahtasi.ColumnCount; j++)
                {
                    Button button1;
                    Button button2;
                    Button button3;
                    if (TryGetButton(i, j, out button1) && TryGetButton(i + 1, j, out button2) && TryGetButton(i + 2, j, out button3))
                    {
                        if (!button1.Enabled && !button2.Enabled && !button3.Enabled)
                        {
                            return
                                button1.Text == oyuncu.ToString() &&
                                button2.Text == oyuncu.ToString() &&
                                button3.Text == oyuncu.ToString();
                        }
                    }
                }
            }

            return false;
        }

        private bool kazananDikey(char oyuncu)
        {
            for (int i = 0; i < this.oynTahtasi.RowCount; i++)
            {
                for (int j = 0; j < this.oynTahtasi.ColumnCount; j++)
                {
                    Button button1;
                    Button button2;
                    Button button3;
                    if (TryGetButton(i, j, out button1) && TryGetButton(i, j + 1, out button2) && TryGetButton(i, j + 2, out button3))
                    {
                        if (!button1.Enabled && !button2.Enabled && !button3.Enabled)
                        {
                            return
                                button1.Text == oyuncu.ToString() &&
                                button2.Text == oyuncu.ToString() &&
                                button3.Text == oyuncu.ToString();
                        }
                    }
                }
            }

            return false;
        }

        private bool kazananCapraz(char oyuncu)
        {
            for (int i = 0; i < this.oynTahtasi.RowCount; i++)
            {
                for (int j = 0; j < this.oynTahtasi.ColumnCount; j++)
                {
                    Button button1;
                    Button button2;
                    Button button3;
                    if (TryGetButton(i, j, out button1) && TryGetButton(i + 1, j + 1, out button2) && TryGetButton(i + 2, j + 2, out button3))
                    {
                        if (!button1.Enabled && !button2.Enabled && !button3.Enabled)
                        {
                            return
                                button1.Text == oyuncu.ToString() &&
                                button2.Text == oyuncu.ToString() &&
                                button3.Text == oyuncu.ToString();
                        }
                    }
                }
            }

            return false;
        }

        public bool beraberlikKontrol()
        {
            var hamlelerBittiMi = this.oynTahtasi.Controls.OfType<Button>().All(btn => !btn.Enabled);
            var xKazandiMi = this.kazanan('X');
            var oKazandiMi = this.kazanan('O');

            return hamlelerBittiMi && !xKazandiMi && !oKazandiMi;
        }

        private bool TryGetButton(int satir, int sutun, out Button button)
        {
            button = null;
            var control = oynTahtasi.GetControlFromPosition(sutun, satir);
            if (control != null)
            {
                button = (Button)control;
                return true;
            }

            return false;
        }
    }
}
