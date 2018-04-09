using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack {
  class StackApp {
    static void Main(string[] args) {
      string input;

      while (true) {
        Console.Write("Enter string containing delimiters: ");
        input = Console.ReadLine();
        if (input == "") { //if they quit (hitting Enter)
          break; 
        }

        DelimiterChecker theChecker = new DelimiterChecker(input);
        theChecker.check();
      }

        //while (true) { This is for testing Reverser class
        //  Console.WriteLine("Ener a string: ");
        //  input = Console.ReadLine();

        //  if (input == "") { //if they quit (hitting Enter)
        //    break; 
        //  }

        //  Reverser theReverser = new Reverser(input);
        //  output = theReverser.DoRev();

        //  Console.WriteLine("Reversed: " + output);
        //}
      }
  }
}
