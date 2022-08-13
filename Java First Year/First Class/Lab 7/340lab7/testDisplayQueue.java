/*

 	ITS-340
 	Lab 07
 	Problem 2 (7.2)
 	3/23/2021
 	Laquon Hamilton
 	
*/

////////////////////////////////////////////////////////////////
public class testDisplayQueue 
{

   public static void main(String[] args)
   {
      Queue theQueue = new Queue(5);  // queue holds 5 items
      //your display method can only show nothing
      //or print a message to indicate the queue is empty
      theQueue.displayQueue();
      
      theQueue.insert(10);            // insert 4 items
      theQueue.insert(20);
      theQueue.insert(30);
      theQueue.insert(40);

      theQueue.remove();              // remove 3 items
      theQueue.remove();              //    (10, 20, 30)
      theQueue.remove();
      //your display method can only show 40
      theQueue.displayQueue();
      
      theQueue.insert(40); 			  //reinsert 40
      
      theQueue.insert(50);            // insert 4 more items
      theQueue.insert(60);            //    (wraps around)
      theQueue.insert(70);
      theQueue.insert(80);

      //your display method can show 40 50 60 70 80
      theQueue.displayQueue();
   }
}
