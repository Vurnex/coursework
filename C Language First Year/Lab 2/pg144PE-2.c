/*
	Laquon Hamilton
	Lab 2 pg 144 PE 2
	2020-01-24
*/

//include preprocessor directives
//stdio for input and output
#include <stdio.h>

//defines the literal 0.08 to symbolic name INTEREST
#define INTEREST 0.08 /*prime interest rate */

int main()
{
	//define variables
	float amount, interest;
	
	//prompt user
	printf("\nEnter the amount: ");
	scanf("%f", &amount);
	//calculates interest
	interest = INTEREST * amount;
	printf("\nThe interest earned is %5.2f dollars", interest);
	
	return 0;
}