using System.Collections.Generic;

List<int> pares = new List<int>();
List<int> divPor3 = new List<int>();

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        pares.Add(i);
    }

    if (i % 3 == 0)
    {
        divPor3.Add(i);
    }
}

Console.WriteLine("Números pares:");
foreach (int num in pares)
{
    Console.WriteLine(num);
}

Console.WriteLine("Números divisibles por 3:");
foreach (int num in divPor3)
{
    Console.WriteLine(num);
}