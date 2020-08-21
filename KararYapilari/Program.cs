using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hesap Makinesi
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem giriniz");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Diğer sayıyı giriniz");
            int y = Convert.ToInt32(Console.ReadLine());

            double sonuc = 0;

            if (c == '+')
            {
                sonuc = x + y;
            }
            else if(c == '*')
            {
                sonuc = x * y;
            }
            else if(c == '/')
            {
                sonuc = x / y;
            }
            else if(c == '-')
            {
                sonuc = x - y;
            }

            Console.WriteLine("Sonuç : " + sonuc);
            Console.ReadLine();




            //saatlik ücret 1 tl. 24 saatten fazla ise 20 tl
            //Console.WriteLine("Kaç saat kaldın kardeşşş?");
            //int saat = Convert.ToInt32(Console.ReadLine());

            //int ucret = 0;
            //if (saat < 24)
            //{
            //    ucret = saat * 1;

            //}
            //else
            //{
            //    int kalan = saat / 24;
            //    ucret = kalan * 20;
                
            //}
            //Console.WriteLine("Ücretiniz: " + ucret);
            //Console.ReadLine();




            //Console.WriteLine("Gün giriniz");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;
            //    default:
            //        Console.WriteLine("De fa ult");
            //        break;
            //}

            //Console.ReadLine();


            // Klavyeden girilen 3 sayıdan en büyüğünü bulan uygulama

            //Console.WriteLine("3 sayı giriniz!");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //if(sayi1 > sayi2 && sayi1 > sayi3)
            //{
            //    Console.WriteLine("Sayi 1 en büyük");
            //}
            //else if(sayi2 > sayi3 && sayi2 > sayi1)
            //{
            //    Console.WriteLine("Sayi 2 en büyük");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi 3 en büyük");
            //}

            //Console.ReadLine();

            //Console.WriteLine("Lütfen bir tarih giriniz");
            //DateTime dt = Convert.ToDateTime(Console.ReadLine());

            //Console.WriteLine("Gün: " + dt.Day);
            //Console.ReadLine();

            //Console.WriteLine("Ay: " + dt.Month);
            //Console.ReadLine();

            //Console.WriteLine("Yıl: " + dt.Year);
            //Console.ReadLine();
            //Dışarıdan girilen sayının negatif veya pozitif olduğunu ekrana yazdır

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if(sayi > 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı pozitif");
            //}
            //if(sayi < 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı negatif");
            //}

            //Console.ReadLine();


            //Girilen sayı 100 den büyükse ekrana "X" yazdır. DEĞİLSE "Y" yazdır

            //Console.WriteLine("Sayı gir");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if(sayi > 100)
            //{
            //    Console.WriteLine("X");
            //}
            //else
            //{
            //    Console.WriteLine("Y");
            //}

            //Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”, yanlış girildiğinde “Girdiğiniz kullanıcı adı veya şifre hatalı” mesajı veren program

            //Console.WriteLine("Lütfen kullanıcı adını giriniz");
            //string username = Console.ReadLine();
            //Console.WriteLine("Lütfen şifreyi giriniz");
            //string password = Console.ReadLine();
            //string ip = "123.11.45.10";

            //username cagatay ve şifre 123 ise!
            //if(username == "cagatay")
            //{
            //    if(password == "123")
            //    {
            //        Console.WriteLine("Giriş Başarılı!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girdiğiniz şifre hatalı");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz kullanıcı adı hatalı");
            //}

            //Console.ReadLine();


            //if(username == "cagatay" && (password == "123" && ip == "235.154.12.11"))
            //{
            //    Console.WriteLine("Giriş Başarılı!");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
            //}

            //Console.ReadLine();



            //Not hesaplama
            //0-45,45-55,55-70,70-85,85-100

            //Console.WriteLine("Lütfen bir not giriniz");
            //int not = Convert.ToInt32(Console.ReadLine());

            //if (not < 0 || not > 100)
            //{
            //    Console.WriteLine("Düzgün not gir..!");
            //}
            //if (not >= 0 && not < 45)
            //{
            //    Console.WriteLine("Hoca bıraktı...");
            //}
            //if (not >= 45 && not < 55)
            //{
            //    Console.WriteLine("Akmasa da damlıyor...");
            //}
            //if (not >= 55 && not < 70)
            //{
            //    Console.WriteLine("çok normal");
            //}
            //if (not >= 70 && not < 85)
            //{
            //    Console.WriteLine("Karizma not...");
            //}
            //if (not >= 85 && not <= 100)
            //{
            //    Console.WriteLine("****");
            //}

            //Console.ReadLine();




            //if (not >= 0 && not < 45)
            //{
            //    Console.WriteLine("Hoca bıraktı...");
            //}
            //else if (not >= 45 && not < 55)
            //{
            //    Console.WriteLine("Akmasa da damlıyor...");
            //}
            //else if (not >= 55 && not < 70)
            //{
            //    Console.WriteLine("çok normal");
            //}
            //else if (not >= 70 && not < 85)
            //{
            //    Console.WriteLine("Karizma not...");
            //}
            //else if (not >= 85 && not <= 100)
            //{
            //    Console.WriteLine("****");
            //}
            //else
            //{
            //    Console.WriteLine("Düzgün not gir..!");
            //}

            //Console.ReadLine();

            //int s = 50;

            ////sayının 2 ye bölümünden kalan 0 ise (ÇİFT)
            //if( s%2 == 0)
            //{

        }

        //sayı tek!
        //if (s % 2 != 0)
        //{

        //}


        //10.10.2020
        //console dan girilen tarihin ayını belirt
        //10.10.2020 03:02
        //console dan girilen tarihin saatini belirt


    }
    }
