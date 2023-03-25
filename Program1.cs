// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
 
 
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр введенного числа = {summa(num)}");
 
double summa(int num)
{
    int sum = 0;
    int result=sum;
while (num > 0)
    {
        int div = num % 10;
        num = num / 10;
        sum = sum + div;
        result=sum;
       
    }
    return result;
}