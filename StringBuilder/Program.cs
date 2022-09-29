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
            //StringBuilder stringbuilder = new StringBuilder("Hello to all");
            //float salary = 25000.00f;
            //Console.WriteLine(stringbuilder);

            //stringbuilder.Append(" My name is Rohan");
            //Console.WriteLine(stringbuilder);

            //stringbuilder.AppendFormat(" my salary is {0:C}", salary);
            //Console.WriteLine(stringbuilder);

            //stringbuilder.Insert(10, " HI ");
            //Console.WriteLine(stringbuilder);

            //stringbuilder.Replace("Rohan", "Suraj");
            //Console.WriteLine(stringbuilder);

            //stringbuilder.Remove(6, 11);
            //Console.WriteLine(stringbuilder);



            StringBuilder stringBuilder = new StringBuilder("Hello to all");
            Console.WriteLine("------string builder class----------");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.GetHashCode());
            stringBuilder.Append(" My name is Rohan");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.GetHashCode());
            Console.WriteLine("------string class ---------");
            string s1 = "Hello to all";
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());

            s1 = s1 + " This is sample code";
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());

        }
    }
}
