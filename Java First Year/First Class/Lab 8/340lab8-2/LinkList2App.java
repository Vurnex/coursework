/*

 	ITS-340
 	Lab 08
 	Problem 2 (8.2)
 	3/29/2021
 	Laquon Hamilton
 	
*/

class LinkList2App
   {
   public static void main(String[] args)
      {
      LinkList theList = new LinkList();  // make list

      theList.insertFirst(10, 1.99);      // insert 4 items
      theList.insertFirst(20, 2.99);
      theList.insertFirst(30, 3.99);
      theList.insertFirst(40, 4.99);
      theList.insertFirst(50, 5.99);

      theList.displayList();              // display list
      
      theList.insertAfterN(60, 6.99, 30); //(id, data, N)
      
      theList.displayList();

      Link f = theList.find(20);          // find item
      if( f != null)
         System.out.println("Found link with key " + f.iData);
      else
         System.out.println("Can't find link");

      Link d = theList.delete(30);        // delete item
      if( d != null )
         System.out.println("Deleted link with key " + d.iData);
      else
         System.out.println("Can't delete link");

      theList.displayList();              // display list
      }  // end main()
   }  // end class LinkList2App
////////////////////////////////////////////////////////////////
