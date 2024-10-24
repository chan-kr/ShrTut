using System;

namespace ShrTut
{

    class Box<T>
    {
        public T content{ get; set; }

        public Box(T content){
            this.content = content;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box<String> BoxOne = new Box<String>("키크론 마우스");
            Console.WriteLine(BoxOne.content);
        }   
    }
}