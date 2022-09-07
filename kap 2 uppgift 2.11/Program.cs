using System;

namespace Uppgift_2._11
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur långt hoppade Alma?");
            string längdText = Console.ReadLine();
            double längd= double.Parse(längdText);
            double skillnad = 10.5 - längd;

            Console.WriteLine("Elin hoppade" + 3 + "meterhögre");
        }
    }
}
