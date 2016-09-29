using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        private String dateNow;
        private String date;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateNow = DateTime.Now.Date.ToString("yyyy");
            date = dateTimePicker1.Value.ToString("yyyy");

            int old = int.Parse(dateNow) - int.Parse(date);
            label3.Text = "Umur Anda : " + old.ToString();
            int min = vScrollBarMin.Value;
            int max = vScrollBarMax.Value;
            if (old >= min && old <= max)
            {
                label4.Text = "cukup umur";
            }
            else
            {
                if (old >= max)
                {
                    label4.Text = "Umur terlalu tua";
                }
                else if (old <= min)
                {
                    label4.Text = "Tidak cukup umur";
                }
            }
        }

        private void vScrollBarMin_Scroll(object sender, ScrollEventArgs e)
        {
            min.Text = "Min :" + vScrollBarMin.Value.ToString();
        }

        private void vScrollBarMax_Scroll(object sender, ScrollEventArgs e)
        {
            max.Text = "Max :" + vScrollBarMax.Value.ToString();
        }
    }
}
