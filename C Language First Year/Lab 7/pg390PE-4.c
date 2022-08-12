/* 
	Laquon Hamilton
	Lab 7 pg 390 PE 4
	2020-03-06
*/


//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//#include <math.h>
//begin our main function
int main()
{	
	printf("\nProgram that stores a list of numbers in an array called rates, and determines the lowest and highest value\n");
	
	#define RATES 9//constant value local to main
	float newRates[RATES] = {18.24, 25.63, 5.94, 33.92, 3.71, 32.84, 35.93, 18.42, 6.92};//array of rates
	int i;//incrementor

	float maxHigh;

	maxHigh = newRates[0];

	float maxLow;

	maxLow = newRates[0];

	for (i = 1; i < RATES; i++)//determines max value
	{
		if (maxHigh < newRates[i])
			maxHigh = newRates[i];

	}
	for (i = 1; i < RATES; i++)//determines lowest value
	{
		if (maxLow > newRates[i])
			maxLow = newRates[i];

	}

		printf("\nThe lowest value is %.2f", maxLow);
		printf("\nThe highest value is %.2f", maxHigh);


	return 0;

}
