using System.Drawing.Text;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Solver sM = new Solver();
        public Form1()
        {
            InitializeComponent();
            top.Text = string.Empty;
            bottom.Text = string.Empty;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sM.Clear();
            top.Text = "";
            bottom.Text = "";
        }

        private void AC_Click(object sender, EventArgs e)
        {
            sM.Clear();
            top.Text = "";
        }

        private void one_Click(object sender, EventArgs e)
        {
            sM.Accumulate("1");
            top.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            sM.Accumulate("2");
            top.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            sM.Accumulate("3");
            top.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            sM.Accumulate("4");
            top.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            sM.Accumulate("5");
            top.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            sM.Accumulate("6");
            top.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            sM.Accumulate("7");
            top.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            sM.Accumulate("8");
            top.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            sM.Accumulate("9");
            top.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            sM.Accumulate("0");
            top.Text += "0";
        }

        private void period_Click(object sender, EventArgs e)
        {
            sM.Accumulate(".");
            top.Text += ".";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double r = 0;
            r = sM.Solve();
            bottom.Text = r.ToString();
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            //how to differenciate 
            sM.Accumulate("(-");
            top.Text += "-";
        }

        private void add_Click(object sender, EventArgs e)
        {
            sM.Accumulate("+");
            top.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            sM.Accumulate("-");
            top.Text += "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            sM.Accumulate("*");
            top.Text += "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            sM.Accumulate("/");
            top.Text += "/";
        }

        private void mod_Click(object sender, EventArgs e)
        {
            sM.Accumulate("%");
            top.Text += "%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}