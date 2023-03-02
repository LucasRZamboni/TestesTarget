using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] vet = { 22174.1664, 24537.6698, 26139.6134, 26742.6612, 42889.2258, 46251.174, 11191.4722, 3847.4823, 373.7838, 2659.7563, 48924.2448, 18419.2614, 35240.1826, 43829.1667, 18235.6852, 4355.0662, 13327.1025, 25681.8318, 1718.1221, 13220.495, 8414.61 };

            double menor=0, maior, soma=0, media=0;
            int i,qtd=0;

            for(i = 0; i < vet.Length; i++)
            {
                soma = soma + vet[i];
            }
            media = soma / vet.Length;

            maior = vet[0];
            menor = vet[0];
            for (i = 1; i < vet.Length; i++)
            {
                if (vet[i] > maior) 
                {
                   maior = vet[i];
                    qtd = i++;

                }
                if (vet[i] < menor)
                {
                    menor = vet[i];
                    
                }
            }

            tbxMedia.Text = media.ToString("C2");
            tbxMaior.Text = maior.ToString("C2");
            tbxMenor.Text = menor.ToString("C2");
            tbxQuantidade.Text = qtd.ToString();
        }

    }
}
