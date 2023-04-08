using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2._4_OOP
{
    struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;
        public override string ToString()
        {
            return string.Format($"Собаку породи {Mark} звати {Name}, йому {Age} років.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog;
            Console.Write("Enter dog's name: ");
            myDog.Name = Console.ReadLine();
            Console.Write("Enter dog's mark: ");
            myDog.Mark = Console.ReadLine();
            Console.Write("Enter dog's age: ");
            myDog.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write(myDog);

            Console.ReadKey();
        }
    }
}
