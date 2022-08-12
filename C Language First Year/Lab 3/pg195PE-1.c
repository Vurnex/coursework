/*
	Laquon Hamilton
	Lab 3 pg 195 PE 1
	2020-02-03
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{

	int codeNum = 0;

	printf("\nProgram to determine disk drive manufacturer based on the code number entered.\n");

	printf("\nEnter the code number: ");
	scanf("%d", &codeNum);

	//determine manufacturer based on input
	if(codeNum == 1)
	{
		printf("\nThe drive manufacturer is 3M Corporation.");
	}
	else if(codeNum == 2)
	{
		printf("\nThe drive manufacturer is Maxwell Corporation.");
	}
	else if(codeNum == 3)
	{
		printf("\nThe drive manufacturer is Sony Corporation.");
	}
	else if(codeNum == 4)
	{
		printf("\nThe drive manufacturer is Verbatim Corporation.");
	}
	else if(codeNum > 4)
	{
		printf("\nThe code numbers are between 1-4");
	}
	else if(codeNum < 1)
	{
		printf("\nThe code numbers are b3tween 1-4");
	}

return 0;

}