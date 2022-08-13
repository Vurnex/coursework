/*

 	ITS-340
 	Lab 07
 	Problem 3 (7.3)
 	3/23/2021
 	Laquon Hamilton
 	
*/

////////////////////////////////////////////////////////////////
class StackFromQ
   {
   private Queue q;
//--------------------------------------------------------------
   public StackFromQ(int s)         // constructor
      {
      q = new Queue(s);  
      }
//--------------------------------------------------------------
   public void push(long j)    // put item on top of stack
      {
	      q.insert(j);
      }
//--------------------------------------------------------------
   public long pop()           // take item from top of stack
      {
		   return q.remove();
      }
//--------------------------------------------------------------
   public long peek()          // peek at top of stack
      {
	   		return q.peekFront();
      }
//--------------------------------------------------------------
   public boolean isEmpty()    // true if stack is empty
      {
	   		return q.isEmpty();
      }
//--------------------------------------------------------------
   public boolean isFull()     // true if stack is full
      {
  			return q.isFull();		
      }
//--------------------------------------------------------------
   }  // end class StackFromQ
////////////////////////////////////////////////////////////////