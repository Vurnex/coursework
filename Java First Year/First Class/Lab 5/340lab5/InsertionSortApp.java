class InsertionSortApp
   {
   public static void main(String[] args)
      {
      int maxSize = 100;            // array size
      ArrayIns arr;                 // reference to array
      arr = new ArrayIns(maxSize);  // create the array

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
      
      arr.insert(24);               // for problem 3
      arr.insert(7);
      arr.insert(3);
      arr.insert(18);
      arr.insert(5);
      arr.insert(9);

      //arr.display();                // display items

      //arr.insertionSort();          // insertion-sort them

      arr.display();                // display them again
      
      System.out.println("\nPrinting each iteration"); //for problem 3
      
      arr.insertionSort2(); //for problem 3
      
      }  // end main()
   }  // end class InsertSortApp