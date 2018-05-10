using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)

        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var ShippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(method);

            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "John", "Mary" };

            Console.WriteLine(names[1]);

            var firstName = "Mosh";
            var lastName = "text";

            var fullName = string.Format("My Name is {0}, {1}", firstName, lastName);

            var names1 = new string[3] { "John", "Jack", "Jill" };
            var formattedNames = string.Join(",", names1);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths 
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
