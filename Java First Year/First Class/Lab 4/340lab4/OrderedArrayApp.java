/*

 	ITS-340
 	Lab 04
 	Problem 1
 	2/16/2021
 	Laquon Hamilton
 	
*/	

public class OrderedArrayApp 
{

	public static void main(String[] args)
    {
    int maxSize = 100;             // array size
    OrderedArray arr;                  // reference to array
    arr = new OrderedArray(maxSize);   // create the array

    
    arr.insert(77);                // insert 10 items
    arr.insert(88);
    arr.insert(44);
    arr.insert(55);
    arr.insert(22);
    arr.insert(88);
    arr.insert(11);
    arr.insert(11);
    arr.insert(66);
    arr.insert(33);
    
    
    //2 10 17 45 49 55 68 85 92 98 110
    /*
    arr.insert(2);                // used for problem 2
    arr.insert(10);
    arr.insert(17);
    arr.insert(45);
    arr.insert(49);
    arr.insert(55);
    arr.insert(68);
    arr.insert(85);
    arr.insert(92);
    arr.insert(98);
    arr.insert(110);
    */

    int searchKey = 55;            // search for item
    if( arr.find(searchKey) != arr.size() )
       System.out.println("Found " + searchKey);
    else
       System.out.println("Can't find " + searchKey);

    arr.display();                 // display items

    //arr.delete(00);                // delete 3 items
    //arr.delete(55);
    //arr.delete(99);
    
    arr.RemoveDuplicates();

    arr.display();                 	// display items again
    
    //arr.find2(searchKey);			//used for problem 2
    
    //System.out.println("\nFinished loop");	//used for problem 2
    
    }
}
