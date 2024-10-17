// See https://aka.ms/new-console-template for more information
using System;

namespace ShrTut
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# 기본문법 - 제어문(2) - switch문
            Console.WriteLine("1부터 5 사이의 숫자를 입력하세요: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("매우 나쁨");
                        break;
                    case 2:
                        Console.WriteLine("나쁨");
                        break;
                    case 3:
                        Console.WriteLine("보통");
                        break;
                    case 4:
                        Console.WriteLine("좋음");
                        break;
                    case 5:
                        Console.WriteLine("매우 좋음");
                        break;
                    default:
                        Console.WriteLine("1부터 5 사이의 숫자를 입력해주세요.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("올바른 숫자를 입력해주세요.");
            }
        }
    }
}
