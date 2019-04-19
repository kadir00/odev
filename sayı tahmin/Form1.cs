using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int sayı = 1;
        Random a = new Random();
        int sayı1 = 100;
        int dgr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgr = a.Next(sayı, sayı1);
            label1.Text = dgr.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayı = dgr;
            dgr = a.Next(sayı, sayı1);
            label1.Text = dgr.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayı1 = dgr;
            dgr = a.Next(sayı, sayı1);
            label1.Text = dgr.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bildin");
        }
    }
}
