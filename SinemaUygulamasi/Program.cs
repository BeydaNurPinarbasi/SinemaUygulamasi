﻿using System;

namespace SinemaUygulamasi
{
    internal class Program
    {
        static Sinema Snm;

        static void Main(string[] args)
        {
            Uygulama();

           


        }

        static void Test()
        {

            while (true)
            {
                Console.Write("Sayı girin: ");
                string giris = Console.ReadLine();

                int sayi;

                bool sonuc = int.TryParse(giris, out sayi);

                if (sonuc == true)
                {
                    Console.WriteLine("Sayının 2 katı : " + (sayi * 2));
                }
                else
                {
                    Console.WriteLine("hatalı giriş yapıldı");
                }

                
            }



        }
        static int SayiAl(string mesaj)
        {
            int sayi;

            while (true)
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out sayi))
                {
                    return sayi;
                }
                Console.WriteLine("Hatalı giriş yapıldı.");

            }

        }
        static void Uygulama()
        {
            Kurulum();
            Menu();

            while (true)
            {
                string secim = SecimAl();

                switch (secim)
                {
                    case "1":
                    case "S":
                        BiletSat();
                        break;
                    case "2":
                    case "R":
                        BiletIade();
                        break;
                    case "3":
                    case "D":
                        DurumBilgisi();
                        break;
                    case "4":
                    case "X":
                        Environment.Exit(0);
                        break;


                }

                Console.WriteLine();
            }



        }
        static void BiletSat()
        {
            Console.WriteLine("Bilet Sat: ");
            
            int tam = SayiAl("Tam Bilet Adedi: ");

            
            int yarim = SayiAl("Yarım Bilet Adedi: ");

            Snm.BiletSatisi(tam, yarim);

        }
        static void BiletIade()
        {
            Console.WriteLine("Bilet İade: ");
          
            int tam = SayiAl("Tam Bilet Adedi: ");

           
            int yarim = SayiAl("Yarım Bilet Adedi: ");

            Snm.BiletIadesi(tam, yarim);


        }
        static void DurumBilgisi()
        {
            Console.WriteLine("Durum Bilgisi");
            Console.WriteLine("Film: " + Snm.FilmAdi);
            Console.WriteLine("Kapasite: " + Snm.Kapasite);
            Console.WriteLine("Tam Bilet Fiyatı : " + Snm.TamBiletFiyati);
            Console.WriteLine("Yarım Bilet Fiyatı : " + Snm.YarimBiletFiyati);
            Console.WriteLine("Toplam Tam Bilet Adeti : " + Snm.ToplamTamBiletAdeti);
            Console.WriteLine("Toplam Yarım Bilet Adeti : " + Snm.ToplamYarimBiletAdeti);
            Console.WriteLine("Ciro: " + Snm.Ciro);
            Console.WriteLine("Boş Koltuk Adedi: " + Snm.BosKoltukAdetiGetir());



        }
        static void Kurulum()
        {
            Console.WriteLine("-------Butik Sinema Salonu-------");
            Console.Write("Film adı: ");
            string film = Console.ReadLine();

           
            int kapasite = SayiAl("Kapasite: ");

           
            int tam = SayiAl("Tam Bilet Fiyatı: ");

            
            int yarim = SayiAl("Yarım Bilet Fiyatı: ");

            Snm = new Sinema(film, kapasite, tam, yarim);

            Console.WriteLine();

        }
        static void Menu()
        {
            Console.WriteLine("1 - Bilet Sat(S)        ");
            Console.WriteLine("2 - Bilet İade(R)       ");
            Console.WriteLine("3 - Durum Bilgisi(D)    ");
            Console.WriteLine("4 - Çıkış(X)            ");
            Console.WriteLine();
        }

        static string SecimAl()
        {
       

            string karakterler = "1234SRDX";
            int sayac = 0;


            while (true)
            {
                sayac++;
                Console.Write("Seçiminiz: ");
                string giris = Console.ReadLine().ToUpper();
                int index = karakterler.IndexOf(giris);

                Console.WriteLine();

                if (giris.Length == 1 && index >= 0)
                {
                    return giris;
                }
                else
                {
                    if (sayac == 10)
                    {
                        Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Hatalı giriş yapıldı.");

                }
                Console.WriteLine();

            }





        }

    }
}
