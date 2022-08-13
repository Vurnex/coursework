/*

 	ITS-340
 	Lab 09
 	Problem 1
 	4/5/2021
 	Laquon Hamilton
 	
*/

// Lab9_1.java

////////////////////////////////////////////////////////////////
class Link
   {
   public long dData;                  // data item
   public Link next;                   // next link in list
// -------------------------------------------------------------
   public Link(long dd)                // constructor
      { dData = dd; }
// -------------------------------------------------------------
   public void displayLink()           // display this link
      { System.out.print(dData + " "); }
   }  // end class Link
////////////////////////////////////////////////////////////////
