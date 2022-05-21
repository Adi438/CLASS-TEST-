using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSTEST
{
    internal class Anonymous
    {
        public class AnonymousMethods
        {
            public delegate string GreetingsDelegate(string name);
            public static string Greetings(string name)
            {
                return "Hello @" + name + " Welcome to Anonymous Program";
            }
            static void Main(string[] args)
            {
                GreetingsDelegate gd = new GreetingsDelegate(AnonymousMethods.Greetings);
                string GreetingsMessage = gd.Invoke("Aaditya");
                Console.WriteLine(GreetingsMessage);
                Console.ReadKey();
            }
        }
    }
}    
                    
