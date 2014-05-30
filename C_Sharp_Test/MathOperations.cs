using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Test
{
    class MathOperations
    {
        private float myResult; //stores the calculated value
        private string myOperation; //stores the arithemic operation to perform     
        private bool IsOperationSet; //serves as flag to know if the user has chosen an operation   
        private List<float> myNumberHistory = new List<float>(); // keeps the list of numbers calculated and entered

        public MathOperations ()
	    {
            IsOperationSet = false;
	    }

        public void ClearList()
        {
            myNumberHistory.Clear();
        }

        public void ClearAll()
        {
            myNumberHistory.Clear();
            myOperation = "";
            IsOperationSet = false;
        }

        public void setNumbers(string Numbers)
        {
            if (!string.IsNullOrEmpty(Numbers))
            {
                myNumberHistory.Add(Convert.ToSingle(Numbers));
            }
        }

        public void setOperation(string NameofOperation)
        {
            myOperation = NameofOperation;
        }

        public void setOperationStatus(bool status)
        {
            IsOperationSet = status;
        }

        public bool getOperationStatus()
        {
            return IsOperationSet;
        }

        public float Calculate()
        {
            int sizeofNumberHistory = myNumberHistory.Count;

            //Calculates the result if enough data is entered
            if (sizeofNumberHistory > 1 && !string.IsNullOrEmpty(myOperation))
            {
                if (myOperation == "Addition")
                {
                    myResult = myNumberHistory.ElementAt(sizeofNumberHistory - 2) + myNumberHistory.ElementAt(sizeofNumberHistory - 1);
                }

                else if (myOperation == "Substraction")
                {
                    myResult = myNumberHistory.ElementAt(sizeofNumberHistory - 2) - myNumberHistory.ElementAt(sizeofNumberHistory - 1);
                }

                else if (myOperation == "Multiplication")
                {
                    myResult = myNumberHistory.ElementAt(sizeofNumberHistory - 2) * myNumberHistory.ElementAt(sizeofNumberHistory - 1);
                }

                else if (myOperation == "Division")
                {
                    if (myNumberHistory.ElementAt(sizeofNumberHistory - 1) != 0)
                    {
                        myResult = myNumberHistory.ElementAt(sizeofNumberHistory - 2) / myNumberHistory.ElementAt(sizeofNumberHistory - 1);
                    }

                    else
                    {
                        MessageBox.Show("Cannot Divide By Zero", "Error");
                        return myNumberHistory.Last();
                    }
                }

                myNumberHistory[sizeofNumberHistory - 2] = myResult;
                return myResult;
                
            }

            return myNumberHistory.Last();
        }
    }
}
