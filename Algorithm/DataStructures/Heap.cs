using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class Heap<T> : AlgorithmBase<T> where T : IComparable
    {
        public int Count => Items.Count;
        public Heap() { }
        public Heap(IEnumerable<T> items)
        {
            Items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }
        public void Add(T item)
        {
            Items.Add(item);
            var currentIndex = Count - 1;
            var parentIndex = GetPerentIndex(currentIndex);

            while (currentIndex > 0 && Compare(Items[parentIndex], Items[currentIndex]) == -1)
            {
                Swop(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetPerentIndex(currentIndex);
            }
        }
        public T GetMax()
        {
            var result = Items[0];
            Items[0] = Items[Count - 1];
            Items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int currentIndex, int maxLenght = -1)
        {
            int maxIndex, leftIndex, rightIndex;
            maxIndex = currentIndex;

            maxLenght = maxLenght == -1 ? Count : maxLenght;

            while (currentIndex < maxLenght)
            {
                leftIndex = currentIndex * 2 + 1;
                rightIndex = currentIndex * 2 + 2;

                if (leftIndex < maxLenght && Compare(Items[leftIndex], Items[maxIndex]) == 1)
                {
                    maxIndex = leftIndex;
                }
                if (rightIndex < maxLenght && Compare(Items[rightIndex], Items[maxIndex]) == 1)
                {
                    maxIndex = rightIndex;
                }
                if (maxIndex == currentIndex)
                {
                    break;
                }
                Swop(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }
        }
        private static int GetPerentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }
        public override void MakeSort()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                Swop(0, i);
                Sort(0, i);
            }
        }
    }
}
