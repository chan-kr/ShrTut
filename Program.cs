// See https://aka.ms/new-console-template for more information
using System;

namespace ShrTut
{

    public class Item<T>
    {
        // Generic type parameter
        public T content { get; set; }

        public Item(T content)
        {
            this.content = content;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }


}
