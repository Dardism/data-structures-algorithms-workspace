using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue {
  class Queue {
    private int _maxSize;
    private long[] _queArray;
    private int _front;
    private int _rear;
    private int _nItems;

    public Queue(int s) {
      _maxSize = s;
      _queArray = new long[_maxSize];
      _front = 0;
      _rear = -1;
      _nItems = 0;
    }

    public void insert(long j) {
      if (_rear == _maxSize - 1) { //deal with wrap around
        _rear = -1;
      }
      _queArray[++_rear] = j;
      _nItems++;
    }

    public long remove() { //take item from front of queue
      long temp = _queArray[_front++];
      if (_front == _maxSize) {
        _front = 0;
      }
      _nItems--;
      return temp;
    }

    public long peekFront() {
      return _queArray[_front];
    }

    public bool isEmpty() {
      return (_nItems == 0);
    }

    public bool isfull() {
      return (_nItems == _maxSize);
    }

    public int size() {
      return _nItems;
    }

  }
}
