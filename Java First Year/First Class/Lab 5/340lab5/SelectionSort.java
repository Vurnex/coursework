/*

 	ITS-340
 	Lab 05
 	Problem 2, 5
 	2/24/2021
 	Laquon Hamilton
 	
*/


// selectSort.java
// demonstrates selection sort
// to run this program: C>java SelectSortApp
////////////////////////////////////////////////////////////////
class ArraySel
   {
   private long[] a;                 // ref to array a
   private int nElems;               // number of data items
//--------------------------------------------------------------
   public ArraySel(int max)          // constructor
      {
      a = new long[max];                 // create the array
      nElems = 0;                        // no items yet
      }
//--------------------------------------------------------------
   public void insert(long value)    // put element into array
      {
      a[nElems] = value;             // insert it
      nElems++;                      // increment size
      }
//--------------------------------------------------------------
   public void display()             // displays array contents
      {
      for(int j=0; j<nElems; j++)       // for each element,
         System.out.print(a[j] + " ");  // display it
      System.out.println("");
      }
//--------------------------------------------------------------
   public void selectionSort()
      {
      int out, in, min;

      for(out=0; out<nElems-1; out++)   // outer loop
         {
         min = out;                     // minimum
         for(in=out+1; in<nElems; in++) // inner loop
            if(a[in] < a[min] )         // if min greater,
                min = in;               // we have a new min
         swap(out, min);                // swap them
         }  // end for(out)
      }  // end selectionSort()
//--------------------------------------------------------------
 //--------------------------------------------------------------
   public void selectionSort_Max()
   {
   int out, in, max;
   
   int iteration = 0;

   for(out=0; out<nElems-1; out++)   // outer loop
   {
	   
 	  System.out.print("\nIteration #" + iteration + ": ");
 	  reverse();
 	  //display();
 	  iteration++;
	   
      max = out;                     // maximum
      
      for(in=out+1; in<nElems; in++) // inner loop
      {
         if(a[in] > a[max] )         // if in greater,
         {
             max = in;               // we have a new max
         }
      }
      
      swap(out, max);                // swap them
      }  // end for(out)
   
   }  // end selectionSort_Max()
   
   public void reverse() //reverse array
   {
       long[] b; 
       b = new long[nElems];
       int j = nElems; 
       for (int i = 0; i < nElems; i++) 
       { 
           b[j - 1] = a[i]; 
           j = j - 1; 
       } 
 
       /*printing the reversed array*/
       for (int k = 0; k < nElems; k++) 
       { 
           System.out.print(b[k]+" "); 
       } 
   } 
       
       
   public void selectionSort2()
   {
   int out, in, min;
   
   int iteration = 0;

   for(out=0; out<nElems-1; out++)   // outer loop
      {
	   
 	  System.out.print("\nIteration #" + iteration + ": ");
 	  display();
 	  iteration++;
	   
      min = out;                     // minimum
      
      for(in=out+1; in<nElems; in++) // inner loop
      {
         if(a[in] < a[min] )         // if min greater,
             min = in;               // we have a new min
      }
      
      swap(out, min);                // swap them
      }  // end for(out)
   
   System.out.print("\nFinal Iteration (#" + iteration + "): ");
   display();
   }  // end selectionSort2()
//--------------------------------------------------------------
   private void swap(int one, int two)
      {
      long temp = a[one];
      a[one] = a[two];
      a[two] = temp;
      }
//--------------------------------------------------------------
   }  // end class ArraySel
////////////////////////////////////////////////////////////////
