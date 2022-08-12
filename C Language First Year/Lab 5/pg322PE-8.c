/* 
	Laquon Hamilton
	Lab 5 pg 322 PE 8
	2020-02-16
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
//begin our main function
int main()
{
	printf("\nProgram that simulates the rolling of two dice.\n");

	int dice1;
	int dice2;
	int i;
	int diceSum = 0;

	srand(time(NULL));//randomize values

	for (i = 1; i <= 1; i++)//determines random values, adds them, and determines the outcome based on the sum
	{
		dice1 = rand() % 6 + 1;

		dice2 = rand() % 6 + 1;

		diceSum = dice1 + dice2;

		printf("\nThe roll of dice one was %d\n", dice1);
		printf("\nThe roll of dice two was %d\n", dice2);		

		if ((diceSum == 7) || (diceSum == 11))
		{
			printf("\nYou win.\n");
		}
		else
		{
			printf("\nYou lose.\n");
		}

		printf("\nThe sum of the dice rolls was %d\n", diceSum);
	}

	return 0;
}