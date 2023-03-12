// Задача 6: Проверка на простое число:

bool RecPrime(int value, int i)
{
    if(i == 1) return true;
    System.Console.WriteLine(i);
    return value%i != 0 && RecPrime(value, i-1);
}

int num = 101, i = num - 1;
if(RecPrime(num, i)) System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");