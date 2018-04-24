using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
  class Link {
    public double dData; //data item
    public Link next;

    public Link(double dd) {
      dData = dd;
    }

    public void displayLink() {
      Console.Write(dData + " ");
    }
  }
}
