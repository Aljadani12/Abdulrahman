/* 
C# program to demonstrate use the of arithmetic operators 
 */
using System;
using System.IO;
using System.Text;

namespace IncludeHelp {
    class Test {
        // Main Method 
        static void Main (string[] args) {
            // initializing variables
            int a = 10;
            int b = 3;

            int sum = a + b; // addition
            int sub = a - b; // substraction
            int mul = a * b; // multiplicaion
            float div = (float) a / (float) b; // division
            int rem = a % b; // getting modulus

            // Displaying Output on the console.
            Console.WriteLine ("Addition of {0} and {1} is = {2}", a, b, sum);
            Console.WriteLine ("Subtraction of {0} and {1} is = {2}", a, b, sub);
            Console.WriteLine ("Multiplication of {0} and {1} is = {2}", a, b, mul);
            Console.WriteLine ("Division of {0} and {1} is = {2}", a, b, div);
            Console.WriteLine ("Remainder of {0} and {1} is = {2}", a, b, rem);

            //hit ENTER to exit the program
            Console.ReadLine ();
        }
    }
}
/**
 * Addition of 10 and 3 is = 13
 * Subtraction of 10 and 3 is = 7
 * Multiplication of 10 and 3 is = 30
 * Division of 10 and 3 is = 3.333333
 * Remainder of 10 and 3 is = 1
 *
 */
