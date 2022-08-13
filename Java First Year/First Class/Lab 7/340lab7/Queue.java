/*

 	ITS-340
 	Lab 07
 	Problem 1 (7.1, 7.2)
 	3/16/2021
 	Laquon Hamilton
 	
*/

// Queue.java
// demonstrates queue
// to run this program: C>java QueueApp
////////////////////////////////////////////////////////////////
public class Queue
   {
   private int maxSize;
   private long[] queArray;
   private int front;
   private int rear;
   private int nItems;
//--------------------------------------------------------------
   public Queue(int s)          // constructor
   {
      maxSize = s;
      queArray = new long[maxSize];
      front = 0;
      rear = -1;
      nItems = 0;
   }
//--------------------------------------------------------------
   public void insert(long j)   // put item at rear of queue
   {
	  if (!isFull())
	  {
	      if(rear == maxSize-1)         // deal with wraparound
	      {
	         rear = -1;
	      }
	      queArray[++rear] = j;         // increment rear and insert
	      nItems++;                     // one more item
	  }
	  else if ( isFull() )
	  {
		  System.out.println("The queue is full. No more items can be added.\n"); //7.1 #2
	  }
   }
//--------------------------------------------------------------
public long remove()         // take item from front of queue
{
	   
   long temp = 0;
   
   if ( !isEmpty() )	//7.1 (2
   {
	   temp = queArray[front++]; // get value and incr front
  
	   if(front == maxSize)           // deal with wraparound
	   {
		   front = 0;
	   }
	   nItems--;                      // one less item
   }
   else if ( isEmpty() )
   {
	   System.out.println("Can't remove items from an empty queue.\n"); //7.1 (2
   }
   
  return temp;
      
}
//--------------------------------------------------------------
   public long peekFront()      // peek at front of queue
      {
      return queArray[front];
      }
//--------------------------------------------------------------
   public boolean isEmpty()    // true if queue is empty
      {
      return (nItems==0);
      }
//--------------------------------------------------------------
   public boolean isFull()     // true if queue is full
      {
      return (nItems==maxSize);
      }
//--------------------------------------------------------------
   public int size()           // number of items in queue
      {
      return nItems;
      }
//--------------------------------------------------------------   
   public void displayQueue() //display all items in the queue from the front to the rear. (7.2)
   {
	   System.out.print("\nQueue has items: ");
	   if ( isEmpty() )
	   {
		   System.out.print("No itmes currently.");
	   }
	   while( !isEmpty() )    // remove and display
       {                            //    all items
			long n = remove();  // (40, 50, 60, 70, 80)
			System.out.print(n);
			System.out.print(" ");
       }
		System.out.println("");
   }
//--------------------------------------------------------------
   }  // end class Queue
