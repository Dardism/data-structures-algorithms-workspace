using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towers {
  class TowersApp {
    static int nDisks = 3;

    static void Main(string[] args) {
      doTowers(nDisks, 'A', 'B', 'C');
      Console.ReadKey();
    }
    //************************************
    public static void doTowers(int topN, char from, char inter, char to) {
      if (topN == 1) {
        Console.WriteLine("Disk 1 from " + from + " to " + to);
      }
      else {
        doTowers(topN - 1, from, to, inter);  //from--> inter

        Console.WriteLine("Disk " + topN + " from " + from + " to " + to);
        doTowers(topN - 1, inter, from, to);
      }
    }
  }
}
