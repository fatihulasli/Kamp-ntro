﻿using System;

namespace Metototlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi+"\n"+ urun.Fiyati+ "\n" + urun.Aciklama+ "\n" + "-------------");
            }

            Console.WriteLine("------------Metotlar-------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);


        }
    }
}
