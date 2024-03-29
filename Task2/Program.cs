﻿// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// Пример
// m = 3, n = 2 -> A(m,n) = 29


int Ackermann(int m, int n)
{
    if( m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(m, n);
}


System.Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"A(m, n) = {Ackermann(m, n)}");
