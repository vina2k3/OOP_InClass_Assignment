using System;

namespace OOP_InClass_Assignment
{
    class Car
    {
        public string color = "red";
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }
    class MyClass
    {
        string color = "red";
        int maxSpeed = 200;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

}
