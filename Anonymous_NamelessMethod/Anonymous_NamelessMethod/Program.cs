using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_NamelessMethod
{
    internal class Program
    {
        public delegate string GreetingsDelegate(string name);

        // named method
        public static string Greetings(string name)
        {
            return "Hello " + name + " a very good morning.";
        }
        static void Main(string[] args)
        {
            // creating instance of named method
            // GreetingsDelegate obj = new GreetingsDelegate(Greetings);

            // Anonymous/Nameless Method
            // start
            GreetingsDelegate obj = delegate (string name)
            {
                return "Hello " + name + " a very good morning.";
            };
            // end

            Console.WriteLine(obj.Invoke("Amey"));
            Console.ReadKey();
        }
    }
}
