Console.WriteLine("Ingresa el primer numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("Los numeros son iguales");
} else if (num1 > num2)
{
    Console.WriteLine($"El numero {num1} es mas grande que el numero {num2}");
} else
{
    Console.WriteLine($"El numero {num2} es mas grande que el numero {num1}");
}