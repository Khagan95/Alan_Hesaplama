using System;

namespace AlanHesaplamaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometrik şekil seçin: (Daire, Üçgen, Kare, Dikdörtgen)");
            string sekil = Console.ReadLine();

            AlanHesaplayici alanHesaplayici = new AlanHesaplayici();

            switch (sekil.ToLower())
            {
                case "daire":
                    Console.Write("Dairenin yarıçapını girin: ");
                    double yaricap = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hesaplanacak boyutu seçin: (Alan, Çevre)");
                    string boyutDaire = Console.ReadLine();
                    if (boyutDaire.ToLower() == "alan")
                    {
                        double alan = alanHesaplayici.DaireAlaniHesapla(yaricap);
                        Console.WriteLine($"Dairenin alanı: {alan}");
                    }
                    else if (boyutDaire.ToLower() == "çevre")
                    {
                        double cevre = alanHesaplayici.DaireCevresiHesapla(yaricap);
                        Console.WriteLine($"Dairenin çevresi: {cevre}");
                    }
                    break;

                // Diğer geometrik şekiller ve hesaplamalarını burada ekleyebilirsiniz.

                default:
                    Console.WriteLine("Geçersiz şekil seçimi!");
                    break;
            }
        }
    }

    class AlanHesaplayici
    {
        public double DaireAlaniHesapla(double yaricap)
        {
            return Math.PI * yaricap * yaricap;
        }

        public double DaireCevresiHesapla(double yaricap)
        {
            return 2 * Math.PI * yaricap;
        }

        // Diğer şekil alan ve çevre hesaplamalarını burada ekleyebilirsiniz.
    }
}
