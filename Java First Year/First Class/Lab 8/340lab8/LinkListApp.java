/*

 	ITS-340
 	Lab 08
 	Problem 1 (8.1)
 	3/29/2021
 	Laquon Hamilton
 	
*/


class LinkListApp
   {
   public static void main(String[] args)
      {
      LinkList theList = new LinkList();  // make new list

      theList.insertFirst(22, 2.99);      // insert four items
      theList.insertFirst(44, 4.99);
      theList.insertFirst(66, 6.99);
      theList.insertFirst(88, 8.99);
      
      theList.insertArrays(null, null);

      theList.displayList();              // display list

      while( !theList.isEmpty() )         // until it's empty,
         {
         Link aLink = theList.deleteFirst();   // delete link
         System.out.print("Deleted ");         // display it
         aLink.displayLink();
         System.out.println("");
         }
      theList.displayList();              // display list
      
      //theList.insertArrays(null, null);
      
      //theList.displayList(); 
      }  // end main()
   }  // end class LinkListApp
////////////////////////////////////////////////////////////////
