using System;
using System.Collections.Generic;

namespace AlgoShowcase.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Sorting demo");
            var sampleunsorted = new List<Int32>();
            sampleunsorted.Add(64);
            sampleunsorted.Add(34);
            sampleunsorted.Add(25);
            sampleunsorted.Add(12);
            sampleunsorted.Add(22);
            sampleunsorted.Add(11);
            sampleunsorted.Add(90);
            Console.WriteLine("Bubble sort");
            var sampleBubbleSorted = BubbleSort.DoBubbleSort(sampleunsorted);
            foreach (var item in sampleBubbleSorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
