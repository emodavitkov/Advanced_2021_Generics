using System;

namespace GenericsList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            GenericList<string> stringList = new GenericList<string>();

            list.Add(1);
            stringList.Add("one");
            list.Add(2);
            stringList.Add("two");
            list.Add(3);
            stringList.Add("three");

            Console.WriteLine(list.GetAt(0));
            Console.WriteLine(stringList.GetAt(0));
            Console.WriteLine(list.GetAt(1));
            Console.WriteLine(stringList.GetAt(1));
            Console.WriteLine(list.GetAt(2));
            Console.WriteLine(stringList.GetAt(2));
        }
    }
}
