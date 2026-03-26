Console.WriteLine("Ingresa el precio del producto: ");
int precio = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la forma de pago:\n 1)Efectivo\n 2)Tarjeta");
int opc = int.Parse(Console.ReadLine());

switch (opc)
{
    case 1:
        Console.WriteLine($"El precio en efectivo es ${precio}");
        break;

    case 2:
        Console.WriteLine("Ingresa el numero de la tarjeta");
        string numTarjeta = Console.ReadLine().Trim();

        if (numTarjeta.Length == 16)
        {
            float recargo = precio + (precio * 0.10f);
            Console.WriteLine($"El precio a pagar con el 10% de recargo es ${recargo}");
        }
        else
        {
            Console.WriteLine("Numero de tarjeta invalido");
        }
        break;

    default:
        Console.WriteLine("Ingresa una opcion valida");
        break;
}