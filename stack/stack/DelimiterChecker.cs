using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack {
  class DelimiterChecker {
    private string _input;

    public DelimiterChecker(string input) {
      _input = input;
    }

    public void check() {
      int stackSize = _input.Length; //get max stack size
      StackX theStack = new StackX(stackSize); //make stack

      for (int j = 0; j < _input.Length; j++) {
        char ch = _input[j];
        switch (ch) {
          case '{':
          case '[':
          case '(':
            theStack.push(ch); //push to stack
            break;
          case '}':
          case ']':
          case ')':
            if (!theStack.isEmpty()) {
              char chx = theStack.pop();
              if ((ch == '}' && chx != '{') ||
                  (ch == ']' && chx != '[') ||
                  (ch == ')' && chx != '(')) {
                Console.WriteLine("Error: " + ch + " at " + j);
              }
            }
            else {
              Console.WriteLine("Error: " + ch + " at " + j);
            }
            break;
          default:
            break;
        }
      }

      //at this point all characters have been processed
      if (!theStack.isEmpty()) {
        Console.WriteLine("Error: Missing right delimter");
      }
    }
  }
}
