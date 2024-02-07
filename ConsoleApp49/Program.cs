private static double Ortalama(int[] sayilar)
{
    int toplam = 0;
    for (int i = 0; i < sayilar.Length; i++)
    {
        toplam += sayilar[i];
    }

    return (double)toplam / sayilar.Length;
}
static void Main(string[] args)
{

    Random rastgele = new Random();

    int[] sayilar = new int[10];

    for (int i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = rastgele.Next(100);
    }

    Console.Write("Dizideki Sayıların Ortalaması:" + Ortalama(sayilar));

    Console.ReadKey();
}
