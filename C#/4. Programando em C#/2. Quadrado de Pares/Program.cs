﻿int n = int.Parse(Console.ReadLine());

if (n > 5 && n < 2000)
{
    for (int i = 1; i <= n; i++)
    {
        if (i%2 == 0)
        {
            Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
        }
    }
}