/*

 	ITS-330
 	Final Exam
 	Problem ---
 	5/4/2021
 	Laquon Hamilton
 	
*/

import java.text.SimpleDateFormat;
import java.util.Date;

public class PrintThread implements Runnable, java.lang.Runnable
{
	private char newElement;
	private int limit;
	
	public int numDivisible;
	
	Date date = new Date();
	
	SimpleDateFormat formatter = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss");
	
	public PrintThread()
	{
		
	}
	
	public int getLimit()
	{
		return this.limit;
	}
	
	public PrintThread(char c, int t)
	{
		newElement = c;
		limit = t;
	}
	
	public void run()
	{
		int num = 0; //for confirming how many times the element is printed
		for (int i = 0; i < limit; i++)
		{
			num++;
			System.out.print(" " + newElement);
			System.out.print("(" + num + ")");
			numDivisible = num;
			
			if (newElement == 'A')
			{
				System.out.println("\n" + formatter.format(date));
			}
			
		}
	}
}
