// Задача 10: 
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = A%100/10;
Console.WriteLine(B);
