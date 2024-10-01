using System;
using System.Windows.Forms;

namespace MoneyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int five;
        int ten;
        int fiveCount;
        int tenCount;
        int summ;
        private void AddFive_Click(object sender, EventArgs e)
        {
            AddFiveCount();
            UpdateCountTextBox();
            UpdateSummTextBox();
        }
        private void AddTen_Click(object sender, EventArgs e)
        {
            AddTenCount();
            UpdateCountTextBox();
            UpdateSummTextBox();
        }
        private void LessFive_Click(object sender, EventArgs e)
        {
            MinusFiveClick();
            UpdateCountTextBox();
            UpdateSummTextBox();
        }
        private void LessTen_Click(object sender, EventArgs e)
        {
            MinusTenClick();
            UpdateCountTextBox();
            UpdateSummTextBox();
        }

        private void AddFiveCount()
        {
            fiveCount += 20;
            CountFive.Text = fiveCount.ToString();
        }
        private void AddTenCount()
        {
            tenCount += 10;
            CountTen.Text = tenCount.ToString();
        }

        private void MinusFiveClick()
        {

            if (fiveCount <= 0)
            {
                fiveCount = 0;
            }
            else
            {
                fiveCount -= 20;
                CountFive.Text = fiveCount.ToString();
            }
        }
        private void MinusTenClick()
        {
            if (tenCount <= 0)
            {
                tenCount = 0;
            }
            else
            {
                tenCount -= 10;
                CountTen.Text = tenCount.ToString();
            }
        }


        private void UpdateCountTextBox()
        {
            CountCoins.Text = $"{fiveCount + tenCount}";
        }
        private void UpdateSummTextBox()
        {
            SummTextBox.Text = $"{fiveCount * 5 + tenCount * 10}";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
