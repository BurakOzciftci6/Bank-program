using System;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.ConstrainedExecution;

namespace Bank
{
    class User
    {
        public string Name { get; set; }
        public int Pass { get; set; }
        public int Wallet { get; set; }
        public int BankNO { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var k1 = new User();
            k1.Name = "user ";
            k1.Pass = 1111;
            k1.Wallet = 0;
            k1.BankNO = 1111111;

            Console.WriteLine("Şifrenizi giriniz :");
            int a = int.Parse(Console.ReadLine());

            if (a == k1.Pass)
            {
                Console.WriteLine("Giriş Başarılı\n\n");

                while (true)
                {
                    Console.WriteLine($"Ad:{k1.Name}\nCüzdan Bakiyesi:{k1.Wallet} $\nİsoBANK no:{k1.BankNO}\nseçenekler\n1)para yatır\n2)para çek\n3)çıkış\n");
                    Console.WriteLine("seçiminiz :");
                    int b = int.Parse(Console.ReadLine());

                    if (b == 1)
                    {
                        Console.WriteLine("para yatırma seçildi \nyatırmak istediğiniz tutarı yazınız :");
                        int miktar = int.Parse(Console.ReadLine());
                        k1.Wallet = k1.Wallet + miktar;
                    }


                    if (b == 2)
                    {
                        Console.WriteLine("para çekme seçildi \nçekmek istediğiniz tutarı yazınız :");
                        int miktar = int.Parse(Console.ReadLine());
                        if (miktar > k1.Wallet)
                        {
                            Console.WriteLine("Yeterli bakiye bulunmamakta!!");

                            break;
                        }
                        k1.Wallet = k1.Wallet - miktar;
                    }


                    if (b == 3)
                    {
                        Console.WriteLine("çıkılıyor...");

                        break;
                    }

                    else 
                    {
                        Console.WriteLine("Böyle bir komut bulunamadı\n");
                    }

                }
            }
            else
            {
                Console.WriteLine("Hatalı giriş");
            }
        }
    }
}

