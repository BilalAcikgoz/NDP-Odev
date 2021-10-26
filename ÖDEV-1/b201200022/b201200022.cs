/******************************************************************** 
**                                  SAKARYA ÜNİVERSİTESİ             
**                         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                           BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
**                              NESNEYE DAYALI PROGRAMLAMA DERSİ  
**                                   2020-2021 BAHAR DÖNEMİ
**                           
**                         ÖDEV NUMARASI    : 1 
**                         ÖĞRENCİ ADI      : BİLAL AÇIKGÖZ
**                         ÖĞRENCİ NUMARASI : b201200022
**                         GRUP NUMARASI    : 1. ÖĞRETİM A GRUBU 
*********************************************************************/                                                                    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_1
{
    class Program
    {
        static void Main(string[] args)
        {

            short secim;

            do
            {
            a1: Console.WriteLine("..:: İşlemler ::..");
                Console.Write("1. Matris İşlemleri\n2. String İşlemleri\n3. Çıkış\nSeçiminiz: ");
                secim = Convert.ToInt16(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.Clear();
                        MatrisIslemleri();
                        Console.Clear();
                        goto a1;
                        break;
                    case 2:
                        Console.Clear();
                        StringIslemleri();
                        Console.Clear();
                        goto a1;
                        break;
                    case 3:
                        Console.WriteLine("Çıkış yapmak\nDevam etmek için tıklayınız.");
                        goto a2;
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim\nDevam etmek için tıklayınız.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (!(secim > 0 && secim < 3));

        a2:
            Console.ReadLine();
        }

        static void MatrisIslemleri()
        {
            short satır, sutun;

            Console.WriteLine("..:: Matris İşlemleri ::..");
            Console.Write("Matrisin satır sayısını giriniz.(1-10 arasında):");
            satır = Convert.ToInt16(Console.ReadLine());
            sutun = satır;

            short kullaniciDeger;
            int[,] dizi = new int[satır, sutun];

            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("[" + (i + 1) + "," + (j + 1) + "] = ");
                    kullaniciDeger = Convert.ToInt16(Console.ReadLine());
                    dizi[i, j] = kullaniciDeger;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int secim;
            short satirtoplam = 0;
            int[] buyukDizi = new int[satır];

            Console.Write("1- Satır En Büyük\n2- Satır Toplam\nSeçiminiz: ");
            secim = Convert.ToInt32(Console.ReadLine());


            do
            {
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Sonuç: ");
                        for (int i = 0; i < satır; i++)
                        {
                            for (int j = 0; j < sutun; j++)
                            {
                                if (buyukDizi[i] < dizi[i, j])
                                {
                                    buyukDizi[i] = dizi[i, j];
                                }
                            }
                        }

                        for (int i = 0; i < buyukDizi.Length; i++)
                        {
                            Console.Write(buyukDizi[i] + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Devam etmek için tıklayınız.");
                        break;
                    case 2:
                        Console.WriteLine("Sonuç: ");
                        for (int i = 0; i < satır; i++)
                        {
                            for (int j = 0; j < sutun; j++)
                            {
                                satirtoplam += (short)dizi[i, j];
                            }
                            Console.Write(satirtoplam + " ");
                            satirtoplam = 0;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Devam etmek için tıklayınız.");
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim\nDevam etmek için tıklayınız.");
                        break;

                        Console.Clear();
                }


            } while (false);



            Console.ReadLine();
        }

        static void StringIslemleri()
        {
            string kullaniciGiriş;
            char harf;
            int secim;

            Console.WriteLine("..:: String İşlemleri ::..");

            Console.Write("İşlem Yapılacak Stringi giriniz: ");
            kullaniciGiriş = Console.ReadLine();
            Console.WriteLine();

            Console.Write("İstenen harf: ");
            harf = Console.ReadKey().KeyChar;
            Console.WriteLine();


            char[] karakterKatarı = kullaniciGiriş.ToCharArray();
            short sayac = 0;


            for (int i = 0; i < kullaniciGiriş.Length; i++)
            {
                if (karakterKatarı[i] == harf)
                {
                    sayac++;
                }
            }
            int harfSayac = 0;
            int[] harfSirasi = new int[2];

            if (sayac == 2)
            {
                Console.WriteLine("1- Ara Metni Tersten Yaz\n2- Ara Metni Tekrarlı Yaz\nSeçiminiz: ");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Array.Reverse(karakterKatarı);
                        Console.WriteLine(karakterKatarı);
                        Console.WriteLine("Devam etmek için tıklayınız.");
                        Console.ReadKey();
                        break;
                    case 2:
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(kullaniciGiriş);
                        }
                        Console.WriteLine("Devam etmek için tıklayınız.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız.\nDevam etmek için tıklayınız.");
                        Console.ReadKey();
                        break;
                }

            }
            else
            {

                Console.WriteLine("Cümle içerisinde aranan harf bulunamamıştır.\nDevam etmek için tıklayınız.");
                Console.ReadKey();
            }


        }

    }
}

