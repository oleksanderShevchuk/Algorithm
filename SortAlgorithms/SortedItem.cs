using System;
using System.Drawing;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public class SortedItem : IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }
        public Label Lable { get; private set; }
        public int Value { get; private set; }
        public SortedItem(int value, int number)
        {
            Value = value;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Lable = new Label();
            var x = number * 20;

            // ProgressBar
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(x, 3);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar" + number;
            ProgressBar.Size = new System.Drawing.Size(18, 96);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            
            // Lable
            Lable.AutoSize = true;
            Lable.Location = new System.Drawing.Point(x, 102);
            Lable.Name = "label" + number;
            Lable.Size = new System.Drawing.Size(19, 13);
            Lable.TabIndex = 5;
            Lable.Text = Value.ToString();
        }
        public void SetValue(int value)
        {
            Value = value;
            ProgressBar.Value = value;
            Lable.Text = value.ToString();
        }
        public void SetColor(Color color)
        {
            ProgressBar.Color = color;
        }
        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }
    }
}
