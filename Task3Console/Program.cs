using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3Logic;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomPolinomial a = new CustomPolinomial(new int[3] { 2,1,0 }, new double[3] { 3,18,-8 });
            CustomPolinomial b = new CustomPolinomial(new int[4] { 15,3,2,0 }, new double[4] { 1,8,-20,5 });
            CustomPolinomial c = new CustomPolinomial(new int[4] { 15, 3, 2, 0 }, new double[4] { 1, 8, -20, 5 });

            Console.WriteLine((a*b).ToString());
            Console.ReadKey();
        }
    }
}
