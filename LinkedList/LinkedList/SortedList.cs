using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
  class SortedList {
    private Link _first;

    public SortedList() {
      _first = null;
    }

    public bool isEmpty() {
      return (_first == null);
    }

    public void insert(long key) {
      Link newLink = new Link(key); //make new link
      Link previous = null;
      Link current = _first;  //start at first

      while (current != null && key > current.dData) { //until end o flist, OR key is > current
        previous = current;
        current = current.next;
      }
      if (previous == null) {
        _first = newLink;
      }
      else {
        previous.next = newLink;
      }

      newLink.next = current;
    }

    public Link remove() {
      Link temp = _first;
      _first = _first.next;
      return temp;
    }

    public void displayList() {

    }

  }
}
