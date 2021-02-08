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
            Console.WriteLine("Type a message, and I'll display it five times.");
            Console.WriteLine("Message: ");
            String message = Console.ReadLine();
            for (int i = 2; i <= 10; i = i + 2)
            {
                Console.WriteLine(i + ". " + message);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task 1 - Ten Times");
            Console.WriteLine("------------------");
            Console.WriteLine();
            //Task1TenTimes();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task 2 - Counting Machine");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            //Task2CountingMachine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task 3 - Counting Machine Revisited");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Task3CountingMachineRevisited();

            Console.ReadLine();
        }
        
        // Programming Task 1 - Ten Times
        public static void Task1TenTimes()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " Pizza is delicious!");
            }
        }

        // Programming Task 2 - Counting Machine
        public static void Task2CountingMachine()
        {
            int number;
            Console.Write("What do you want me to count to? ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Programming Task 3 - Counting Machine Revisited
        public static void Task3CountingMachineRevisited()
        {
            int start, end, step;
            Console.Write("Count from: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Count to: ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Count by: ");
            step = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (step > 0) // Step must be 1 or greater in order to reach the end
            {
                for (int i = start; i <= end; i += step)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Infinite Loop Error");
            }
                          
        }
    }
}
