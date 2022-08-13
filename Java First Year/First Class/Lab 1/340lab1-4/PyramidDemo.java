/*

 	ITS-340
 	Lab 01
 	Problem 4
 	1/26/2021
 	Laquon Hamilton
 	
*/

import java.util.Scanner;

public class PyramidDemo 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		int newInt = 0;
		
		try (Scanner myInteger = new Scanner(System.in)) // Creates a Scanner object
		{
			System.out.print("Enter a number: ");
			System.out.print("\n");
			
			newInt = myInteger.nextInt();
		}
		catch (Exception e) 
		{

	        //  handle exception
		}
		
		//Create the pyramid
		for (int rows = 1; rows <= newInt; rows++) 
		{
			
			// Create spaces in each row
			for (int spaces = newInt - rows; spaces >= 1; spaces--) 
			{
				System.out.print("  ");
			}
			
			// Create descending numbers in each row
			for (int des = rows; des >= 2; des--) 
			{
				System.out.print(des + " ");
			}
			
			// Create ascending number in each row
			for (int asc = 1; asc <= rows; asc++) 
			{
				System.out.print(asc + " ");
			}
			
			// End line
			System.out.println();

		}
		
	}

}
