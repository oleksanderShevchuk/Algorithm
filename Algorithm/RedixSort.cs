using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class RedixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public RedixSort(IEnumerable<T> items) : base(items) { }
        public RedixSort() { }
        protected override void MakeSort()
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }
            int length = GetMaxLength();
            for (int step = 0; step < length; step++)
            {
                // Розпределение елементов по корзине
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }
                Items.Clear();

                // Сборка елементов
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Items.Add(item);
                    }
                }
                // Очистка корзини
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }
        private int GetMaxLength()
        {
            var length = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Порозрядна сортировка поддерживаєт только целие числа", nameof(item));
                }
                // var l = Convert.ToInt32(Math.Log10(item.GetHashCode()) + 1); // Не работает со значением item = 0
                var l = item.GetHashCode().ToString().Length;
                if (l > length)
                {
                    length = l;
                }
            }
            return length;
        }
    }
}
