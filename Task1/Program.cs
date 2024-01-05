// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void SumInterval (int m, int n)
{
    if (m > n) return;
    else 
    {
        System.Console.Write(m + " ");
        m++;
        SumInterval(m, n);
    }
}

System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

SumInterval(M, N);