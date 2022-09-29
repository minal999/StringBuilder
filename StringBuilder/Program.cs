using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringbuilder = new StringBuilder("Hello to all");
            float salary = 25000.00f;
            Console.WriteLine(stringbuilder);

            stringbuilder.Append(" My name is Rohan");
            Console.WriteLine(stringbuilder);

            stringbuilder.AppendFormat(" my salary is {0:C}", salary);
            Console.WriteLine(stringbuilder);

            stringbuilder.Insert(10, " HI ");
            Console.WriteLine(stringbuilder);

            stringbuilder.Replace("Rohan", "Suraj");
            Console.WriteLine(stringbuilder);

            stringbuilder.Remove(6, 11);
            Console.WriteLine(stringbuilder);


        }
    }
}
