//Aaron D
//9/12/19
// ISM 4300
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //a write line statement for integer values from 1-100
            Console.WriteLine("Enter a integer value between 1 and 100.");
            try
            {
                //creating a sting to hold the variables through the code.
                string input = Console.ReadLine();
                int new_input = int.Parse(input);

                if ((new_input >= 1) && (new_input <= 100))
                    for (int i = 1; i < new_input + 1; i++)
                        //Having the system write a line and including the variable.
                        Console.WriteLine("You have entered " + i + " This is the current integer value in the loop: " + i);

                Console.WriteLine("Please press Enter to end this program.");
                Console.ReadLine();
            }
            // a catch for errors
            catch
            {
                Console.WriteLine("An Error has occured");
            }

        }

    }
}

