Console.WriteLine("Ingrese el precio del producto: ");
double precio = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la forma de pago (efectivo/tarjeta): ");
string formaPago = Console.ReadLine().Trim();

if (formaPago.Equals("tarjeta", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Ingrese número de la tarjeta: ");
    string tarjeta = Console.ReadLine();

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
else if (formaPago.Equals("efectivo", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"Total a pagar: {precio}");
}
else
{
    Console.WriteLine("Forma de pago inválida");
}
