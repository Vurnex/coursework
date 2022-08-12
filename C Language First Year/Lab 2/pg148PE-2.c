/*
	Laquon Hamilton
	Lab 2 pg 148 PE 2
	2020-01-26
*/

//include preprocessor directives
//stdio for input and output
//math.h for math functions
#include <stdio.h>
#include <math.h>
 
int main()
{
	//define variables
	float x1 = 3;
	float y1 = 4;
	float x2 = 10;
	float y2 = 12;
	//float slope = 0;
	float midX = 0;
	float midY = 0;

	//State the coordinates	
	printf("\nFinding the midpoints of the given coordinates (3,4) and (10,12)\n");

	//calculate midpoints	
	midX=(x1 + x2) / 2;
	midY=(y1 + y2) / 2;

	printf("\nMidpoints:(%5.2f,%5.2f)\n",midX,midY);

	printf("\nThe x midpoint coordinate is: %5.2f\n", midX);
	printf("\nThe y midpoint coordinate is: %5.2f\n", midY);

	//b. You can use the formula given to verify the outputs

	printf("\n--- Part C ---\n");//Part C to PE 2

	//define more variables 
	float x3 = 2;
	float y3 = 10;
	float x4 = 12;
	float y4 = 6;
	float midX2 = 0;
	float midY2 = 0;
	
	printf("\nFinding the midpoints of the given coordinates (2,10) and (12,6)\n");
		
	midX2=(x3 + x4) / 2;
	midY2=(y3 + y4) / 2;
	
	printf("\nMidpoints:(%5.2f,%5.2f)\n",midX2,midY2);

	printf("\nThe x midpoint coordinate is: %5.2f\n", midX2);
	printf("\nThe y midpoint coordinate is: %5.2f\n", midY2);

	return 0;
}