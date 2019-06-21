﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler = new string[] { "ali", "veli", "ahmet", "mehmet", "ayse", "fatma" };
        string[] soyisimler = new string[] { "celik", "demirel", "durmaz", "ates", "cevik", "ay" };
        Random salla = new Random();
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, vendeks;

            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows.Add();

                kilo = salla.Next(45, 135);
                boy = salla.Next(150, 215);

                boy = boy / 100;
                vendeks = kilo / (boy * boy);

                dataGridView1.Rows[sayac].Cells[0].Value = isimler[salla.Next(0, isimler.Length)];
                dataGridView1.Rows[sayac].Cells[1].Value = soyisimler[salla.Next(0, soyisimler.Length)];
                dataGridView1.Rows[sayac].Cells[2].Value = salla.Next(1, 100);
                dataGridView1.Rows[sayac].Cells[3].Value = kilo;
                dataGridView1.Rows[sayac].Cells[4].Value = boy;

                if (vendeks <= 18.5)
                {
                    dataGridView1.Rows[sayac].Cells[5].Value = "Zayıf";
                }
                else if (vendeks > 18.5 && vendeks <= 24.9)
                {
                    dataGridView1.Rows[sayac].Cells[5].Value = "Normal";
                }
                else if (vendeks > 24.9 && vendeks <= 29.9)
                {
                    dataGridView1.Rows[sayac].Cells[5].Value = "Fazla kilolu";
                }
                else
                {
                    dataGridView1.Rows[sayac].Cells[5].Value = "Obez";
                }
                sayac++;
            }
        }
    }
}
