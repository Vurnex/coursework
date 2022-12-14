/*

 	ITS-340
 	Lab 08
 	Problem 2 (8.2)
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
   public void insertFirst(int id, double dd)
      {                           // make new link
      Link newLink = new Link(id, dd);
      newLink.next = first;       // it points to old first link
      first = newLink;            // now first points to this
      }
// -------------------------------------------------------------
   public Link find(int key)      // find link with given key
      {                           // (assumes non-empty list)
      Link current = first;              // start at 'first'

      while(current.iData != key)        // while no match,
         {
         if(current.next == null)        // if end of list,
            return null;                 // didn't find it
         else                            // not end of list,
            current = current.next;      // go to next link
         }
      return current;                    // found it
      }
// -------------------------------------------------------------
   public Link delete(int key)    // delete link with given key
      {                           // (assumes non-empty list)
      Link current = first;              // search for link
      Link previous = first;
      while(current.iData != key)
         {
         if(current.next == null)
            return null;                 // didn't find it
         else
            {
            previous = current;          // go to next link
            current = current.next;
            }
         }                               // found it
      if(current == first)               // if first link,
         first = first.next;             //    change first
      else                               // otherwise,
         previous.next = current.next;   //    bypass it
      return current;
      }
// -------------------------------------------------------------
   public void displayList()      // display the list
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
   
   public void insertAfterN(int id, double dd, int n)  
   {
   
	   Link newLink = new Link(id, dd);
	   newLink.iData = id;
	   newLink.next = null;
	
	   Link current = first;         
	   Link previous = null;
	   
	   int i = 0;
	   
	   while (i < n)
	   {
		   previous = current;
		   current = current.next;
		   
		   if (current == null)
		   {
			   break;
		   }
		   
		   i = i + 10;
	   }

	   newLink.next = current;       
	   previous.next = newLink;

   }

// -------------------------------------------------------------
   }  // end class LinkList
////////////////////////////////////////////////////////////////