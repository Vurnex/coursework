/* 

	Laquon Hamilton
	Lab 10 pg 572 PE 1
	2020-04-04

*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()//b.
{ 
	printf("\nProgram that returns a day of the week based on the number entered..\n");

	void displayDay();

	displayDay();

	return 0;

}

void displayDay()//a.
{
	int newDay;
	char *message[] = {"", "Sunday", "Monday", "Tuesday", "Wednesday","Thursday", "Friday","Saturday"};//array of pointers

	printf("\nEnter a number 1 - 7 to display a day between Sunday - Saturday: ");
	scanf("%d", &newDay);

	if (newDay < 1 || newDay > 7)
	{//input validation
		printf("\nPlease enter a value between 1 - 7\n");
		displayDay();//recall the function
	}
	else
	{
	printf("\nThe day corresponding to %d is %s", newDay, message[newDay]);
	}

}
