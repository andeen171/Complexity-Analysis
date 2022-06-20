MaxMin maxMin = new();
Random random = new();
int[] asc = new int[1000], desc = new int[1000], rand = new int[1000];

for (int i = 0; i < 1000; i++)
{
    asc[i] = i;
    desc[i] = 1000 - i;
    rand[i] = random.Next(10);
}
Console.WriteLine("Metodo 1");
Console.WriteLine(maxMin.MaxMin1(desc));
Console.WriteLine(maxMin.MaxMin1(asc));
Console.WriteLine(maxMin.MaxMin1(rand));

Console.WriteLine("Metodo 2");
Console.WriteLine(maxMin.MaxMin2(desc));
Console.WriteLine(maxMin.MaxMin2(asc));
Console.WriteLine(maxMin.MaxMin2(rand));

Console.WriteLine("Metodo 3");
Console.WriteLine(maxMin.MaxMin3(desc));
Console.WriteLine(maxMin.MaxMin3(asc));
Console.WriteLine(maxMin.MaxMin3(rand));