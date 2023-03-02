using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase;

            frase = richTextBox1.Text;

            char[] charArray = frase.ToCharArray();
            
            string fraseInvertida = String.Empty;

            for (int i = charArray.Length - 1; i >= 0; i--)
            {

                fraseInvertida += charArray[i];
            }
            richTextBox2.Text = fraseInvertida.ToString();
        }
    }
}
