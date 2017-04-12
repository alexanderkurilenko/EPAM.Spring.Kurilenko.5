using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Logic
{
    public class CustomPolinomial
    {
        #region Fields
        private SortedDictionary<int, double> polinomialElements = new SortedDictionary<int, double>();
        #endregion

        #region Ctors
        
        public CustomPolinomial()
        {
            
        }
        /// <summary>
        /// Constructor with 2 params
        /// </summary>
        /// <param name="powers">Polynoms powers</param>
        /// <param name="coefficients">Polynoms coefficients</param>
        public CustomPolinomial(int[] powers, double[] coefficients)
        {
            if (coefficients.Length == 0)
                throw new ArgumentException("Empty array of coefficients.");

            if (powers.Length == 0)
                throw new ArgumentException("Empty array of powers");

            if (coefficients.Length != powers.Length)
                throw new ArgumentException("Array of powers must have the same counts of elements of coefficient array.");

            for (int i = 0; i < powers.Length; i++)
            {
                if (coefficients[i] != 0)
                {
                    if (polinomialElements.ContainsKey(powers[i]))
                    {
                        polinomialElements[powers[i]] += coefficients[i];
                    }
                    else
                    {
                        polinomialElements.Add(powers[i], coefficients[i]);
                    }
                }
            }

        }

        public CustomPolinomial(int[] powers)
        {
            if (powers.Length == 0)
                throw new ArgumentException("Empty array of powers");
            if (HasDuplicatesPowers(powers))
                throw new ArgumentException("Array of powers has duplicates");

            for (int i = 0; i < powers.Length; i++)
            {
                polinomialElements.Add(powers[i], 1);
            }

        }
        #endregion

        #region Methods

        public bool Equals(CustomPolinomial polinomial)
        {
            if (this.polinomialElements.Count != polinomial.polinomialElements.Count)
                return false;

            foreach (var element in polinomial.polinomialElements)
            {
                if (this.polinomialElements[element.Key] != element.Value)
                {
                    return false;
                }
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(CustomPolinomial))
                throw new ArgumentException("Argument isn't CustomPolinomial type");

            return this.Equals((CustomPolinomial)obj);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = polinomialElements.Count - 1; i >= 0; i--)
            {

                if (polinomialElements.Keys.ElementAt(i) == 0)
                {
                    result.Append(polinomialElements.Values.ElementAt(i));
                }
                else
                {
                    if (polinomialElements.Keys.ElementAt(i) == 1)
                    {
                        result.Append(String.Format(" {0}x ", polinomialElements.Values.ElementAt(i)));
                    }
                    else
                    {
                        result.Append(String.Format(" {0}x^{1}", polinomialElements.Values.ElementAt(i), polinomialElements.Keys.ElementAt(i)));
                    }
                }
            }

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion

        #region Operators
        public static CustomPolinomial operator +(CustomPolinomial p1, CustomPolinomial p2)
        {
            return SummatorOfPolinomials(p1, p2,(a,b) => a+b);            
        }

        public static CustomPolinomial operator -(CustomPolinomial p1, CustomPolinomial p2)
        {
            return SummatorOfPolinomials(p1, p2, (a, b) => a - b);
        }

        public static CustomPolinomial operator *(CustomPolinomial p1, CustomPolinomial p2)
        {
           return  MultiplyOfPolinomials(p1, p2);
        }

        public static bool operator ==(CustomPolinomial p1, CustomPolinomial p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(CustomPolinomial p1, CustomPolinomial p2)
        {
            return !p1.Equals(p2);
        }
        #endregion

        #region Private Methods
        
        /// <summary>
        /// Checking for duplicate powers
        /// </summary>
        /// <param name="powers"></param>
        /// <returns></returns>
        private bool HasDuplicatesPowers(int[] powers)
        {
            var duplicates = new List<int>();
            foreach (int element in powers)
            {
                if (duplicates.Contains(element))
                {
                    return false;
                }
                else
                {
                    duplicates.Add(element);
                }
            }

            return true;
        }

        /// <summary>
        /// Multiplication of 2 polynoms
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        private static CustomPolinomial MultiplyOfPolinomials(CustomPolinomial p1, CustomPolinomial p2)
        {
            int countOfElements = p1.polinomialElements.Count * p2.polinomialElements.Count + 1;
            int[] powers = new int[countOfElements];
            double[] coefficient = new double[countOfElements];

            for (int i = 0; i < p1.polinomialElements.Count; i++)
            {
                for (int j = 0; j < p2.polinomialElements.Count; j++)
                {
                    int resultPower = p1.polinomialElements.Keys.ElementAt(i) + p2.polinomialElements.Keys.ElementAt(j);
                    double resultCoefficieent = p1.polinomialElements.Values.ElementAt(i) * p2.polinomialElements.Values.ElementAt(j);
                    powers[i * p2.polinomialElements.Count + j] = resultPower;
                    coefficient[i * p2.polinomialElements.Count + j] += resultCoefficieent;
                }
            }
            return new CustomPolinomial(powers, coefficient);
        }

        /// <summary>
        /// Adding and Substraction method
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        private static CustomPolinomial SummatorOfPolinomials(CustomPolinomial p1, CustomPolinomial p2, Func<double, double, double> operation)
        {
            int countOfElements = p1.polinomialElements.Count + p2.polinomialElements.Count;
            int[] powers = new int[countOfElements];
            double[] coefficient = new double[countOfElements];

            for (int i = 0; i < p1.polinomialElements.Count; i++)
            {
                int position = p1.polinomialElements.Keys.ElementAt(i);
                powers[i] = position;
                if (p2.polinomialElements.Keys.Contains(position))
                {
                    coefficient[i] = operation(p1.polinomialElements.Values.ElementAt(i), p2.polinomialElements[position]);
                }
                else
                {
                    coefficient[i] = p1.polinomialElements.Values.ElementAt(i);
                }
            }

            int adder = p1.polinomialElements.Count;
            for (int i = 0; i < p2.polinomialElements.Count; i++)
            {
                int power = p2.polinomialElements.Keys.ElementAt(i);
                if (!p1.polinomialElements.Keys.Contains(power))
                {
                    powers[i + adder] = power;
                    coefficient[i + adder] = operation(0,p2.polinomialElements[power]);   
                }
            }
            return new CustomPolinomial(powers, coefficient);
        }
        #endregion
    }
}
