using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public int SwopCount { get; protected set; }
        public int ComparisonCount { get; protected set; }
        public List<T> Items { get; set; } = new List<T>();
        protected void Swop(int positionA, int positionB)
        {
            var temp = Items[positionA];
            Items[positionA] = Items[positionB];
            Items[positionB] = temp;
            SwopCount++;
        }
        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwopCount = 0;

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }
        public virtual void MakeSort()
        {
            Items.Sort();
        }
    }
}
