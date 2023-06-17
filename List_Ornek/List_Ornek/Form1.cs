﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();

            karakterler.Add("Mazhar");
            karakterler.Add("Ruhsar");
            karakterler.Add("Menkıbe");
            karakterler.Add("Müfit");
            karakterler.Add("Reyhan");
            karakterler.Add("Firdevs");
            foreach(string k in karakterler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(45);
            sayilar.Add(75);
            sayilar.Add(25);
            sayilar.Add(33);
            sayilar.Add(22);
            sayilar.Add(15);
            sayilar.Add(14);
            foreach(int s in sayilar)
            {
                if(s % 5 == 0)
                {
                    listBox2.Items.Add(s);
                }
            }
            if (sayilar.Contains(74))
            {
                MessageBox.Show("Bu Sayı var");
            }
            else
            {
                MessageBox.Show("Bu sayı yok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();
            kisi.Add (new Kisiler()
            {
                ADI = "Önder",
                SOYADI = "AYDIN",
                MESLEK = "Öğretmen"
            });
            foreach (Kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI + " " + k.SOYADI + " " + k.MESLEK);
            }
        }
    }
}
