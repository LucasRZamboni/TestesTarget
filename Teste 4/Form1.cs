namespace Teste_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float perceSP, perceRJ, perceMG, perceES, perceOutros, perceTotal;
        float sp = 67836.43f, rj = 36678.66f, mg = 29229.88f, es = 27165.48f, outros = 19849.53f, total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            

            total = sp + rj + mg + es + outros;

            

            perceSP  = (sp / total);
            perceRJ = (rj / total);
            perceMG = (mg / total);
            perceES = (es / total);
            perceOutros = (outros / total);
            perceTotal = perceSP + perceRJ + perceMG + perceES + perceOutros;

            textBox6.Text = total.ToString("C2");
            percSP.Text = perceSP.ToString("P2");
            percRJ.Text = perceRJ.ToString("P2");
            percMG.Text = perceMG.ToString("P2");
            percES.Text = perceES.ToString("P2");
            percOutros.Text = perceOutros.ToString("P2");
            percTotal.Text = perceTotal.ToString("P2");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = sp.ToString("C");
            textBox2.Text = rj.ToString("C");
            textBox3.Text = mg.ToString("C");
            textBox4.Text = es.ToString("C");
            textBox5.Text = outros.ToString("C");
        }
    }
}