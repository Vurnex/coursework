/*

 	ITS-340
 	Lab 01
 	Problem 3
 	1/26/2021
 	Laquon Hamilton
 	
*/

import java.lang.Math;

public class SmallestIntegerDemo 
{
	static double n = 0;
	static double proof;

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		while (Math.pow(n, 2) < 11000)
		{
			n++;
		}
		
		System.out.println("New integer where n ^ 2 is greater than 11,000: " + n);
		
		proof = Math.pow(n, 2);
		
		System.out.println("\n" + n + " ^ 2 = " + proof);
		
	}

}
