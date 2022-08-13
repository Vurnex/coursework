/*

 	ITS-340
 	Lab 09
 	Problem 1
 	4/5/2021
 	Laquon Hamilton
 	
*/


class SortedList
   {
   private Link first;                 // ref to first item
   public int caseNum = 1;
// -------------------------------------------------------------
   public SortedList()                 // constructor
      { first = null; }
// -------------------------------------------------------------
   public boolean isEmpty()            // true if no links
      { return (first==null); }
// -------------------------------------------------------------
   public void insert(long key)        // insert, in order
      {
      Link newLink = new Link(key);    // make new link
      Link previous = null;            // start at first
      Link current = first;
                                       // until end of list,
      while(current != null && key > current.dData)
         {                             // or key > current,
         previous = current;
         current = current.next;       // go to next item
         }
      if(previous==null)               // at beginning of list
         first = newLink;              // first --> newLink
      else                             // not at beginning
         previous.next = newLink;      // old prev --> newLink
      newLink.next = current;          // newLink --> old currnt
      }  // end insert()
// -------------------------------------------------------------
   public Link remove()           // return & delete first link
      {                           // (assumes non-empty list)
      Link temp = first;               // save first
      first = first.next;              // delete first
      return temp;                     // return value
      }
// -------------------------------------------------------------
   public void displayList()
      {
      System.out.print("Test Case " + caseNum + " List:(first-->last): ");
      Link current = first;       // start at beginning of list
      while(current != null)      // until end of list,
         {
         current.displayLink();   // print data
         current = current.next;  // move to next link
         }
      System.out.println("");
      increment();
      }

// **Instructor hint: write your solution to problem 1 here.
//-------------------------------------------------------------
   public void deleteDuplicates()
  {
	   if ( isEmpty() )
	   {
		   System.out.println("No items in the list yet (Test Case 1)");
	   }
	   else
	   {
		   Link temp1 = null, temp2 = null, tempDup = null;
		   temp1 = first;
		   
		   //pick the elements one by one.
		   while (temp1 != null && temp1.next != null)
		   {
			   temp2 = temp1;
			   
			   //compare element with the others
			   while (temp2.next != null)
			   {
				   //if duplicate, then get rid of it.
				   if (temp1.dData == temp2.next.dData)
				   {
					   tempDup = temp2.next;
					   temp2.next = temp2.next.next;
					   
				   }
				   else
				   {
					   temp2 = temp2.next;
				   }
			   }
			   
			   temp1 = temp1.next;
		   }
	   }

  }  
   
   public void increment()//simply for incrementing the caseNum variable
   {
	   caseNum++; 
   }
   
   }  // end class SortedList
////////////////////////////////////////////////////////////////