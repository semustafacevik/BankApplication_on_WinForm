﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProjesi
{
    public class Banka
    {
        public List<Musteri> Musteriler;
        public List<Hesap> Hesaplar;

        public Banka()
        {
            Musteriler = new List<Musteri>();
            Hesaplar = new List<Hesap>();
        }

        public void BankayaMusteriEkle(Musteri yenimusteri)
        {
            Musteriler.Add(yenimusteri);
        }

        public void BankayaHesapEkle(Hesap yeniHesap)
        {
            Hesaplar.Add(yeniHesap);
        }

        public Musteri MusteriBul(ulong musteriNumarasi)
        {
            Musteri arananMusteri;

            foreach (Musteri musteriler in Musteriler)
            {
                if (musteriler.musteriNosu == musteriNumarasi)
                {
                    arananMusteri = musteriler;
                    return arananMusteri;
                }
            }
            return null;
        }


        public Hesap HesapBul(ulong hesapNumarasi)
        {
            Hesap arananHesap = null;

            foreach (Hesap hesaplar in Hesaplar)
            {
                if (hesaplar.hesapNumarasi == hesapNumarasi) 
                {
                    arananHesap = hesaplar;
                    return arananHesap;
                }
            }
            return null;
        }
    }
}
