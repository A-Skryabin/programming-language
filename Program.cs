// Задача 23
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1, j = 1, y = 1; i < N+1; i++, j++, y++)
    Console.Write($" {i * j * y}");