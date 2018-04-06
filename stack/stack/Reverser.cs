using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack {
  class Reverser {
    private string _input;
    private string _output;

    public Reverser(string input) {
      _input = input;
    }

    public string DoRev() {
      int stackSize = _input.Length;
      StackX theStack = new StackX(stackSize);

      for (int j = 0; j < _input.Length; j++) {
        char ch = _input[j]; //get char at index
        theStack.push(ch);  //push it
      }

      _output = "";
      while (!theStack.isEmpty()) {
        char ch = theStack.pop();
        _output = _output + ch;
      }

      return _output;
    }
  }
}
