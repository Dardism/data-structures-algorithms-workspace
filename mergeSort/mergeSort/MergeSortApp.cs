﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeSort {
  class MergeSortApp {
    static void Main(string[] args) {
      int maxSize = 100; //array size
      DArray arr = new DArray(maxSize); //create array

      arr.insert(64);
      arr.insert(21);
      arr.insert(33);
      arr.insert(70);
      arr.insert(12);
      arr.insert(85);
      arr.insert(44);
      arr.insert(3);
      arr.insert(99);
      arr.insert(0);
      arr.insert(108);
      arr.insert(36);

      arr.display();

      arr.mergeSort(); //merge then display again

      arr.display();

      Console.ReadKey();
    }
  }
}
