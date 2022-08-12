/* 
	Laquon Hamilton
	Lab 7 pg 396 PE 4
	2020-03-07
*/


//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
#define AMOUNT 10//constant integer
//#include <math.h>
//begin our main function
int main()
{	
	printf("\nProgram that stores values in three arrays and calculates the elements inthe arrays\n");

	void extend(double prices[], double quantity[], double amount[]);//function prototype
	
	double prices[10] = {10.62, 14.89, 13.21, 16.55, 18.62, 9.47, 6.58, 18.32, 12.15, 3.98};
	
	double quantity[10] = {4, 8.5, 6, 8.35, 9, 15.3, 3, 5.4, 2.9, 4.8};
	
	double amount[AMOUNT];

	extend(prices, quantity, amount);//call function

	for (int i = 1; i < AMOUNT; i++)//prints the results
	{
		printf("\nAmount %d is %.2f", i, amount[i]);
		amount[i]++;
	}


	return 0;

}

void extend(double prices[], double quantity[], double amount[]) 
{
	int i;

	for (i = 1; i < AMOUNT; i++)//calculates the elements in the array
	{
		amount[i] = prices[i] * quantity[i];
		amount[i]++;
		prices[i]++;
		quantity[i]++;
	}

	return;

}
