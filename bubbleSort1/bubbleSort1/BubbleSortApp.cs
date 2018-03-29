﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort {
  class BubbleSortApp {
    static void Main(string[] args) {
      int maxSize = 100; //array size
      ArrayBub arr = new ArrayBub(maxSize);

      arr.insert(77);
      arr.insert(99);
      arr.insert(44);
      arr.insert(55);
      arr.insert(22);
      arr.insert(88);
      arr.insert(11);
      arr.insert(00);
      arr.insert(66);
      arr.insert(33);
      arr.insert(32);


      arr.display();

      arr.bubbleSort();
      arr.display();

      Console.ReadKey();

    }
  }
}
