using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Media;
using System.Threading;

namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer sound = new SoundPlayer();
            string yol;
            yol = @"C:\Users\user\Desktop\ÖdevEnum\1.wav";
            sound.SoundLocation = yol;
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen kategori girin (BilimKurgu, DünyaKlasikleri, Psikoloji):\nÇıkış yapmak için q basınız.");
                    string secim = Console.ReadLine().ToLower();
                    secim = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(secim);
                    if (Enum.TryParse(secim, out KitapKategori kategori))
                    {
                        switch (kategori)
                        {
                            case KitapKategori.Bilimkurgu:
                                Console.Clear();
                                Console.WriteLine("Bilim Kurgu kategorisindeki kitaplar A reyonundadır.");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            case KitapKategori.Dünyaklasikleri:
                                Console.Clear();
                                Console.WriteLine("Dünya Klasikleri kategorisindeki kitaplar B reyonundadır.");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            case KitapKategori.Psikoloji:
                                Console.Clear();
                                Console.WriteLine("Psikoloji kategorisindeki kitaplar C reyonundadır.");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Listede böyle bir kategori yok");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                        }
                    }
                    else if (secim == "q" || secim == "Q")
                    {
                        Console.Clear();
                        Console.WriteLine("Programdan çıkış yapılıyor iyi günler.\nEğlenceye hazırlan!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        sound.Play();
                        for (; ; )
                        {
                            for (var i = 0; i < 15; i++)
                            {
                                string backColor = i.ToString();
                                string foreColor = i.ToString();
                                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backColor);
                                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreColor);
                                Console.Clear();
                                Thread.Sleep(1);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Listede böyle bir kategori yok");
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("HATA!" + ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("HATA!" + ex);
                }
            }

        }
    }
    enum KitapKategori : int
    {
        Bilimkurgu = 0,
        Dünyaklasikleri = 1,
        Psikoloji = 2
    }
}
