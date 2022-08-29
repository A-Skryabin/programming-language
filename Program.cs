// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int value, number, one = 0, two = 1;
Console.WriteLine("Введите число N > 2: ");
value = Convert.ToInt32(Console.ReadLine());
if (value > 2)
{
Console.Write(one + " " + two);
    for (; (value - 2 > 0); value--)
        {
        number = one + two;
        one = two;
        two = number;
        Console.Write(" " + number);
        }
}
    Console.ReadKey();
    