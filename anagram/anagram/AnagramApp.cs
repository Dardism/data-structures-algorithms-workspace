using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram {
  class AnagramApp {
    static int size;
    static int count;
    static char[] arrChar = new char[100];

    static void Main(string[] args) {
      Console.WriteLine("Enter a wor: "); //get word
      string input = getString();
      size = input.Length;
      count = 0;

      for (int j = 0; j < size; j++) {
        arrChar[j] = input[j];
      }

      doAnagram(size);
      Console.ReadKey();
    }
    //************************************************
    public static void doAnagram(int newSize) {
      if (newSize == 1) {                 //if too small, 
        return;                           //go no further
      }

      for (int j = 0; j < newSize; j++) { //for each position
        doAnagram(newSize - 1);           //anagram remaining
        if (newSize == 2) {               //if innermost, 
          displayWord();                  //display it
        }
        rotate(newSize);                  //rotate word
      }
    }
    //************************************************
    public static void rotate(int newSize) {
      int j;                            
      int position = size - newSize;
      char temp = arrChar[position];          //save first letter

      for (j = position + 1; j < size; j++) { //shift others left
        arrChar[j - 1] = arrChar[j];
      }
      arrChar[j - 1] = temp;                  //put first on right
    }
    //************************************************
    public static void displayWord() {
      if (count < 99) {
        Console.Write(" ");
      }
      if (count < 9) {
        Console.Write(" ");
      }
      Console.Write(++count + " ");

      for (int j = 0; j < size; j++) {
        Console.Write(arrChar[j]);
      }
      Console.Write(" ");

      if ((count % 6) == 0) {
        Console.Write("");
      }
    }
    //***********************************************
    public static String getString() {
      string s = Console.ReadLine();
      return s;
    }
  }
}
