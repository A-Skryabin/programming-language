// Задачача 19:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i, j, sum=0;
for(j=N; N!=0; N=N/10)
{
    i=N % 10;
    sum=sum*10+i;
}
    if(j==sum)
    {
         Console.WriteLine("Да");
    }
    else
    {
         Console.WriteLine("Нет");	 
    }
