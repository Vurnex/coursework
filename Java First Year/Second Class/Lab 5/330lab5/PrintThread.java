/*

 	ITS-330
 	Lab 05
 	Problem 1 (5.1, 5.2)
 	3/3/2021
 	Laquon Hamilton
 	
*/

public class PrintThread implements Runnable, java.lang.Runnable
{
	private char newElement;
	private int limit;
	
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
			
		}
	}
}
