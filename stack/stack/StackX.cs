using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack {
  class StackX {
    private int maxSize;
    private char[] stackArray;
    private int top;

    public StackX(int s) {
      maxSize = s;
      stackArray = new char[maxSize];
      top = -1;
    }

    public void push(char j) {
      stackArray[++top] = j;
    }

    public char pop() {
      return stackArray[top--];
    }

    public char peek() {
      return stackArray[top];
    }

    public bool isEmpty() {
      return (top == - 1);
    }

    public bool isFull() {
      return (top == maxSize - 1);
    }
  }
}
