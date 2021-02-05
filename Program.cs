using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mr. Aldworth
            Console.WriteLine("Type a message, and I'll display it five times.");
            Console.WriteLine("Message: ");
            String message = Console.ReadLine();
            for (int i = 2; i <= 10; i = i + 2)
            {
                Console.WriteLine(i + ". " + message);
            }

            Console.ReadLine();
        }
    }
}
