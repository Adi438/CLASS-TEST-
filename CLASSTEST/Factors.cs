using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSTEST
{
    internal class Factors
    {
        public void Fact()
        {
            Console.WriteLine("Welcome to Factor");
            Console.WriteLine("Enter a number to check: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                  Console.WriteLine(i);
                }
            }
           
            Console.ReadLine();
        }
    }
}

    
    
