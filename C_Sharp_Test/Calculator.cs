using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Test
{
    public partial class Calculator : Form
    {

        //The numerical display is in charge of displaying the numbers in the text box
        NumericDisplay myNumericDisplay = new NumericDisplay();
        //The math operation object is in charge of all the arthimetic 
        MathOperations myMathOperations = new MathOperations();
        
        public Calculator()
        {
            InitializeComponent();
            textBox1.Text = myNumericDisplay.GetNumbers();
        }



        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Each number buttons when click add a number to the list and updates the numerical display
            myNumericDisplay.Add("7");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            myNumericDisplay.Add("1");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myNumericDisplay.Add("2");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            myNumericDisplay.Remove();
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myNumericDisplay.Add("0");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myNumericDisplay.IsPresent(".");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            myNumericDisplay.Add("3");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myNumericDisplay.Add("4");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myNumericDisplay.Add("5");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            myNumericDisplay.Add("6");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            myNumericDisplay.Add("8");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            myNumericDisplay.Add("9");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myMathOperations.setOperation("Addition");

            if (!myMathOperations.getOperationStatus())
            {
                myMathOperations.setOperationStatus();
                myMathOperations.setNumbers(myNumericDisplay.GetNumbers());
                textBox1.Text = myMathOperations.Calculate().ToString();
                myNumericDisplay.ClearList();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myMathOperations.setOperation("Substraction");

            if (!myMathOperations.getOperationStatus())
            {
                myMathOperations.setOperationStatus();
                myMathOperations.setNumbers(myNumericDisplay.GetNumbers());
                textBox1.Text = myMathOperations.Calculate().ToString();
                myNumericDisplay.ClearList();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myMathOperations.setOperation("Multiplication");

             if (!myMathOperations.getOperationStatus())
             {
                 myMathOperations.setOperationStatus();
                 myMathOperations.setNumbers(myNumericDisplay.GetNumbers());
                 textBox1.Text = myMathOperations.Calculate().ToString();
                 myNumericDisplay.ClearList();
             }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            myMathOperations.setOperation("Division");

            if (!myMathOperations.getOperationStatus())
            {
                myMathOperations.setOperationStatus();
                myMathOperations.setNumbers(myNumericDisplay.GetNumbers());
                textBox1.Text = myMathOperations.Calculate().ToString();
                myNumericDisplay.ClearList();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {   
            //Equal button
            myMathOperations.setNumbers(myNumericDisplay.GetNumbers());
            textBox1.Text = myMathOperations.Calculate().ToString();
            myNumericDisplay.ClearList();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //Clear button
            myNumericDisplay.ClearList();
            myMathOperations.ClearAll();
            myNumericDisplay.Add("0");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }
     
    }
}
