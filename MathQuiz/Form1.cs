using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer to generate random numbers.
        Random randomizer = new Random();
        // These integer variables store the numbers for the addition problem.
        int addend1, addend2;
        // These integer variables store the numbers for the subtraction problem.
        int minuend, subtrahend;
        // These integer variables store the numbers for the multiplication problem.
        int multiplicand,multiplier;
        // These integer variables store the numbers for the division problem.
        int dividend, divisor;
        // This integer variable keeps track of thr remaining time.
        int timeLeft;

        private void btnstart_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            btnstart.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If the user got all the answers right, stop the timer and show a message.
                timer1.Stop();
                MessageBox.Show("Congratulations! You got all the answers right!", "Congratulations!");
                btnstart.Enabled = true; // Enable the start button for a new quiz.
            }
            else if (timeLeft > 0)
            {
                // If there is still time left, decrease the time left by one second.
                timeLeft--;
                lbltime.Text = timeLeft + " seconds"; // Update the label to show the remaining time.
                if (timeLeft < 6)
                {
                    lbltime.BackColor = Color.Red; // Change the label color to red when time is running out.
                }
            }
            else
            {
                // If there is no time left, stop the timer and show a message.
                lbltime.BackColor = Color.White;
                timer1.Stop();
                lbltime.Text = "Time's up!";
                MessageBox.Show("Sorry, you didn't finish in time.", "Time's up!");
                sum.Value = addend1 + addend2; // Show the correct answer for addition.
                difference.Value = minuend - subtrahend; // Show the correct answer for subtraction.
                product.Value = multiplicand * multiplier; // Show the correct answer for multiplication.
                quotient.Value = dividend / divisor; // Show the correct answer for division.
                btnstart.Enabled = true; // Enable the start button for a new quiz.
            }
                
            }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown; // Cast the sender to NumericUpDown.
            if (answerBox != null) // Check if the cast was successful.
            {
                answerBox.Select(0, answerBox.Text.Length); // Select all text in the NumericUpDown control.
            }
        }

       

        private bool CheckTheAnswer()   //Check the answers to see if the user got everything right.
        {
            if ((addend1 + addend2 == sum.Value) && (minuend - subtrahend == difference.Value) &&
                (multiplicand * multiplier == product.Value) && (dividend / divisor == quotient.Value))
            {
                return true; // All answers are correct.
            }
            else
            {
                return false; // At least one answer is incorrect.
            }
            {

            }
        }
        public void StartTheQuiz()
        {
            // Fill in the addition problem. 
            // Generate two random numbers to add. 
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1= randomizer.Next(51); // Random number between 0 and 50
            addend2 = randomizer.Next(51); // Random number between 0 and 50
            // Convert the two randomly generated numbers into strings so that they can be displayed in the label controls.
            lblplusLeft.Text = addend1.ToString();
            lblplusRight.Text = addend2.ToString();
            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before adding any values to it.
            sum.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(0, 101); // Random number between 0 and 100
            subtrahend = randomizer.Next(1, minuend); // Random number between 1 and minuend
            lblminusLeft.Text= minuend.ToString();
            lblminusRight.Text = subtrahend.ToString();
            difference.Value= 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11); // Random number between 2 and 10
            multiplier = randomizer.Next(2, 11); // Random number between 2 and 10
            lbltimesLeft.Text = multiplicand.ToString();
            lbltimesRight.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11); // Random number between 2 and 10
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient; // Ensure the dividend is a multiple of the divisor
            lbldividedLeft.Text= dividend.ToString();
            lbldividedRight.Text = divisor.ToString();
            quotient.Value = 0;

            // Start the timer.
            timeLeft = 30; // Set the time limit to 30 seconds.
            lbltime.Text = timeLeft + " seconds"; // Update the label to show the remaining time.
            timer1.Start(); // Start the timer.
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
