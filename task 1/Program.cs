// Задача 1: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от 1 до N при помощи рекурсии.

void RecNumbers(int number)
{
    if (number <= 0)
    {
        return;
    }
    RecNumbers(number -1);
    System.Console.Write($"{number} ");
}

RecNumbers(10);