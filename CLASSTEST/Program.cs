using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSTEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
           HarmonicNumber harmonicNumber  = new HarmonicNumber();
            harmonicNumber.Harmonic();
           Factors factors = new Factors();
            factors.Fact();
            Palindrome palindrome = new Palindrome();
            palindrome.Palin();
        }
    }
}
