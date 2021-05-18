using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<double>> boxes = new List<Box<double>>();



            for (int i = 0; i < n; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            double value = double.Parse(Console.ReadLine());

            Box<double> comparebleBox = new Box<double>(value);

            int count = GetGreaterThanCount(boxes, comparebleBox);

            Console.WriteLine(count);

        }

        private static int GetGreaterThanCount<T>(List<Box<T>> boxes,Box<T> box)
            where T : IComparable
        {
            int count = 0;

            foreach (Box<T> item in boxes)
            {
                int compare = item.Value.CompareTo(box.Value);

                if (compare>0)
                {
                    count++;
                }
            }
            return count;
        }
        
    }
}
