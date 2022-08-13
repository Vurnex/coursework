/*

 	ITS-340
 	Lab 07
 	Problem 1 (7.1)
 	3/16/2021
 	Laquon Hamilton
 	
*/

public class QueueApp
{
	public static void main(String[] args)
	{
		int queueSize = 5;
		Queue theQueue = new Queue(queueSize);  // queue holds 5 items


		theQueue.remove();
		
		if (theQueue.isEmpty())
		{
    	  System.out.println("The queue is currently empty.\n");
		}
		else
		{
    	  System.out.println("The first item is "+ theQueue.peekFront()); 
		}
      
      
		theQueue.insert(10);            // insert 5 items only
		theQueue.insert(20);
		theQueue.insert(30);
		theQueue.insert(40);
		theQueue.insert(50);
		theQueue.insert(60);
		
		//theQueue.insert(70);
      

		System.out.print("The queue has items: ");
		while( !theQueue.isEmpty() )    // remove and display
        {                            //    all items
			long n = theQueue.remove();  // (40, 50, 60, 70, 80)
			System.out.print(n);
			System.out.print(" ");
        }
		System.out.println("");
	}  // end main()
}  // end class QueueApp
////////////////////////////////////////////////////////////////
