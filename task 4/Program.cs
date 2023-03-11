// Задача 4: Напишите программу, 
// которая на вход принимает два 
// числа A и B, и возводит число
// А в целую степень B с помощью рекурсии.

int RecPower (int a, int b)
{
    if(b == 0) return 1;
    else return a * RecPower(a, b-1);
}

System.Console.WriteLine(RecPower(2, 10));