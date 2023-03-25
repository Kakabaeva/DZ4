// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
 
Console.WriteLine ("Для указания диапазона значений введите минимальное число");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Для указания диапазона значений введите максимальное число");
int max = Convert.ToInt32(Console.ReadLine())+1;
int [] numbers = new int[8];
FillArray(numbers);
 
void FillArray(int []collection)
{
    int index=0;
    Console.Write("[");
    while (index<8)
    {
        if (index<7)
        {
        collection[index]= new Random().Next(min,max);
        Console.Write($"{collection[index]}, ");
        index++;
        }
        if (index==7)
        {
        collection[index]= new Random().Next(min,max);
        Console.Write($"{collection[index]}");
        index++;
        }
    }
    Console.Write("]");
}