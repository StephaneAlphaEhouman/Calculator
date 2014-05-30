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
        private float myResult;
        private string myOperation;
        private bool IsOperationSet;
        private List<float> myNumberHistory = new List<float>();

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

        public void setOperationStatus()
        {
            IsOperationSet = true;
        }

        public bool getOperationStatus()
        {
            return IsOperationSet;
        }

        public float Calculate()
        {
            int sizeofNumberHistory = myNumberHistory.Count;

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
