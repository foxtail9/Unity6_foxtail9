using System;

class Program
{
    static void Main()
    {
        int num;

        while (true)
        {
            Console.Write("숫자 입력 :  ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out num))
            {
                break;
            }
            else
            {
                Console.WriteLine("숫자가 아닙니다.");
            }
        }

        int facto = Facfn(num);
        Console.WriteLine($"{num}! = {facto}");
    }
    static int Facfn(int i)
    {
        if (i <= 1)
            return 1;
        else
            return i * Facfn(i - 1);
    }
}
