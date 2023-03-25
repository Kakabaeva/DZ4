// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16
 
Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(fifthPower(num1, num2));
int fifthPower(int num1, int num2)
{
    int power = 2;
    int powered = num1;
    int result=0;
 
    {
        if (num2 == 0) 
        {
            result=1; 
        }
        else if (num2 == 1) 
        {
            result=num1;
        }
        else
        {
            while (num2 >= power)
            {
            result = powered * num1;
            powered = result;
            power++;
            }
        }
    }
    return result;
}
