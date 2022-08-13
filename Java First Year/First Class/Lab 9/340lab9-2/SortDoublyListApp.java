/*

 	ITS-340
 	Lab 09
 	Problem 1
 	4/5/2021
 	Laquon Hamilton
 	
*/

////////////////////////////////////////////////////////////////
public class SortDoublyListApp
   {
   public static void main(String[] args)
      {                            
	   SortedDoublyLinkedList theList = new SortedDoublyLinkedList();

      theList.insert(22);     
      theList.insert(44);
      theList.insert(66);
      theList.insert(77);
      theList.insert(11);       
      theList.insert(33);
      theList.insert(55);
      
      


    //**Instructor:  the sorted doubly linked list should be displayed forward and backward
    
      theList.displayForward();     // display list forward
    //**Your display result should be: 
    //**List (first-->last): 11 22 33 44 55 66
      
      //theList.reverse();
      
      theList.displayBackward();    // display list backward
    //**Your display result should be: 
    //**List (first-->last): 66 55 44 33 22 11
      
      }  // end main()
   }  // end class DoublyLinkedApp
////////////////////////////////////////////////////////////////