//ej6

decimal precio;
        string tipo;
        string numero;
        decimal total;

        Console.WriteLine("Ingrese el precio de un producto:");
        if (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0)
        {
            Console.WriteLine("Error: el precio debe ser un número positivo.");
            return;
        }

        Console.WriteLine("Ingrese cómo abona el producto (efectivo/tarjeta):");
        tipo = Console.ReadLine().Trim();

        
        if (!(tipo.Equals("efectivo", StringComparison.OrdinalIgnoreCase) ||
              tipo.Equals("tarjeta", StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Error: ingrese 'efectivo' o 'tarjeta'.");
        }
        else if (tipo.Equals("tarjeta", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Ingrese el número de la tarjeta (16 dígitos):");
            numero = Console.ReadLine().Trim();

            if (numero.Length == 16 && long.TryParse(numero, out _))
            {
                total = precio * 1.10m; // recargo del 10%
                Console.WriteLine($"El total es: {total:C}");
            }
            else
            {
                Console.WriteLine("Error: debe ingresar exactamente 16 dígitos numéricos.");
            }
        }
        else 
        {
            Console.WriteLine($"El total es: {precio:C}");
        }