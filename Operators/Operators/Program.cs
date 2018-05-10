using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operators.Maths;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LasName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            calculator.Add(1, 2);
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
