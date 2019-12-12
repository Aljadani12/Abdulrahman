/*
*C# program to input and print an integer number
*
*/

// code from https://www.includehelp.com/dot-net/input-and-print-an-integer-number-in-c-sharp.aspx


using System;
class ReadIntExample {
    static void Main () {
        try {
            //declare an integer variable
            int num = 0;
            //prompt message to take input
            Console.Write ("Input an integer value: ");
            num = Convert.ToInt32 (Console.ReadLine ());
            //print the value
            Console.WriteLine ("num = " + num);
        } catch (Exception ex) {
            // Print error when input is not an integer
            Console.WriteLine ("Error: " + ex.ToString ());
        }
    }
}

/*
 Output (when input value is an integer)

* Input an integer value : 200
* num = 200
* Output (when input value is a string)

Input an integer value : Hello

*Error : System.FormatException : Input string was not in the correct format
*  at System.Int32.Parse (System.String s) [0x00000] in<filename unknown>:0
*  at System.Convert.ToInt32 (System.String value) [0x00000] 
*  in<filename unknown>:0
*  at ReadIntExample.Main () [0x00000] 
*  in<filename unknown>:0
**/
