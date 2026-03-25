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