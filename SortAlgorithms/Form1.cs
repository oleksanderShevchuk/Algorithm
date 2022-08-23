﻿using Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
            }
            RefreshItems();
            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(100), items.Count);
                    items.Add(item);
                }
            }
            RefreshItems();
            FillTextBox.Text = "";
        }
        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();
            foreach (var item in items)
            {
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Lable);
            }
            panel3.Refresh();
        }
        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }
            DrawItems(items);
        }
        private void BubbleSortBtn_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            BtnClick(bubble);
        }

        private void Algorithm_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            panel3.Refresh();
        }

        private void Algorithm_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();

            Thread.Sleep(110);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();
        }

        private void BtnClick(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            algorithm.CompareEvent += Algorithm_CompareEvent;
            algorithm.SwopEvent += Algorithm_SwopEvent;
            var time = algorithm.Sort();

            TimeLbl.Text = "Время: " + time.Seconds;
            CompareLbl.Text = "Количество сравнений: " + algorithm.ComparisonCount;
            SwopLbl.Text = "Количество обменов: " + algorithm.SwopCount;
        }

        private void CocktailSortBtn_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            BtnClick(cocktail);
        }
        private void InsertSortBtn_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            BtnClick(insert);
        }
        private void ShellSortBtn_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            BtnClick(shell);
        }

        private void TreeSortBtn_Click(object sender, EventArgs e)
        {
            var tree = new TreeSort<SortedItem>(items);
            BtnClick(tree);
        }

        private void HeapSortBtn_Click(object sender, EventArgs e)
        {
            var heap = new HeapSort<SortedItem>(items);
            BtnClick(heap);
        }

        private void BaseSortBtn_Click(object sender, EventArgs e)
        {
            var bases = new AlgorithmBase<SortedItem>(items);
            BtnClick(bases);
        }

        private void SelectionSortBtn_Click(object sender, EventArgs e)
        {
            var selection = new SelectionSort<SortedItem>(items);
            BtnClick(selection);
        }
    }
}
