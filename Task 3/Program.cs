/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Akkermann(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkermann(n - 1, 1);
    if (n > 0 && m > 0) return Akkermann(n - 1, Akkermann(n, m - 1));
    return Akkermann(n, m);
}

int m = 3;
int n = 2;
int Ak=Akkermann(m, n);
Console.WriteLine(Ak);