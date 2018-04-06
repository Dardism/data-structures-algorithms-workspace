using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack {
  class StackApp {
    static void Main(string[] args) {
      string input;
      string output;

      while (true) {
        Console.WriteLine("Ener a string: ");
        input = Console.ReadLine();

        if (input == "") { //if they quit (hitting Enter)
          break; 
        }

        Reverser theReverser = new Reverser(input);
        output = theReverser.DoRev();

        Console.WriteLine("Reversed: " + output);
      }
    }
  }
}
