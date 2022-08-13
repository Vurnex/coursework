/*

 	ITS-340
 	Lab 02
 	Problem 1, 2, 3, 4
 	2/3/2021
 	Laquon Hamilton
 	
*/	


// highArray.java
// demonstrates array class with high-level interface
// to run this program: C>java HighArrayApp
////////////////////////////////////////////////////////////////
public class HighArray
   {
   private long[] a;                 // ref to array a
   private int nElems;               // number of data items
   static int loopin;
   //-----------------------------------------------------------
   
   public HighArray(int max)         // constructor
      {
      a = new long[max];                 // create the array
      nElems = 0;                        // no items yet
      }
   //-----------------------------------------------------------
   
   public boolean find(long searchKey)
      {                              // find specified value
      int j;
      for(j=0; j<nElems; j++)            // for each element,
         if(a[j] == searchKey)           // found item?
            break;                       // exit loop before end
      loopin = j;
      if(j == nElems)                    // gone to end?
         return false;                   // yes, can't find it
      else
    	  return true;                    // no, found it
      	  
      }  // end find()
   //-----------------------------------------------------------
   
   public int getMin()
   {
	   int i = 0;
	   long min=Integer.MAX_VALUE;
	   
	   if (a.length == 0)
	   {
		   return -1;
	   }
	   else
	   {
		   for (i = 0; i < nElems; i++)
		   {
			   if (a[i] < min)
			   {
				   min = a[i];
			   }   
		   }
	   }
	   
	   System.out.println("\nThe minimum value is: " + min);
	   
	   return 1;
   }
   
   public int setValue(long searchKey)
   {
	   int j;
	   for(j=0; j<nElems; j++)            // for each element,
		   if(a[j] == searchKey)           // found item?
		   {
			 break;  
		   }
	   System.out.println("\nThe array index for " + searchKey + " is " + loopin + "\n");
	   
	      //loopin = j;
	   
	   return 1;
	   
   }
   public void insert(long value)    // put element into array
  {  
	  
      a[nElems] = value;             // insert it
      nElems++;                      // increment size
      
      //int j;
      //for(j=0; j<nElems; j++)        // look for it
      //   if(nElems > a[j])
	  //       nElems--;               // decrement size

  }
   
   public void checkArray()
   {
	      int j;
	      for(j=0; j<nElems; j++)        // look for it
	         if(nElems > a[j])
		         nElems--;               // decrement size
	   
   }
   //-----------------------------------------------------------
   
   public boolean delete(long value)
   {
	   
	   
		    //int j;
		    //for(j=0; j<nElems; j++)        // look for it
		       
		    //if(j==nElems)                  // can't find it
		       //return false;
		    //else                           // found it
		    //{   
    		for(int k = loopin; k<nElems; k++) // move higher ones down
    		{
    			
    			a[k] = a[k+1];
    		}
    		nElems--;                   // decrement size
    		return true;
       
     
	  
	  
	  }  // end delete()
   //-----------------------------------------------------------
   
   public void display()             // displays array contents
  {
	  for(int j=0; j<nElems; j++)       // for each element,
	     System.out.print(a[j] + " ");  // display it
	  System.out.println(" ");
  }
   //-----------------------------------------------------------
   }  // end class HighArray
////////////////////////////////////////////////////////////////
