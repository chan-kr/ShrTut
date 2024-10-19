// See https://aka.ms/new-console-template for more information
using System;

namespace ShrTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1부터 10까지의 숫자를 출력합니다:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("for문이 종료되었습니다.");
        }
    }
}
