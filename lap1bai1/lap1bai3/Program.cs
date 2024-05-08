using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap1bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(3,7);
            int resultCong = calculator.Cong();
            Console.WriteLine("Cong: " + resultCong);
            Console.ReadLine();
        }
    }
}
