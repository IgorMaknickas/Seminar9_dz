// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Write("Введи M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введи N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (N>M)
for (int i = M; i <= N; i++)
    Console.Write($" {i}");
else
    for (int i = N; i <= M; i++)
        Console.Write($" {i}");
