// Задача 35: Задайте одномерный массив из 123 случайн. чисел. 
// Найдите кол-во элем. массива, значения которых лежат в отрезке [10,99].
// для массива из 5. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Задайте массив :");
// int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[123];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int a = 10;
int b = 99;
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if ((numbers[i]>=a)&&(numbers[i]<=b))
count++;

Console.Write($"{count}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
