//Задача 15: 
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
