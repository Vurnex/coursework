/*
	Laquon Hamilton
	Lab 2 pg 130 PE 4
	2020-01-23
*/

//include preprocessor directives
//stdio for input and output
//math.h for math functions
#include <stdio.h>
#include <math.h>

int main() 
{
	//declare and initialize variables
	float allMiles = 0.0;
	float gallonsUsed = 0.0;
	float milesPerGallon = 0.0;
	//prompt user
	printf("\nEnter the miles driven-->");
	scanf("%f", &allMiles);
	printf("\nEnter the gallons of gas used-->");
	scanf("%f", &gallonsUsed);
	//print the value back out to the screen
	//print the value back out to the screen
	printf("\nYour miles driven is %5.2f", allMiles);
	printf(" miles");
	printf("\nThe gallons of gas used is %5.2f", gallonsUsed);
	printf(" gallons");
	//calculate miles per gallon obtained
	milesPerGallon = allMiles / gallonsUsed;
	//display miles per gallon obtained
	printf("\nMiles per gallon (MPG) obtained is %5.2f\n", milesPerGallon);
	return 0;
}//end main