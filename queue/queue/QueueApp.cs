using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue {
  class QueueApp {
    static void Main(string[] args) {
      Queue theQueue = new Queue(5); //queue holds 5 items

      theQueue.insert(10);
      theQueue.insert(20);
      theQueue.insert(30);
      theQueue.insert(40);

      theQueue.remove();
      theQueue.remove();
      theQueue.remove();

      theQueue.insert(50); //this will trigger wrap around
      theQueue.insert(60);
      theQueue.insert(70);
      theQueue.insert(80);

      while (!theQueue.isEmpty()) { //remove and display all items
        long n = theQueue.remove();
        Console.WriteLine(n);
        Console.WriteLine(" ");
      }
      Console.WriteLine(" ");
      Console.ReadKey();
    }
  }
}
