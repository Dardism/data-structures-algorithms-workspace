using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BigO: N^2 - but twice as fast as bubble sort, and faster than selection sort. fastest among the simple sorts
//good if data is already partially or mostly sorted
namespace insertionSort {
  class InsertSortApp {
    static void Main(string[] args) {
      int maxSize = 100; //array size
      ArrayIns arr = new ArrayIns(maxSize);

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

      arr.insertionSort();
      arr.display();

      Console.ReadKey();
    }
  }
}
