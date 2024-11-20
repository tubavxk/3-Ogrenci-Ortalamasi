int ders1, ders2, ders3;
Console.Write("1. ders notunu girin: ");
ders1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. ders notunu girin: ");
ders2 = Convert.ToInt32(Console.ReadLine());

Console.Write("3. ders notunu girin: ");
ders3 = Convert.ToInt32(Console.ReadLine());


int ortalama = (ders1 + ders2 + ders3) / 3;


if (ortalama > 50)
{
    Console.WriteLine("Geçtiniz!");
}
else
{
    Console.WriteLine("Kaldınız.");
}