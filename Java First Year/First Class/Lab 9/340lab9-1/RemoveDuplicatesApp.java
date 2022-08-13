/*

 	ITS-340
 	Lab 09
 	Problem 1
 	4/5/2021
 	Laquon Hamilton
 	
*/


public class RemoveDuplicatesApp
   {
   public static void main(String[] args)
      {                            // create new list
      SortedList theSortedList = new SortedList();
    
    //**Test case1 
      theSortedList.deleteDuplicates();
      theSortedList.displayList(); // display list
    //**Instructor:  the list should be displayed as follows
    //**List (first-->last): 
      
      
      theSortedList.insert(10);    // insert 2 items
      theSortedList.insert(20);
      theSortedList.insert(20);

    //**Test case2 
      theSortedList.deleteDuplicates();
      theSortedList.displayList(); // display list
    //**Instructor:  the list should be displayed as follows
    //**List (first-->last): 10 20
      
      theSortedList.insert(30);
      theSortedList.insert(40);
      theSortedList.insert(50);
      
    //**Test case3 
      theSortedList.deleteDuplicates();
      theSortedList.displayList(); // display list
      //**Instructor:  the list should be displayed as follows
      //**List (first-->last): 10 20 30 40 50
    
     
      theSortedList.insert(30);    // insert 3 more items
      theSortedList.insert(30);
      theSortedList.insert(50);

    //**Test case4
      theSortedList.deleteDuplicates();
      theSortedList.displayList(); // display list
      //**Instructor:  the list should be displayed as follows
      //**List (first-->last): 10 20 30 40 50
     }  // end main()
   }  // end class Lab9_1
////////////////////////////////////////////////////////////////