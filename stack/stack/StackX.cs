using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack {
  class StackX {
    private int maxSize;
    private long[] stackArray;
    private int top;

    public StackX(int s) {
      maxSize = s;
      stackArray = new long[maxSize];
      top = -1;
    }

    public void push(long j) {
      stackArray[++top] = j;
    }

    public long pop() {
      return stackArray[top--];
    }

    public long peek() {
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
