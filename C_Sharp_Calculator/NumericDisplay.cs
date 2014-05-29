using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Test
{
    class NumericDisplay
    {
        //This list stores the number to be displayed on the textbox
        private List<string> myNumbers = new List<string>();

        public NumericDisplay()
        {
            myNumbers.Add("0");
        }

        //Those functions adds/remove functions to be displayed
        public void Add(string number)
        {
            if (myNumbers.Count < 16)
            {
                myNumbers.Add(number);
            }

            else 
            { 
                MessageBox.Show("Cannot add anymore digits", "Error"); 
            }

            if (myNumbers.Count > 1 && myNumbers.First()=="0")
            {
                myNumbers.Remove("0");
            }

        }

        public void Remove()
        {
            if (myNumbers.Count > 1)
            {
                myNumbers.RemoveAt(myNumbers.Count - 1);
            }

            else if (myNumbers.Count == 1)
            {
                myNumbers.RemoveAt(myNumbers.Count - 1); 
                myNumbers.Add("0");
                MessageBox.Show("Cannot remove anymore digits", "Error");
            }
            
            else
            {
                myNumbers.Add("0");
                MessageBox.Show("Cannot remove anymore digits", "Error");
            }
        }

        public void IsPresent(string character)
        {
            if (myNumbers.Exists(e => e.EndsWith(character)))
            {
                MessageBox.Show("Cannot add this character multiple times", "Error"); 
            }

            else
            {
                myNumbers.Add(character);
            }

        }

        public string GetNumbers()
        {
            return String.Join(String.Empty, myNumbers);
        }

        public void ClearList()
        {
            myNumbers.Clear();
        }
    }
}
