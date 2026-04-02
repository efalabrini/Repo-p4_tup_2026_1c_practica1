Console.WriteLine("Ingrese el día: ");
string dia = Console.ReadLine().Trim();

if (dia.Equals("sabado", StringComparison.OrdinalIgnoreCase) ||
    dia.Equals("domingo", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"El día {dia} es fin de semana");
}
else if (
    dia.Equals("lunes", StringComparison.OrdinalIgnoreCase) ||
    dia.Equals("martes", StringComparison.OrdinalIgnoreCase) ||
    dia.Equals("miercoles", StringComparison.OrdinalIgnoreCase) ||
    dia.Equals("jueves", StringComparison.OrdinalIgnoreCase) ||
    dia.Equals("viernes", StringComparison.OrdinalIgnoreCase)
)
{
    Console.WriteLine($"El día {dia} no es fin de semana");
}
else
{
    Console.WriteLine("El día ingresado es inválido");
}