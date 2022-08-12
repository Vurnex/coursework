/* 
  Laquon Hamilton
  Lab 6 pg 364 PE 2
  2020-02-28
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{
	printf("\nProgram that accepts a number of cups and determines the number of");
	printf("\ngallons, quarts, pints, and cups.\n");

	void liquid(int, int*, int*, int*, int*);//function prototype with pointers
	//display 0 rather than the address if not true
	int gallons = 0;
	int quarts = 0;
	int pints = 0;
	int cups = 0;
	int totalCups;//inputted value
	

	printf("\nEnter the number of cups: ");
	scanf("%d", &totalCups);

	liquid(totalCups, &gallons, &quarts, &pints, &cups);//passes variables to function by reference

	printf("\nThe value entered amounts to %d Gallons(s), %d Quarts(s), %d Pint(s), and %dCup(s)", gallons, quarts, pints, cups);

	return 0;

}

void liquid(int totalCups, int *gallons, int *quarts, int *pints, int *cups)//pointers indicate th function is using references
{
	//determine values
	if (totalCups >= 16)
	{
		*gallons = totalCups / 16;
	}
	if (totalCups >= 4) 
	{
			*quarts = totalCups / 4;
	}
	if (totalCups >= 2)
	{
			*pints = totalCups / 2;
	}

	*cups = totalCups;//total number of cups entered

	return;

}
