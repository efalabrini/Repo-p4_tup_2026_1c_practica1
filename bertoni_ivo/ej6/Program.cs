// Ejercicio 6

Console.Write("Ingrese el precio del producto: ");
double price = double.Parse(Console.ReadLine());

if (price <= 0)
{
    Console.WriteLine("Error: el precio debe ser un valor positivo.");
    return;
}

Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
string formpay = Console.ReadLine().Trim();

if (formpay.Equals("efectivo", StringComparison.OrdinalIgnoreCase))
    {Console.WriteLine($"El valor a pagar es: {price}");}
else if (formpay.Equals("tarjeta", StringComparison.OrdinalIgnoreCase))
    {
    Console.Write("Ingrese el numero de la tarjeta (16 digitos): ");
    string cardnum = Console.ReadLine().Trim();

    if (cardnum.Length == 16 && long.TryParse(cardnum, out _))
    {
        double finalPrice = price * 1.10;
        Console.WriteLine($"Numero de tarjeta valido. El valor a pagar con recargo es: {finalPrice}");
    }
    else
    {Console.WriteLine("Error: el numero de tarjeta debe tener exactamente 16 digitos.");}
    }
else
{Console.WriteLine("Error: forma de pago no reconocida.");}