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