using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=0, b=1 , c=0, d;

            d = Convert.ToInt32(textBox1.Text);

            while(d > c)
            {
                c = a + b;
                a = b;
                b = c;
            }
            if (d == 0 || d == 1)
            {
                MessageBox.Show("O seu número FAZ parte da sequência de Fibonacci.");
            }
            else if (d == c)
            {
                MessageBox.Show("O seu número FAZ parte da sequência de Fibonacci.");
            }
            else
            {
                MessageBox.Show("O seu número NÃO faz parte da sequência de Fibonacci.");
            }
        }
    }
}
