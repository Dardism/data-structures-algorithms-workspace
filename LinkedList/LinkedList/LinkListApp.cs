using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
  class LinkListApp {
    static void Main(string[] args) {
      LinkList theList = new LinkList();

      theList.insertFirst(22, 2.99);
      theList.insertFirst(44, 4.99);
      theList.insertFirst(66, 6.99);
      theList.insertFirst(88, 8.99);

      theList.displayList();

      Link f = theList.find(44);
      if (f != null) {
        Console.WriteLine("Found link with key " + f.iData);
      }
      else {
        Console.WriteLine("Can't find link");
      }


      Link d = theList.delete(66); //delete item
      if (d != null) {
        Console.WriteLine("Deleted link with key " + d.iData);
      }
      else {
        Console.WriteLine("Can't delete item");
      }


      theList.displayList();
      Console.ReadKey();
    }
  }
}
