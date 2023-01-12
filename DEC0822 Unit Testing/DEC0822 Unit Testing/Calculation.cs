using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEC0822_Unit_Testing
{
    public class Calculator
    {
        int a; // Fields or Data Members
        int b;

        public int A  // Property for A - Fully Implemented
        {
            get { return a; } // Mutator and Accessor Functions
            set 
            { 
                if (value < 0)
                {
                    throw new Exception("Negative Value is Not Allowed");
                }
                else
                {
                    a = value;
                }
            }
        }

        public int B
        {
            get { return b; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Negative Value is Not Allowed");
                }
                else
                {
                    a = value;
                }
            }
        }

        public Calculator(int val1, int val2) // Constructor
        {
            A = val1;
            B = val2;
        }

        public int Add()
        {
            return A + B;
        }
    }

}
