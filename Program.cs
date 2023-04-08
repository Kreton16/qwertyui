using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR._4._1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> person = new Dictionary<uint, string>();

            person.Add(1, "Stefan");
            person.Add(2, "Steven");
            person.Add(3, "Dmytro");
            person.Add(4, "Oleh");
            person.Add(5, "Nazar");
            person.Add(6, "Denys");
            person.Add(7, "Mykola");

            Console.WriteLine("Enter the id:");
            uint id = Convert.ToUInt32(Console.ReadLine());
            if (id < 1 || id > 7)
                Console.WriteLine("Invalid id");
            else
                Console.WriteLine(person[id]);

            Console.ReadKey();
        }
    }
}
