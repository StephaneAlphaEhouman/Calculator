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

        NumericDisplay myNumericDisplay = new NumericDisplay();
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
            if (myMathOperations.LastOperation() != "Addition")
            {
                myMathOperations.Store(myNumericDisplay.GetNumbers(), "Addition");
                textBox1.Text = myMathOperations.Calculate().ToString();
                myNumericDisplay.ClearList();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (myMathOperations.LastOperation() != "Substraction")
            {
                myMathOperations.Store(myNumericDisplay.GetNumbers(), "Substraction");
                textBox1.Text = myMathOperations.Calculate().ToString();
                myNumericDisplay.ClearList();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (myMathOperations.LastOperation() != "Multiplication")
            {
                myMathOperations.Store(myNumericDisplay.GetNumbers(), "Multiplication");
                textBox1.Text = myMathOperations.Calculate().ToString();
                myNumericDisplay.ClearList();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (myMathOperations.LastOperation() != "Division")
            {
                myMathOperations.Store(myNumericDisplay.GetNumbers(), "Division");
                textBox1.Text = myMathOperations.Calculate().ToString();
                myNumericDisplay.ClearList();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {   
            //Equal button
            myMathOperations.Store(myNumericDisplay.GetNumbers());
            textBox1.Text = myMathOperations.Calculate().ToString();
            myNumericDisplay.ClearList();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //Clear button
            myNumericDisplay.ClearList();
            myMathOperations.ClearList();
            myNumericDisplay.Add("0");
            textBox1.Text = myNumericDisplay.GetNumbers();
        }
     
    }
}
