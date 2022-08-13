/*

 	ITS-340
 	Lab 05
 	Problem 2, 5
 	2/24/2021
 	Laquon Hamilton
 	
*/

class SelectionSortApp
   {
   public static void main(String[] args)
      {
      int maxSize = 100;            // array size
      ArraySel arr;                 // reference to array
      arr = new ArraySel(maxSize);  // create the array

      /*
      arr.insert(77);               // insert 10 items
      arr.insert(99);
      arr.insert(44);
      arr.insert(55);
      arr.insert(22);
      arr.insert(88);
      arr.insert(11);
      arr.insert(00);
      arr.insert(66);
      arr.insert(33); */
      
      arr.insert(24);               // insert 10 items 24	7	3	18	5	9
      arr.insert(7);
      arr.insert(3);
      arr.insert(18);
      arr.insert(5);
      arr.insert(9);

      //arr.display();                // display items

      //arr.selectionSort();          // selection-sort them

      arr.display();                // display them again
      
      System.out.println("\nPrinting each iteration"); // for problem 2
      
      //arr.selectionSort2(); // for problem 2
      
      arr.selectionSort_Max(); // for problem 5
      }  // end main()
   }  // end class SelectSortApp
////////////////////////////////////////////////////////////////