using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
  class LinkList {
    private Link _first; //ref to first link on list

    public LinkList() {
      _first = null; //no items on list yet
    }

    public bool isEmtpy() {
      return (_first == null);
    }

    public void insertFirst(int id, double dd) {
      Link newLink = new Link(id, dd);
      newLink.next = _first;
      _first = newLink;
    }

    public Link find(int key) {
      Link current = _first;
      while (current.iData != key) {
        if (current.next == null) {
          return null;
        }
        else {
          current = current.next;
        }
      }
      return current;
    }

    public Link delete(int key) {
      Link current = _first;
      Link previous = _first;
      while (current.iData != key) {
        if (current.next == null) {
          return null;
        }
        else {
          previous = current; //go to next link
          current = current.next;
        }
      }
      if (current == _first) { //if first link, change first. otherwise, bypass it
        _first = _first.next;
      }
      else {
        previous.next = current.next; //shifts things to fill gap
      }
      return current;
    }

    public void displayList() {
      Console.Write("List (fisrt-->last): ");
      Link current = _first;
      while (current != null) {
        current.displayLink();
        current = current.next;
      }
      Console.WriteLine("");
    }
  }
}
