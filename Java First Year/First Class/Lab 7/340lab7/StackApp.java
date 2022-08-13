/*

 	ITS-340
 	Lab 07
 	Problem 3 (7.3)
 	3/23/2021
 	Laquon Hamilton
 	
*/

public class StackApp //Same as  StackApp in textbook
   {
   public static void main(String[] args)
      {
	  StackFromQ theStack = new StackFromQ(10);  // make new stack
	  
      theStack.push(20);               // push items onto stack
      theStack.push(40);
      theStack.push(60);
      theStack.push(80);
      
      System.out.print("The stack has items: ");
      
      while( !theStack.isEmpty() )     // until it's empty,
         {                             // delete item from stack
         long value = theStack.pop();
         System.out.print(value);      // display it
         System.out.print(" ");
         }  // end while
      System.out.println("");
      }  // end main()
   }  // end class StackApp
////////////////////////////////////////////////////////////////
