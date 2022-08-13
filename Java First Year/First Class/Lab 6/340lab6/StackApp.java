/*

 	ITS-340
 	Lab 06
 	Problem 2
 	3/2/2021
 	Laquon Hamilton
 	
*/


class StackApp
   {
   public static void main(String[] args)
      {
	   
      StackX theStack = new StackX(10);  // make new stack
      theStack.push('a');               // push items onto stack
      theStack.push('b');
      theStack.push('c');
      theStack.push('d');
      
      System.out.println("\nContents in stack");

      while( !theStack.isEmpty() )     // until it's empty,
         {                             // delete item from stack
         char value = theStack.pop();
         System.out.print(value);      // display it
         System.out.print(" ");
         }  // end while
      System.out.println("");
      
      System.out.print("\nContents printed as they were entered into the stack");
      
      //print characters in the order they were stored
      System.out.print("\n" + theStack.peek(1) + " ");
      System.out.print(theStack.peek(2) + " ");
      System.out.print(theStack.peek(3) + " ");
      System.out.print(theStack.peek(4) + " ");
      }  // end main()
   }  // end class StackApp
////////////////////////////////////////////////////////////////
