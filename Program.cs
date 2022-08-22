// Задача 27: 
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (N > 0)
{
    int num = N % 10;
    N /= 10;
    sum = sum + num;
}
Console.WriteLine ($"{sum}");
