// Задача 5: Определите, является ли число степенью двойки:

bool RecBin(int value)
{
    if (value == 1) return true;
    return value % 2 == 0 && RecBin(value / 2);
}

if(RecBin(1023)) System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");