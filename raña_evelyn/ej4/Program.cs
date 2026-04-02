Console.WriteLine("Ingrese un número");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro número");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} es mayor que {b}");
}
else if (b > a)
{
    Console.WriteLine($"{b} es mayor que {a}");
}
else
{
    Console.WriteLine("Ambos números son iguales");
}
