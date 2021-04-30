using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tıklama___yakalama__Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int artipuan = 0, eksipuan = 0;

        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;

            for (int i = 0; i <= 62; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.DarkCyan;
                btn.ForeColor = Color.Black;
                btn.Width = 55;
                btn.Height = 55;
                btn.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(btn);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int rastgele = rnd.Next(1, 62);
            foreach (var buttonlarim in flowLayoutPanel1.Controls)
            {
                Button Btn = buttonlarim as Button;
                if (Btn.Text == rastgele.ToString())
                {
                    Btn.BackColor = Color.Red;
                    Btn.Click += new EventHandler(Btn_Click);
                }
                else
                {
                    Btn.BackColor = Color.DarkCyan;
                }

            }




        }
        void Btn_Click(object sender, EventArgs e)
        {
            Button BTN = sender as Button;

            if (BTN.BackColor == Color.Red)
            {
                artipuan++;
            }
            else
            {
                eksipuan++;
            }
            label2artipuan.Text = artipuan.ToString();
            label2eksipuan.Text = eksipuan.ToString();
        }

        private void button1Sifirla_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.Enabled = true;
            button1istegeBagli.Enabled = true;
            timer1.Enabled = true;
            //timer2.Enabled = true;
            artipuan = 0;
            eksipuan = 0;
            label2artipuan.Text = artipuan.ToString();
            label2eksipuan.Text = eksipuan.ToString();
        }

        private void button1istegeBagli_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            if (artipuan >= sayi)
            {

                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler " + textBox1.Text + " Tıklama ile oyunu Kazandınız..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }
            if (eksipuan >= sayi)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("Üzgünüm Oyunu Kaybettiniz..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            button1istegeBagli.Enabled = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }
    }
}
