// Ejercicio 4

Console.Write("Ingrese el primer numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{Console.WriteLine($"El numero mayor es {num1}");}
else if (num2 > num1)
{Console.WriteLine($"El numero mayor es {num2}");}
else
{Console.WriteLine("Ambos numeros son iguales");}