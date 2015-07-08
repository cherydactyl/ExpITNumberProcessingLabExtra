using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITNumberProcessingLabExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            //A program for solving the Quadratic equation
            /*
             * expects arguments a, b, and c, in that order, as integers
             * 
             * The quadratic formula
             *      X = [-b +/- Sqrt(b^2 - 4ac)] / 2a
             * solves for the root(s) X of equations in the form
             *      a(X^2) + bX + c = 0
             *      
             * Depending on whether the discriminant (b^2 - 4ac) is
             *      negative, zero, or positive,
             *      there will be 0, 1, or 2 solutions for X
             *      
             * Note the special case when a, b, and c are all 0:
             *      any X is a solution
             */

            Console.WriteLine("Extra Credit: solve the quadratic equation");
            Console.WriteLine();    //whitespace
            
            //no error handling; naive processing of input
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            int c = Convert.ToInt32(args[2]);

            //show the equation to be solved, reflecting the arguments as passed in
            //making it pretty if b and/or c are negative
            Console.WriteLine("Equation to solve:");
            Console.Write(a + "X^2 ");
            if (b < 0)
            {
                Console.Write("- " + (-b) + "X ");
            }
            else
            {
                Console.Write("+ " + b + "X ");
            }
            if (c < 0)
            {
                Console.Write("- " + (-c));
            }
            else
            {
                Console.Write("+ " + c);
            }
            Console.WriteLine(" = 0");

            Console.WriteLine();    //whitespace

            //check for all coefficients being 0's
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("For those values, any X is a solution.  Nice Try.");
            }   
            else
            {   //a, b, and c are not all equal to 0, so proceed
                //caluculate discriminant
                int discriminant = (b * b) - (4 * a * c);
                //Console.WriteLine("Discriminant = " + discriminant);  //for debugging check of discriminant

                //check status of discriminant: negative, zero, or positive
                if (discriminant < 0)
                {
                    Console.WriteLine("There is no solution.");
                }
                else if (discriminant == 0)
                {
                    Console.WriteLine("There is exactly one solution: X = " + -b / (2 * a));
                }
                else
                {
                    Console.WriteLine("There are two solutions:");
                    Console.WriteLine("X = " + (-b + Math.Sqrt(discriminant)) / (2 * a) + " and");
                    Console.WriteLine("X = " + (-b - Math.Sqrt(discriminant)) / (2 * a));

                }
            }

            //wait until the user is done
            Console.WriteLine();    //whitespace
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
    
        }
    }
}
