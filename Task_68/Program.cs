﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkF(m, n);

void AkkF(int m, int n)
{
    Console.Write(Akk(m, n));
}

int Akk(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return Akk(m - 1, 1);
    else
        return (Akk(m - 1, Akk(m, n - 1)));
}