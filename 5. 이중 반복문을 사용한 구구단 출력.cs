using System;

class Program
{
    static void Main()
    {
        //세로 출력
        for (int i = 2; i <= 9; i++)
        {
            for (int k = 1; k <= 9; k++)
            {
                Console.WriteLine($"{i} x {k} = {i * k}");
            }
            Console.WriteLine("--------------------");
        }

        //가로 출력
        for (int i = 2; i <= 9; i++)
        {
            for (int k = 1; k <= 9; k++)
            {
                Console.Write($"{i} x {k} = {i * k,2} ");
            }
            Console.WriteLine();
        }
    }
}