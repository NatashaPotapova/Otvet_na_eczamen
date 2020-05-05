using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otvet_na_eczamen
{
    public partial class Podcchet : Form
    {
        public Podcchet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x, y;

            {

                if (znaX.Text.Equals("")

                || znaY.Text.Equals(""))

                {
                    proverka.Text = "Не все поля заполнены";
                }
                else
                {
                    x = Convert.ToInt32(znaX.Text);
                    y = Convert.ToInt32(znaY.Text);
                    if (x > 1 || y > 1 || x < -1 || y < -1)
                    {
                        otvet.Text = "Да!";
                    }
                    else if (Math.Pow(x, 2) < Math.Abs(y) && Math.Pow(y, 2) < Math.Abs(x))
                    {
                        otvet.Text = "Да!";
                    }
                    else otvet.Text = "На границе!";
                }
            }
        }
    }
}
    

