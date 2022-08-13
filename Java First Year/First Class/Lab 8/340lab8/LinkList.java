/*

 	ITS-340
 	Lab 08
 	Problem 1 (8.1)
 	3/29/2021
 	Laquon Hamilton
 	
*/

////////////////////////////////////////////////////////////////
class LinkList
   {
   private Link first;            // ref to first link on list

// -------------------------------------------------------------
   public LinkList()              // constructor
      {
      first = null;               // no links on list yet
      }
// -------------------------------------------------------------
   public boolean isEmpty()       // true if list is empty
      {
      return (first==null);
      }
// -------------------------------------------------------------
                                  // insert at start of list
   public void insertFirst(int id, double dd)
      {                           // make new link
      Link newLink = new Link(id, dd);
      newLink.next = first;       // newLink --> old first
      first = newLink;            // first --> newLink
      }
// -------------------------------------------------------------
   public Link deleteFirst()      // delete first item
      {                           // (assumes list not empty)
      Link temp = first;          // save reference to link
      first = first.next;         // delete it: first-->old next
      return temp;                // return deleted link
      }
// -------------------------------------------------------------
   public void displayList()
      {
      System.out.print("List (first-->last): ");
      Link current = first;       // start at beginning of list
      while(current != null)      // until end of list,
         {
         current.displayLink();   // print data
         current = current.next;  // move to next link
         }
      System.out.println("");
      }
// -------------------------------------------------------------
   
   public boolean insertArrays(int[] idArray, double[] ddArray )
   {
	   idArray = new int[] {102, 122, 144};
	   
	   ddArray = new double[] {10.99, 12.99, 14.99};
	   
	   int i = 0;
	   
	   for (i = 0; i < idArray.length; i++)
	   {
		   insertFirst(idArray[i], ddArray[i]);
	   }
	   
	   if (idArray.length != ddArray.length)
	   {
		   return false;
	   }
	   else
	   {
		   return true;
	   }
   }
   
// -------------------------------------------------------------
   }  // end class LinkList
////////////////////////////////////////////////////////////////