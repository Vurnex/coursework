/* 
	Laquon Hamilton
	Lab 3 pg 199 PE 2
	2020-02-03
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{
	int lineAngle = 0;

	//get input from user
	printf("\nInput the angle of the line: ");
	scanf("%d",&lineAngle);

	//determine quadrant
	if (lineAngle > 0 && lineAngle < 90)
	{
		printf("\nThe angle is in the First Quadrant (I).");
	}
	else if (lineAngle > 90 && lineAngle < 180)
	{
		printf("\nThe angle is in the Second Quadrant (II).");
	}
	else	if (lineAngle > 180 && lineAngle < 270)
	{
		printf("\nThe angle is in the Third Quadrant (III).");
	}
	else if (lineAngle > 270 && lineAngle < 360)
	{
		printf("\nThe angle is in the First Quadrant (IV).");
	}
	else if (lineAngle == 0 || lineAngle == 90 || lineAngle == 180 || lineAngle == 270)
	{
		printf("\nThe angle lies on the axis.\n");
	}	
	else
	{
		printf("\nThe value must be between 0 and 360\n");
	}

	//Part B

	if (lineAngle == 0)
	{
		printf("\nThis angle is the positive X-axis.");
	}
	else if (lineAngle == 90)
	{
		printf("\nThis angle is the positive Y-axis.");		
	}
	else if (lineAngle == 180)
	{
		printf("\nThis angle is the negative X-axis.");		
	}
	else if (lineAngle == 270)
	{
		printf("\nThis angle is the negative Y-axis.");		
	}

	return 0;
	
}