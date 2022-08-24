﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class GnomeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public GnomeSort(IEnumerable<T> items) : base(items) { }
        public GnomeSort() { }
        public override void MakeSort()
        {
            int i = 1;
            while (i < Items.Count)
            {
                if (i == 0 || Compare(Items[i], Items[i-1]) == 1 || Compare(Items[i], Items[i - 1]) == 0)
                {
                    i++;
                }
                else
                {
                    Swop(i, i - 1);
                    i--;
                }
            }
        }
    }
}
