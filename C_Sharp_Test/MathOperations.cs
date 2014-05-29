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
        private List<float> myNumberHistory = new List<float>();
        private List<string> myOperationHistory = new List<string>();

        public MathOperations ()
	    {
          
	    }
        
        public void Store(string Numbers, string NameofOperation)
        {
            if (!string.IsNullOrEmpty(Numbers))
            {
                myNumberHistory.Add(Convert.ToSingle(Numbers));
                myOperationHistory.Add(NameofOperation);
            }
        }

        public void Store(string Numbers)
        {
            if(!string.IsNullOrEmpty(Numbers))
            {
                myNumberHistory.Add(Convert.ToSingle(Numbers));
            }
        }

        public float Calculate()
        {
            int sizeofNumberHistory = myNumberHistory.Count;
            int sizeofOperationHistory = myOperationHistory.Count;

            if (sizeofNumberHistory > 1 && sizeofNumberHistory > 0)
            {
                if (myOperationHistory.Last() == "Addition")
                {
                    myResult = myNumberHistory.ElementAt(sizeofNumberHistory - 2) + myNumberHistory.ElementAt(sizeofNumberHistory - 1);
                }

                else if (myOperationHistory.Last() == "Substraction")
                {
                    myResult = myNumberHistory.ElementAt(sizeofNumberHistory - 2) - myNumberHistory.ElementAt(sizeofNumberHistory - 1);
                }

                else if (myOperationHistory.Last() == "Multiplication")
                {
                    myResult = myNumberHistory.ElementAt(sizeofNumberHistory - 2) * myNumberHistory.ElementAt(sizeofNumberHistory - 1);
                }

                else if (myOperationHistory.Last() == "Division")
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

            else
            {
                MessageBox.Show("Cannot Evaluate","Error"); 
            }

            return myNumberHistory.Last();
        }
    }
}
