using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        hesap nesnem = new hesap();
        double sayi = 0;
        char islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(tbekran.Text); //ekrandaki sayıyı hafızaya aldık
            tbekran.Text = ""; // ekranı boşalttık
            tbekran.Focus(); //kursoru aktif ettik
            islem = '+'; //Tıklanan işlemi hafızaya aldık
        }

        private void btcikar_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(tbekran.Text); //ekrandaki sayıyı hafızaya aldık
            tbekran.Text = ""; // ekranı boşalttık
            tbekran.Focus(); //kursoru aktif ettik
            islem = '-'; //Tıklanan işlemi hafızaya aldık
        }

        private void btcarp_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(tbekran.Text); //ekrandaki sayıyı hafızaya aldık
            tbekran.Text = ""; // ekranı boşalttık
            tbekran.Focus(); //kursoru aktif ettik
            islem = '*'; //Tıklanan işlemi hafızaya aldık
        }

        private void btbol_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(tbekran.Text); //ekrandaki sayıyı hafızaya aldık
            tbekran.Text = ""; // ekranı boşalttık
            tbekran.Focus(); //kursoru aktif ettik
            islem = '/'; //Tıklanan işlemi hafızaya aldık
        }

        private void btc_Click(object sender, EventArgs e)
        {
            sayi = 0;
            tbekran.Text = ""; // ekranı boşalttık
            tbekran.Focus(); //kursoru aktif ettik
            islem = '?'; //Tıklanan işlemi hafızaya aldık
        }

        private void btesittir_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            try
            {
                sonuc = Convert.ToDouble(tbekran.Text);
            }
             catch
            {
                sonuc = 0;
            }
            switch(islem)
            {
                case '+':sonuc = nesnem.topla(sayi, sonuc); break;
                case '-': sonuc = nesnem.cikar(sayi, sonuc); break;
                case '*': sonuc = nesnem.carp(sayi, sonuc); break;
                case '/': sonuc = nesnem.bol(sayi, sonuc); break;
                case 'u': sonuc = nesnem.ussu(sayi, sonuc); break;
                case 'y': sonuc = nesnem.yuzde(sayi, sonuc); break;
                case 'b': sonuc = nesnem.obeb(sayi, sonuc); break;
                case 'k': sonuc = nesnem.okek(sayi, sonuc); break;
                default:MessageBox.Show("Geçersiz İşlem"); break;
            }
            tbekran.Text = sonuc.ToString();
        }

        private void btus_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(tbekran.Text);
            tbekran.Text = "";
            tbekran.Focus();
            islem = 'u';
        }

        private void btyuzde_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(tbekran.Text);
            tbekran.Text = "";
            tbekran.Focus();
            islem = 'y';
        }

        private void btobeb_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(tbekran.Text);
            tbekran.Text = "";
            tbekran.Focus();
            islem = 'b';
        }

        private void btokek_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(tbekran.Text);
            tbekran.Text = "";
            tbekran.Focus();
            islem = 'k';
        }
    }
}
