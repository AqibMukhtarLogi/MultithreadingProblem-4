using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreding___Task_4
{
    public partial class Form1 : Form
    {
        delegate int AsyncCallToGenerateRandomNumber();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = textBox1.BeginInvoke(new AsyncCallToGenerateRandomNumber(GenerateRandomNumber));
            textBox1.Text = textBox1.EndInvoke(result).ToString();
        }

        int GenerateRandomNumber()
        {
            var rand = new Random();
            return rand.Next(1, 6);
        }
    }
}
