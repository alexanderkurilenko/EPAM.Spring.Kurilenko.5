using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3Logic;
using Task2Logic;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomPolinomial a = new CustomPolinomial(new int[3] { 2, 1, 0 }, new double[3] { 3, 18, -8 });
            CustomPolinomial b = new CustomPolinomial(new int[4] { 15, 3, 2, 0 }, new double[4] { 1, 8, -20, 5 });
            CustomPolinomial c = new CustomPolinomial(new int[4] { 15, 3, 2, 0 }, new double[4] { 1, 8, -20, 5 });

            double time = 0;
            int[] arr = new int[4] { 50, 100, 250, 1000 };
            GcdSolver.GetBinaryGCD(0, 0, out time);


            Console.WriteLine(GcdSolver.GetBinaryGCD(out time, -13, -13, -13, -13, -13, -13, -13, -13, -13, -13) + " " + time.ToString());
            Console.ReadKey();

        }
        
    }
}
