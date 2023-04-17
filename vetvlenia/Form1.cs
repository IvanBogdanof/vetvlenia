using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vetvlenia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Работу выполнил ст. Савченков Н.А." + Environment.NewLine;

            double x = x0;
            while (x <= (xk + dx))
            {
                double y = 0.00084*(1/Math.Log(Math.Pow(Math.Abs(x),5/4))+b)/(Math.Pow(x,2)+3.82);

                textBox5.Text += "+=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
            }
        }
    }
}
