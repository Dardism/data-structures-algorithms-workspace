using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionSort {
  class ArrayIns {
    private long[] a;
    private int nElems; //number of elements

    public ArrayIns(int max) {
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
    public void insertionSort() {
      int inner;
      int outer;

      for (outer = 1; outer < nElems; outer++) {
        long temp = a[outer];
        inner = outer;
        while (inner > 0 && a[inner - 1] >= temp) {
          a[inner] = a[inner - 1];
          --inner;
        }
        a[inner] = temp;
      }
    }
  }
}
