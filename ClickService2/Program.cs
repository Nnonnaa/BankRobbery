using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickService2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of suspects:");
            var numberOfSuspects = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a name of suspects:");
            char[] separators = new char[] { ',', ' ', ';' };
            List <string> names = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            var guiltless = new List<string>();

            for (int i = 0; i < numberOfSuspects; i++)
            {
                Console.WriteLine($"Statements of {names[i]}");
                var statement = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < names.Count; j++)
                {
                    if (statement.Contains(names[j]))
                    {
                        guiltless.Add(names[j]);
                        guiltless.Add(names[i]);

                    }
                }                

            }

            for (int i = 0; i < guiltless.Count; i++)
            {
                if (names.Contains(guiltless[i]))
                {
                    names.Remove(guiltless[i]);
                }
            }


            if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} is guilty");
            }
            else
            {
                Console.WriteLine("Not enough information");
            }


        }
    }
}
