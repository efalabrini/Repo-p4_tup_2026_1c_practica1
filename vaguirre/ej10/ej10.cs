
List<int> pares = new List<int>();
List<int> div3 = new List<int>();

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        pares.Add(i);
    }

    if (i % 3 == 0)
    {
        div3.Add(i);
    }
}

Console.WriteLine("Numeros pares:");
foreach (int num in pares)
{
    Console.Write(num + " ");
}

Console.WriteLine("\n\nNumeros divisibles entre 3:");
foreach (int num in div3)
{
    Console.Write(num + " ");
}