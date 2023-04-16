using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_01_PUNTO_8
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

        private void button2_Click(object sender, EventArgs e)
        {
            string a = tA.Text;
            string b = tB.Text;
            double A = Convert.ToDouble(a);
            double B = Convert.ToDouble(b);

            double temp = A;

            A = B;
            B = temp;

            MessageBox.Show($"A= {A}\nB= {B}");
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
