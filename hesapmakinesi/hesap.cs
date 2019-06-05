using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapmakinesi
{
    class hesap
    {
        public hesap()
        {

        }
        public double bol(double sayi1, double sayi2)
        {
            double sonuc;
            sonuc = sayi1 / sayi2;
            return sonuc;
        }
        public double carp(double sayi1, double sayi2)
        {
            double sonuc;
            sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public double cikar(double sayi1, double sayi2)
        {
            double sonuc;
            sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public double topla(double sayi1, double sayi2)
        {
            double sonuc;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public double ussu(double sayi1, double sayi2)
        {
            double sonuc = 1;
            for (int i = 0; i < sayi2; i++) 
            sonuc = sonuc * sayi1;
            return sonuc;
        }
        public double yuzde(double sayi1, double sayi2)
        {
            double sonuc;
            sonuc = (sayi1 * sayi2) / 100;
            return sonuc;
        }
        public double obeb(double sayi1, double sayi2)
        {
            double kucuk, sonuc = 1;
            if (sayi1 < sayi2)
                kucuk = sayi1;
            else
                kucuk = sayi2;
            for (double i = kucuk; i > 0; i--)
                if (sayi1 % i == 0 && sayi2 % i == 0) 
                {
                    sonuc = i;
                    break;
                }
            return sonuc;
        }
        public double okek(double sayi1, double sayi2)
        {
            double buyuk, sonuc = 1;
            if (sayi1 > sayi2)
                buyuk = sayi1;
            else
                buyuk = sayi2;
            for (double i = buyuk; i <= sayi1*sayi2; i++)
                if (i % sayi1 == 0 && i % sayi2 == 0)
                {
                    sonuc = i;
                    break;
                }
            return sonuc;
        }
    }
}
