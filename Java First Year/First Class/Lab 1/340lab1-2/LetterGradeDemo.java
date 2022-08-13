/*

 	ITS-340
 	Lab 01
 	Problem 2
 	1/26/2021
 	Laquon Hamilton
 	
*/

public class LetterGradeDemo 
{
	static char grade = 'B';

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		System.out.println("Assigned letter grade: " + grade);
		
		if (grade == 'A')
		{
			System.out.println("\nLetter grade " + grade + " is between 90-100");
		}
		else if (grade == 'B')
		{
			System.out.println("\nLetter grade " + grade + " is between 80-89");
		}
		else if (grade == 'C')
		{
			System.out.println("\nLetter grade " + grade + " is between 70-79");
		}
		else if (grade == 'D')
		{
			System.out.println("\nLetter grade " + grade + " is between 60-69");
		}
		else if (grade == 'E')
		{
			System.out.println("\nLetter grade " + grade + " is a 59 and lower");
		}
		else if (grade == 'F')
		{
			System.out.println("\nLetter grade " + grade + " is a 59 and lower");
		}
		else
		{
			System.out.println("\nThere are errors with the assigned grade.");
		}

	}

}
