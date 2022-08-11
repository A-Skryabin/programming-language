Console.WriteLine("Введите первое число: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberb = Convert.ToInt32(Console.ReadLine());
if(numbera > numberb)
{
    Console.WriteLine($"{numbera}");
}

if(numbera < numberb)
{
    Console.WriteLine($"{numberb}");
}