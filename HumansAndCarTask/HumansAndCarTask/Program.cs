using System;

namespace HumansAndCarTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Car();
            mercedes.Millage = 0;
            mercedes.Brand = "Mercedes";
            mercedes.Drive(20);
            mercedes.Model = "E220";
            mercedes.Drive(30);

            Console.WriteLine($"Masin {mercedes.Millage}km surulub");
        }
    }
}
