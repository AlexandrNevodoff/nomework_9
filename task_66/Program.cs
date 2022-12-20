// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int rec(int m, int n, int sum)
{
    //int sum =0;
    if (m > n)
    { 
    {
        Console.Write($"Сумма натуральных элементов в промежутке от M до N: "); 
        return sum;
    }
    }
    
    return rec(m, n - 1,sum) + n;
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int total = (rec(m,n,0));
Console.WriteLine (total);
