using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Lib.Services
{
    public class SharedCalculator
    {
        public double Add(double a, double b) => a + b;
        
        public double Subtract(double a, double b) => a - b;

        public double Divide (double a, double b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }   
        }

    }
}
