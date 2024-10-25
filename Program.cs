using System;

namespace ShrTut
{
    
    class Program
    {   
        static void Main(string[] args)
        {   
            //1. 표현식과 문장
            // 값을 만들어 내는 간단한 코드조각 '표현식'이라고 함.
            // 예를 들어 
            // 273
            // 10 + 20 + 30 * 2
            // "C# Programming"
            // 모두 표현식임.

            // 표현식이 하나 이상 모이고, 마지막에 세미콜론(;)이 찍히면 문장(statement)이 됨.
            // 코드 문장 마지막에 종결의 의미로 세미콜론(;)을 찍음.

            var name = "허" + "찬";
            // Console.WriteLine(name);

            
            //식별자
            // 이름을 붙일 때에 사용하는 단어
            // 예를 들어 변수, 함수, 클래스 등의 이름을 식별자라고 함. 그리고 식별자를 붙일 때는 규칙이 있음

            /*
            1. 키워드를 사용하면 안된다. ex ) class, int, string, var, if, else, for 등등
            2. 숫자로 시작하면 안된다.
            3. 특수문자는 _만 사용할 수 있다.
            4. 띄어쓰기는 사용할 수 없다.
            */
            
            /*
            알파벳 사용 외에도 대부분의 C# 개발자가 식별자를 만들 때 지키는 관례
            1. 클래스, 속성, 메서드, 네임스페이스 이름은 대문자로 시작함.
            2. 지역 변수와 전역 변수의 이름은 항상 소문자로 시작함.
            3. 여러 단어로 이루어진 식별자는 각 단어의 첫 글자를 대문자로 시작함.
            */
            string iLoveYou = "I Love You";
            string iAmBoy = "I am a boy";
            string createServer = "Create Server";

            //2. 출력

            Console.WriteLine(iLoveYou);


            //3. 기본 자료형 

            // 정수(소수점이 없는 숫자)
            Console.WriteLine(123);
            Console.WriteLine(10-2);
            Console.WriteLine(5*2);
            Console.WriteLine(5/2);
            Console.WriteLine((10 + 2) * 3);
            /*
                !!중요!!
                정수끼리 연산하면 결과도 정수로 나온다. 나누었을 때에 소수점이 생기는 부분은
                모두 사라진다. 얘를 들어 57번 라인과 같이 5/2를 하면 2.5가 나오지만 결과는 2가 됨. 
                이는 C언어 기반의 프로그래밍 언어(C, C++, C#, JAVA)의 특징임.
            */

            // 실수(소수점이 있는 숫자)
            Console.WriteLine(52.723);
            Console.WriteLine(5.0/2.0);
            
            // 문자(Character) - 문자 하나를 나타내는 자료형
            Console.WriteLine('A');
            Console.WriteLine('가');
            Console.WriteLine('나');

            //문자열 - 문자의 집합을 문자열이라고 부름
            Console.WriteLine("안녕하세요");

            //이스케이프 문자
            Console.WriteLine("한빛\t아가카메");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"꽃이 지고나서 봄인 줄을 알았다\"");
            Console.WriteLine("역슬래시 출력\\");

            //문자열 연결
            Console.WriteLine("가" + "나" + "다");
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[2]);
            Console.WriteLine("안녕하세요"[3]);
            Console.WriteLine("안녕하세요"[4]);

            //불

            
        }   
    }
}