using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {


        static int Mod = 1000000007;
        public Form1()
        {
            InitializeComponent();
        }
        static long Volleyball(int a, int b)
        {
            if (a > b) return Volleyball(b, a);
            if (b < 25) return 0;
            if (b > 25 && b != a + 2) return 0;
            if (b == 25 && b - a < 2) return 0;

            int max = 25;
            long[,] pascal = new long[max, max];

            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    if (i == 0 || j == 0)
                        pascal[i, j] = 1;
                    else
                        pascal[i, j] = (pascal[i - 1, j] + pascal[i, j - 1]) % Mod;
                }
            }

            if (b == 25)
                return pascal[24, a];

            return pascal[24, 24] % Mod * PowerMod(2, (a - 24), Mod) % Mod;
        }

        static long PowerMod(long a, long power, long n)
        {
            long mod = 1;

            while (power != 0)
            {
                if ((power & 1) == 1)
                    mod = mod * a % n;

                a = (a * a) % n;
                power >>= 1;
            }

            return mod;
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);
            TxtHasil.Text = (Volleyball(a, b)).ToString();
        }
    }
}
