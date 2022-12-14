using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class CocktailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public CocktailSort(IEnumerable<T> items) : base(items) { }
        public CocktailSort() { }
        protected override void MakeSort()
        {
            var left = 0;
            var right = Items.Count - 1;
            while(left < right)
            {
                var sc = SwopCount;
                for (int j = left; j < right; j++)
                {
                    var a = Items[j];
                    var b = Items[j + 1];
                    if (Compare(a, b) == 1)
                    {
                        Swop(j, j + 1);
                    }
                }
                right--;
                if (sc == SwopCount)
                {
                    break;
                }
                for (int j = right; j > left; j--)
                {
                    var a = Items[j-1];
                    var b = Items[j];
                    if (Compare(a, b) == 1)
                    {
                        Swop(j - 1, j);
                    }
                }
                left++;
                if (sc == SwopCount)
                {
                    break;
                }
            }
        }
    }
}
