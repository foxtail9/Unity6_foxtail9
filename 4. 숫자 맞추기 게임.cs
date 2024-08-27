using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int luckynum = rand.Next(1, 101);

        Console.Write("1~100숫자 하나를 맞춰보세요 : ");
        Console.WriteLine(luckynum);
        while(true)
        {
            String input = Console.ReadLine();
            int num;

            if(int.TryParse(input, out num))
            {
                if (num == luckynum)
                {
                    Console.WriteLine("축하합니다. 정답!");
                    break;
                }
                else
                {
                    string hint = hintfn(num,luckynum);
                    Console.WriteLine("오답!" + hint);
                }
            }
            else
            {
                Console.WriteLine("1~100 숫자 입력해주세요.");
            }
        }
    }

    static string hintfn(int n,int m)
    {
        if (n < m)
            return ("입력값 보다 커요");
        else
            return ("입력값 보다 작아요");
    }
}