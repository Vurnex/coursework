/*

 	ITS-340
 	Lab 04
 	Problem 1
 	2/16/2021
 	Laquon Hamilton
 	
*/

public class OrderedArray 
{
	   private long[] a;                 	// ref to array a
	   private int nElems;              // number of data items
	   //-----------------------------------------------------------
	   public OrderedArray(int max)         // constructor
	      {
		      a = new long[max];             	// create array
		      nElems = 0;
	      }
	   //-----------------------------------------------------------
	   public int size()
	      { return nElems; }
	   //-----------------------------------------------------------
	   public int find(long searchKey)
	   {
	      int lowerBound = 0; //beginning of index range
	      int upperBound = nElems-1; //end of index range
	      int curIn; //current index
	
	      while(true)
	      {
	         curIn = (lowerBound + upperBound ) / 2;
	         if(a[curIn]==searchKey)		//a[curIn] = element stored in current index
	            return curIn;              // found it
	         else if(lowerBound >= upperBound)
	            return nElems;             // can't find it
	         else                          // divide range
	         {
	            if(a[curIn] < searchKey)
	               lowerBound = curIn + 1; // it's in upper half
	            else
	               upperBound = curIn - 1; // it's in lower half
	         }  // end else divide range
	      }  // end while
	   }  // end find()
	   //-----------------------------------------------------------
	   public int find2(long searchKey) //used for problem 2
	   {
	      int lowerBound = 0; //beginning of index range
	      int upperBound = nElems-1; //end of index range
	      int curIn; //current index
	      int currentIteration = 1;  
	      int numComparisons = 3; //There are 3 if statements in the loop, so there will always be 3 
	      						  //comparisons unless any of the if statements are true/activated.
	      int totalComparisons = 3;
	
	      while(true)
	      {
	    	 System.out.println("\n---------------------------------------");
	    	 System.out.println("\nCurrent Iteration: " + currentIteration);
	    	 System.out.println("\nLowerbound: " + lowerBound);
	    	 System.out.println("\nUpperbound: " + upperBound);
	    	 
	         curIn = (lowerBound + upperBound ) / 2;
	         
	    	 System.out.println("\nCurrent Index: " + curIn);
	    	 System.out.println("\nNumber in Index: " + a[curIn]);
	    	 System.out.println("\n# of Comparisons: " + numComparisons);
	    	 System.out.println("\nTotal Comparisons: " + totalComparisons);
	    	 
	    	 totalComparisons = totalComparisons + 3;
	    	 
	         if(a[curIn]==searchKey)		//a[curIn] = element stored in current index
	         {
	        	 numComparisons--;	
	        	 totalComparisons--;
	         
	        	 return curIn;              // found it
	         }
	         else if(lowerBound >= upperBound)
	         {
	        	 numComparisons--;
	        	 totalComparisons--;
	        	 return nElems;             // can't find it
	         }
	         else                          // divide range
	         {
	            if(a[curIn] < searchKey)
	            {
	            	lowerBound = curIn + 1; // it's in upper half
	            	numComparisons--;
	            	totalComparisons--;
	            }
	            else
	            {
	               upperBound = curIn - 1; // it's in lower half
	            }
	         }  // end else divide range
	         
	         currentIteration++;
	       
	         
	         System.out.println("\n---------------------------------------");//formatting
	         
	      }  // end while
	      
	   }  // end find()
	   //-----------------------------------------------------------
	   public void insert(long value)    // put element into array
	   {
	      int j;
	      for(j=0; j<nElems; j++)        // find where it goes
	         if(a[j] > value)            // (linear search)
	            break;
	      for(int k=nElems; k>j; k--)    // move bigger ones up
	         a[k] = a[k-1];
	      a[j] = value;                  // insert it
	      nElems++;                      // increment size
	   }  // end insert()
	   //-----------------------------------------------------------
	   public boolean delete(long value)
	   {
	      int j = find(value);
	      if(j==nElems)                  // can't find it
	         return false;
	      else                           // found it
	      {
	         for(int k=j; k<nElems; k++) // move bigger ones down
	            a[k] = a[k+1];
	         nElems--;                   // decrement size
	         return true;
	      }
	   }  // end delete()
	   
	   public int RemoveDuplicates()
	   {
		   long dupe = 0;
		   boolean dupesRemoved = false;
		   
		   for (int i = 0; i < nElems-1; i++)
	       {
	           for (int j = i+1; j < nElems; j++)
	           {
	               if ((a[i] == a[j]) && (i != j))
	               {
	            	   dupe = a[j];
	            	   //a[j]++;
	            	   delete(dupe);
	            	   dupesRemoved = true;
	               }
	           }
	       }
		   
		   if (dupesRemoved == true)
		   {
			   nElems--; //make nElems match true array length
			   System.out.println("\nDuplicates removed. New array length: " + nElems);
			   nElems++; //restore old nElems number to prevent the last element in array from being hidden
		   }
		   
		   return 0;
		   
	   }
	   //-----------------------------------------------------------
	   public void display()             // displays array contents
	   {
	      for(int j=0; j<nElems; j++)       // for each element,
	         System.out.print(a[j] + " ");  // display it
	      System.out.println("");
	   }
	   //-----------------------------------------------------------
}  // end class OrderedArray
	////////////////////////////////////////////////////////////////