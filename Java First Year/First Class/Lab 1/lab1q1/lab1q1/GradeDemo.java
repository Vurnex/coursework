/*

 	ITS-340
 	Lab 01
 	Problem 1
 	1/22/2021
 	Laquon Hamilton
 	
*/

package lab1q1;

import java.util.Scanner;

public class GradeDemo 
{
	
	static int score;
	static String grade;

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		try (Scanner myScore = new Scanner(System.in)) // Creates a Scanner object
		{
			System.out.println("Enter your score:");
	    
			score = myScore.nextInt();
		}
		catch (Exception e) {

	        //  handle exception
		}  

		if (score < 60)
		{
			grade = "F";
		}
		else if (score < 70)
		{
			grade = "D";
		}
		else if (score < 80)
		{
			grade = "C";
		}
		else if (score < 90)
		{
			grade = "B";
		}	
		else if (score <= 100)
		{
			grade = "A";
		}
		
		System.out.println("Score entered: " + score + "\nGrade given: " + grade);

	}

}
