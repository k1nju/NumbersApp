using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersClassLibrary
{
    public class NumberList
    {
        public Random random;
        public List<int> numbers;

        public NumberList()
        {
            random = new Random();
            numbers = new List<int>();
        }

        public void InitializeList()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.Add(random.Next(-1000, 1000));
            }
        }
        public double GetSum()
        {
            stopwatch = Stopwatch.StartNew();



            return Stopwatch.
        }

        public int GetSumParallel(int processors)
        {
            int[] partialSums = new int[processors];
            Parallel.For(0, processors, (p) =>
            {
                int sum = 0; int partitionSize = numbers.Count / processors;
                int start = p * partitionSize; int end = (p == processors - 1) ? numbers.Count : start + partitionSize;
                for (int i = start; i < end; i++)
                {
                    sum += numbers[i];
                }
                partialSums[p] = sum;
            });
            int totalSum = 0; foreach (var partialSum in partialSums)
            {
                totalSum += partialSum;
            }
            return totalSum;
        }
    }
}