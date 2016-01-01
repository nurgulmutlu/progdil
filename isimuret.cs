using System;
using System.Collections.Generic;

namespace Prog_Dil
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new List<string>();
            string secim, tamlama;
            int adet, sayac = 0, sonuc;

            Console.Write("Bir dil seciniz:(turkce/ingilizce): ");
            secim = Console.ReadLine();

            Console.Write("Lutfen Adet Giriniz: ");
            adet = Int32.Parse(Console.ReadLine());
            
            while (sayac < adet)
            {
                if (secim == "turkce")
                {
                    tamlama = turkce_uret();
                    sonuc = kontrolet(tamlama, liste);

                    if (sonuc == 0)
                    {
                        liste.Add(tamlama);
                        sayac = sayac + 1;
                    }
                }
                else if (secim == "ingilizce")
                {
                    tamlama = ingilizce_uret();
                    sonuc = kontrolet(tamlama, liste);

                    if (sonuc == 0)
                    {
                        liste.Add(tamlama);
                        sayac = sayac + 1;
                    }
                }
                else
                {
                    Console.Write("Hatalı dil seçimi!");
                    break;
                }
            }
            int i = 0;
            while (i < liste.Count)
            {
                Console.WriteLine(liste[i]);
                i = i + 1;
            }
            Console.ReadLine(); //prog beklesin diye

        }

        static string turkce_uret()
        {
            Random rnd = new Random();
            Random rndm = new Random();
            List<string> isim = new List<string>();
            isim.Add("ev");
            isim.Add("otomobil");
            isim.Add("dünya");
            isim.Add("balık");
            isim.Add("insan");
            isim.Add("bardak");
            isim.Add("havlu");
            isim.Add("fincan");
            isim.Add("tencere");
            isim.Add("mısır");
            isim.Add("hakem");
            isim.Add("vazo");
            isim.Add("evren");
            isim.Add("ay");
            isim.Add("yıldız");

            List<string> sıfat = new List<string>();
            sıfat.Add("güzel");
            sıfat.Add("soğuk");
            sıfat.Add("iyi");
            sıfat.Add("akıllı");
            sıfat.Add("kötü");
            sıfat.Add("tatlı");
            sıfat.Add("eski");
            sıfat.Add("yavaş");
            sıfat.Add("komik");
            sıfat.Add("büyük");
            sıfat.Add("neşeli");
            sıfat.Add("sabırlı");
            sıfat.Add("yeni");
            sıfat.Add("pahalı");
            sıfat.Add("kırmızı");
            sıfat.Add("taze");
            sıfat.Add("kolay");

            int isim_adet, sıfat_adet;
            string tamlama, isim2, sıfat2;
            isim_adet = rnd.Next(isim.Count);    //ismin uzunlugu 10 ise 0 ile 10 arasında sayı uret
            sıfat_adet = rndm.Next(sıfat.Count); 

            isim2 = isim[isim_adet];
            sıfat2 = sıfat[sıfat_adet];

            tamlama = sıfat2 + " " + isim2;
            return tamlama;
        }

        static string ingilizce_uret()
        {
            Random rnd = new Random();
            Random rndm = new Random();
            List<string> isim = new List<string>();
            isim.Add("home");
            isim.Add("car");
            isim.Add("Earth");
            isim.Add("fish");
            isim.Add("human");
            isim.Add("glass");
            isim.Add("towel");
            isim.Add("cup");
            isim.Add("pot");
            isim.Add("corn");
            isim.Add("referee");
            isim.Add("vase");
            isim.Add("universe");
            isim.Add("month");
            isim.Add("star");

            List<string> sıfat = new List<string>();
            sıfat.Add("beautiful");
            sıfat.Add("cold");
            sıfat.Add("good");
            sıfat.Add("smart");
            sıfat.Add("bad");
            sıfat.Add("dessert");
            sıfat.Add("old");
            sıfat.Add("slow");
            sıfat.Add("funny");
            sıfat.Add("big");
            sıfat.Add("cheerful");
            sıfat.Add("patient");
            sıfat.Add("new");
            sıfat.Add("expensive");
            sıfat.Add("red");
            sıfat.Add("fresh");
            sıfat.Add("easy");

            int isim_adet = 0, sıfat_adet = 0;
            string tamlama, isim2, sıfat2;
            isim_adet = rnd.Next(isim.Count);
            sıfat_adet = rndm.Next(sıfat.Count);

            isim2 = isim[isim_adet].ToString();
            sıfat2 = sıfat[sıfat_adet].ToString();

            tamlama = sıfat2 + " " + isim2;
            return tamlama;
        }

        static int kontrolet(string gelen_tamlama, List<string> liste)
        {
            int sayac = 0, bulundu = 0;
            int listeUzunluk = liste.Count;
            string sifat_tamlamasi;
            while (sayac < listeUzunluk)
            {
                sifat_tamlamasi = liste[sayac];
                sayac = sayac + 1;

                if (gelen_tamlama == sifat_tamlamasi)
                {
                    bulundu = 1;
                    break;
                }
            }
            return bulundu;
        }

    }
}
