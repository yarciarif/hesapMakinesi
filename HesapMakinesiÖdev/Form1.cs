using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiÖdev
{
    public partial class Form1 : Form
    {
        double x = 0;
        double y = 0;
        double z = 0;
        int islem = 0;
        int nokta = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void birButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void ikiButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }

        }

        private void ucButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }

        }

        private void dortButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }

        }

        private void besButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }

        }

        private void altiButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }

        }

        private void yediButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }

        }

        private void sekizButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }

        }

        private void dokuzButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }

        }

        private void sifirButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }

        }

        private void NOKTA_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                if (nokta < 1)
                {
                    textBox1.Text = "0,";
                    nokta = nokta + 1;
                }
            }
            else
            {
                if (nokta < 1)
                {
                    textBox1.Text = textBox1.Text + ",";
                    nokta = nokta + 1;
                }
            }

        }

        private void Topla_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            islem = 1;
            nokta = 0;
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            islem = 2;
            nokta = 0;

        }

        private void carp_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            islem = 3;
            nokta = 0;

        }

        private void bol_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            islem = 4;
            nokta = 0;

        }
        
        private void Hesapla_Click(object sender, EventArgs e)
        {
            y = double.Parse(textBox1.Text);
            switch(islem)
            {
                case 1:
                    z = x + y;
                    textBox1.Text = z.ToString();
                    break;
                    
                case 2:
                    z = x - y;
                    textBox1.Text = z.ToString();
                    break;
                case 3:
                    z = x * y;
                    textBox1.Text = z.ToString();
                    break;
                case 4:
                    z = x / y;
                    textBox1.Text = z.ToString();
                    break;
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            textBox1.Text = "0";
            islem = 0;
            nokta = 0;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            nokta = 0;
        }
    }
}
