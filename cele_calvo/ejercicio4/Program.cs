Console.WriteLine("Ingresá el primer número:");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ingresá el segundo número:");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine($"El número mayor es: {num1}");
}
else if (num2 > num1)
{
    Console.WriteLine($"El número mayor es: {num2}");
}
else
{
    Console.WriteLine("Ambos números son iguales");
}