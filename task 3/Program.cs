// Задача 3: Напишите программу, 
// которая будет принимать на вход число 
// и возвращать сумму его цифр. Использовать рекурсию.

int RecSumDigits(int num)
{
    if(num == 0) return 0;
    return num = num%10 + RecSumDigits(num/10);
}

System.Console.WriteLine(RecSumDigits(555));