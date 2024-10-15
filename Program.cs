// See https://aka.ms/new-console-template for more information
using System;

namespace ShrTut
{
    class Program
    {
        static void Main(string[] args)
        {
            //2일차 조건문 공부(1) - if문 
            Console.WriteLine("숫자를 입력하세요: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number > 0)
                {
                    Console.WriteLine("입력한 숫자는 양수입니다.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("입력한 숫자는 음수입니다.");
                }
                else
                {
                    Console.WriteLine("입력한 숫자는 0입니다.");
                }
            }
            else
            {
                Console.WriteLine("올바른 숫자를 입력해주세요.");
            }
        }
    }
}
