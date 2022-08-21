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
        public event EventHandler<Tuple<T,T>> CompareEvent;
        public event EventHandler<Tuple<T, T>> SwopEvent;
        public AlgorithmBase(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }
        public AlgorithmBase() { }
        protected void Swop(int positionA, int positionB)
        {
            var temp = Items[positionA];
            Items[positionA] = Items[positionB];
            Items[positionB] = temp;

            SwopCount++;
            CompareEvent?.Invoke(this, new Tuple<T, T>(Items[positionA], Items[positionB]));
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
        protected int Compare(T a, T b)
        {
            CompareEvent?.Invoke(this, new Tuple<T,T>(a,b));
            ComparisonCount++;
            return a.CompareTo(b);
        }
    }
}
