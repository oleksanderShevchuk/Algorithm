namespace SortAlgorithms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FillButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSortBtn = new System.Windows.Forms.Button();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.SwopLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Addbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 68);
            this.panel1.TabIndex = 0;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(341, 27);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(87, 23);
            this.Addbutton.TabIndex = 2;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить число";
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(12, 28);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(323, 22);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 65);
            this.panel2.TabIndex = 1;
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(341, 27);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(87, 23);
            this.FillButton.TabIndex = 2;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заполнить массив случайними числами";
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(12, 28);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(323, 22);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(448, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 143);
            this.panel3.TabIndex = 2;
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.Location = new System.Drawing.Point(12, 149);
            this.BubbleSortBtn.Name = "BubbleSortBtn";
            this.BubbleSortBtn.Size = new System.Drawing.Size(94, 23);
            this.BubbleSortBtn.TabIndex = 3;
            this.BubbleSortBtn.Text = "BubbleSort";
            this.BubbleSortBtn.UseVisualStyleBackColor = true;
            this.BubbleSortBtn.Click += new System.EventHandler(this.BubbleSortBtn_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(12, 186);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(54, 16);
            this.TimeLbl.TabIndex = 4;
            this.TimeLbl.Text = "Время: ";
            // 
            // CompareLbl
            // 
            this.CompareLbl.AutoSize = true;
            this.CompareLbl.Location = new System.Drawing.Point(12, 213);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(165, 16);
            this.CompareLbl.TabIndex = 5;
            this.CompareLbl.Text = "Количество сравнений: ";
            // 
            // SwopLbl
            // 
            this.SwopLbl.AutoSize = true;
            this.SwopLbl.Location = new System.Drawing.Point(12, 240);
            this.SwopLbl.Name = "SwopLbl";
            this.SwopLbl.Size = new System.Drawing.Size(151, 16);
            this.SwopLbl.TabIndex = 6;
            this.SwopLbl.Text = "Количество обменов: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 449);
            this.Controls.Add(this.SwopLbl);
            this.Controls.Add(this.CompareLbl);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.BubbleSortBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSortBtn;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Label SwopLbl;
    }
}

