// Ejercicio 5

Console.Write("Ingrese el nombre de un día: ");
string day = Console.ReadLine();
day = day.Trim();

if (day.Equals("sabado", StringComparison.OrdinalIgnoreCase) ||
    day.Equals("domingo", StringComparison.OrdinalIgnoreCase))
{Console.WriteLine("Es fin de semana");}
else if (day.Equals("lunes", StringComparison.OrdinalIgnoreCase) ||
        day.Equals("martes", StringComparison.OrdinalIgnoreCase) ||
        day.Equals("miercoles", StringComparison.OrdinalIgnoreCase) ||
        day.Equals("jueves", StringComparison.OrdinalIgnoreCase) ||
        day.Equals("viernes", StringComparison.OrdinalIgnoreCase))
{Console.WriteLine("No es fin de semana");}
else
{Console.WriteLine("Error: el texto ingresado no corresponde a un dia valido");}