using System;

class Program
{
    static void Main(){
        int[] numbers = { 10, 20, 30, 40, 50 };
        int max = numbers[0];
        int min = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }

            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine($"최대값: {max}");
        Console.WriteLine($"최소값: {min}");
    }

}