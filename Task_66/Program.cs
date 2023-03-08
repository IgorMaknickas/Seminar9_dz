// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
// от M до N.
int M, N, S=0;
Console.Write("Введи значение M: ");
M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи значение N: ");
N = Convert.ToInt16(Console.ReadLine());
for (int i = M; i <= N; i++)
    S += i;
Console.WriteLine(S);