using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    public class RootCounter
    {
        public static double GetRoot(double number, int degree, double requiredAccuracy)
        {
            if (number <= 0)
                throw new ArgumentException();
            else if (requiredAccuracy < 0)
                throw new ArgumentException();
            
            bool degreeIsNegative = false;

            if (degree < 0)
            {
                degreeIsNegative = true;
                degree = Math.Abs(degree);
            }
            
            else if (degree == 0)
                throw new ArgumentException();
            
            double result = number;
            double accuracy = 1;
            double currentValue = 0;
            
            while (accuracy >= requiredAccuracy)
            {
                currentValue = ((degree - 1) * result + number / Math.Pow(result, degree - 1)) / degree;
                accuracy = Math.Abs(result - currentValue);
                result = currentValue;
            }

            if (!degreeIsNegative)
                return result;
            else
                return Math.Round(1d / result,10);
        }
    }
}
