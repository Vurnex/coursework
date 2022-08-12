/* 
	Laquon Hamilton
	Lab 7 pg 401 PE 6
	2020-03-08
*/


//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//#include <math.h>
//begin our main function
int main()
{	
	printf("\nProgram that stores 4 types of people in an array and determines the number of each type\n");

	int peopleTypes[10];
	int i;
	int newInfants = 0;
	int newChildren = 0;
	int newTeenagers = 0;
	int newAdults = 0;

	for (i = 1; i < 11; i++)//loop to prompt user for person type
	{
		printf("\nEnter the Person Type: ");
		scanf("%d", &peopleTypes[i]);
		//increment specified value
		if (peopleTypes[i] == 1)
		{
			newInfants+= 1;
		}
		if (peopleTypes[i] == 2)
		{
			newChildren+= 1;
		}
		if (peopleTypes[i] == 3)
		{
			newTeenagers+= 1;
		}
		if (peopleTypes[i] == 4)
		{
			newAdults+= 1;
		}
	
	
	while (peopleTypes[i] > 4)//invalid if value greater than 5
	{
		printf("\nThe value must be between 1-4\n");
		printf("\nEnter the Person Type: ");
		scanf("%d", &peopleTypes[i]);
		if (peopleTypes[i] == 1)
		{
			newInfants+= 1;
		}
		if (peopleTypes[i] == 2)
		{
			newChildren+= 1;
		}
		if (peopleTypes[i] == 3)
		{
			newTeenagers+= 1;
		}
		if (peopleTypes[i] == 4)
		{
			newAdults+= 1;
		}
	}

	if (peopleTypes[i] == 0)//invalid if value equals 0
	{
		printf("\nThe value must be between 1-4\n");
		printf("\nEnter the Person Type: ");
		scanf("%d", &peopleTypes[i]);
		if (peopleTypes[i] == 1)
		{
			newInfants+= 1;
		}
		if (peopleTypes[i] == 2)
		{
			newChildren+= 1;
		}
		if (peopleTypes[i] == 3)
		{
			newTeenagers+= 1;
		}
		if (peopleTypes[i] == 4)
		{
			newAdults+= 1;
		}
	}
	if (peopleTypes[i] < 0)//ends the program and prints results if negative value entered
	{
		printf("\nInfants: %d", newInfants);
		printf("\nChildren: %d", newChildren);
		printf("\nTeenagers: %d", newTeenagers);
		printf("\nAdults: %d", newAdults);
		break;
	}
	if (i == 10)//ends program when incrementor reaches max value
	{
		printf("\nInfants: %d", newInfants);
		printf("\nChildren: %d", newChildren);
		printf("\nTeenagers: %d", newTeenagers);
		printf("\nAdults: %d", newAdults);
		break;
	}

	}

	return 0;

}
