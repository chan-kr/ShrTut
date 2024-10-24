using System;

namespace ShrTut
{

    class Program
    {
        static void Main(string[] args)
        {
            // 값을 만들어 내는 간단한 코드조각 '표현식'이라고 함.
            // 예를 들어 
            // 273
            // 10 + 20 + 30 * 2
            // "C# Programming"
            // 모두 표현식임.

            // 표현식이 하나 이상 모이고, 마지막에 세미콜론(;)이 찍히면 문장(statement)이 됨.
            // 코드 문장 마지막에 종결의 의미로 세미콜론(;)을 찍음.

            var name = "허" + "찬";
            Console.WriteLine(name);
        }   
    }
}