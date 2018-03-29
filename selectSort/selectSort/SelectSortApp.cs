using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BigO Time: N^2 - still slow, but signifintly faster than the bubble becasue of a lot less swapping
namespace selectSort {
  class SelectSortApp {
    static void Main(string[] args) {
      int maxSize = 100; //array size
      ArraySel arr = new ArraySel(maxSize);

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

      arr.selectionSort();
      arr.display();

      Console.ReadKey();

    }
  }
}
