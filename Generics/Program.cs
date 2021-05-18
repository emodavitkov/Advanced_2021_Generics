using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintElement<int>(5);
            PrintElement<string>("some string");
            PrintElement<List<int>>(new List<int>());
        }

        static void PrintElement<T>(T element)
        {
            Console.WriteLine($"Generics are cool {element}");
        }

        //If not with generics we have to go with one by one: 
        static void PrintElement(string element)
        {
            Console.WriteLine(element);
        }

        static void PrintElement(int element)
        {
            Console.WriteLine(element);
        }

        static void PrintElement(List<int> element)
        {
            Console.WriteLine(element);
        }
    }
}
