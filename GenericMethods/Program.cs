using System;

namespace GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintKeyValuepair<int, string>(5, "pesho");

            
        }

        static void PrintKeyValuepair<TKey, TValue>(TKey key, TValue value)
        {
            Console.WriteLine($"Key: {key} Value : {value}");
        }
    }
}
