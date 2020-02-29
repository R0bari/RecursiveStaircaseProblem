using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveStaircaseProblem
{
    class Program
    {
        static int CalculateCases(int currentStep, int resultStep)
        {
            if (currentStep < resultStep - 1)
            {
                return CalculateCases(currentStep + 1, resultStep) + CalculateCases(currentStep + 2, resultStep);
            }
            else if (currentStep == resultStep - 1)
            {
                return CalculateCases(currentStep + 1, resultStep);
            }
            else if (currentStep == resultStep)
            {
                return 1;
            }
            return 0;
        }
        static void Main()
        {
            bool repeat;
            do
            {
                Console.WriteLine("Enter the number of stairsteps:");
                if (!int.TryParse(Console.ReadLine(), out int N))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                Console.WriteLine("All possible cases: " + CalculateCases(0, N));

                Console.WriteLine("Enter \'y\' to repeat:");
                repeat = Console.ReadKey().KeyChar == 'y' ? true : false;
                Console.WriteLine();

            } while (repeat);
        }
    }
}
