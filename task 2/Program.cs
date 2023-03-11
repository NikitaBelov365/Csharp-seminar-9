// Задача 2: Задайте значения M и N. 
// Напишите программу, которая рекурсивно 
// выведет все натуральные числа в промежутке от M до N.

void RecNumbers(int m, int n)
{
    if (m > n-2) return;
    System.Console.Write($"{m+1} ");
    RecNumbers(m + 1, n);
}

RecNumbers(5, 10);