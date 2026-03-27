using System.Collections.Generic;

List<int> pares = new List<int>();
List<int> divisiblesPor3 = new List<int>();

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        pares.Add(i);
    }

    if (i % 3 == 0)
    {
        divisiblesPor3.Add(i);
    }
}

// Mostrar lista de pares
Console.WriteLine("Números pares:");
foreach (int n in pares)
{
    Console.WriteLine(n);
}

// Mostrar lista de divisibles por 3
Console.WriteLine("Números divisibles por 3:");
foreach (int n in divisiblesPor3)
{
    Console.WriteLine(n);
}
