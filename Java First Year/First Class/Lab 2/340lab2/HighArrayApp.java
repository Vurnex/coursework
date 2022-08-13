/*

 	ITS-340
 	Lab 02
 	Problem 1, 2, 3, 4
 	2/3/2021
 	Laquon Hamilton
 	
*/	

public class HighArrayApp
   {
	
   public static void main(String[] args)
      {
      int maxSize = 100;            // array size
      HighArray arr;                // reference to array
      arr = new HighArray(maxSize); // create the array

      arr.insert(77);               // insert 10 items
      arr.insert(99);
      arr.insert(44);
      arr.insert(55);
      arr.insert(22);
      arr.insert(88);
      arr.insert(11);
      arr.insert(67);
      arr.insert(66);
      arr.insert(33);
      arr.insert(34); 				//extra item
      
      arr.checkArray();

      arr.display();                // display items

      int searchKey = 54;           // search for item
      if( arr.find(searchKey) )
      {
    	  	System.out.println("\nFound " + searchKey);
      		arr.delete(55);
      		arr.setValue(searchKey);
      }
      else
      {
    	  	System.out.println("\nCan't find " + searchKey + ". It will be added into the array");
    	  	arr.insert(searchKey);
    	  	arr.setValue(searchKey);
      }
      
      
      
      //arr.checkArray();
      
      //arr.delete(00);               // delete 3 items
      
      //arr.delete(99);
      
      
      
      arr.display();                // display items again
      
      //arr.setValue(searchKey);
      
      arr.getMin();
      }  // end main()
   }  // end class HighArrayApp
