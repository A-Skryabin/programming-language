// Задача 25: 
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int deg = a;
for(int i = 1; i < b; i++)
{
    deg = deg * a;
}
Console.WriteLine($"{deg}");
