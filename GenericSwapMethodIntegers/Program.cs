using System;
using System.Linq;
using System.Collections.Generic;

namespace GenericSwapMethodIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();
            
            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            SwapIndex(boxes, firstIndex, secondIndex);

            foreach (var currentBox in boxes)
            {
                Console.WriteLine(currentBox);
            }

        }

        private static void SwapIndex<T>(List<Box<T>> boxes,int firstIndex, int secondIndex)
        {
            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;

        }
    }
}
