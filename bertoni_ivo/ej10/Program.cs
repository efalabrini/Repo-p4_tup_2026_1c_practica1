// Ejercicio 10

List<int> pares = new List<int>();
List<int> divisiblesPorTres = new List<int>();

for (int i = 1; i <= 100; i++)
    {
    if (i % 2 == 0)
    {pares.Add(i);}
    
    if (i % 3 == 0)
    {divisiblesPorTres.Add(i);}
    }

Console.WriteLine("Números pares:");
foreach (int num in pares)
{Console.Write(num + " ");}

Console.WriteLine("\n");

Console.WriteLine("Números divisibles por 3:");
foreach (int num in divisiblesPorTres)
{Console.Write(num + " ");}
        