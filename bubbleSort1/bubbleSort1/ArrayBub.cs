using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort {
  class ArrayBub {
    private long[] a;
    private int nElems;

    public ArrayBub(int max) {
      a = new long[max];
      nElems = 0;
    }
    //***********************************
    public void insert(long value) {
      a[nElems] = value;
      nElems++;
    }
    //***********************************
    public void display() {
      for (int j = 0; j < nElems; j++) {
        Console.Write(a[j] + "  ");
      }
      Console.WriteLine("");
    }
    //***********************************
    public void bubbleSort() {
      int inner;
      int outer;

      for (outer = nElems - 1; outer > 1; outer--) {
        for (inner = 0; inner < outer; inner++) {
          if (a[inner] > a[inner + 1]) {
            swap(inner, inner + 1);
          }
        }
      }
    }
    //***********************************
    public void swap(int one, int two) {
      long temp = a[one];
      a[one] = a[two];
      a[two] = temp;
    }
  }
}
