/* 
	Laquon Hamilton
	Lab 4 pg 223 PE 6
	2020-02-09
*/

//include the stdio file for user input and output
//preprocessor directive
#include <stdio.h>
//begin our main function
int main()
{
	printf("\nProgram that displays the distance an automobile traveling at 55 mph has driven every half hour for 4 hours (8 counts)\n");
	
	float milesPerHour = 0;
	float count = 0;
	float distanceDriven = 0;
	int halfHour = 0;

	//printf("Enter the number of hours driven");
	//scanf("%f", &count);

	//calculate miles driven
	while (count < 4)
	{
		distanceDriven+= 55;
		halfHour+= 30;

		printf("\nThe distance driven after %2d minutes is: %.0f miles\n", halfHour, distanceDriven);
		count+= 0.5;
	}

	return 0;

}