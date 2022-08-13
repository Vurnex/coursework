/*

 	ITS-340
 	Lab 03
 	Problem 1, 2
 	2/9/2021
 	Laquon Hamilton
 	
*/	

public class HighArrayApp
   {
	
   public static void main(String[] args)
      {
      int maxSize = 100;            // array size
      HighArray arr;                // reference to array
      arr = new HighArray(maxSize); // create the array

      //original order
      
      
      arr.insert(77);               // insert 10 items
      arr.insert(99);
      arr.insert(44);
      arr.insert(55);
      arr.insert(22);
      arr.insert(88);
      arr.insert(33);
      arr.insert(67);
      arr.insert(66);
      arr.insert(33);
      arr.insert(33);
      
      							//extra item
      
      //ascending order
      
      /*
      arr.insert(22);      
      arr.insert(33);      
      arr.insert(33);
      arr.insert(33);      
      arr.insert(44);      
      arr.insert(55);      
      arr.insert(66);      
      arr.insert(67);
      arr.insert(77);
      arr.insert(88);               
      arr.insert(99);
      */
      
      //descending order 
      /*     
      arr.insert(99);
      arr.insert(88);      
      arr.insert(77);      
      arr.insert(67);      
      arr.insert(66);       
      arr.insert(55);      
      arr.insert(44);      
      arr.insert(33);      
      arr.insert(33);      
      arr.insert(33);      
      arr.insert(22);  
      */         




      
      arr.checkArray();

      arr.display();                // display items

      int searchKey = 33;           // search for item
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
      
      arr.noDups();
      
      System.out.println("Duplicates removed\n");
      
      arr.display();
      
      arr.isSorted();
      
      }  // end main()
   }  // end class HighArrayApp
