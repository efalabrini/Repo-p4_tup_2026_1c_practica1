//ej4
int num1;
int num2;
Console.WriteLine("ingrese dos numero");
num1=int.Parse(Console.ReadLine());
num2=int.Parse(Console.ReadLine());
if (num1 == num2){
    Console.WriteLine("son el mismo numero");
}else if (num1 < num2)
{
    Console.WriteLine($"{num2} en mayor a {num1}");
}
else
{
    Console.WriteLine($"{num1} en mayor a {num2}");
}

