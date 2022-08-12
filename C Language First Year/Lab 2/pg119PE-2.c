/*
	Laquon Hamilton
	Lab 2 pg 119 PE 2
	2020-01-22
*/

//include preprocessor directives
//stdio for input and output
//math.h for math functions
#include <stdio.h>
#include <math.h>

int main() 
{
	//declare and initialize variables
	float x1 = 7;
	float y1 = 12; 
	float x2 = 3; 
	float y2 = 9; 
	float findDistance;
	//State the given coordinates
	printf("\nFinding the distance between given coordinates (7,12) and (3,9)\n");
	//Calculate coordinates
	findDistance = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
	printf("\nThe distance between the given coordinates is: %5.2f\n", sqrt(findDistance));

	return 0;
}//end main
