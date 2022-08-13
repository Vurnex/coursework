/*

 	ITS-330
 	Final Exam
 	Problem ---
 	5/4/2021
 	Laquon Hamilton
 	
*/

import java.lang.Thread;

public class ThreadCoop
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		
		java.lang.Runnable printNums = new PrintThread('\0', 200);
		
		Thread thread1 = new Thread(printNums);
		
		System.out.println("\n\nThread 1:\n");
		
		thread1.start();
		
		while(thread1.isAlive()) 
		{
			//waits until previous thread is finished to execute the next thread
		}
		
		java.lang.Runnable printNums2 = new PrintThread('A', 1);
		
		Thread thread2 = new Thread(printNums2);
		
		System.out.println("\n\nThread 2:\n");
		
		PrintThread divisible = new PrintThread();
		
		if (divisible.numDivisible % 10 == 0)
			
		{
			thread2.start();
		}
		

	}

}
