using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Tiklandiginda(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz " + textBox1.Text +" Efendim ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;

            txtYeniIsim.Text = "100";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //Herhangi bir nesnenin Text özelliği (property si) içine string ifade aldığı için
        //Türkçe karakter gibi özel karakterleri alabilir. Yani istenilen ifade yazılabilir.

        //Herhangi bir nesnenin Name özelliği (property si) kodlama alanında kullanılan
        //bir ifade olduğu için string olmasına rağmen türkçe karakter ve boşluk gibi özel
        //karakterlerin kullanılmaması gerekir.
    }
}
