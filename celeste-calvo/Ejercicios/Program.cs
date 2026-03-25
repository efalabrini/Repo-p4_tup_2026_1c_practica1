/* //EJERCICIO 1: 
int num1 = 4; 
int num2 = 5; 
int num3 = 9; 
int suma = num1 + num2 + num3; 
Console.WriteLine($"La suma total es: {suma}"); 

//EJERCICIO 2: 
void Saludo(string nombre, string ciudad) 
{ 
    Console.WriteLine($"Hola {nombre}, bienvenido a {ciudad}"); 
} Saludo("Pepe", "Bariloche"); 

//EJERCICIO 3: 
Console.WriteLine("Ingresa tu nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Ingresa tu edad");
string edad = Console.ReadLine();

Console.WriteLine($"Te llamas {nombre} y tienes {edad} años");
 
//EJERCICIO 4: 
Console.WriteLine("Ingresa un numero:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa otro numero:");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"el mayor es {num1}");
}
else if (num2 > num1)
{
    Console.WriteLine($"el mayor es {num2}");
}
else
{
    Console.WriteLine("ambos numeros son iguales");
}

//EJERCICIO 5: 
Console.WriteLine("Ingresá un día:");
string dia = Console.ReadLine()!.Trim().ToLower();

if (dia == "sabado" || dia == "domingo")
{
    Console.WriteLine("Es fin de semana");
}
else if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
{
    Console.WriteLine("Es día de semana");
}
else
{
    Console.WriteLine("Día inválido");
}

//EJERCICIO 6: 
Console.WriteLine("Ingresá el precio del producto:");
double precio = double.Parse(Console.ReadLine()!);

Console.WriteLine("Forma de pago (efectivo/tarjeta):");
string formaPago = Console.ReadLine()!.Trim().ToLower();

if (formaPago == "tarjeta")
{
    Console.WriteLine("Ingresá el número de tarjeta:");
    string tarjeta = Console.ReadLine()!;

    if (tarjeta.Length == 16)
    {
        double total = precio * 1.10;
        Console.WriteLine($"Total con recargo: {total}");
    }
    else
    {
        Console.WriteLine("Número de tarjeta inválido");
    }
}
else if (formaPago == "efectivo")
{
    Console.WriteLine($"Total a pagar: {precio}");
}
else
{
    Console.WriteLine("Forma de pago inválida");
}

//EJERCICIO 7: 
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}

//EJERCICIO 8: 
int i = 1;

while (i <= 100)
{
    Console.WriteLine(i);
    i++;
}

//EJERCICIO 9: 
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//EJERCICIO 10:
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

// lista de pares
Console.WriteLine("Números pares:");
foreach (int n in pares)
{
    Console.WriteLine(n);
}

// lista de divisibles por 3
Console.WriteLine("Números divisibles por 3:");
foreach (int n in divisiblesPor3)
{
    Console.WriteLine(n);
}

*/