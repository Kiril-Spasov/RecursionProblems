using System;
using System.Windows.Forms;

namespace RecursionProblems
{
    public partial class FormRecursion : Form
    {
        public FormRecursion()
        {
            InitializeComponent();
        }

        private void BtnProblem1_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();

            //Find out the first 10 numbers of the Fibonacci sequence
            for (long counter = 1; counter <= 10; counter++)
            {
                TxtResult.Text += counter + "\t" + Fibonacci(counter) + Environment.NewLine;
            }
        }

        private long Fibonacci(long n)
        {
            //First and second numbers of the Fibonacci sequence are 1,1,
            //so for 1st and 2nd number of the sequence we should return 1.
            //This is the base case.
            if (n <= 2)
            {
                return 1;
            }
            //Recursion step.
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();

            long number = 0;

            try
            {
                number = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Enter a number: ", "Number"));

                TxtResult.Text += "The square of " + number + " is " + Square(number);
            }
            catch (FormatException)
            {
                MessageBox.Show("You must enter a number.");
            }
        }


        private long Square(long n)
        {
            //Base case. Square(1) = 1.
            if (n == 1)
            {
                return 1;
            }
            //Recursion step. Using the formula: Square(n) = square(n-1) + 2n-1.
            else
            {
                return Square(n - 1) + 2 * n - 1;
            }
        }
    }
}
