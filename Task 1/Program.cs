/* 
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void ReturnIntegers(int n)
{
    if (n == 1)
        Console.WriteLine(1);
    else
    {
        Console.Write($"{n} \t");
        ReturnIntegers(n - 1);
    }
}
int integersNumber = 100;
ReturnIntegers(integersNumber);