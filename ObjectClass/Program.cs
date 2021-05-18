using System;

namespace ObjectClass
{
    public class Program
    {
        static void Main(string[] args)
        {//non type safety
            Object someObject = new Object();

            Shoe shoe = new Shoe();
            someObject = 5;
            someObject = "5";
            someObject = new Shoe();

            GenericListWithObject intList = new GenericListWithObject();
            GenericListWithObject stringList = new GenericListWithObject();

            intList.Add(5);
            stringList.Add("five");
            intList.Add(6);
            intList.Add(7);

            Console.WriteLine(intList.GetAt(0));
            Console.WriteLine(stringList.GetAt(0));

        }
    }
}
