using System;

namespace Operators
{
    public class Person
    {
        public string FirstName;
        public string LasName;

        public void Introduce()
        {
            Console.WriteLine("My Name is " + FirstName + " " + LasName);
        }
    }
}
