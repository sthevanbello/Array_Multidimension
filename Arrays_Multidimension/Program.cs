using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Multidimension
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] result = new string[3, 3]
            {
                {"Alemanha", "Espanha", "Itália" },
                {"Argentina", "Holanda", "França" },
                {"Holanda", "Alemanha", "Alemanha"}
            };

            
            for (int copa = 0; copa < 3; copa++)
            {
                int ano = 2014 - (copa * 4);
                Console.Write(ano.ToString().PadRight(14));

            }
            Console.WriteLine();
            for (int i = 0; i <= result.GetUpperBound(0); i++)
            {
                
                for (int j = 0; j <= result.GetUpperBound(1); j++)
                {
                    Console.Write($"{result[i, j].PadRight(14)}");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
