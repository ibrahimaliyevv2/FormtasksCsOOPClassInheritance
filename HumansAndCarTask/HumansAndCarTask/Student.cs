using System;
namespace HumansAndCarTask
{
    internal class Student : Human
    {
        public Student(string name, string surname) : base(name, surname)
        {
            Console.WriteLine("Telebe yarandi");
        }
        public string GroupNo;
    }
}
