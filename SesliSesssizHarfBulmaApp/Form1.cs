using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SesliSesssizHarfBulmaApp
{
    public partial class Form1 : Form
    {
        string kelime = "";
        string[] sesli = new string[8]
        {
                "a", "e", "ı", "i", "o", "ö", "u", "ü"
        };
        string[] sessiz = new string[20]
        {
                "z", "y", "v", "t", "ş", "s", "r", "p", "n",  "m", "l", "k", "h", "j", "ğ", "g", "d", "ç", "c", "b"
        };
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            kelime = textBox1.Text.ToLower();

            if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    foreach (var harf in sesli)
                    {
                        if (kelime.Contains(harf))
                        {
                            Sonuc.Items.Add(harf);
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    foreach (var harf in sessiz)
                    {
                        if (kelime.Contains(harf))
                        {
                            Sonuc.Items.Add(harf);
                        }
                    }
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                comboBox1.Items.Add("-Seçenek-");
                comboBox1.Items.Add("Sesliharfler");
                comboBox1.Items.Add("SessizHarler");
                comboBox1.SelectedIndex = 0;
        }

    }
}
