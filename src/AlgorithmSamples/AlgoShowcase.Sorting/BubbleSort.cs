using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoShowcase.Sorting
{
    public class BubbleSort
    {
        public static List<Int32> DoBubbleSort(List<Int32> data)
        {
            List<Int32> sortedResult = data;
            for (int i = 0; i < sortedResult.Count - 1; i++)
            {
                for (int j = 0; j < sortedResult.Count - i - 1; j++)
                {
                    if (sortedResult[j] > sortedResult[j + 1])
                    {
                        var temp = sortedResult[j];
                        sortedResult[j] = sortedResult[j + 1];
                        sortedResult[j + 1] = temp;
                    }
                }
            }
            return sortedResult;
        }
    }
}
