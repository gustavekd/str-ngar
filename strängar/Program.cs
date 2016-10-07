using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strängar
{
    class Program
    {
        static void Main(string[] args)
        //övning1
        {
            Console.WriteLine("\u0056\u00E4\u0157\u006D\u0064\u00F6\0\u0047\u0079\u006D\u006E\u0061\u0073\u0069\u0075\u006D");


            //övning2,3a,b

            string myString = "Hello World";
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.ToLower());

            //övning 4        
            Console.WriteLine("Hello World är " + myString.Length + " tecken lång");

            //övning 5 
            Console.Write("skriv en text: ");
            string bakofram = Console.ReadLine();

            for (int i = bakofram.Length - 1; i >= 0; i--)
            {
                Console.Write(bakofram[i]);
            }

                      

        }

    }
}
