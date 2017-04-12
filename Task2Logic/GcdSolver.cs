using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    public class GcdSolver
    {
        #region Public Methods


        public static int GetGCD(int firstNumber, int secondNumber, out double elapsedTime)
        {
            return GcdWithTimeMeasure(EuklidGcd,out elapsedTime,firstNumber,secondNumber);
        }


        public static int GetGCD(out double elapsedTime, params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("Not enough parameters");
            }

            return GcdWithTimeMeasure(EuklidGcd, out elapsedTime, numbers);
        }

        public static int GetBinaryGCD(int firstNumber, int secondNumber, out double elapsedTime)
        {
            return GcdWithTimeMeasure(SteinGcd, out elapsedTime, firstNumber, secondNumber);
        }


        public static int GetBinaryGCD(out double elapsedTime, params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("Not enough parameters");
            }

            return GcdWithTimeMeasure(SteinGcd, out elapsedTime, numbers);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Gcd with two arguments with time measure
        /// </summary>
        /// <param name="method"></param>
        /// <param name="duration"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int GcdWithTimeMeasure(Func<int, int, int> method, out double duration, int a, int b)
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            int gcd = method(a, b);
            clock.Stop();
            duration = clock.Elapsed.TotalMilliseconds;
            return gcd;
        }
    
        /// <summary>
        /// Gcd with multiple arguments
        /// </summary>
        /// <param name="method"></param>
        /// <param name="duration"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private static int GcdWithTimeMeasure(Func<int, int, int> method, out double duration, int[] numbers)
        {
            
            Stopwatch clock = new Stopwatch();
            clock.Start();
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result = method(result, numbers[i]);
            }
            clock.Stop();
            duration = clock.Elapsed.TotalMilliseconds;
            return result; 
        }

        /// <summary>
        /// Euklids algorithm implementation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int EuklidGcd(int a, int b)
        {
            if (a == 0)
                return Math.Abs(b);
            if (b == 0)
                return Math.Abs(a);
            if (a < 0)
                a = Math.Abs(a);
            if (b < 0)
                b = Math.Abs(b);
            return b == 0 ? a : EuklidGcd(b, a % b);
        }

        /// <summary>
        /// Binary gcd Stein algorithm
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>gcd(a,b)</returns>
        private static int SteinGcd(int a, int b)
        {
            if (a < 0)
                a = Math.Abs(a);
            if (b < 0)
                b = Math.Abs(b);
            if (a == b)
                return a;
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if ((~a & 1) == 1)
            {
                if ((b & 1) == 1)
                    return SteinGcd(a >> 1, b);
                else
                    return SteinGcd(a >> 1, b >> 1) << 1;
            }

            if ((~b & 1) == 1)
                return SteinGcd(a, b >> 1);

            if (a > b)
                return SteinGcd((a - b) >> 1, b);

            return SteinGcd((b - a) >> 1, a);
        }
        #endregion
    }
}
