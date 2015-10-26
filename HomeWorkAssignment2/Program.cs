using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompts for Singles then converts to Int
            Console.WriteLine("Please Enter Number of Singles.");
            Int32 Singles = Convert.ToInt32(Console.ReadLine());
            //Prompts for DOubles then converts to Int
            Console.WriteLine("Please Enter Number of Doubles.");
            Int32 Doubles = Convert.ToInt32(Console.ReadLine());
            //Prompts for Triples then converts to Int
            Console.WriteLine("Please Enter Number of Triples.");
            Int32 Triples = Convert.ToInt32(Console.ReadLine());
            //Asks if the user is tired of entering numbers.
            Console.WriteLine("Getting Tired of Entering Numbers?");
            String Response = Console.ReadLine();
            if (Response.StartsWith("y"))
                Console.WriteLine("Thats to bad.");
            else if (Response.StartsWith("n"))
                Console.WriteLine("Ok, then.");
            else
                Console.WriteLine("Keep Going");
            //Prompts for the number of Home Runs then converts to Int
            Console.WriteLine("Please enter Number of Home Runs.");
            Int32 HomeRuns = Convert.ToInt32(Console.ReadLine());
            //Prompts for Number of times at bat and converts to int
            Console.WriteLine("Please enter amount of times at bat.");
            Int32 AtBat = Convert.ToInt32(Console.ReadLine());
            //Adds the Total number of bases (Not sure if done correctly, im not a baseball fan)
            int TotalBases = (Singles + (Doubles * 2) + (Triples * 3) + (HomeRuns * 4));
            //Converts the Total to a double and assigns it a new variable
            Double TotalBasePercent = Convert.ToDouble(TotalBases); 
            //Calculates and Prints the batting Average 
            Console.WriteLine(TotalBasePercent / AtBat);
            Console.ReadKey();
        }
    }
}
