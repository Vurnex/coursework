/*
	Laquon Hamilton
	Lab 2 pg 114 PE 5
	2020-01-22
*/

//include preprocessor directives
//stdio for input and output
#include <stdio.h>

//12 half dollars, 20 quarters, 32 dimes, 45 nickels, 27 pennies. 

int main()
{
	//declare and initialize variables
  float halfDollar = 12.0 * 0.50;
	float allQuarters = 20.0 * 0.25;
	float allDimes = 32.0 * 0.10;
	float allNickels = 45.0 * 0.05;
	float allPennies = 27.0 * 0.01;

	//print the values given
	printf("\nFinding the total dollar amount of:\n");
	printf("\n12 half dollars\n");
	printf("20 quarters\n");
	printf("32 dimes\n");
	printf("45 nickels\n");
	printf("27 pennies\n");

	//calculate dollar amount
	float dollarAmount = halfDollar + allQuarters + allDimes + allNickels + allPennies;
	printf("\nTotal Dollar Amount = %5.2f\n", dollarAmount);
  return 0;
}
