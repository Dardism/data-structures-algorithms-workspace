using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectSort {
  class ArraySel {
    private long[] a;
    private int nElems; //number of elements

    public ArraySel(int max) {
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
    public void selectionSort() {
      int inner;
      int outer;
      int min;

      for (outer = 0; outer < nElems - 1; outer++) { //outer loop
        min = outer;                            //minimum
        for (inner = outer + 1; inner < nElems; inner++) { //inner loop
          if (a[inner] < a[min]) {  //if min is greater, we have a new min
            min = inner;
          }
        }
        swap(outer, min);
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
