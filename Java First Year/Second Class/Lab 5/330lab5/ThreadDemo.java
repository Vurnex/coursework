/*

 	ITS-330
 	Lab 05
 	Problem 1 (5.1, 5.2)
 	3/3/2021
 	Laquon Hamilton
 	
*/

import java.lang.Thread;

public class ThreadDemo
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		java.lang.Runnable printA = new PrintThread('A', 100);
		
		Thread thread1 = new Thread(printA);
		
		System.out.println("\nThread 1:\n");
		
		thread1.start();
		
		while(thread1.isAlive()) 
		{
			//waits until previous thread is finished to execute the next thread
		}
		
		java.lang.Runnable printB = new PrintThread('B', 100);
		
		Thread thread2 = new Thread(printB);
		
		System.out.println("\n\nThread 2:\n");
		
		thread2.start();
		
		while(thread2.isAlive()) 
		{
			//waits until previous thread is finished to execute the next thread
		}
		
		java.lang.Runnable printNums = new PrintThread('\0', 100);
		
		Thread thread3 = new Thread(printNums);
		
		System.out.println("\n\nThread 3:\n");
		
		thread3.start();
		


	}

}
