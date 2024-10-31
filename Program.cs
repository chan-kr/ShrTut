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
                모두 사라진다. 예를 들어 57번 라인과 같이 5/2를 하면 2.5가 나오지만 결과는 2가 됨. 
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

            //불(Bool) - 참과 거짓을 표현하는 자료형
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine("\n-------------------------------------------------------------\n");

            //논리합 연산자(|| , OR)
            Console.WriteLine("논리합 연산자(||)");
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);
            Console.WriteLine("\n-------------------------------------------------------------\n");

            //논리곱 연산자(&& , AND)
            Console.WriteLine("논리곱 연산자(&&)");
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(true && false);
            Console.WriteLine(false && false);
            

            //DateTime.Now.Hor과 불의 활용
            Console.WriteLine("\n------------------------------------------------------------------\n");
            Console.WriteLine(DateTime.Now.Hour < 3 || DateTime.Now.Hour > 8);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
            Console.WriteLine("\n------------------------------------------------------------------\n");

            // 정수형 변수 선언
            // int는 4바이트(32비트)를 사용하며, 맨 앞 1비트는 부호(+/-)를 나타내는 데 사용됨
            // long은 8바이트(64비트)를 사용하며, 맨 앞 1비트는 부호(+/-)를 나타내는 데 사용됨
            // unsigned 자료형(uint, ulong)은 맨 앞 비트도 숫자를 나타내는 데 사용되어 더 큰 양수를 저장할 수 있음
            // 참고 영상 : https://www.youtube.com/watch?v=vEKkCLZ7n78 (C언어를 통해 설명하므로 소스코드가 아닌 이론만 참고 할 것.)
            
            /*
            int 자료형의 범위:
            - int는 4바이트(32비트)의 메모리를 사용
            - 맨 앞 1비트는 부호 비트로 사용 (0: 양수, 1: 음수)
            - 나머지 31비트로 숫자를 표현
            - 따라서 표현 가능한 범위는:
              * 최소값: -2^31 = -2,147,483,648
              * 최대값: 2^31-1 = 2,147,483,647
            - int의 범위를 넘어가는 값을 저장하려고 하면 오버플로우 발생
            
            * 이러한 범위를 외울 필요는 없습니다!
            * int.MinValue와 int.MaxValue를 사용하면 언제든지 
              int 자료형의 최솟값과 최댓값을 확인할 수 있습니다.
            */

            int number = 100;                        // 32비트 정수
            Console.WriteLine($"int 최소값: {int.MinValue}");    // -2,147,483,648
            Console.WriteLine($"int 최대값: {int.MaxValue}");    // 2,147,483,647

            uint unsignedNumber = 4000000000;        // 부호 없는 int(32비트) 32비트 정수
            Console.WriteLine($"uint 최소값: {uint.MinValue}");  // 0
            Console.WriteLine($"uint 최대값: {uint.MaxValue}");  // 4,294,967,295

            long bigNumber = 9223372036854775807;    // int(64비트) 정수
            Console.WriteLine($"long 최소값: {long.MinValue}");  // -9,223,372,036,854,775,808
            Console.WriteLine($"long 최대값: {long.MaxValue}");  // 9,223,372,036,854,775,807

            ulong unsignedBigNumber = 18446744073709551615;    // 부호 없는 int(64비트) 정수
            Console.WriteLine($"ulong 최소값: {ulong.MinValue}"); // 0
            Console.WriteLine($"ulong 최대값: {ulong.MaxValue}"); // 18,446,744,073,709,551,615

            /*
            오버플로우(Overflow) 예제:
            - int의 최대값은 약 21억(2,147,483,647)입니다
            - 아래 예제에서는 20억 + 10억 = 30억이 되어야 하지만
            - int가 저장할 수 있는 범위를 초과하여 오버플로우가 발생합니다
            - 오버플로우가 발생하면 예상치 못한 값이 저장됩니다
            - 이런 경우 더 큰 범위를 저장할 수 있는 long 자료형을 사용해야 합니다.
            - 또는 음수를 사용하지 않는 경우, uint 자료형을 사용하면 됩니다.
            */
            int a = 2000000000;    // 20억
            int b = 1000000000;    // 10억
            int c = a + b;         // 오버플로우 발생!
            Console.WriteLine(c);  // -1,294,967,296 출력

            float f = 3.145f; // float 자료형은 소수점 이하 7자리까지 표현 가능(4바이트의 실수)
            double d = 3.14159265358; // double 자료형은 소수점 이하 15자리까지 표현 가능(8바이트의 실수)

            Console.WriteLine(f);
            Console.WriteLine(d);




            
        }   
    }
}